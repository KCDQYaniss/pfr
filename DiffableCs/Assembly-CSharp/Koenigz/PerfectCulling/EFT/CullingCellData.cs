namespace Koenigz.PerfectCulling.EFT;

public sealed class CullingCellData : ISpatialItem, IBinarySerializable
{
	public OrientedBounds CellBounds; //Field offset: 0x10
	public List CullingData; //Field offset: 0x38
	public List IndividualSampleProbes; //Field offset: 0x40
	public bool UserModified; //Field offset: 0x48
	public bool Ignored; //Field offset: 0x49
	public List Connections; //Field offset: 0x50
	public int RuntimeCellId; //Field offset: 0x58

	public override Bounds SpatialItemBounds
	{
		 get { } //Length: 51
	}

	public CullingCellData() { }

	public Vector3 ClosestPointOriented(Vector3 p, out bool isPointInside) { }

	public override Bounds get_SpatialItemBounds() { }

	public override void Read(BinaryReader reader) { }

	public override void Write(BinaryWriter writer) { }

}

