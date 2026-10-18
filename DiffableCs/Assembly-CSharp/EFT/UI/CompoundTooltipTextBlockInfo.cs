namespace EFT.UI;

public sealed class CompoundTooltipTextBlockInfo
{
	public readonly string Header; //Field offset: 0x10
	public readonly string Text; //Field offset: 0x18
	public readonly Sprite HeaderSprite; //Field offset: 0x20
	public readonly Nullable HeaderColor; //Field offset: 0x28

	public CompoundTooltipTextBlockInfo(string header, string text, Sprite headerSprite = null, Nullable headerColor = null) { }

}

