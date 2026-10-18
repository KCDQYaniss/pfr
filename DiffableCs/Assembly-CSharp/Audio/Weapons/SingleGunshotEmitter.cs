namespace Audio.Weapons;

public sealed class SingleGunshotEmitter : IAudioGunshotEmitter, IDisposable
{
	private readonly BifacialTransform _soundTransform; //Field offset: 0x10
	private readonly IAudioScheduleService _scheduler; //Field offset: 0x18
	private readonly WeaponPlaybackSettings _settings; //Field offset: 0x20
	private AudioMixerGroup _currentMixerGroup; //Field offset: 0x28
	private IPlayer _player; //Field offset: 0x30
	private bool _occlusionEnabled; //Field offset: 0x38
	private bool _reverbEnabled; //Field offset: 0x39
	[CompilerGenerated]
	private double <LastScheduledDspTime>k__BackingField; //Field offset: 0x40
	private double _nextIdealShotTime; //Field offset: 0x48

	public override bool HasPendingFades
	{
		 get { } //Length: 3
	}

	public private override double LastScheduledDspTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public SingleGunshotEmitter(BifacialTransform soundTransform, IServerTimeProvider serverTimeProvider, WeaponPlaybackSettings settings) { }

	public override void Dispose() { }

	public override void EnabledOcclusion(bool enabled) { }

	public override void EnabledReverb(bool enabled) { }

	public override bool get_HasPendingFades() { }

	[CompilerGenerated]
	public override double get_LastScheduledDspTime() { }

	public override void RegisterInOcclusionProcess(IObserverToPlayerBridge playerBridge) { }

	public override void Reset() { }

	public override void ScheduleShotSound(ShotPlaybackContext playbackContext) { }

	[CompilerGenerated]
	private void set_LastScheduledDspTime(double value) { }

	public override void SetMixerGroup(AudioMixerGroup mixerGroup) { }

	public override void Tick(double dspNow) { }

}

