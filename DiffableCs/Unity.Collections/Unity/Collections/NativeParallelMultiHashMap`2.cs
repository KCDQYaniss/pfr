namespace Unity.Collections;

[DebuggerTypeProxy(typeof(NativeParallelMultiHashMapDebuggerTypeProxy`2))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[NativeContainer]
public struct NativeParallelMultiHashMap`2 : INativeDisposable, IDisposable, IEnumerable, IEnumerable
{
	internal struct Enumerator : IEnumerator, IEnumerator, IDisposable
	{
		internal NativeParallelMultiHashMap hashmap; //Field offset: 0x0
		internal TKey key; //Field offset: 0x0
		internal byte isFirst; //Field offset: 0x0
		private TValue value; //Field offset: 0x0
		private NativeParallelMultiHashMapIterator iterator; //Field offset: 0x0

		public override TValue Current
		{
			 get { } //Length: 217
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 253
		}

		public override void Dispose() { }

		public override TValue get_Current() { }

		public Enumerator GetEnumerator() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct KeyValueEnumerator : IEnumerator, IEnumerator, IDisposable
	{
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		public override KeyValue Current
		{
			[IsReadOnly]
			 get { } //Length: 144
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 164
		}

		public override void Dispose() { }

		[IsReadOnly]
		public override KeyValue get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	internal struct ParallelWriter
	{
		internal ParallelWriter m_Writer; //Field offset: 0x0

		public int Capacity
		{
			[IsReadOnly]
			 get { } //Length: 112
		}

		public int m_ThreadIndex
		{
			 get { } //Length: 4
		}

		public void Add(TKey key, TValue item) { }

		[IsReadOnly]
		public int get_Capacity() { }

		public int get_m_ThreadIndex() { }

	}

	[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy`2))]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct ReadOnly : IEnumerable, IEnumerable
	{
		internal UnsafeParallelMultiHashMap m_MultiHashMapData; //Field offset: 0x0

		public int Capacity
		{
			[IsReadOnly]
			 get { } //Length: 112
		}

		public bool IsCreated
		{
			[IsReadOnly]
			 get { } //Length: 112
		}

		public bool IsEmpty
		{
			[IsReadOnly]
			 get { } //Length: 206
		}

		internal ReadOnly(UnsafeParallelMultiHashMap container) { }

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[IsReadOnly]
		private void CheckRead() { }

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

		public KeyValueEnumerator GetEnumerator() { }

		[IsReadOnly]
		public NativeArray GetKeyArray(AllocatorHandle allocator) { }

		[IsReadOnly]
		public NativeKeyValueArrays GetKeyValueArrays(AllocatorHandle allocator) { }

		[IsReadOnly]
		public NativeArray GetValueArray(AllocatorHandle allocator) { }

		private override IEnumerator System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Conditional("UNITY_DOTS_DEBUG")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[IsReadOnly]
		private void ThrowKeyNotPresent(TKey key) { }

		[IsReadOnly]
		public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator it) { }

		[IsReadOnly]
		public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator it) { }

	}

	internal UnsafeParallelMultiHashMap m_MultiHashMapData; //Field offset: 0x0

	public int Capacity
	{
		[IsReadOnly]
		 get { } //Length: 112
		 set { } //Length: 126
	}

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 118
	}

	public bool IsEmpty
	{
		[IsReadOnly]
		 get { } //Length: 112
	}

	public NativeParallelMultiHashMap`2(int capacity, AllocatorHandle allocator) { }

	public void Add(TKey key, TValue item) { }

	public ParallelWriter AsParallelWriter() { }

	public ReadOnly AsReadOnly() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	private void CheckRead() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckWrite() { }

	public void Clear() { }

	public bool ContainsKey(TKey key) { }

	[IsReadOnly]
	public int Count() { }

	public int CountValuesForKey(TKey key) { }

	public override void Dispose() { }

	public override JobHandle Dispose(JobHandle inputDeps) { }

	[IsReadOnly]
	public int get_Capacity() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	[IsReadOnly]
	public bool get_IsEmpty() { }

	public KeyValueEnumerator GetEnumerator() { }

	public NativeArray GetKeyArray(AllocatorHandle allocator) { }

	public NativeKeyValueArrays GetKeyValueArrays(AllocatorHandle allocator) { }

	public NativeArray GetValueArray(AllocatorHandle allocator) { }

	public Enumerator GetValuesForKey(TKey key) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	internal void Initialize(int capacity, ref U allocator) { }

	public void Remove(NativeParallelMultiHashMapIterator it) { }

	public int Remove(TKey key) { }

	public void set_Capacity(int value) { }

	public bool SetValue(TValue item, NativeParallelMultiHashMapIterator it) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator it) { }

	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator it) { }

}

