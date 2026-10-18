namespace Audio.AmbientSubsystem;

public class AmbientSoundPlayer : BaseRandomAmbientSoundPlayer
{
	[SerializeField]
	private SoundBank _ambientBank; //Field offset: 0x120

	protected virtual SoundBank CurrentBank
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public AmbientSoundPlayer() { }

	protected virtual SoundBank get_CurrentBank() { }

	protected virtual void set_CurrentBank(SoundBank value) { }

}

