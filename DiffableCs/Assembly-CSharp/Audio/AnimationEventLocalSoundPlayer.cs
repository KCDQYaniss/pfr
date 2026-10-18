namespace Audio;

[RequireComponent(typeof(GenericEventTranslator))]
public sealed class AnimationEventLocalSoundPlayer : MonoBehaviour
{
	private struct PlayConfig
	{
		public string ID; //Field offset: 0x0
		public AudioClip Clip; //Field offset: 0x8
		public bool Sustained; //Field offset: 0x10
		[Range(0, 1)]
		public float Volume; //Field offset: 0x14
		[Range(0.1, 3)]
		public float Pitch; //Field offset: 0x18
		[Range(0, 1)]
		public float SpatialBlend; //Field offset: 0x1C
		[Range(-1, 1)]
		public float PanStereo; //Field offset: 0x20
		[Range(0, 360)]
		public float Spread; //Field offset: 0x24
		public float MinDistance; //Field offset: 0x28
		public float MaxDistance; //Field offset: 0x2C
		public AudioRolloffMode RolloffMode; //Field offset: 0x30
		public AudioMixerGroup MixerGroup; //Field offset: 0x38

	}

	private struct SustainedSession
	{
		public PlayConfig config; //Field offset: 0x0
		public double dspStart; //Field offset: 0x40
		public float frozenTime; //Field offset: 0x48

		public bool IsPending
		{
			 get { } //Length: 46
		}

		public bool IsPlaying
		{
			 get { } //Length: 42
		}

		public bool IsValid
		{
			 get { } //Length: 203
		}

		public bool get_IsPending() { }

		public bool get_IsPlaying() { }

		public bool get_IsValid() { }

	}

	private const float DEFAULT_MIN_DISTANCE = 1; //Field offset: 0x0
	private const float DEFAULT_MAX_DISTANCE = 10; //Field offset: 0x0
	private const float MIN_PITCH = 0.01; //Field offset: 0x0
	private const float PLAYING_FROZEN_TIME = -1; //Field offset: 0x0
	[SerializeField]
	private PlayConfig[] _soundsPool; //Field offset: 0x20
	[SerializeField]
	private Transform _soundTransform; //Field offset: 0x28
	[SerializeField]
	private AudioSource _oneShotSource; //Field offset: 0x30
	[SerializeField]
	private AudioSource _sustainedSource; //Field offset: 0x38
	private GenericEventTranslator _eventTranslator; //Field offset: 0x40
	private readonly Dictionary _soundsPoolByID; //Field offset: 0x48
	private SustainedSession _session; //Field offset: 0x50

	public AnimationEventLocalSoundPlayer() { }

	private static void ApplyConfig(AudioSource source, PlayConfig config) { }

	private void Awake() { }

	private void CapturePendingSustained() { }

	private static AudioSource CreateSource(Transform parent, string name) { }

	private void EnsureAudioSources() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void PlayOneShot(PlayConfig config) { }

	private void PlaySustained(PlayConfig config, float time = 0) { }

	private void ResumePendingSustained() { }

	public void SetMuted(bool muted) { }

	private void SoundPlayHandler(string soundName) { }

}

