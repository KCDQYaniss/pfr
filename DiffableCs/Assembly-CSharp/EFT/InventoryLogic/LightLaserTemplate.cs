namespace EFT.InventoryLogic;

public class LightLaserTemplate : FunctionalModTemplate, ILightComponentTemplate
{
	public int ModesCount; //Field offset: 0x1A0

	private override int EFT.InventoryLogic.ILightComponentTemplate.ModesCount
	{
		private get { } //Length: 7
	}

	public LightLaserTemplate() { }

	private override int EFT.InventoryLogic.ILightComponentTemplate.get_ModesCount() { }

}

