namespace ZLogger.Internal;

internal static class WindowsConsoleMode
{
	[Nullable(1)]
	private const string Kernel32 = "kernel32.dll"; //Field offset: 0x0
	private const int STD_OUTPUT_HANDLE = -11; //Field offset: 0x0
	private const int ENABLE_VIRTUAL_TERMINAL_PROCESSING = 4; //Field offset: 0x0

	internal static bool GetConsoleMode(IntPtr handle, out int mode) { }

	internal static IntPtr GetStdHandle(int nStdHandle) { }

	internal static bool SetConsoleMode(IntPtr handle, int mode) { }

	internal static bool TryEnableVirtualTerminalProcessing() { }

}

