namespace System.Runtime;

public static class RuntimeImports
{

	internal static void _ecvt_s(byte* buffer, int sizeInBytes, double value, int count, int* dec, int* sign) { }

	internal static void Memmove(byte* dest, byte* src, uint len) { }

	internal static void Memmove_wbarrier(byte* dest, byte* src, uint len, IntPtr type_handle) { }

	internal static void RhZeroMemory(ref byte b, ulong byteLength) { }

	private static void ZeroMemory(void* p, uint byteLength) { }

}

