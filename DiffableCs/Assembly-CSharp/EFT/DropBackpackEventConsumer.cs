namespace EFT;

public class DropBackpackEventConsumer : BaseEventConsumer, IDropBackPackEvents
{
	[CompilerGenerated]
	private Action OnBackpackDropEvent; //Field offset: 0x18

	public override event Action OnBackpackDropEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public DropBackpackEventConsumer() { }

	[CompilerGenerated]
	public override void add_OnBackpackDropEvent(Action value) { }

	private void OnBackpackDrop(IAnimatorEventParameter param) { }

	[CompilerGenerated]
	public override void remove_OnBackpackDropEvent(Action value) { }

}

