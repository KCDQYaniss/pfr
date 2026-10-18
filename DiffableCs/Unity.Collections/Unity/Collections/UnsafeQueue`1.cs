namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
public struct UnsafeQueue`1 : INativeDisposable, IDisposable
{
	internal struct Enumerator : IEnumerator, IEnumerator, IDisposable
	{
		[NativeDisableUnsafePtrRestriction]
		internal UnsafeQueueBlockHeader* m_FirstBlock; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		internal UnsafeQueueBlockHeader* m_Block; //Field offset: 0x0
		internal int m_Index; //Field offset: 0x0
		private T value; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 94
		}

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		internal UnsafeQueueData* m_Buffer; //Field offset: 0x0
		internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0
		[NativeSetThreadIndex]
		internal int m_ThreadIndex; //Field offset: 0x0

		public void Enqueue(T value) { }

		internal void Enqueue(T value, int threadIndexOverride) { }

	}

	[DefaultMember("Item")]
	internal struct ReadOnly : IEnumerable, IEnumerable
	{
		[NativeDisableUnsafePtrRestriction]
		private UnsafeQueueData* m_Buffer; //Field offset: 0x0

		public int Count
		{
			[IsReadOnly]
			 get { } //Length: 59
		}

		public bool IsCreated
		{
			[IsReadOnly]
			 get { } //Length: 8
		}

		public T Item
		{
			[IsReadOnly]
			 get { } //Length: 138
		}

		internal ReadOnly(ref UnsafeQueue data) { }

		[IsReadOnly]
		public int get_Count() { }

		[IsReadOnly]
		public bool get_IsCreated() { }

		[IsReadOnly]
		public T get_Item(int index) { }

		[IsReadOnly]
		public Enumerator GetEnumerator() { }

		[IsReadOnly]
		public bool IsEmpty() { }

		private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		private void ThrowIndexOutOfRangeException(int index) { }

		[IsReadOnly]
		private bool TryGetValue(int index, out T item) { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal UnsafeQueueData* m_Buffer; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	public int Count
	{
		[IsReadOnly]
		 get { } //Length: 59
	}

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public UnsafeQueue`1(AllocatorHandle allocator) { }

	internal static UnsafeQueue* Alloc(AllocatorHandle allocator) { }

	public ParallelWriter AsParallelWriter() { }

	public ReadOnly AsReadOnly() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void CheckNotEmpty() { }

	public void Clear() { }

	public T Dequeue() { }

	public override void Dispose() { }

	public override JobHandle Dispose(JobHandle inputDeps) { }

	public void Enqueue(T value) { }

	internal static void Free(UnsafeQueue* data) { }

	[IsReadOnly]
	public int get_Count() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	[IsReadOnly]
	public bool IsEmpty() { }

	public T Peek() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void ThrowEmpty() { }

	public NativeArray ToArray(AllocatorHandle allocator) { }

	public bool TryDequeue(out T item) { }

}

