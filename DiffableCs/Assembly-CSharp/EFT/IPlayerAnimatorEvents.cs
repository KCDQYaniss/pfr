namespace EFT;

public interface IPlayerAnimatorEvents
{

	public IBipodToggleEvents BipodToggleEvents
	{
		 get { } //Length: 0
	}

	public IVaultingSoundsEvents ClimbSoundsEvents
	{
		 get { } //Length: 0
	}

	public IDropBackPackEvents DropBackpackEvents
	{
		 get { } //Length: 0
	}

	public IIntroActionsEvents IntroActionsEvents
	{
		 get { } //Length: 0
	}

	public ILeftHandInteractionEvents LeftHandInteractionEvents
	{
		 get { } //Length: 0
	}

	public IVaultingSoundsEvents SprintVaultSoundsEvents
	{
		 get { } //Length: 0
	}

	public IVaultingSoundsEvents VaultingSoundsEvents
	{
		 get { } //Length: 0
	}

	public IZombieFireBulletEvents ZombieFireBulletEvents
	{
		 get { } //Length: 0
	}

	public IZombieFireEndEvents ZombieFireEndEvents
	{
		 get { } //Length: 0
	}

	public IBipodToggleEvents get_BipodToggleEvents() { }

	public IVaultingSoundsEvents get_ClimbSoundsEvents() { }

	public IDropBackPackEvents get_DropBackpackEvents() { }

	public IIntroActionsEvents get_IntroActionsEvents() { }

	public ILeftHandInteractionEvents get_LeftHandInteractionEvents() { }

	public IVaultingSoundsEvents get_SprintVaultSoundsEvents() { }

	public IVaultingSoundsEvents get_VaultingSoundsEvents() { }

	public IZombieFireBulletEvents get_ZombieFireBulletEvents() { }

	public IZombieFireEndEvents get_ZombieFireEndEvents() { }

}

