namespace Audio.RadioSystem;

public class ClientBroadcastPlayer : MonoBehaviour, IBroadcastPlayer, IAudioCullingObject
{
	private const float SYNC_THRESHOLD = 0.05; //Field offset: 0x0
	[SerializeField]
	[Space]
	private ERadioStation _radioStation; //Field offset: 0x20
	[SerializeField]
	protected AudioSource _sourceA; //Field offset: 0x28
	[SerializeField]
	protected AudioSource _sourceB; //Field offset: 0x30
	[SerializeField]
	private AudioMixerGroup _mixerGroup; //Field offset: 0x38
	[SerializeField]
	private AnimationCurve _spreadCurve; //Field offset: 0x40
	[SerializeField]
	private AnimationCurve _rolloffCurve; //Field offset: 0x48
	[SerializeField]
	private float _volume; //Field offset: 0x50
	[SerializeField]
	private float _minDistance; //Field offset: 0x54
	[SerializeField]
	private float _maxDistance; //Field offset: 0x58
	private AudioSourceCrossfader _crossfader; //Field offset: 0x60
	private Transform _cachedTransform; //Field offset: 0x68
	private bool _initialized; //Field offset: 0x70
	[CompilerGenerated]
	private EAudibleState <CurrentAudibleState>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private float <SqrMaxDistance>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private Action AudibleStateChanged; //Field offset: 0x80

	public override event Action AudibleStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private override EAudibleState CurrentAudibleState
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override Vector3 CurrentPosition
	{
		 get { } //Length: 138
	}

	public override ERadioStation RadioStation
	{
		 get { } //Length: 5
	}

	public private override float SqrMaxDistance
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public ClientBroadcastPlayer() { }

	[CompilerGenerated]
	public override void add_AudibleStateChanged(Action value) { }

	public override void ChangeAudibleState(EAudibleState state) { }

	public override void ChangeStation(ERadioStation station) { }

	private float ClampCrossfadeDuration(AudioClip clip, float targetCrossfadeDuration) { }

	[CompilerGenerated]
	public override EAudibleState get_CurrentAudibleState() { }

	public override Vector3 get_CurrentPosition() { }

	public override ERadioStation get_RadioStation() { }

	[CompilerGenerated]
	public override float get_SqrMaxDistance() { }

	public override void Initialize() { }

	public override void Mute(bool value) { }

	private bool NeedSync(int newClipHashcode, float time) { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public override void remove_AudibleStateChanged(Action value) { }

	[CompilerGenerated]
	private void set_CurrentAudibleState(EAudibleState value) { }

	[CompilerGenerated]
	private void set_SqrMaxDistance(float value) { }

	protected override void SetupSource(AudioSource source) { }

	public override void Stop() { }

	public override void SyncBroadcast(AudioClip clip, double time = 0, float crossfadeDuration = 1) { }

}

