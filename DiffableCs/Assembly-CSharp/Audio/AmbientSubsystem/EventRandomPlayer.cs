namespace Audio.AmbientSubsystem;

public class EventRandomPlayer : BaseRandomAmbientSoundPlayer, IEventSoundContentChanger
{
	[SerializeField]
	private EventSoundBanks _soundBanks; //Field offset: 0x120
	private bool _eventInitialized; //Field offset: 0x128
	[CompilerGenerated]
	private SoundBank <CurrentBank>k__BackingField; //Field offset: 0x130

	protected virtual SoundBank CurrentBank
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public EventRandomPlayer() { }

	protected virtual bool CanPlay() { }

	public override void ChangeSoundContent(EEventType eventType) { }

	[CompilerGenerated]
	protected virtual SoundBank get_CurrentBank() { }

	[CompilerGenerated]
	protected virtual void set_CurrentBank(SoundBank value) { }

}

