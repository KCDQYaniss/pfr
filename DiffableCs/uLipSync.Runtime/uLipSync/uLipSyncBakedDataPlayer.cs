namespace uLipSync;

public class uLipSyncBakedDataPlayer : MonoBehaviour
{
	private const float AUDIO_SCHEDULE_DELAY = 0.01; //Field offset: 0x0
	public AudioSource audioSource; //Field offset: 0x20
	public BakedData bakedData; //Field offset: 0x28
	public bool playOnAwake; //Field offset: 0x30
	public bool playAudioSource; //Field offset: 0x31
	[Range(0, 1)]
	public float volume; //Field offset: 0x34
	[Range(-0.3, 0.3)]
	public float timeOffset; //Field offset: 0x38
	public LipSyncUpdateEvent onLipSyncUpdate; //Field offset: 0x40
	public float soundFadeInDurationSec; //Field offset: 0x48
	public float soundFadeOutDurationSec; //Field offset: 0x4C
	public float skipFadeOutDurationSec; //Field offset: 0x50
	private bool _isFirstPlay; //Field offset: 0x54
	private bool _isPlaying; //Field offset: 0x55
	private double _startTime; //Field offset: 0x58
	private BakedData _pendingPlayData; //Field offset: 0x60
	private Coroutine _playCoroutine; //Field offset: 0x68

	public bool isPlaying
	{
		 get { } //Length: 5
	}

	public uLipSyncBakedDataPlayer() { }

	[CompilerGenerated]
	private void <StopAudioSource>b__30_0() { }

	public bool get_isPlaying() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnSkipComplete() { }

	public void Play() { }

	public void Play(BakedData data) { }

	private void PlayAudioSource() { }

	private void SkipAndPlay() { }

	public void Stop() { }

	private void StopAudioSource() { }

	private void StopPlayingCoroutine() { }

	private void Update() { }

	private void UpdateCallback() { }

}

