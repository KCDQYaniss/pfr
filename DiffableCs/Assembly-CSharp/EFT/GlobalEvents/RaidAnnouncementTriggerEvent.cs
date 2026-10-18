namespace EFT.GlobalEvents;

public class RaidAnnouncementTriggerEvent : BaseEvent
{
	[CompilerGenerated]
	private string <AnnouncementId>k__BackingField; //Field offset: 0x18

	public private string AnnouncementId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public RaidAnnouncementTriggerEvent() { }

	[CompilerGenerated]
	public string get_AnnouncementId() { }

	public void Invoke(string announcementId) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_AnnouncementId(string value) { }

}

