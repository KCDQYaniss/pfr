namespace Sirenix.Utilities.Unsafe;

public static class UnsafeUtilities
{

	public static void MemoryCopy(object from, object to, int byteCount, int fromByteOffset, int toByteOffset) { }

	public static string StringFromBytes(byte[] buffer, int charLength, bool needs16BitSupport) { }

	public static int StringToBytes(byte[] buffer, string value, bool needs16BitSupport) { }

	public static T[] StructArrayFromBytes(byte[] bytes, int byteLength) { }

	public static T[] StructArrayFromBytes(byte[] bytes, int byteLength, int byteOffset) { }

	public static byte[] StructArrayToBytes(T[] array) { }

	public static byte[] StructArrayToBytes(T[] array, ref byte[] bytes, int byteOffset) { }

}

