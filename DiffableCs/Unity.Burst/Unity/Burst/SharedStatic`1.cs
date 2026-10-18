namespace Unity.Burst;

[IsReadOnly]
public struct SharedStatic`1
{
	private const uint DefaultAlignment = 16; //Field offset: 0x0
	private readonly void* _buffer; //Field offset: 0x0

	public T Data
	{
		 get { } //Length: 36
	}

	public void* UnsafeDataPointer
	{
		 get { } //Length: 4
	}

	private SharedStatic`1(void* buffer) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckIf_T_IsUnmanagedOrThrow() { }

	public T get_Data() { }

	public void* get_UnsafeDataPointer() { }

	public static SharedStatic GetOrCreate(uint alignment = 0) { }

	public static SharedStatic GetOrCreate(uint alignment = 0) { }

	public static SharedStatic GetOrCreate(Type contextType, uint alignment = 0) { }

	public static SharedStatic GetOrCreate(Type contextType, Type subContextType, uint alignment = 0) { }

	public static SharedStatic GetOrCreatePartiallyUnsafeWithHashCode(uint alignment, long hashCode) { }

	public static SharedStatic GetOrCreatePartiallyUnsafeWithSubHashCode(uint alignment, long subHashCode) { }

	public static SharedStatic GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode) { }

}

