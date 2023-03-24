using System;
namespace ProjBobcat.Class.Helper
{
	public class SymLinkHelper
	{
		/// <summary>
		/// 符号链接创建工具
		/// </summary>

		private string _defaultPublicResourceLocation;

		public bool CreateLink(string targetItem, string? overrideDefaultLocation = null, bool? parseToWindowsPath = null)
		{
            ///<summary>
            ///	自动根据当前系统(构建) 选择 符号链接 创建方法.
            /// </summary>
            /// <param name="targetItem">
            ///	需要创建链接到具体版本的资源文件夹的单个文件之路径.(需要包含文件名与后缀)
            /// </param>
            /// <param name="overrideDefaultLocation">
            ///	链接需要被创建到的路径(需要包含文件名与后缀), 可为null, 默认值在创建对象时候创建(强烈建议传一个具体的)
            /// </param>
            /// <param name="parseToWindowsPath">
            /// 可null的值. 为true时将把两个路径中的/转换为\
            /// </param>
            /// <returns>返回成功与否.</returns>

            string ThisDefaultLocation;

			if (overrideDefaultLocation is not null) ThisDefaultLocation = overrideDefaultLocation;
			else ThisDefaultLocation = _defaultPublicResourceLocation;
			// 未验证: 是否可以在不给文件后缀的情况下创建到此目录的默认同名文件... 若不能, 将在后续添加文件名检测和自动拼接.

			if(parseToWindowsPath is not null) if ((bool)parseToWindowsPath)
			{
					ThisDefaultLocation = ThisDefaultLocation.Replace("/", "\\");
					targetItem = targetItem.Replace("/", "\\");
			}
            string? CmdReturn = "";
            try {
				
#if WINDOWS
		// 原来从vista就自带mklink了哇 那就不考虑junction工具了.
			CmdReturn = CommandLineHelper.RunCMD("mklink", $"/d {targetItem} {ThisDefaultLocation}");
			//? 待验证: /d与/h是否: 跨分区, 增加占用, 可被Minecraft识别
#elif OSX
            CmdReturn = CommandLineHelper.RunBash($"ln -s {targetItem} {ThisDefaultLocation}");
			// 一般而言, mac与linux用户可以不考虑跨分区问题. 可以在确认软链接可以被minecraft识别后直接全部软链接
#elif LINUX
			CmdReturn = CommandLineHelper.RunBash($"ln -s {targetItem} {ThisDefaultLocation}");
			// 这应该||就好了吧……不确定
#endif
            }
            catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return false;
			}

			if (CmdReturn.Contains("nvalid")) return false; // 收集可能的错误信息. 但是返回信息可能是不同的语言, 考虑移除...

            return true;
		}

		public bool RemoveLink(string targetLink)
		{
            string? CmdReturn = "";

            try
            {

#if WINDOWS
		// 原来从vista就自带mklink了哇 那就不考虑junction工具了.
			CmdReturn = CommandLineHelper.RunCMD("erase", $"/Q {targetLink}");
			//? 待验证: /d与/h是否: 跨分区, 增加占用, 可被Minecraft识别
#elif OSX
                CmdReturn = CommandLineHelper.RunBash($"rm -rf {targetLink}");
                // 一般而言, mac与linux用户可以不考虑跨分区问题. 可以在确认软链接可以被minecraft识别后直接全部软链接
#elif LINUX
			CmdReturn = CommandLineHelper.RunBash($"unlink {targetLink}");
			// 这应该||就好了吧……不确定
#endif
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            if (CmdReturn.Contains("nvalid")) return false; // 同上...
            return true;
		}

		public SymLinkHelper(string defaultLocation)
		{
			/// <summary>
			/// 构造方法
			/// </summary>
			/// <param name="defaultLocation">
			///	创建对象时候存入默认的存储共享资源(软链创建点)的路径.
			/// </param>
			///
			_defaultPublicResourceLocation = defaultLocation;
			
		}
	}
}

