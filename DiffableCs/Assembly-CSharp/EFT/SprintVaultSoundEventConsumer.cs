namespace EFT;

public class SprintVaultSoundEventConsumer : BaseEventConsumer, IVaultingSoundsEvents
{
	[CompilerGenerated]
	private Action OnStartEvent; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnEndEvent; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnGrabEvent; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnSlideEvent; //Field offset: 0x30

	public override event Action OnEndEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnGrabEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnSlideEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnStartEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public SprintVaultSoundEventConsumer() { }

	[CompilerGenerated]
	public override void add_OnEndEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnGrabEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnSlideEvent(Action value) { }

	[CompilerGenerated]
	public override void add_OnStartEvent(Action value) { }

	private void OnEnd(IAnimatorEventParameter param) { }

	private void OnGrab(IAnimatorEventParameter param) { }

	private void OnSlide(IAnimatorEventParameter param) { }

	private void OnStart(IAnimatorEventParameter param) { }

	[CompilerGenerated]
	public override void remove_OnEndEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnGrabEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnSlideEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_OnStartEvent(Action value) { }

}

