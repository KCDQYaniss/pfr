namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Count = {Count()}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeParallelHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
public struct UnsafeParallelHashMap`2 : INativeDisposable, IDisposable, IEnumerable, IEnumerable
{
	internal struct Enumerator : IEnumerator, IEnumerator, IDisposable
	{
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		public override KeyValue Current
		{
			 get { } //Length: 79
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 153
		}

		public override void Dispose() { }

		public override KeyValue get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	internal struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
		[NativeSetThreadIndex]
		internal int m_ThreadIndex; //Field offset: 0x0

		public int Capacity
		{
			[IsReadOnly]
			 get { } //Length: 25
		}

		public int ThreadIndex
		{
			 get { } //Length: 4
		}

		[IsReadOnly]
		public int get_Capacity() { }

		public int get_ThreadIndex() { }

		public bool TryAdd(TKey key, TValue item) { }

		internal bool TryAdd(TKey key, TValue item, int threadIndexOverride) { }

	}

	[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
	[DefaultMember("Item")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	internal struct ReadOnly : IEnumerable, IEnumerable
	{
		internal UnsafeParallelHashMap m_HashMapData; //Field offset: 0x0

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

		public TValue Item
		{
			[IsReadOnly]
			 get { } //Length: 144
		}

		internal ReadOnly(UnsafeParallelHashMap hashMapData) { }

		[IsReadOnly]
		public bool ContainsKey(TKey key) { }

		[IsReadOnly]
		public int Count() { }

		[IsReadOnly]
		public int get_Capacity() { }

		[IsReadOnly]
		public bool get_IsCreated() { }

		[IsReadOnly]
		public bool get_IsEmpty() { }

		[IsReadOnly]
		public TValue get_Item(TKey key) { }

		[IsReadOnly]
		public Enumerator GetEnumerator() { }

		[IsReadOnly]
		public NativeArray GetKeyArray(AllocatorHandle allocator) { }

		[IsReadOnly]
		public NativeKeyValueArrays GetKeyValueArrays(AllocatorHandle allocator) { }

		[IsReadOnly]
		public NativeArray GetValueArray(AllocatorHandle allocator) { }

		private override IEnumerator System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		private void ThrowKeyNotPresent(TKey key) { }

		[IsReadOnly]
		public bool TryGetValue(TKey key, out TValue item) { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	public int Capacity
	{
		[IsReadOnly]
		 get { } //Length: 25
		 set { } //Length: 93
	}

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public bool IsEmpty
	{
		[IsReadOnly]
		 get { } //Length: 94
	}

	public TValue Item
	{
		 get { } //Length: 142
		 set { } //Length: 278
	}

	public UnsafeParallelHashMap`2(int capacity, AllocatorHandle allocator) { }

	public void Add(TKey key, TValue item) { }

	public ParallelWriter AsParallelWriter() { }

	public ReadOnly AsReadOnly() { }

	public void Clear() { }

	public bool ContainsKey(TKey key) { }

	[IsReadOnly]
	public int Count() { }

	public override JobHandle Dispose(JobHandle inputDeps) { }

	public override void Dispose() { }

	[IsReadOnly]
	public int get_Capacity() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	[IsReadOnly]
	public bool get_IsEmpty() { }

	public TValue get_Item(TKey key) { }

	public Enumerator GetEnumerator() { }

	public NativeArray GetKeyArray(AllocatorHandle allocator) { }

	public NativeKeyValueArrays GetKeyValueArrays(AllocatorHandle allocator) { }

	public NativeArray GetValueArray(AllocatorHandle allocator) { }

	public bool Remove(TKey key) { }

	public void set_Capacity(int value) { }

	public void set_Item(TKey key, TValue value) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryAdd(TKey key, TValue item) { }

	public bool TryGetValue(TKey key, out TValue item) { }

}

