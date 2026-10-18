namespace System.Runtime.CompilerServices;

public static class Unsafe
{

	[NonVersionable]
	public static T Add(ref T source, IntPtr elementOffset) { }

	[NonVersionable]
	public static T As(object o) { }

	[NonVersionable]
	public static TTo As(ref TFrom source) { }

	[NonVersionable]
	public static T ReadUnaligned(void* source) { }

	[NonVersionable]
	public static T ReadUnaligned(ref byte source) { }

	[NonVersionable]
	public static int SizeOf() { }

	[NonVersionable]
	public static void WriteUnaligned(void* destination, T value) { }

	[NonVersionable]
	public static void WriteUnaligned(ref byte destination, T value) { }

}

