namespace Unity.Collections.LowLevel.Unsafe;

[NativeHeader("Runtime/Export/BurstLike/BurstLike.bindings.h")]
[StaticAccessor("BurstLike", StaticAccessorType::DoubleColon (2))]
internal static class BurstLike
{
	public static class SharedStatic
	{

		public static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }

	}

	[IsReadOnly]
	public struct SharedStatic`1
	{
		private readonly void* _buffer; //Field offset: 0x0

		public T Data
		{
			 get { } //Length: 36
		}

		private SharedStatic`1(void* buffer) { }

		public T get_Data() { }

		public static SharedStatic GetOrCreate(uint alignment = 0) { }

	}


}

