namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerTypeProxy(typeof(UnsafeParallelMultiHashMapDebuggerTypeProxy`2))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
public struct UnsafeParallelMultiHashMap`2 : INativeDisposable, IDisposable, IEnumerable, IEnumerable
{
	internal struct Enumerator : IEnumerator, IEnumerator, IDisposable
	{
		internal UnsafeParallelMultiHashMap hashmap; //Field offset: 0x0
		internal TKey key; //Field offset: 0x0
		internal bool isFirst; //Field offset: 0x0
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

	internal struct KeyValueEnumerator : IEnumerator, IEnumerator, IDisposable
	{
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		public override KeyValue Current
		{
			 get { } //Length: 136
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 164
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

		public void Add(TKey key, TValue item) { }

		[IsReadOnly]
		public int get_Capacity() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
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

		[IsReadOnly]
		public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator it) { }

		[IsReadOnly]
		public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator it) { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	public int Capacity
	{
		[IsReadOnly]
		 get { } //Length: 25
		 set { } //Length: 150
	}

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public bool IsEmpty
	{
		[IsReadOnly]
		 get { } //Length: 183
	}

	public UnsafeParallelMultiHashMap`2(int capacity, AllocatorHandle allocator) { }

	public void Add(TKey key, TValue item) { }

	public ParallelWriter AsParallelWriter() { }

	public ReadOnly AsReadOnly() { }

	public void Clear() { }

	[IsReadOnly]
	public bool ContainsKey(TKey key) { }

	[IsReadOnly]
	public int Count() { }

	[IsReadOnly]
	public int CountValuesForKey(TKey key) { }

	public override JobHandle Dispose(JobHandle inputDeps) { }

	public override void Dispose() { }

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

	public Enumerator GetValuesForKey(TKey key) { }

	public void Remove(NativeParallelMultiHashMapIterator it) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public void Remove(TKey key, TValueEQ value) { }

	public int Remove(TKey key) { }

	public void set_Capacity(int value) { }

	public bool SetValue(TValue item, NativeParallelMultiHashMapIterator it) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IsReadOnly]
	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator it) { }

	[IsReadOnly]
	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator it) { }

}

