namespace EFT.InventoryLogic;

public class ThermalVisionTemplate : SpecialScopeTemplate, IThermalVisionComponentTemplate
{
	public SelectablePalette RampPalette; //Field offset: 0x1F0
	public float DepthFade; //Field offset: 0x1F4
	public float MainTexColorCoef; //Field offset: 0x1F8
	public float MinimumTemperatureValue; //Field offset: 0x1FC
	public float RampShift; //Field offset: 0x200
	public float HeatMin; //Field offset: 0x204
	public float ColdMax; //Field offset: 0x208
	public bool IsNoisy; //Field offset: 0x20C
	public float NoiseIntensity; //Field offset: 0x210
	public bool IsFpsStuck; //Field offset: 0x214
	public bool IsGlitch; //Field offset: 0x215
	public bool IsMotionBlurred; //Field offset: 0x216
	public EMask Mask; //Field offset: 0x218
	public float MaskSize; //Field offset: 0x21C
	public bool IsPixelated; //Field offset: 0x220
	public int PixelationBlockCount; //Field offset: 0x224

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.ColdMax
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.DepthFade
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.HeatMin
	{
		private get { } //Length: 9
	}

	private override bool EFT.InventoryLogic.IThermalVisionComponentTemplate.IsFpsStuck
	{
		private get { } //Length: 8
	}

	private override bool EFT.InventoryLogic.IThermalVisionComponentTemplate.IsGlitch
	{
		private get { } //Length: 8
	}

	private override bool EFT.InventoryLogic.IThermalVisionComponentTemplate.IsMotionBlurred
	{
		private get { } //Length: 8
	}

	private override bool EFT.InventoryLogic.IThermalVisionComponentTemplate.IsNoisy
	{
		private get { } //Length: 8
	}

	private override bool EFT.InventoryLogic.IThermalVisionComponentTemplate.IsPixelated
	{
		private get { } //Length: 8
	}

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.MainTexColorCoef
	{
		private get { } //Length: 9
	}

	private override EMask EFT.InventoryLogic.IThermalVisionComponentTemplate.Mask
	{
		private get { } //Length: 7
	}

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.MaskSize
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.MinimumTemperatureValue
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.NoiseInstensity
	{
		private get { } //Length: 9
	}

	private override int EFT.InventoryLogic.IThermalVisionComponentTemplate.PixelationBlockCount
	{
		private get { } //Length: 7
	}

	private override SelectablePalette EFT.InventoryLogic.IThermalVisionComponentTemplate.RampPalette
	{
		private get { } //Length: 7
	}

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.RampShift
	{
		private get { } //Length: 9
	}

	public ThermalVisionTemplate() { }

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.get_ColdMax() { }

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.get_DepthFade() { }

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.get_HeatMin() { }

	private override bool EFT.InventoryLogic.IThermalVisionComponentTemplate.get_IsFpsStuck() { }

	private override bool EFT.InventoryLogic.IThermalVisionComponentTemplate.get_IsGlitch() { }

	private override bool EFT.InventoryLogic.IThermalVisionComponentTemplate.get_IsMotionBlurred() { }

	private override bool EFT.InventoryLogic.IThermalVisionComponentTemplate.get_IsNoisy() { }

	private override bool EFT.InventoryLogic.IThermalVisionComponentTemplate.get_IsPixelated() { }

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.get_MainTexColorCoef() { }

	private override EMask EFT.InventoryLogic.IThermalVisionComponentTemplate.get_Mask() { }

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.get_MaskSize() { }

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.get_MinimumTemperatureValue() { }

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.get_NoiseInstensity() { }

	private override int EFT.InventoryLogic.IThermalVisionComponentTemplate.get_PixelationBlockCount() { }

	private override SelectablePalette EFT.InventoryLogic.IThermalVisionComponentTemplate.get_RampPalette() { }

	private override float EFT.InventoryLogic.IThermalVisionComponentTemplate.get_RampShift() { }

}

