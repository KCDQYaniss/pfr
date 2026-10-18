namespace Mirror;

public static class Compression
{
	private const float QuaternionMinRange = -0.707107; //Field offset: 0x0
	private const float QuaternionMaxRange = 0.707107; //Field offset: 0x0
	private const ushort TenBitsMax = 1023; //Field offset: 0x0

	public static bool AttachedToMask(byte mask, byte index) { }

	public static void AttachToMask(ref byte mask, byte index, bool value) { }

	public static uint CompressQuaternion(Quaternion q) { }

	public static void CompressVarInt(NetworkWriter writer, long i) { }

	public static void CompressVarUInt(NetworkWriter writer, ulong value) { }

	public static Quaternion DecompressQuaternion(uint data) { }

	public static long DecompressVarInt(NetworkReader reader) { }

	public static ulong DecompressVarUInt(NetworkReader reader) { }

	public static int LargestAbsoluteComponentIndex(Vector4 value, out float largestAbs, out Vector3 withoutLargest) { }

	private static float QuaternionElement(Quaternion q, int element) { }

	private static Quaternion QuaternionNormalizeSafe(Quaternion value) { }

	public static float ScaleByteToFloat(byte value, byte minValue, byte maxValue, float minTarget, float maxTarget) { }

	public static float ScaleByteToFloat(byte value, float minTarget, float maxTarget) { }

	public static int ScaleByteToInt(byte value, byte minValue, byte maxValue, int minTarget, int maxTarget) { }

	public static int ScaleByteToInt(byte value, int minTarget, int maxTarget) { }

	public static byte ScaleFloatToByte(float value, float minValue, float maxValue, byte minTarget, byte maxTarget) { }

	public static byte ScaleFloatToByte(float value, float minValue, float maxValue) { }

	public static short ScaleFloatToShort(float value, float minValue, float maxValue) { }

	public static short ScaleFloatToShort(float value, float minValue, float maxValue, short minTarget, short maxTarget) { }

	public static ushort ScaleFloatToUShort(float value, float minValue, float maxValue, ushort minTarget, ushort maxTarget) { }

	public static Vector2 ScaleFromVector2Byte(Vector2Byte value, float minTarget, float maxTarget) { }

	public static Vector2 ScaleFromVector2Byte(Vector2Byte value, byte minValue, byte maxValue, float minTarget, float maxTarget) { }

	public static Vector2 ScaleFromVector2Short(Vector2Short value, short minValue, short maxValue, float minTarget, float maxTarget) { }

	public static Vector2 ScaleFromVector2Short(Vector2Short value, short minTarget, short maxTarget) { }

	public static Vector3 ScaleFromVector3Byte(Vector3Byte value, byte minValue, byte maxValue, float minTarget, float maxTarget) { }

	public static Vector3 ScaleFromVector3Byte(Vector3Byte value, float minTarget, float maxTarget) { }

	public static Vector3 ScaleFromVector3Short(Vector3Short value, float minTarget, float maxTarget) { }

	public static Vector3 ScaleFromVector3Short(Vector3Short value, short minValue, short maxValue, float minTarget, float maxTarget) { }

	public static byte ScaleIntToByte(int value, int minValue, int maxValue) { }

	public static byte ScaleIntToByte(int value, int minValue, int maxValue, byte minTarget, byte maxTarget) { }

	public static float ScaleShortToFloat(short value, float minTarget, float maxTarget) { }

	public static float ScaleShortToFloat(short value, short minValue, short maxValue, float minTarget, float maxTarget) { }

	public static float ScaleToFloat(long value, float precision) { }

	public static Vector3 ScaleToFloat(long x, long y, long z, float precision) { }

	public static Vector3 ScaleToFloat(Vector3Long value, float precision) { }

	public static bool ScaleToLong(float value, float precision, out long result) { }

	public static bool ScaleToLong(Vector3 value, float precision, out long x, out long y, out long z) { }

	public static bool ScaleToLong(Vector3 value, float precision, out Vector3Long quantized) { }

	public static Vector2Byte ScaleToVector2Byte(Vector2 value, float minValue, float maxValue) { }

	public static Vector2Byte ScaleToVector2Byte(Vector2 value, float minValue, float maxValue, byte minTarget, byte maxTarget) { }

	public static Vector2Short ScaleToVector2Short(Vector2 value, float minValue, float maxValue) { }

	public static Vector2Short ScaleToVector2Short(Vector2 value, float minValue, float maxValue, short minTarget, short maxTarget) { }

	public static Vector3Byte ScaleToVector3Byte(Vector3 value, float minValue, float maxValue) { }

	public static Vector3Byte ScaleToVector3Byte(Vector3 value, float minValue, float maxValue, byte minTarget, byte maxTarget) { }

	public static Vector3Short ScaleToVector3Short(Vector3 value, float minValue, float maxValue, short minTarget, short maxTarget) { }

	public static Vector3Short ScaleToVector3Short(Vector3 value, float minValue, float maxValue) { }

	public static float ScaleUShortToFloat(ushort value, ushort minValue, ushort maxValue, float minTarget, float maxTarget) { }

}

