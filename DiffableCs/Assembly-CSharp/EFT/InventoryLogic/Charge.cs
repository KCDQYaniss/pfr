namespace EFT.InventoryLogic;

public class Charge : GearMod
{

	public virtual float DurabilityBurnModificator
	{
		 get { } //Length: 81
	}

	public Charge(string id, ChargeTemplate template) { }

	public virtual float get_DurabilityBurnModificator() { }

}

