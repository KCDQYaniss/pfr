//Type is in global namespace

public struct BoundsSerializer : ISerializer
{
	public Vector3 center; //Field offset: 0x0
	public Vector3 extents; //Field offset: 0xC

	public override Bounds Deserialize() { }

	public override object Serialize(Bounds t) { }

}

