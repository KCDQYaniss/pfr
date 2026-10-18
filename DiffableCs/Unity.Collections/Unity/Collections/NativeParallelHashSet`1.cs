namespace Unity.Collections;

[DebuggerTypeProxy(typeof(NativeParallelHashSetDebuggerTypeProxy`1))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
public struct NativeParallelHashSet`1 : INativeDisposable, IDisposable, IEnumerable, IEnumerable
{
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct Enumerator : IEnumerator, IEnumerator, IDisposable
	{
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 97
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 113
		}

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[NativeContainerIsAtomicWriteOnly]
	internal struct ParallelWriter
	{
		internal ParallelWriter m_Data; //Field offset: 0x0

		public int Capacity
		{
			[IsReadOnly]
			 get { } //Length: 81
		}

		public bool Add(T item) { }

		internal bool Add(T item, int threadIndexOverride) { }

		[IsReadOnly]
		public int get_Capacity() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct ReadOnly : IEnumerable, IEnumerable
	{
		internal UnsafeParallelHashMap m_Data; //Field offset: 0x0

		public int Capacity
		{
			[IsReadOnly]
			 get { } //Length: 49
		}

		public bool IsCreated
		{
			[IsReadOnly]
			 get { } //Length: 40
		}

		public bool IsEmpty
		{
			[IsReadOnly]
			 get { } //Length: 135
		}

		internal ReadOnly(ref NativeParallelHashSet data) { }

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[IsReadOnly]
		private void CheckRead() { }

		[IsReadOnly]
		public bool Contains(T item) { }

		[IsReadOnly]
		public int Count() { }

		[IsReadOnly]
		public int get_Capacity() { }

		[IsReadOnly]
		public bool get_IsCreated() { }

		[IsReadOnly]
		public bool get_IsEmpty() { }

		[IsReadOnly]
		public Enumerator GetEnumerator() { }

		private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[IsReadOnly]
		public NativeArray ToNativeArray(AllocatorHandle allocator) { }

	}

	internal NativeParallelHashMap m_Data; //Field offset: 0x0

	public int Capacity
	{
		[IsReadOnly]
		 get { } //Length: 81
		 set { } //Length: 67
	}

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 72
	}

	public bool IsEmpty
	{
		[IsReadOnly]
		 get { } //Length: 54
	}

	public NativeParallelHashSet`1(int capacity, AllocatorHandle allocator) { }

	public bool Add(T item) { }

	public ParallelWriter AsParallelWriter() { }

	public ReadOnly AsReadOnly() { }

	public void Clear() { }

	public bool Contains(T item) { }

	public int Count() { }

	public override void Dispose() { }

	public override JobHandle Dispose(JobHandle inputDeps) { }

	[IsReadOnly]
	public int get_Capacity() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	[IsReadOnly]
	public bool get_IsEmpty() { }

	public Enumerator GetEnumerator() { }

	public bool Remove(T item) { }

	public void set_Capacity(int value) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public NativeArray ToNativeArray(AllocatorHandle allocator) { }

}

