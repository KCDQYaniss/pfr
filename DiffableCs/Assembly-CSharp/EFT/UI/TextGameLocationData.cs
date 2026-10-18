namespace EFT.UI;

public sealed class TextGameLocationData
{
	public readonly string Name; //Field offset: 0x10
	public readonly Vector2 LabelPosition; //Field offset: 0x18
	public readonly Vector2 PlayerPosition; //Field offset: 0x20
	public readonly EMapType MapType; //Field offset: 0x28
	public readonly float Scale; //Field offset: 0x2C

	public TextGameLocationData(string name, Vector2 labelPosition, Vector2 playerPosition, EMapType mapType, float scale = 1) { }

}

