namespace EFT.UI;

public sealed class SingleLineInfo
{
	public readonly string Label; //Field offset: 0x10
	public readonly string Value; //Field offset: 0x18
	public readonly bool NeedLocalizeLabel; //Field offset: 0x20

	public SingleLineInfo(string label, string value = null, bool needLocalizeLabel = true) { }

}

