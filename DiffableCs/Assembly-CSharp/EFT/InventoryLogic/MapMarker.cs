namespace EFT.InventoryLogic;

[GenerateBinarySerialization]
public class MapMarker
{
	public const int CHARACTER_LIMIT = 75; //Field offset: 0x0
	public MapMarkerType Type; //Field offset: 0x10
	public int X; //Field offset: 0x14
	public int Y; //Field offset: 0x18
	public string Note; //Field offset: 0x20

	public MapMarker() { }

	public MapMarker(MapMarkerType type, int x, int y, string note) { }

	public void CopyFieldsFrom(MapMarker marker) { }

}

