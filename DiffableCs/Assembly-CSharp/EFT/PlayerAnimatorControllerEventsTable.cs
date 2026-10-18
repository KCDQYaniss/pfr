namespace EFT;

public class PlayerAnimatorControllerEventsTable : IPlayerAnimatorEvents
{
	private readonly List _playerEventsConsumers; //Field offset: 0x10
	private readonly VaultSoundsEventConsumer _vaultingSoundsEventsConsumer; //Field offset: 0x18
	private readonly SprintVaultSoundEventConsumer _sprintVaultSoundsEventsConsumer; //Field offset: 0x20
	private readonly ClimbSoundsEventConsumer _climbSoundsEventsConsumer; //Field offset: 0x28
	private readonly DropBackpackEventConsumer _dropBackpackEventsConsumer; //Field offset: 0x30
	private readonly BipodToggleEvents _bipodToggleEventsConsumer; //Field offset: 0x38
	private readonly ZombieFireBulletEventConsumer _zombieFireBulletEventConsumer; //Field offset: 0x40
	private readonly ZombieFireEndEventConsumer _zombieFireEndEventConsumer; //Field offset: 0x48
	private readonly LeftHandInteractionsEventConsumer _leftHandInteractionsEventConsumer; //Field offset: 0x50
	private readonly IntroActionsEventConsumer _introActionsEventConsumer; //Field offset: 0x58

	public override IBipodToggleEvents BipodToggleEvents
	{
		 get { } //Length: 5
	}

	public override IVaultingSoundsEvents ClimbSoundsEvents
	{
		 get { } //Length: 5
	}

	public override IDropBackPackEvents DropBackpackEvents
	{
		 get { } //Length: 76
	}

	public override IIntroActionsEvents IntroActionsEvents
	{
		 get { } //Length: 5
	}

	public override ILeftHandInteractionEvents LeftHandInteractionEvents
	{
		 get { } //Length: 5
	}

	public override IVaultingSoundsEvents SprintVaultSoundsEvents
	{
		 get { } //Length: 5
	}

	public override IVaultingSoundsEvents VaultingSoundsEvents
	{
		 get { } //Length: 5
	}

	public override IZombieFireBulletEvents ZombieFireBulletEvents
	{
		 get { } //Length: 5
	}

	public override IZombieFireEndEvents ZombieFireEndEvents
	{
		 get { } //Length: 5
	}

	public PlayerAnimatorControllerEventsTable() { }

	public void DispatchEvents(int functionNameHash, AnimationEventParameter parameter) { }

	public override IBipodToggleEvents get_BipodToggleEvents() { }

	public override IVaultingSoundsEvents get_ClimbSoundsEvents() { }

	public override IDropBackPackEvents get_DropBackpackEvents() { }

	public override IIntroActionsEvents get_IntroActionsEvents() { }

	public override ILeftHandInteractionEvents get_LeftHandInteractionEvents() { }

	public override IVaultingSoundsEvents get_SprintVaultSoundsEvents() { }

	public override IVaultingSoundsEvents get_VaultingSoundsEvents() { }

	public override IZombieFireBulletEvents get_ZombieFireBulletEvents() { }

	public override IZombieFireEndEvents get_ZombieFireEndEvents() { }

}

