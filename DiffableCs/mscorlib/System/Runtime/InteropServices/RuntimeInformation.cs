namespace System.Runtime.InteropServices;

public static class RuntimeInformation
{
	private static readonly Architecture _osArchitecture; //Field offset: 0x0
	private static readonly Architecture _processArchitecture; //Field offset: 0x4
	private static readonly OSPlatform _osPlatform; //Field offset: 0x8

	private static RuntimeInformation() { }

	private static string GetOSName() { }

	private static string GetRuntimeArchitecture() { }

	public static bool IsOSPlatform(OSPlatform osPlatform) { }

}

