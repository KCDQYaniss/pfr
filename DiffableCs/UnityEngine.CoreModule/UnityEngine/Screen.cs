namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[NativeHeader("Runtime/Graphics/WindowLayout.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GetScreenManager()", StaticAccessorType::Dot (0))]
public sealed class Screen
{

	public static Resolution currentResolution
	{
		 get { } //Length: 87
	}

	public static float dpi
	{
		[NativeName("GetDPI")]
		 get { } //Length: 69
	}

	public static bool fullScreen
	{
		[NativeName("IsFullscreen")]
		 get { } //Length: 69
	}

	public static FullScreenMode fullScreenMode
	{
		[NativeName("GetFullscreenMode")]
		 get { } //Length: 69
	}

	public static int height
	{
		[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
		 get { } //Length: 69
	}

	public static DisplayInfo mainWindowDisplayInfo
	{
		 get { } //Length: 138
	}

	public static Vector2Int mainWindowPosition
	{
		 get { } //Length: 88
	}

	public static Resolution[] resolutions
	{
		[FreeFunction("ScreenScripting::GetResolutions")]
		 get { } //Length: 69
	}

	public static int width
	{
		[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
		 get { } //Length: 69
	}

	public static Resolution get_currentResolution() { }

	private static void get_currentResolution_Injected(out Resolution ret) { }

	[NativeName("GetDPI")]
	public static float get_dpi() { }

	[NativeName("IsFullscreen")]
	public static bool get_fullScreen() { }

	[NativeName("GetFullscreenMode")]
	public static FullScreenMode get_fullScreenMode() { }

	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	public static int get_height() { }

	public static DisplayInfo get_mainWindowDisplayInfo() { }

	public static Vector2Int get_mainWindowPosition() { }

	[FreeFunction("ScreenScripting::GetResolutions")]
	public static Resolution[] get_resolutions() { }

	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	public static int get_width() { }

	public static void GetDisplayLayout(List displayLayout) { }

	[FreeFunction("GetDisplayLayout")]
	private static void GetDisplayLayoutImpl(List displayLayout) { }

	[FreeFunction("GetMainWindowDisplayInfo")]
	private static DisplayInfo GetMainWindowDisplayInfo() { }

	private static void GetMainWindowDisplayInfo_Injected(out DisplayInfo ret) { }

	[FreeFunction("GetMainWindowPosition")]
	private static Vector2Int GetMainWindowPosition() { }

	private static void GetMainWindowPosition_Injected(out Vector2Int ret) { }

	[FreeFunction("MoveMainWindow")]
	private static AsyncOperation MoveMainWindowImpl(in DisplayInfo display, Vector2Int position) { }

	private static AsyncOperation MoveMainWindowImpl_Injected(in DisplayInfo display, ref Vector2Int position) { }

	public static AsyncOperation MoveMainWindowTo(in DisplayInfo display, Vector2Int position) { }

	[NativeName("RequestResolution")]
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate) { }

}

