namespace EFT.GlobalEvents.AudioEvents;

public class ClientSeasonChangedEvent : BaseEvent
{
	[CompilerGenerated]
	private ESeasonStatus <SeasonStatus>k__BackingField; //Field offset: 0x18

	public private ESeasonStatus SeasonStatus
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ClientSeasonChangedEvent() { }

	[CompilerGenerated]
	public ESeasonStatus get_SeasonStatus() { }

	public void Invoke(ESeasonStatus newSeasonStatus) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_SeasonStatus(ESeasonStatus value) { }

}

