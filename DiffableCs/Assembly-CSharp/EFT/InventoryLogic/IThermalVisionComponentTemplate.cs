namespace EFT.InventoryLogic;

public interface IThermalVisionComponentTemplate
{

	public float ColdMax
	{
		 get { } //Length: 0
	}

	public float DepthFade
	{
		 get { } //Length: 0
	}

	public float HeatMin
	{
		 get { } //Length: 0
	}

	public bool IsFpsStuck
	{
		 get { } //Length: 0
	}

	public bool IsGlitch
	{
		 get { } //Length: 0
	}

	public bool IsMotionBlurred
	{
		 get { } //Length: 0
	}

	public bool IsNoisy
	{
		 get { } //Length: 0
	}

	public bool IsPixelated
	{
		 get { } //Length: 0
	}

	public float MainTexColorCoef
	{
		 get { } //Length: 0
	}

	public EMask Mask
	{
		 get { } //Length: 0
	}

	public float MaskSize
	{
		 get { } //Length: 0
	}

	public float MinimumTemperatureValue
	{
		 get { } //Length: 0
	}

	public float NoiseInstensity
	{
		 get { } //Length: 0
	}

	public int PixelationBlockCount
	{
		 get { } //Length: 0
	}

	public SelectablePalette RampPalette
	{
		 get { } //Length: 0
	}

	public float RampShift
	{
		 get { } //Length: 0
	}

	public float get_ColdMax() { }

	public float get_DepthFade() { }

	public float get_HeatMin() { }

	public bool get_IsFpsStuck() { }

	public bool get_IsGlitch() { }

	public bool get_IsMotionBlurred() { }

	public bool get_IsNoisy() { }

	public bool get_IsPixelated() { }

	public float get_MainTexColorCoef() { }

	public EMask get_Mask() { }

	public float get_MaskSize() { }

	public float get_MinimumTemperatureValue() { }

	public float get_NoiseInstensity() { }

	public int get_PixelationBlockCount() { }

	public SelectablePalette get_RampPalette() { }

	public float get_RampShift() { }

}

