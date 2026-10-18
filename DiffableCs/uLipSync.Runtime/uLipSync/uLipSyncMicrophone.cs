namespace uLipSync;

[RequireComponent(typeof(AudioSource))]
public class uLipSyncMicrophone : MonoBehaviour
{
	private const int MaxRetryMilliSec = 1000; //Field offset: 0x0
	public int index; //Field offset: 0x20
	private int _preIndex; //Field offset: 0x24
	private AudioClip _micClip; //Field offset: 0x28
	[Tooltip("When ON, AudioClip of the Microphone input is automatically registered to AudioSource")]
	public bool isAutoStart; //Field offset: 0x30
	[Range(0.01, 0.2)]
	[Tooltip("Threshold time to resynchronize Microphone and AudioSource")]
	public float latencyTolerance; //Field offset: 0x34
	[Range(0.01, 0.2)]
	[Tooltip("Buffer time for reflecting Microphone input as AudioSource (too low can cause noise)")]
	public float bufferTime; //Field offset: 0x38
	[CompilerGenerated]
	private AudioSource <source>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <isReady>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <isStartRequested>k__BackingField; //Field offset: 0x49
	[CompilerGenerated]
	private bool <isStopRequested>k__BackingField; //Field offset: 0x4A
	[CompilerGenerated]
	private bool <isRecording>k__BackingField; //Field offset: 0x4B
	[CompilerGenerated]
	private MicDevice <device>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private float <latency>k__BackingField; //Field offset: 0x68

	public private AudioClip clip
	{
		 get { } //Length: 293
		private set { } //Length: 296
	}

	public private MicDevice device
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public float freq
	{
		 get { } //Length: 328
	}

	public bool isMicClipSet
	{
		 get { } //Length: 483
	}

	public bool isOutOfSync
	{
		 get { } //Length: 29
	}

	public bool isPlaying
	{
		 get { } //Length: 293
	}

	public private bool isReady
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool isRecording
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool isStartRequested
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool isStopRequested
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float latency
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public int maxFreq
	{
		 get { } //Length: 24
	}

	public int micFreq
	{
		 get { } //Length: 17
	}

	public private AudioSource source
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public uLipSyncMicrophone() { }

	public AudioClip get_clip() { }

	[CompilerGenerated]
	public MicDevice get_device() { }

	public float get_freq() { }

	public bool get_isMicClipSet() { }

	public bool get_isOutOfSync() { }

	public bool get_isPlaying() { }

	[CompilerGenerated]
	public bool get_isReady() { }

	[CompilerGenerated]
	public bool get_isRecording() { }

	[CompilerGenerated]
	public bool get_isStartRequested() { }

	[CompilerGenerated]
	public bool get_isStopRequested() { }

	[CompilerGenerated]
	public float get_latency() { }

	public int get_maxFreq() { }

	public int get_micFreq() { }

	[CompilerGenerated]
	public AudioSource get_source() { }

	private void OnDisable() { }

	protected void OnEnable() { }

	private void set_clip(AudioClip value) { }

	[CompilerGenerated]
	private void set_device(MicDevice value) { }

	[CompilerGenerated]
	private void set_isReady(bool value) { }

	[CompilerGenerated]
	private void set_isRecording(bool value) { }

	[CompilerGenerated]
	private void set_isStartRequested(bool value) { }

	[CompilerGenerated]
	private void set_isStopRequested(bool value) { }

	[CompilerGenerated]
	private void set_latency(float value) { }

	[CompilerGenerated]
	private void set_source(AudioSource value) { }

	public void StartRecord() { }

	private void StartRecordInternal() { }

	public void StopRecord() { }

	public void StopRecordAndCreateAudioClip() { }

	private void StopRecordInternal() { }

	private void Update() { }

	private void UpdateAudioClip() { }

	private void UpdateDevice() { }

	private void UpdateLatencyCheck() { }

	public void UpdateMicInfo() { }

}

