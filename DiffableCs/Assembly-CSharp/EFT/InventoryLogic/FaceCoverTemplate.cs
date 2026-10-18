namespace EFT.InventoryLogic;

public class FaceCoverTemplate : ArmoredEquipmentTemplate, IFaceCoverMaskComponentTemplate
{
	public bool IsHalfMask; //Field offset: 0x1D0
	public EFaceCoverMask FaceCoverMask; //Field offset: 0x1D4
	public float MaskSize; //Field offset: 0x1D8

	private override EFaceCoverMask EFT.InventoryLogic.IFaceCoverMaskComponentTemplate.Mask
	{
		private get { } //Length: 7
	}

	private override float EFT.InventoryLogic.IFaceCoverMaskComponentTemplate.MaskSize
	{
		private get { } //Length: 9
	}

	public FaceCoverTemplate() { }

	private override EFaceCoverMask EFT.InventoryLogic.IFaceCoverMaskComponentTemplate.get_Mask() { }

	private override float EFT.InventoryLogic.IFaceCoverMaskComponentTemplate.get_MaskSize() { }

}

