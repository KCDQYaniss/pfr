namespace EFT.InventoryLogic;

public class SpecialWeapon : Weapon
{

	public virtual bool CanBePickedUp
	{
		 get { } //Length: 3
	}

	public SpecialWeapon(string id, SpecialWeaponTemplate template) { }

	public virtual bool get_CanBePickedUp() { }

}

