namespace UnityEngine;

[NativeHeader("Runtime/Utilities/URLUtility.h")]
[NativeHeader("Runtime/Network/NetworkUtility.h")]
[NativeHeader("Runtime/Misc/BuildSettings.h")]
[NativeHeader("Runtime/Misc/Player.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
[NativeHeader("Runtime/Logging/LogSystem.h")]
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
public class Application
{
	internal sealed class LogCallback : MulticastDelegate
	{

		public LogCallback(object object, IntPtr method) { }

		public override void Invoke(string condition, string stackTrace, LogType type) { }

	}

	internal sealed class LowMemoryCallback : MulticastDelegate
	{

		public LowMemoryCallback(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	internal sealed class MemoryUsageChangedCallback : MulticastDelegate
	{

		public MemoryUsageChangedCallback(object object, IntPtr method) { }

		public override void Invoke(in ApplicationMemoryUsageChange usage) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static LowMemoryCallback lowMemory; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static MemoryUsageChangedCallback memoryUsageChanged; //Field offset: 0x8
	private static LogCallback s_LogCallbackHandler; //Field offset: 0x10
	private static LogCallback s_LogCallbackHandlerThreaded; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action focusChanged; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action deepLinkActivated; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Func wantsToQuit; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action quitting; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action unloading; //Field offset: 0x40
	private static CancellationTokenSource s_currentCancellationTokenSource; //Field offset: 0x48

	public static event LogCallback logMessageReceived
	{
		 add { } //Length: 381
		 remove { } //Length: 318
	}

	public static event LogCallback logMessageReceivedThreaded
	{
		 add { } //Length: 381
		 remove { } //Length: 318
	}

	public static event LowMemoryCallback lowMemory
	{
		[CompilerGenerated]
		 add { } //Length: 335
		[CompilerGenerated]
		 remove { } //Length: 335
	}

	public static event UnityAction onBeforeRender
	{
		 add { } //Length: 78
		 remove { } //Length: 78
	}

	public static event Action quitting
	{
		[CompilerGenerated]
		 add { } //Length: 335
		[CompilerGenerated]
		 remove { } //Length: 335
	}

	public static ThreadPriority backgroundLoadingPriority
	{
		[FreeFunction("GetPreloadManager().SetThreadPriority")]
		 set { } //Length: 76
	}

	public static string companyName
	{
		[FreeFunction("GetPlayerSettings().GetCompanyName")]
		 get { } //Length: 69
	}

	public static string dataPath
	{
		[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
		 get { } //Length: 69
	}

	public static NetworkReachability internetReachability
	{
		[FreeFunction("GetInternetReachability")]
		 get { } //Length: 69
	}

	public static bool isBatchMode
	{
		[FreeFunction("::IsBatchmode")]
		 get { } //Length: 69
	}

	public static bool isConsolePlatform
	{
		 get { } //Length: 163
	}

	public static bool isEditor
	{
		 get { } //Length: 5
	}

	public static bool isFocused
	{
		[FreeFunction("IsPlayerFocused")]
		 get { } //Length: 69
	}

	public static bool isMobilePlatform
	{
		 get { } //Length: 232
	}

	public static bool isPlaying
	{
		[FreeFunction("IsWorldPlaying")]
		 get { } //Length: 69
	}

	public static string persistentDataPath
	{
		[FreeFunction("GetPersistentDataPathApplicationSpecific")]
		 get { } //Length: 69
	}

	public static RuntimePlatform platform
	{
		[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
		 get { } //Length: 69
	}

	public static string productName
	{
		[FreeFunction("GetPlayerSettings().GetProductName")]
		 get { } //Length: 69
	}

	public static bool runInBackground
	{
		[FreeFunction("GetPlayerSettingsRunInBackground")]
		 get { } //Length: 69
	}

	public static string streamingAssetsPath
	{
		[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
		 get { } //Length: 69
	}

	public static SystemLanguage systemLanguage
	{
		[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
		 get { } //Length: 69
	}

	public static int targetFrameRate
	{
		[FreeFunction("GetTargetFrameRate")]
		 get { } //Length: 69
		[FreeFunction("SetTargetFrameRate")]
		 set { } //Length: 76
	}

	public static string temporaryCachePath
	{
		[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
		 get { } //Length: 69
	}

	public static string unityVersion
	{
		[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
		 get { } //Length: 69
	}

	private static Application() { }

	public static void add_logMessageReceived(LogCallback value) { }

	public static void add_logMessageReceivedThreaded(LogCallback value) { }

	[CompilerGenerated]
	public static void add_lowMemory(LowMemoryCallback value) { }

	public static void add_onBeforeRender(UnityAction value) { }

	[CompilerGenerated]
	public static void add_quitting(Action value) { }

	[RequiredByNativeCode]
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCode]
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	[FreeFunction("GetPlayerSettings().GetCompanyName")]
	public static string get_companyName() { }

	[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
	public static string get_dataPath() { }

	[FreeFunction("GetInternetReachability")]
	public static NetworkReachability get_internetReachability() { }

	[FreeFunction("::IsBatchmode")]
	public static bool get_isBatchMode() { }

	public static bool get_isConsolePlatform() { }

	public static bool get_isEditor() { }

	[FreeFunction("IsPlayerFocused")]
	public static bool get_isFocused() { }

	public static bool get_isMobilePlatform() { }

	[FreeFunction("IsWorldPlaying")]
	public static bool get_isPlaying() { }

	[FreeFunction("GetPersistentDataPathApplicationSpecific")]
	public static string get_persistentDataPath() { }

	[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
	public static RuntimePlatform get_platform() { }

	[FreeFunction("GetPlayerSettings().GetProductName")]
	public static string get_productName() { }

	[FreeFunction("GetPlayerSettingsRunInBackground")]
	public static bool get_runInBackground() { }

	[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
	public static string get_streamingAssetsPath() { }

	[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
	public static SystemLanguage get_systemLanguage() { }

	[FreeFunction("GetTargetFrameRate")]
	public static int get_targetFrameRate() { }

	[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
	public static string get_temporaryCachePath() { }

	[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
	public static string get_unityVersion() { }

	[FreeFunction("GetStackTraceLogType")]
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	[RequiredByNativeCode]
	internal static bool HasLogCallback() { }

	[RequiredByNativeCode]
	private static void Internal_ApplicationInit() { }

	[RequiredByNativeCode]
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCode]
	private static void Internal_ApplicationUnload() { }

	[RequiredByNativeCode]
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCode]
	internal static void InvokeDeepLinkActivated(string url) { }

	[RequiredByNativeCode]
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCode]
	internal static void InvokeOnBeforeRender() { }

	[FreeFunction("OpenURL")]
	public static void OpenURL(string url) { }

	[FreeFunction("GetInputManager().QuitApplication")]
	public static void Quit(int exitCode) { }

	public static void Quit() { }

	public static void remove_logMessageReceived(LogCallback value) { }

	public static void remove_logMessageReceivedThreaded(LogCallback value) { }

	[CompilerGenerated]
	public static void remove_lowMemory(LowMemoryCallback value) { }

	public static void remove_onBeforeRender(UnityAction value) { }

	[CompilerGenerated]
	public static void remove_quitting(Action value) { }

	[FreeFunction("GetPreloadManager().SetThreadPriority")]
	public static void set_backgroundLoadingPriority(ThreadPriority value) { }

	[FreeFunction("SetTargetFrameRate")]
	public static void set_targetFrameRate(int value) { }

	[FreeFunction("Application_Bindings::SetLogCallbackDefined")]
	private static void SetLogCallbackDefined(bool defined) { }

	[FreeFunction("SetStackTraceLogType")]
	public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType) { }

}

