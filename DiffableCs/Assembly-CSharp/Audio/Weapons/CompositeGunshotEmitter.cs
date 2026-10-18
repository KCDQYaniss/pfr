namespace Audio.Weapons;

public sealed class CompositeGunshotEmitter : IAudioGunshotEmitter, IDisposable
{
	private readonly IAudioGunshotEmitter _autoStrategy; //Field offset: 0x10
	private readonly IAudioGunshotEmitter _singleStrategy; //Field offset: 0x18
	private readonly IAudioFireModeSelector _fireModeSelector; //Field offset: 0x20
	private IAudioGunshotEmitter _currentStrategy; //Field offset: 0x28
	private EEmitterFireMode _currentFireMode; //Field offset: 0x30

	public override bool HasPendingFades
	{
		 get { } //Length: 81
	}

	public override double LastScheduledDspTime
	{
		 get { } //Length: 75
	}

	public CompositeGunshotEmitter(IAudioGunshotEmitter autoStrategy, IAudioGunshotEmitter singleStrategy, IAudioFireModeSelector fireModeSelector) { }

	public override void Dispose() { }

	public override void EnabledOcclusion(bool enabled) { }

	public override void EnabledReverb(bool enabled) { }

	private void FireModeChangedHandler(EEmitterFireMode fireMode) { }

	public override bool get_HasPendingFades() { }

	public override double get_LastScheduledDspTime() { }

	public override void RegisterInOcclusionProcess(IObserverToPlayerBridge player) { }

	public override void Reset() { }

	public override void ScheduleShotSound(ShotPlaybackContext playbackContext) { }

	public override void SetMixerGroup(AudioMixerGroup mixerGroup) { }

	public override void Tick(double dspNow) { }

}

