namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class DisplayAsStringAttribute : Attribute
{
	public bool Overflow; //Field offset: 0x10
	public TextAlignment Alignment; //Field offset: 0x14
	public int FontSize; //Field offset: 0x18
	public bool EnableRichText; //Field offset: 0x1C
	public string Format; //Field offset: 0x20

	public DisplayAsStringAttribute() { }

	public DisplayAsStringAttribute(bool overflow) { }

	public DisplayAsStringAttribute(TextAlignment alignment) { }

	public DisplayAsStringAttribute(int fontSize) { }

	public DisplayAsStringAttribute(bool overflow, TextAlignment alignment) { }

	public DisplayAsStringAttribute(bool overflow, int fontSize) { }

	public DisplayAsStringAttribute(int fontSize, TextAlignment alignment) { }

	public DisplayAsStringAttribute(bool overflow, int fontSize, TextAlignment alignment) { }

	public DisplayAsStringAttribute(TextAlignment alignment, bool enableRichText) { }

	public DisplayAsStringAttribute(int fontSize, bool enableRichText) { }

	public DisplayAsStringAttribute(bool overflow, TextAlignment alignment, bool enableRichText) { }

	public DisplayAsStringAttribute(bool overflow, int fontSize, bool enableRichText) { }

	public DisplayAsStringAttribute(int fontSize, TextAlignment alignment, bool enableRichText) { }

	public DisplayAsStringAttribute(bool overflow, int fontSize, TextAlignment alignment, bool enableRichText) { }

}

