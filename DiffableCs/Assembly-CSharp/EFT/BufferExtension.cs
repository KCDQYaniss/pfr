namespace EFT;

[Extension]
public static class BufferExtension
{

	[Extension]
	public static Quaternion ReadQuaternion(byte[] buffer, ref int offset) { }

	[Extension]
	public static string ReadString(byte[] buffer, ref int offset) { }

	[Extension]
	public static Vector2 ReadVector2(byte[] buffer, ref int offset) { }

	[Extension]
	public static Vector3 ReadVector3(byte[] buffer, ref int offset) { }

	[Extension]
	public static Vector4 ReadVector4(byte[] buffer, ref int offset) { }

	[Extension]
	public static int Write(byte[] buffer, Vector2 value, int offset = 0) { }

	[Extension]
	public static int Write(byte[] buffer, Vector3 value, int offset = 0) { }

	[Extension]
	public static int Write(byte[] buffer, Vector4 value, int offset = 0) { }

	[Extension]
	public static int Write(byte[] buffer, Quaternion value, int offset = 0) { }

	[Extension]
	public static int Write(byte[] buffer, string str, int offset) { }

}

