using System;
using System.Diagnostics;

namespace ProjBobcat.Class.Helper
{
	public static class CommandLineHelper
	{
		public static string RunCMD(string head, string flags)
		{
			try
			{
				ProcessStartInfo i = new()
				{
					FileName = head,
					Arguments = flags,
					RedirectStandardOutput = true,
					CreateNoWindow = true,
				};
				using (var proc = Process.Start(i))
				{
					return proc.StandardOutput.ReadToEnd();
				}

			}catch(Exception ex)
			{
				return ex.ToString();
			}
			return "null";
		}
		//
		public static string RunBash(string command)
		{
			///<summary>供Linux和macOS使用的Bash(macOS默认使用zsh)</summary>
			///
#if OSX || LINUX

			try
			{
				command = command.Replace("\"", "\\\"");
				Process proc = new()
				{
					StartInfo = new ProcessStartInfo
					{
#if OSX
						FileName = "/bin/zsh",
#elif LINUX
						FileName = "/bin/bash",
#endif
						Arguments = $"-c \"{command}\"",
						RedirectStandardOutput = true,
						UseShellExecute = false,
						CreateNoWindow = true,

                    }
                };
				proc.Start();
				string returning = proc.StandardOutput.ReadToEnd();
				proc.WaitForExit();
				proc.Dispose();
				return returning;
			}
			catch (Exception ex)
			{
                return ex.ToString();
            }
#endif
			return "null";
		}
		//
		public static string RunBashArgs(string commandHead, string[] args)
		{
			string Arg = "";
			foreach(var arg in args)
			{
				Arg += (" " + arg);
			}
			return RunBash(commandHead + Arg);

		}

	}
}

