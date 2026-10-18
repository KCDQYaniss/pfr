namespace EFT.Interactive;

public sealed class MaterialEmission : MaterialData
{
	private static readonly int _emissionVisibility; //Field offset: 0x0
	[SerializeField]
	private float _maxEmissionVisibility; //Field offset: 0x28

	private static MaterialEmission() { }

	public MaterialEmission() { }

	public virtual void Init() { }

	public virtual void SetIntensity(float intensity) { }

	public void SetMaxEmissionVisibility(float value) { }

	public virtual void TurnLights(bool on) { }

}

