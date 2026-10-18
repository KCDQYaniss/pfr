namespace EFT.InventoryLogic;

public class Handguard : MasterMod
{

	public virtual float CoolFactor
	{
		 get { } //Length: 81
	}

	public virtual float HeatFactor
	{
		 get { } //Length: 81
	}

	public Handguard(string id, HandguardTemplate template) { }

	public virtual float get_CoolFactor() { }

	public virtual float get_HeatFactor() { }

}

