namespace Mirror;

[Extension]
public static class NetworkWriterExtensions
{
	public struct UIntDouble
	{
		public double doubleValue; //Field offset: 0x0
		public ulong longValue; //Field offset: 0x0

	}


	[Extension]
	public static void WriteBool(NetworkWriter writer, bool value) { }

	[Extension]
	public static void WriteBoolNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteByte(NetworkWriter writer, byte value) { }

	[Extension]
	public static void WriteByteNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteBytesAndSize(NetworkWriter writer, byte[] buffer, int offset, int count) { }

	[Extension]
	public static void WriteBytesAndSize(NetworkWriter writer, byte[] buffer) { }

	[Extension]
	public static void WriteBytesAndSizeSegment(NetworkWriter writer, ArraySegment buffer) { }

	[Extension]
	public static void WriteChar(NetworkWriter writer, char value) { }

	[Extension]
	public static void WriteCharNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteColor(NetworkWriter writer, Color value) { }

	[Extension]
	public static void WriteColor32(NetworkWriter writer, Color32 value) { }

	[Extension]
	public static void WriteColor32Nullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteColorNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteDecimal(NetworkWriter writer, decimal value) { }

	[Extension]
	public static void WriteDecimalNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteDouble(NetworkWriter writer, double value) { }

	[Extension]
	public static void WriteDoubleNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteFloat(NetworkWriter writer, float value) { }

	[Extension]
	public static void WriteFloatNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteGuid(NetworkWriter writer, Guid value) { }

	[Extension]
	public static void WriteGuidNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteInt(NetworkWriter writer, int value) { }

	[Extension]
	public static void WriteIntNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteLong(NetworkWriter writer, long value) { }

	[Extension]
	public static void WriteLongNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteMatrix4x4(NetworkWriter writer, Matrix4x4 value) { }

	[Extension]
	public static void WriteMatrix4x4Nullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WritePlane(NetworkWriter writer, Plane value) { }

	[Extension]
	public static void WritePlaneNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteQuaternion(NetworkWriter writer, Quaternion value) { }

	[Extension]
	public static void WriteQuaternionNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteRay(NetworkWriter writer, Ray value) { }

	[Extension]
	public static void WriteRayNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteRect(NetworkWriter writer, Rect value) { }

	[Extension]
	public static void WriteRectNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteSByte(NetworkWriter writer, sbyte value) { }

	[Extension]
	public static void WriteSByteNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteShort(NetworkWriter writer, short value) { }

	[Extension]
	public static void WriteShortNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteString(NetworkWriter writer, string value) { }

	[Extension]
	public static void WriteTimeSpan(NetworkWriter writer, TimeSpan value) { }

	[Extension]
	public static void WriteUInt(NetworkWriter writer, uint value) { }

	[Extension]
	public static void WriteUIntNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteULong(NetworkWriter writer, ulong value) { }

	[Extension]
	public static void WriteULongNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteUri(NetworkWriter writer, Uri uri) { }

	[Extension]
	public static void WriteUShort(NetworkWriter writer, ushort value) { }

	[Extension]
	public static void WriteUShortNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteVector2(NetworkWriter writer, Vector2 value) { }

	[Extension]
	public static void WriteVector2Int(NetworkWriter writer, Vector2Int value) { }

	[Extension]
	public static void WriteVector2IntNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteVector2Nullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteVector3(NetworkWriter writer, Vector3 value) { }

	[Extension]
	public static void WriteVector3Int(NetworkWriter writer, Vector3Int value) { }

	[Extension]
	public static void WriteVector3IntNullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteVector3Nullable(NetworkWriter writer, Nullable value) { }

	[Extension]
	public static void WriteVector4(NetworkWriter writer, Vector4 value) { }

	[Extension]
	public static void WriteVector4Nullable(NetworkWriter writer, Nullable value) { }

}

