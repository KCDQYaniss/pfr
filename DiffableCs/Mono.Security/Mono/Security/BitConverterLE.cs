namespace Mono.Security;

internal sealed class BitConverterLE
{

	internal static byte[] GetBytes(int value) { }

	internal static byte[] GetBytes(long value) { }

	private static byte[] GetUIntBytes(byte* bytes) { }

	private static byte[] GetULongBytes(byte* bytes) { }

	internal static int ToInt32(byte[] value, int startIndex) { }

	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	internal static uint ToUInt32(byte[] value, int startIndex) { }

	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

}

