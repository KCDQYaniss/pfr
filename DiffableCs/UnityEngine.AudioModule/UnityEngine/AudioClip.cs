namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("AudioClipBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioClip : Object
{
	internal sealed class PCMReaderCallback : MulticastDelegate
	{

		public PCMReaderCallback(object object, IntPtr method) { }

		public override void Invoke(float[] data) { }

	}

	internal sealed class PCMSetPositionCallback : MulticastDelegate
	{

		public PCMSetPositionCallback(object object, IntPtr method) { }

		public override void Invoke(int position) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PCMReaderCallback m_PCMReaderCallback; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PCMSetPositionCallback m_PCMSetPositionCallback; //Field offset: 0x20

	private event PCMReaderCallback m_PCMReaderCallback
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	private event PCMSetPositionCallback m_PCMSetPositionCallback
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	[NativeProperty("ChannelCount")]
	public int channels
	{
		 get { } //Length: 78
	}

	public int frequency
	{
		 get { } //Length: 78
	}

	[NativeProperty("LengthSec")]
	public float length
	{
		 get { } //Length: 78
	}

	public AudioDataLoadState loadState
	{
		[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = True)]
		 get { } //Length: 78
	}

	public AudioClipLoadType loadType
	{
		 get { } //Length: 78
	}

	public bool preloadAudioData
	{
		 get { } //Length: 78
	}

	[NativeProperty("SampleCount")]
	public int samples
	{
		 get { } //Length: 78
	}

	private AudioClip() { }

	[CompilerGenerated]
	private void add_m_PCMReaderCallback(PCMReaderCallback value) { }

	[CompilerGenerated]
	private void add_m_PCMSetPositionCallback(PCMSetPositionCallback value) { }

	private static AudioClip Construct_Internal() { }

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback) { }

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback) { }

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	[Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream) { }

	private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	public int get_channels() { }

	public int get_frequency() { }

	public float get_length() { }

	[NativeMethod(Name = "AudioClipBindings::GetLoadState", HasExplicitThis = True)]
	public AudioDataLoadState get_loadState() { }

	public AudioClipLoadType get_loadType() { }

	public bool get_preloadAudioData() { }

	public int get_samples() { }

	public bool GetData(float[] data, int offsetSamples) { }

	private static bool GetData(AudioClip clip, out float[] data, int numSamples, int samplesOffset) { }

	private string GetName() { }

	[RequiredByNativeCode]
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCode]
	private void InvokePCMSetPositionCallback_Internal(int position) { }

	public bool LoadAudioData() { }

	[CompilerGenerated]
	private void remove_m_PCMReaderCallback(PCMReaderCallback value) { }

	[CompilerGenerated]
	private void remove_m_PCMSetPositionCallback(PCMSetPositionCallback value) { }

	public bool SetData(float[] data, int offsetSamples) { }

	private static bool SetData(AudioClip clip, float[] data, int numsamples, int samplesOffset) { }

	public bool UnloadAudioData() { }

}

