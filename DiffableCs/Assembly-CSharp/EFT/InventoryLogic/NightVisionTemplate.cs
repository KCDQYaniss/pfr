namespace EFT.InventoryLogic;

public class NightVisionTemplate : SpecialScopeTemplate, INightVisionComponentTemplate
{
	public float Intensity; //Field offset: 0x1F0
	public EMask Mask; //Field offset: 0x1F4
	public float MaskSize; //Field offset: 0x1F8
	public float NoiseIntensity; //Field offset: 0x1FC
	public float NoiseScale; //Field offset: 0x200
	public Color32 Color; //Field offset: 0x204
	public float DiffuseIntensity; //Field offset: 0x208

	private override Color32 EFT.InventoryLogic.INightVisionComponentTemplate.Color
	{
		private get { } //Length: 7
	}

	private override float EFT.InventoryLogic.INightVisionComponentTemplate.DiffuseIntensity
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.INightVisionComponentTemplate.Intensity
	{
		private get { } //Length: 9
	}

	private override EMask EFT.InventoryLogic.INightVisionComponentTemplate.Mask
	{
		private get { } //Length: 7
	}

	private override float EFT.InventoryLogic.INightVisionComponentTemplate.MaskSize
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.INightVisionComponentTemplate.NoiseIntensity
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.INightVisionComponentTemplate.NoiseScale
	{
		private get { } //Length: 9
	}

	public NightVisionTemplate() { }

	private override Color32 EFT.InventoryLogic.INightVisionComponentTemplate.get_Color() { }

	private override float EFT.InventoryLogic.INightVisionComponentTemplate.get_DiffuseIntensity() { }

	private override float EFT.InventoryLogic.INightVisionComponentTemplate.get_Intensity() { }

	private override EMask EFT.InventoryLogic.INightVisionComponentTemplate.get_Mask() { }

	private override float EFT.InventoryLogic.INightVisionComponentTemplate.get_MaskSize() { }

	private override float EFT.InventoryLogic.INightVisionComponentTemplate.get_NoiseIntensity() { }

	private override float EFT.InventoryLogic.INightVisionComponentTemplate.get_NoiseScale() { }

}

