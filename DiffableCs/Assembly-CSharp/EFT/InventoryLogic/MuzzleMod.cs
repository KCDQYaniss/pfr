namespace EFT.InventoryLogic;

public class MuzzleMod : FunctionalMod
{

	public virtual float CoolFactor
	{
		 get { } //Length: 81
	}

	public virtual float DurabilityBurnModificator
	{
		 get { } //Length: 81
	}

	public virtual float HeatFactor
	{
		 get { } //Length: 81
	}

	public MuzzleMod(string id, MuzzleModTemplate template) { }

	public virtual float get_CoolFactor() { }

	public virtual float get_DurabilityBurnModificator() { }

	public virtual float get_HeatFactor() { }

}

