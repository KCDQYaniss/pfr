namespace Audio.SpatialSystem;

public struct AudioRouteData : IBinarySerializable
{
	public short PortalDataLength; //Field offset: 0x0
	public float HeuristicCost; //Field offset: 0x4
	public ushort StartIndex; //Field offset: 0x8
	public ushort NodeStartIndex; //Field offset: 0xA

	public override void Read(BinaryReader reader) { }

	public override void Write(BinaryWriter writer) { }

}

