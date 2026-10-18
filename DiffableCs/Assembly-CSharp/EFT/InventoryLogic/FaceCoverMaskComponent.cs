namespace EFT.InventoryLogic;

public class FaceCoverMaskComponent : ItemComponent
{
	internal enum EFaceCoverMask
	{
		None = 0,
		GasMaskOld = 1,
		Binocular = 2,
	}

	public readonly IFaceCoverMaskComponentTemplate Template; //Field offset: 0x18

	public FaceCoverMaskComponent(Item item, IFaceCoverMaskComponentTemplate template) { }

}

