namespace EFT.GlobalEvents.AudioEvents;

public class PlayerInteractionEvent : BaseEvent
{
	[CompilerGenerated]
	private string <InteractionTag>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private EInteractionStatus <InteractionStatus>k__BackingField; //Field offset: 0x20

	public private EInteractionStatus InteractionStatus
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string InteractionTag
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public PlayerInteractionEvent() { }

	[CompilerGenerated]
	public EInteractionStatus get_InteractionStatus() { }

	[CompilerGenerated]
	public string get_InteractionTag() { }

	public void Invoke(string interactionTag, EInteractionStatus interactionStatus) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_InteractionStatus(EInteractionStatus value) { }

	[CompilerGenerated]
	private void set_InteractionTag(string value) { }

}

