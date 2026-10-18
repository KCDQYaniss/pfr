namespace EFT;

internal class LeftHandInteractionsEventConsumer : BaseEventConsumer, ILeftHandInteractionEvents
{
	[CompilerGenerated]
	private Action OnTakeEvent; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnRemoveEvent; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnActionStartedEvent; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnActionEndedEvent; //Field offset: 0x30

	public override event Action OnActionEndedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnActionStartedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnRemoveEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnTakeEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public LeftHandInteractionsEventConsumer() { }

	[CompilerGenerated]
	public override void add_OnActionEndedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnActionStartedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnRemoveEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnTakeEvent(Action value) { }

	private void OnActionEnded(IAnimatorEventParameter param) { }

	private void OnRemoveItem(IAnimatorEventParameter param) { }

	private void OnStartAction(IAnimatorEventParameter param) { }

	private void OnTakeItem(IAnimatorEventParameter param) { }

	[CompilerGenerated]
	public override void remove_OnActionEndedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnActionStartedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnRemoveEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnTakeEvent(Action value) { }

}

