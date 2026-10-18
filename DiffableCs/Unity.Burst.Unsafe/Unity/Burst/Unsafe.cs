namespace Unity.Burst;

internal static class Unsafe
{

	[NonVersionable]
	public static T Add(ref T source, IntPtr elementOffset) { }

	[NonVersionable]
	public static void* Add(void* source, int elementOffset) { }

	[NonVersionable]
	public static T Add(ref T source, int elementOffset) { }

	[NonVersionable]
	public static T AddByteOffset(ref T source, IntPtr byteOffset) { }

	[NonVersionable]
	public static bool AreSame(ref T left, ref T right) { }

	[NonVersionable]
	public static TTo As(ref TFrom source) { }

	[NonVersionable]
	public static T As(object o) { }

	[NonVersionable]
	public static void* AsPointer(ref T value) { }

	[NonVersionable]
	public static T AsRef(ref T source) { }

	[NonVersionable]
	public static T AsRef(void* source) { }

	[NonVersionable]
	public static IntPtr ByteOffset(ref T origin, ref T target) { }

	[NonVersionable]
	public static void Copy(void* destination, ref T source) { }

	[NonVersionable]
	public static void Copy(ref T destination, void* source) { }

	[NonVersionable]
	public static void CopyBlock(void* destination, void* source, uint byteCount) { }

	[NonVersionable]
	public static void CopyBlock(ref byte destination, ref byte source, uint byteCount) { }

	[NonVersionable]
	public static void CopyBlockUnaligned(void* destination, void* source, uint byteCount) { }

	[NonVersionable]
	public static void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount) { }

	[NonVersionable]
	public static void InitBlock(void* startAddress, byte value, uint byteCount) { }

	[NonVersionable]
	public static void InitBlock(ref byte startAddress, byte value, uint byteCount) { }

	[NonVersionable]
	public static void InitBlockUnaligned(void* startAddress, byte value, uint byteCount) { }

	[NonVersionable]
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	[NonVersionable]
	public static bool IsAddressGreaterThan(ref T left, ref T right) { }

	[NonVersionable]
	public static bool IsAddressLessThan(ref T left, ref T right) { }

	[NonVersionable]
	public static T Read(void* source) { }

	[NonVersionable]
	public static T ReadUnaligned(ref byte source) { }

	[NonVersionable]
	public static T ReadUnaligned(void* source) { }

	[NonVersionable]
	public static int SizeOf() { }

	[NonVersionable]
	public static T Subtract(ref T source, int elementOffset) { }

	[NonVersionable]
	public static void* Subtract(void* source, int elementOffset) { }

	[NonVersionable]
	public static T Subtract(ref T source, IntPtr elementOffset) { }

	[NonVersionable]
	public static T SubtractByteOffset(ref T source, IntPtr byteOffset) { }

	[NonVersionable]
	public static T Unbox(object box) { }

	[NonVersionable]
	public static void Write(void* destination, T value) { }

	[NonVersionable]
	public static void WriteUnaligned(ref byte destination, T value) { }

	[NonVersionable]
	public static void WriteUnaligned(void* destination, T value) { }

}

