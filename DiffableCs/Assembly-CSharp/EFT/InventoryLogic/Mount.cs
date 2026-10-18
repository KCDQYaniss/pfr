namespace EFT.InventoryLogic;

public class Mount : GearMod
{

	public virtual float CoolFactor
	{
		 get { } //Length: 81
	}

	public virtual float HeatFactor
	{
		 get { } //Length: 81
	}

	public Mount(string id, MountTemplate template) { }

	public virtual float get_CoolFactor() { }

	public virtual float get_HeatFactor() { }

}

