namespace Audio.AmbientSubsystem;

public abstract class BaseLoopAmbientSoundPlayer : BaseAmbientSoundPlayer
{

	protected BaseLoopAmbientSoundPlayer() { }

	protected virtual bool CanPlay() { }

	protected virtual void Init() { }

	protected virtual void RestorePlayback() { }

}

