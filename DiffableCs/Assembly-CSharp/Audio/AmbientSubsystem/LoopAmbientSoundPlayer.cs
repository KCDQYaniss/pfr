namespace Audio.AmbientSubsystem;

public class LoopAmbientSoundPlayer : BaseLoopAmbientSoundPlayer
{
	[SerializeField]
	private AudioClip _loopClip; //Field offset: 0xF0

	public LoopAmbientSoundPlayer() { }

	protected virtual AudioClip GetClip() { }

}

