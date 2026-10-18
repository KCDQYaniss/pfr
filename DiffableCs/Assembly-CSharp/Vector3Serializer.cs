//Type is in global namespace

public struct Vector3Serializer : ISerializer
{
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4
	public float z; //Field offset: 0x8

	public override Vector3 Deserialize() { }

	public override object Serialize(Vector3 t) { }

}

