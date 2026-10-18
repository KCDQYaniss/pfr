namespace uLipSync;

[RequireComponent(typeof(AudioSource))]
public class uLipSyncCalibrationAudioPlayer : MonoBehaviour
{
	public AudioClip clip; //Field offset: 0x20
	public float start; //Field offset: 0x28
	public float end; //Field offset: 0x2C
	public float crossFadeDuration; //Field offset: 0x30
	private AudioClip _tmpClip; //Field offset: 0x38
	private float[] _data; //Field offset: 0x40
	private int _currentPos; //Field offset: 0x48
	private bool _audioReadCalled; //Field offset: 0x4C
	private int _sampleRate; //Field offset: 0x50
	private int _sampleCount; //Field offset: 0x54
	private int _channels; //Field offset: 0x58
	private int _crossFadeDataCount; //Field offset: 0x5C
	private readonly object _lockObject; //Field offset: 0x60
	private bool _isApplyRequested; //Field offset: 0x68

	public bool isPlaying
	{
		 get { } //Length: 295
	}

	private int playDataSampleCount
	{
		private get { } //Length: 7
	}

	public uLipSyncCalibrationAudioPlayer() { }

	private void Apply() { }

	public bool get_isPlaying() { }

	private int get_playDataSampleCount() { }

	private void OnAudioRead(float[] data) { }

	private void OnAudioSetPosition(int newPosition) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void Pause() { }

	public void RequestApply() { }

	public void UnPause() { }

	private void Update() { }

}

