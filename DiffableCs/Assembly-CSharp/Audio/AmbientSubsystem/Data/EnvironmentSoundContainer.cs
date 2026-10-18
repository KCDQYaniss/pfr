namespace Audio.AmbientSubsystem.Data;

public class EnvironmentSoundContainer
{
	[SerializeField]
	private AudioClip _indoorClip; //Field offset: 0x10
	[SerializeField]
	private AudioClip _outdoorClip; //Field offset: 0x18

	public EnvironmentSoundContainer() { }

	public AudioClip GetClip(EnvironmentType environment) { }

}

