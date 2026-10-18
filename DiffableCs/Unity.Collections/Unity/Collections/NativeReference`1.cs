namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[NativeContainer]
public struct NativeReference`1 : INativeDisposable, IDisposable, IEquatable
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct ReadOnly
	{
		[NativeDisableUnsafePtrRestriction]
		private readonly void* m_Data; //Field offset: 0x0

		public T Value
		{
			 get { } //Length: 156
		}

		internal ReadOnly(void* data) { }

		public T get_Value() { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal void* m_Data; //Field offset: 0x0
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public T Value
	{
		 get { } //Length: 156
		 set { } //Length: 278
	}

	public NativeReference`1(AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	public NativeReference`1(T value, AllocatorHandle allocator) { }

	private static void Allocate(AllocatorHandle allocator, out NativeReference reference) { }

	public ReadOnly AsReadOnly() { }

	public static void Copy(NativeReference dst, NativeReference src) { }

	public void CopyFrom(NativeReference reference) { }

	public void CopyTo(NativeReference reference) { }

	public override void Dispose() { }

	public override JobHandle Dispose(JobHandle inputDeps) { }

	[ExcludeFromBurstCompatTesting("Equals boxes because Value does not implement IEquatable<T>")]
	public override bool Equals(NativeReference other) { }

	[ExcludeFromBurstCompatTesting("Takes managed object")]
	public virtual bool Equals(object obj) { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	public T get_Value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(NativeReference left, NativeReference right) { }

	public static ReadOnly op_Implicit(NativeReference nativeReference) { }

	public static bool op_Inequality(NativeReference left, NativeReference right) { }

	public void set_Value(T value) { }

}

