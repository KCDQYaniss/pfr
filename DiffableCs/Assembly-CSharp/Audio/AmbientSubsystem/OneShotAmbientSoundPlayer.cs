namespace Audio.AmbientSubsystem;

public class OneShotAmbientSoundPlayer : BaseAmbientSoundPlayer
{
	private const float CLIP_END_BUFFER_SEC = 0.1; //Field offset: 0x0
	[SerializeField]
	private SoundBank _soundBank; //Field offset: 0xF0
	private double _playbackEndTimeDsp; //Field offset: 0xF8
	private bool _hasStartedPlayingLogic; //Field offset: 0x100

	public OneShotAmbientSoundPlayer() { }

	protected virtual bool CanPlay() { }

	protected virtual AudioClip GetClip() { }

	protected virtual void OnStop() { }

	public virtual void Play() { }

	private void ProcessOneShotPlaybackLogic() { }

	protected virtual void RestorePlayback() { }

	protected virtual void UpdateTimers(float dt) { }

	public virtual void UpdateVirtualTimers() { }

}

