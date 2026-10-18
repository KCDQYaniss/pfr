namespace Unity.Collections.LowLevel.Unsafe;

[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
[StaticAccessor("UnsafeUtility", StaticAccessorType::DoubleColon (2))]
public static class UnsafeUtility
{
	private struct AlignOfHelper`1
	{
		public byte dummy; //Field offset: 0x0
		public T data; //Field offset: 0x0

	}

	public struct TypeFlagsCache`1
	{
		internal static readonly int flags; //Field offset: 0x0

		private static TypeFlagsCache`1() { }

		[BurstDiscard]
		private static void Init(ref int flags) { }

	}


	public static void* AddressOf(ref T output) { }

	public static int AlignOf() { }

	public static T ArrayElementAsRef(void* ptr, int index) { }

	public static T As(ref U from) { }

	public static T AsRef(void* ptr) { }

	public static void CopyPtrToStructure(void* ptr, out T output) { }

	public static void CopyStructureToPtr(ref T input, void* ptr) { }

	public static bool EnumEquals(T lhs, T rhs) { }

	public static int EnumToInt(T enumValue) { }

	[ThreadSafe(ThrowsException = True)]
	public static void FreeTracked(void* memory, Allocator allocator) { }

	public static int GetFieldOffset(FieldInfo field) { }

	[ThreadSafe]
	private static int GetFieldOffsetInClass(FieldInfo field) { }

	[ThreadSafe]
	private static int GetFieldOffsetInStruct(FieldInfo field) { }

	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	internal static string GetReasonForGenericListNonBlittable() { }

	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	[ThreadSafe]
	internal static int GetScriptingTypeFlags(Type type) { }

	private static void InternalCopyPtrToStructure(void* ptr, out T output) { }

	private static void InternalCopyStructureToPtr(ref T input, void* ptr) { }

	private static void InternalEnumToInt(ref T enumValue, ref int intValue) { }

	internal static bool IsArrayBlittable(Array arr) { }

	[ThreadSafe]
	public static bool IsBlittable(Type type) { }

	public static bool IsBlittable() { }

	private static bool IsBlittableValueType(Type t) { }

	internal static bool IsGenericListBlittable() { }

	public static bool IsUnmanaged() { }

	[BurstAuthorizedExternalMethod]
	[ThreadSafe(ThrowsException = False)]
	internal static int LeakErase(IntPtr handle, LeakCategory category) { }

	[BurstAuthorizedExternalMethod]
	[ThreadSafe(ThrowsException = False)]
	internal static int LeakRecord(IntPtr handle, LeakCategory category, int callstacksToSkip) { }

	[ThreadSafe(ThrowsException = True)]
	public static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip) { }

	public static void MemClear(void* destination, long size) { }

	[ThreadSafe(ThrowsException = True)]
	public static int MemCmp(void* ptr1, void* ptr2, long size) { }

	[ThreadSafe(ThrowsException = True)]
	public static void MemCpy(void* destination, void* source, long size) { }

	[ThreadSafe(ThrowsException = True)]
	public static void MemCpyReplicate(void* destination, void* source, int size, int count) { }

	[ThreadSafe(ThrowsException = True)]
	public static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count) { }

	[ThreadSafe(ThrowsException = True)]
	public static void MemMove(void* destination, void* source, long size) { }

	[ThreadSafe(ThrowsException = True)]
	public static void MemSet(void* destination, byte value, long size) { }

	public static void* PinGCObjectAndGetAddress(object target, out ulong gcHandle) { }

	[ThreadSafe]
	private static void* PinSystemObjectAndGetAddress(object target, out ulong gcHandle) { }

	public static T ReadArrayElement(void* source, int index) { }

	public static T ReadArrayElementWithStride(void* source, int index, int stride) { }

	[ThreadSafe]
	public static void ReleaseGCObject(ulong gcHandle) { }

	[ThreadSafe]
	public static int SizeOf(Type type) { }

	public static int SizeOf() { }

	public static void WriteArrayElement(void* destination, int index, T value) { }

	public static void WriteArrayElementWithStride(void* destination, int index, int stride, T value) { }

}

