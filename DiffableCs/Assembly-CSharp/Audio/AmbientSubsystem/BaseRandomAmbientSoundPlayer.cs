namespace Audio.AmbientSubsystem;

public abstract class BaseRandomAmbientSoundPlayer : BaseAmbientSoundPlayer, ISoundBankChangeable
{
	private struct VirtualPlaybackData
	{
		public AudioClip clip; //Field offset: 0x0
		public float pitch; //Field offset: 0x8
		public float startTime; //Field offset: 0xC

		public bool IsValid
		{
			 get { } //Length: 202
		}

		public void Clear() { }

		public bool get_IsValid() { }

	}

	private const float PLAYING_TIME_OFFSET = 0.01; //Field offset: 0x0
	[Header("Random Settings")]
	[SerializeField]
	[Space]
	private Vector2 _randomTimeRange; //Field offset: 0xF0
	private float _nextPlayTime; //Field offset: 0xF8
	private float _currentClipEndTime; //Field offset: 0xFC
	private bool _isPlayingVirtualClip; //Field offset: 0x100
	private bool _hasStartedPlayingLogic; //Field offset: 0x101
	private VirtualPlaybackData _virtualData; //Field offset: 0x108
	[CompilerGenerated]
	private Action VirtualClipStarted; //Field offset: 0x118

	public event Action VirtualClipStarted
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	protected abstract SoundBank CurrentBank
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	protected BaseRandomAmbientSoundPlayer() { }

	[CompilerGenerated]
	public void add_VirtualClipStarted(Action value) { }

	public override void ChangeSoundBank(SoundBank newSoundBank) { }

	protected abstract SoundBank get_CurrentBank() { }

	protected virtual AudioClip GetClip() { }

	protected override float GetRandomDelay() { }

	protected virtual void OnStop() { }

	public virtual void Play() { }

	[CompilerGenerated]
	public void remove_VirtualClipStarted(Action value) { }

	protected virtual void RestorePlayback() { }

	protected abstract void set_CurrentBank(SoundBank value) { }

	private void StartRealPlayback(AudioClip clip, float pitch, float timeOffset, bool invokePlayedEvent) { }

	private void UpdateRandomSchedule(bool viaCullingTick) { }

	protected virtual void UpdateTimers(float dt) { }

	public virtual void UpdateVirtualTimers() { }

}

