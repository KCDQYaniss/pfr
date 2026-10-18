namespace EFT.InventoryLogic;

public class MuzzleModTemplate : FunctionalModTemplate, IMuzzleComponentTemplate
{
	public EMuzzleType muzzleModType; //Field offset: 0x1A0
	public float DurabilityBurnModificator; //Field offset: 0x1A4
	public float HeatFactor; //Field offset: 0x1A8
	public float CoolFactor; //Field offset: 0x1AC

	private override EMuzzleType EFT.InventoryLogic.IMuzzleComponentTemplate.MuzzleModType
	{
		private get { } //Length: 7
	}

	public MuzzleModTemplate() { }

	private override EMuzzleType EFT.InventoryLogic.IMuzzleComponentTemplate.get_MuzzleModType() { }

}

