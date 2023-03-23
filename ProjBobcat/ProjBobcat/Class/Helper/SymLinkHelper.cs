using System;
namespace ProjBobcat.Class.Helper
{
	public class SymLinkHelper
	{
		/// <summary>
		/// 符号链接创建工具
		/// </summary>

		private string _defaultPublicResourceLocation;

		public bool CreateLink(string TargetItem, string? OverrideDefaultLocation = null, bool? ParseToWindowsPath = null)
		{
            ///<summary>
            ///	自动根据当前系统(构建) 选择 符号链接 创建方法.
            /// </summary>
            /// <param name="TargetItem">
            ///	需要创建链接到具体版本的资源文件夹的单个文件之路径.(需要包含文件名与后缀)
            /// </param>
            /// <param name="OverrideDefaultLocation">
            ///	链接需要被创建到的路径(需要包含文件名与后缀), 可为null
            /// </param>
            /// <param name="ParseToWindowsPath">
            /// 可null的值. 为true时将把两个路径中的/转换为\
            /// </param>
            /// <returns>返回成功与否.</returns>

            string ThisDefaultLocation;

			if (OverrideDefaultLocation is not null) ThisDefaultLocation = OverrideDefaultLocation;
			else ThisDefaultLocation = _defaultPublicResourceLocation;

			if(ParseToWindowsPath is not null) if ((bool)ParseToWindowsPath)
			{
					ThisDefaultLocation = ThisDefaultLocation.Replace("/", "\\");
					TargetItem = TargetItem.Replace("/", "\\");
			}
			try {
				string? CmdReturn = "";
#if WINDOWS
		// 原来从vista就自带mklink了哇 那就不考虑junction工具了.
			CmdReturn = CommandLineHelper.RunCMD("mklink", $"/h {TargetItem} {ThisDefaultLocation}");
			//? 待验证: /d与/h是否: 跨分区, 增加占用, 可被Minecraft识别
#elif OSX
            CmdReturn = CommandLineHelper.RunBash($"ln -s {TargetItem} {ThisDefaultLocation}");
			// 一般而言, mac与linux用户可以不考虑跨分区问题. 可以在确认软链接可以被minecraft识别后直接全部软链接
#elif LINUX
			CmdReturn = CommandLineHelper.RunBash($"ln -s {TargetItem} {ThisDefaultLocation}");
			// 这应该||就好了吧……不确定
#endif
            }
            catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return false;
			}


            return true;
		}

		public SymLinkHelper(string DefaultLocation)
		{
			/// <summary>
			/// 构造方法
			/// </summary>
			/// <param name="DefaultLocation">
			///	创建对象时候存入默认的存储共享资源的路径.
			/// </param>
			///
			_defaultPublicResourceLocation = DefaultLocation;
			
		}
	}
}

