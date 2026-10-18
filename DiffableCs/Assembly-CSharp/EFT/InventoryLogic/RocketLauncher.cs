namespace EFT.InventoryLogic;

public class RocketLauncher : Weapon
{

	public virtual bool CanLoadAmmo
	{
		 get { } //Length: 3
	}

	public RocketLauncher(string id, RocketLauncherTemplate template) { }

	public virtual bool get_CanLoadAmmo() { }

}

