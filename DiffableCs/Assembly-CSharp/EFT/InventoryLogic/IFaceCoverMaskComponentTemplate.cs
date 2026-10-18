namespace EFT.InventoryLogic;

public interface IFaceCoverMaskComponentTemplate
{

	public EFaceCoverMask Mask
	{
		 get { } //Length: 0
	}

	public float MaskSize
	{
		 get { } //Length: 0
	}

	public EFaceCoverMask get_Mask() { }

	public float get_MaskSize() { }

}

