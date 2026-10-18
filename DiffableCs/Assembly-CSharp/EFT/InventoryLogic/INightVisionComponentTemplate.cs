namespace EFT.InventoryLogic;

public interface INightVisionComponentTemplate
{

	public Color32 Color
	{
		 get { } //Length: 0
	}

	public float DiffuseIntensity
	{
		 get { } //Length: 0
	}

	public float Intensity
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

	public float NoiseIntensity
	{
		 get { } //Length: 0
	}

	public float NoiseScale
	{
		 get { } //Length: 0
	}

	public Color32 get_Color() { }

	public float get_DiffuseIntensity() { }

	public float get_Intensity() { }

	public EMask get_Mask() { }

	public float get_MaskSize() { }

	public float get_NoiseIntensity() { }

	public float get_NoiseScale() { }

}

