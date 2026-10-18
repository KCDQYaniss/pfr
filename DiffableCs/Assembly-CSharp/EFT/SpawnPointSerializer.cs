namespace EFT;

public sealed class SpawnPointSerializer : ISerializer
{
	public float px; //Field offset: 0x10
	public float py; //Field offset: 0x14
	public float pz; //Field offset: 0x18
	public float rw; //Field offset: 0x1C
	public float rx; //Field offset: 0x20
	public float ry; //Field offset: 0x24
	public float rz; //Field offset: 0x28

	public SpawnPointSerializer() { }

	public override SpawnPointInfo Deserialize() { }

	public override object Serialize(SpawnPointInfo t) { }

}

