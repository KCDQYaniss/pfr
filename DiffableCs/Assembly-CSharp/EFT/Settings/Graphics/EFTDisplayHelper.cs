namespace EFT.Settings.Graphics;

[Extension]
internal static class EFTDisplayHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__24_0; //Field offset: 0x8
		public static Func <>9__26_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal EftResolution <GetSortedResolutions>b__26_0(EftResolution r) { }

		internal EftResolution <SuitableResolution>b__24_0(EftResolution resolution) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public int systemWidth; //Field offset: 0x10
		public int systemHeight; //Field offset: 0x14

		public <>c__DisplayClass24_0() { }

		internal bool <SuitableResolution>b__1(EftResolution resolution) { }

	}

	[CompilerGenerated]
	private struct <AwaitScreenReady>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string message; //Field offset: 0x20
		public bool logErrors; //Field offset: 0x28
		private float <time>5__2; //Field offset: 0x2C
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetResolution>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int width; //Field offset: 0x20
		public int height; //Field offset: 0x24
		public FullScreenMode mode; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateWindowPosition>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static class Api
	{
		internal struct RECT
		{
			public int left; //Field offset: 0x0
			public int top; //Field offset: 0x4
			public int right; //Field offset: 0x8
			public int bottom; //Field offset: 0xC

		}


		private static IntPtr GetActiveWindow() { }

		internal static Vector2Int GetBorderSize() { }

		private static bool GetClientRect(IntPtr hWnd, ref RECT rect) { }

		private static bool GetWindowRect(IntPtr hWnd, ref RECT rect) { }

	}

	private const int SCREEN_MIN_WIDTH = 800; //Field offset: 0x0
	private const int SCREEN_MIN_HEIGHT = 600; //Field offset: 0x0
	private static readonly List _displaysLayout; //Field offset: 0x0

	private static TimeSpan ApplyDelay
	{
		private get { } //Length: 137
	}

	private static EFTDisplayHelper() { }

	[Extension]
	private static void AddWindowModeWorkAreaResolution(HashSet resolutions, in RectInt workArea) { }

	[AsyncStateMachine(typeof(<AwaitScreenReady>d__11))]
	internal static Task AwaitScreenReady(string message, bool logErrors = false) { }

	internal static EftDisplaySettings CurrentDisplaySettings() { }

	private static TimeSpan get_ApplyDelay() { }

	internal static EftResolution[] GetAvailableResolutions() { }

	private static Display GetDisplay() { }

	internal static Display GetDisplay(byte displayIndex) { }

	internal static bool GetDisplayInfo(byte displayIndex, out DisplayInfo displayInfo) { }

	internal static int GetDisplaysCount() { }

	private static IReadOnlyList GetDisplaysLayout() { }

	[Extension]
	internal static byte GetIndex(in DisplayInfo displayInfo) { }

	private static HashSet GetResolutions() { }

	internal static ReadOnlyCollection GetSortedResolutions() { }

	private static Vector2Int GetWindowBorderSize() { }

	internal static bool IsScreenReady() { }

	[Extension]
	private static bool IsValid(Resolution resolution, bool landscape) { }

	private static bool IsValid(int width, int height, bool landscape) { }

	internal static byte MainWindowDisplayInfoIndex() { }

	[Extension]
	private static void SelectExclusiveFullscreenModeResolutions(HashSet resolutions, bool landscape) { }

	private static Display SelectFirstWorkedDisplay(Display[] displays) { }

	[Extension]
	private static void SelectFullscreenModeResolutions(HashSet resolutions, bool landscape) { }

	[Extension]
	private static void SelectWindowModeResolutions(HashSet resolutions, bool landscape) { }

	internal static Task SetResolution(int width, int height) { }

	[AsyncStateMachine(typeof(<SetResolution>d__19))]
	internal static Task SetResolution(int width, int height, FullScreenMode mode) { }

	internal static EftResolution SuitableResolution() { }

	[Extension]
	internal static byte TryGetIndex(in DisplayInfo displayInfo) { }

	private static bool ValidateDisplaysLayout(IReadOnlyList layout) { }

	internal static bool ValidateDisplaysLayout() { }

	[AsyncStateMachine(typeof(<ValidateWindowPosition>d__20))]
	internal static Task ValidateWindowPosition() { }

}

