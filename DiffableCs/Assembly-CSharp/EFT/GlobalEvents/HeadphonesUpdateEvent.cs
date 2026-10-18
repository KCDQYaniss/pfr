namespace EFT.GlobalEvents;

public class HeadphonesUpdateEvent : BaseEvent
{
	[CompilerGenerated]
	private HeadphonesTemplate <Template>k__BackingField; //Field offset: 0x18

	public private HeadphonesTemplate Template
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HeadphonesUpdateEvent() { }

	[CompilerGenerated]
	public HeadphonesTemplate get_Template() { }

	public void Invoke(HeadphonesTemplate template) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_Template(HeadphonesTemplate value) { }

}

