namespace uLipSync;

public class uLipSync : MonoBehaviour
{
	public Profile profile; //Field offset: 0x20
	public LipSyncUpdateEvent onLipSyncUpdate; //Field offset: 0x28
	[Range(0, 1)]
	public float outputSoundGain; //Field offset: 0x30
	private AudioSource _audioSource; //Field offset: 0x38
	public uLipSyncAudioSource audioSourceProxy; //Field offset: 0x40
	private uLipSyncAudioSource _currentAudioSourceProxy; //Field offset: 0x48
	private JobHandle _jobHandle; //Field offset: 0x50
	private object _lockObject; //Field offset: 0x60
	private bool _allocated; //Field offset: 0x68
	private int _index; //Field offset: 0x6C
	private bool _isDataReceived; //Field offset: 0x70
	private NativeArray _rawInputData; //Field offset: 0x78
	private NativeArray _inputData; //Field offset: 0x88
	private NativeArray _mfcc; //Field offset: 0x98
	private NativeArray _mfccForOther; //Field offset: 0xA8
	private NativeArray _means; //Field offset: 0xB8
	private NativeArray _standardDeviations; //Field offset: 0xC8
	private NativeArray _phonemes; //Field offset: 0xD8
	private NativeArray _scores; //Field offset: 0xE8
	private NativeArray _info; //Field offset: 0xF8
	private List _requestedCalibrationVowels; //Field offset: 0x108
	private Dictionary _ratios; //Field offset: 0x110
	[CompilerGenerated]
	private LipSyncInfo <result>k__BackingField; //Field offset: 0x118

	private int inputSampleCount
	{
		private get { } //Length: 384
	}

	public NativeArray mfcc
	{
		 get { } //Length: 14
	}

	private int mfccNum
	{
		private get { } //Length: 235
	}

	public private LipSyncInfo result
	{
		[CompilerGenerated]
		 get { } //Length: 27
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public uLipSync() { }

	private void AllocateBuffers() { }

	private void Awake() { }

	private void DisposeBuffers() { }

	private int get_inputSampleCount() { }

	public NativeArray get_mfcc() { }

	private int get_mfccNum() { }

	[CompilerGenerated]
	public LipSyncInfo get_result() { }

	private void InvokeCallback() { }

	private void OnAudioFilterRead(float[] input, int channels) { }

	public void OnDataReceived(float[] input, int channels) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void RequestCalibration(int index) { }

	private void ScheduleJob() { }

	[CompilerGenerated]
	private void set_result(LipSyncInfo value) { }

	private void Update() { }

	private void UpdateAudioSource() { }

	private void UpdateAudioSourceProxy() { }

	private void UpdateBuffers() { }

	private void UpdateCalibration() { }

	private void UpdatePhonemes() { }

	private void UpdateResult() { }

}

