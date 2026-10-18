namespace EFT.InventoryLogic;

public class LauncherTemplate : GearModTemplate
{
	private WeaponTemplate _linkedWeapon; //Field offset: 0x1A0
	public bool UseAmmoWithoutShell; //Field offset: 0x1A8
	public string LinkedWeapon; //Field offset: 0x1B0
	public Slot[] Chambers; //Field offset: 0x1B8

	public WeaponTemplate GhostWeapon
	{
		 get { } //Length: 589
	}

	public LauncherTemplate() { }

	public WeaponTemplate get_GhostWeapon() { }

}

