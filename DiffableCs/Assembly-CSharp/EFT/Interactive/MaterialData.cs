namespace EFT.Interactive;

public abstract class MaterialData
{
	public Renderer Renderer; //Field offset: 0x10
	public int MaterialId; //Field offset: 0x18
	protected MaterialPropertyBlock _mpb; //Field offset: 0x20

	[CanBeNull]
	protected Material Material
	{
		 get { } //Length: 321
	}

	protected MaterialData() { }

	protected Material get_Material() { }

	public override void Init() { }

	public abstract void SetIntensity(float intensity) { }

	public abstract void TurnLights(bool on) { }

}

