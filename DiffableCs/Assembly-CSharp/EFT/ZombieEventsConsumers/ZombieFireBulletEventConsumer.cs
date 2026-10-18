namespace EFT.ZombieEventsConsumers;

public class ZombieFireBulletEventConsumer : BaseEventConsumer, IZombieFireBulletEvents
{
	[CompilerGenerated]
	private Action OnZombieFireBulletEvent; //Field offset: 0x18

	public override event Action OnZombieFireBulletEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public ZombieFireBulletEventConsumer() { }

	[CompilerGenerated]
	public override void add_OnZombieFireBulletEvent(Action value) { }

	private void OnZombieFireBullet(IAnimatorEventParameter parameter) { }

	[CompilerGenerated]
	public override void remove_OnZombieFireBulletEvent(Action value) { }

}

