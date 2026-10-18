namespace Mono.Security;

internal sealed class BitConverterLE
{

	internal static byte[] GetBytes(float value) { }

	internal static byte[] GetBytes(double value) { }

	private static byte[] GetUIntBytes(byte* bytes) { }

	private static byte[] GetULongBytes(byte* bytes) { }

	internal static double ToDouble(byte[] value, int startIndex) { }

	internal static float ToSingle(byte[] value, int startIndex) { }

	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	private static void ULongFromBytes(byte* dst, byte[] src, int startIndex) { }

}

