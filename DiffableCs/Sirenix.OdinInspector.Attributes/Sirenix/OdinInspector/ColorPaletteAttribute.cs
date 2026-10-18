namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class ColorPaletteAttribute : Attribute
{
	public string PaletteName; //Field offset: 0x10
	public bool ShowAlpha; //Field offset: 0x18

	public ColorPaletteAttribute() { }

	public ColorPaletteAttribute(string paletteName) { }

}

