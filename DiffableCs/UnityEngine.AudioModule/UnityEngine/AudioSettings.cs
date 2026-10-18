namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("GetAudioManager()", StaticAccessorType::Dot (0))]
public sealed class AudioSettings
{
	internal sealed class AudioConfigurationChangeHandler : MulticastDelegate
	{

		public AudioConfigurationChangeHandler(object object, IntPtr method) { }

		public override void Invoke(bool deviceWasChanged) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static AudioConfigurationChangeHandler OnAudioConfigurationChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action OnAudioSystemShuttingDown; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action OnAudioSystemStartedUp; //Field offset: 0x10

	public static event AudioConfigurationChangeHandler OnAudioConfigurationChanged
	{
		[CompilerGenerated]
		 add { } //Length: 266
		[CompilerGenerated]
		 remove { } //Length: 266
	}

	public static double dspTime
	{
		[NativeMethod(Name = "GetDSPTime", IsThreadSafe = True)]
		 get { } //Length: 69
	}

	public static int outputSampleRate
	{
		 get { } //Length: 69
	}

	[CompilerGenerated]
	public static void add_OnAudioConfigurationChanged(AudioConfigurationChangeHandler value) { }

	[NativeMethod(Name = "GetDSPTime", IsThreadSafe = True)]
	public static double get_dspTime() { }

	public static int get_outputSampleRate() { }

	public static AudioConfiguration GetConfiguration() { }

	private static void GetConfiguration_Injected(out AudioConfiguration ret) { }

	[NativeMethod(Name = "AudioSettings::GetDSPBufferSize", IsFreeFunction = True)]
	public static void GetDSPBufferSize(out int bufferLength, out int numBuffers) { }

	[NativeMethod(Name = "AudioSettings::GetSampleRate", IsFreeFunction = True)]
	private static int GetSampleRate() { }

	[RequiredByNativeCode]
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	[RequiredByNativeCode]
	internal static void InvokeOnAudioSystemShuttingDown() { }

	[RequiredByNativeCode]
	internal static void InvokeOnAudioSystemStartedUp() { }

	[CompilerGenerated]
	public static void remove_OnAudioConfigurationChanged(AudioConfigurationChangeHandler value) { }

	public static bool Reset(AudioConfiguration config) { }

	[NativeMethod(Name = "AudioSettings::SetConfiguration", IsFreeFunction = True)]
	[NativeThrows]
	private static bool SetConfiguration(AudioConfiguration config) { }

	private static bool SetConfiguration_Injected(ref AudioConfiguration config) { }

}

