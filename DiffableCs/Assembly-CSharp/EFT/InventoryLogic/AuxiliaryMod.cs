namespace EFT.InventoryLogic;

public class AuxiliaryMod : Mod
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

	public AuxiliaryMod(string id, AuxiliaryModTemplate template) { }

	public virtual float get_CoolFactor() { }

	public virtual float get_DurabilityBurnModificator() { }

	public virtual float get_HeatFactor() { }

}

