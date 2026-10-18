namespace System;

internal static class Platform
{
	private static bool checkedOS; //Field offset: 0x0
	private static bool isMacOS; //Field offset: 0x1
	private static bool isAix; //Field offset: 0x2
	private static bool isIBMi; //Field offset: 0x3
	private static bool isFreeBSD; //Field offset: 0x4
	private static bool isOpenBSD; //Field offset: 0x5

	public static bool IsMacOS
	{
		 get { } //Length: 112
	}

	private static void CheckOS() { }

	public static bool get_IsMacOS() { }

	private static int uname(IntPtr buf) { }

}

