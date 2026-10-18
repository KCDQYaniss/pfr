namespace EFT.Interactive;

public sealed class MaterialColor : MaterialData
{
	public string ParemeterName; //Field offset: 0x28
	[ColorUsage(True, True)]
	public Color ColorOn; //Field offset: 0x30
	[ColorUsage(True, True)]
	public Color ColorOff; //Field offset: 0x40

	public MaterialColor() { }

	public virtual void SetIntensity(float intensity) { }

	public virtual void TurnLights(bool on) { }

}

