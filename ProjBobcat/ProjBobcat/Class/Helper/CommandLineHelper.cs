using System;
using System.Diagnostics;

namespace ProjBobcat.Class.Helper
{
	public static class CommandLineHelper
	{
		public static string RunCMD(string Head, string Flags)
		{
			try
			{
				ProcessStartInfo i = new()
				{
					FileName = Head,
					Arguments = Flags,
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
		public static string RunBash(string Command)
		{
			///<summary>供Linux和macOS使用的Bash(macOS默认使用zsh)</summary>
			///
#if OSX || LINUX

			try
			{
				string FixedCommand = Command.Replace("\"", "\\\"");
				Process proc = new()
				{
					StartInfo = new ProcessStartInfo
					{
#if OSX
						FileName = "/bin/zsh",
#elif LINUX
						FileName = "/bin/bash",
#endif
						Arguments = $"-c \"{FixedCommand}\"",
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
		public static string RunBashArgs(string CommandHead, string[] Args)
		{
			string Arg = "";
			foreach(var arg in Args)
			{
				Arg += (" " + arg);
			}
			return RunBash(CommandHead + Arg);

		}

	}
}

