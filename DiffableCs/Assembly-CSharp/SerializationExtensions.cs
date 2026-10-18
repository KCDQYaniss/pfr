//Type is in global namespace

[Extension]
public static class SerializationExtensions
{

	[Extension]
	public static Quaternion ReadQuaternion(BinaryReader reader) { }

	[Extension]
	public static ushort[] ReadUInt16Array(BinaryReader reader) { }

	[Extension]
	public static Vector3 ReadVector3(BinaryReader reader) { }

	[Extension]
	public static void Write(BinaryWriter writer, ushort[] val) { }

	[Extension]
	public static void Write(BinaryWriter writer, Vector3 val) { }

	[Extension]
	public static void Write(BinaryWriter writer, Quaternion val) { }

}

