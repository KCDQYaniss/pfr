namespace EFT.ZombieEventsConsumers;

public class ZombieFireEndEventConsumer : BaseEventConsumer, IZombieFireEndEvents
{
	[CompilerGenerated]
	private Action OnZombieFireEndEvent; //Field offset: 0x18

	public override event Action OnZombieFireEndEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public ZombieFireEndEventConsumer() { }

	[CompilerGenerated]
	public override void add_OnZombieFireEndEvent(Action value) { }

	private void OnZombieFireEnd(IAnimatorEventParameter parameter) { }

	[CompilerGenerated]
	public override void remove_OnZombieFireEndEvent(Action value) { }

}

