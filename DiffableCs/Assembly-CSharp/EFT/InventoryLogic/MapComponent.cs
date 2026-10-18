namespace EFT.InventoryLogic;

public class MapComponent : ItemComponent
{
	[Diffable]
	public List Markers; //Field offset: 0x18
	private readonly IMapComponentTemplate _template; //Field offset: 0x20

	public string ConfigPathStr
	{
		 get { } //Length: 75
	}

	public int MaxMarkersCount
	{
		 get { } //Length: 78
	}

	public float ScaleMax
	{
		 get { } //Length: 78
	}

	public float ScaleMin
	{
		 get { } //Length: 78
	}

	public MapComponent(Item item, IMapComponentTemplate template) { }

	public OperationResult CreateMarker(MapMarker marker, bool simulate) { }

	public OperationResult DeleteMarker(int x, int y, bool simulate) { }

	public OperationResult EditMarker(MapMarker marker, int x, int y, bool simulate) { }

	public string get_ConfigPathStr() { }

	public int get_MaxMarkersCount() { }

	public float get_ScaleMax() { }

	public float get_ScaleMin() { }

	[CanBeNull]
	public MapMarker GetMarker(int x, int y) { }

}

