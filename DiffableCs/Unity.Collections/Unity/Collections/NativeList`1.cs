namespace Unity.Collections;

[DebuggerDisplay("Length = {m_ListData == null ? default : m_ListData->Length}, Capacity = {m_ListData == null ? default : m_ListData->Capacity}")]
[DebuggerTypeProxy(typeof(NativeListDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[NativeContainer]
public struct NativeList`1 : INativeDisposable, IDisposable, INativeList, IIndexable, IEnumerable, IEnumerable
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	internal struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		public UnsafeList* ListData; //Field offset: 0x0

		public void* Ptr
		{
			[IsReadOnly]
			 get { } //Length: 25
		}

		internal ParallelWriter(UnsafeList* listData) { }

		public void AddNoResize(T value) { }

		public void AddRangeNoResize(void* ptr, int count) { }

		public void AddRangeNoResize(UnsafeList list) { }

		public void AddRangeNoResize(NativeList list) { }

		[IsReadOnly]
		public void* get_Ptr() { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal UnsafeList* m_ListData; //Field offset: 0x0

	public override int Capacity
	{
		[IsReadOnly]
		 get { } //Length: 36
		 set { } //Length: 67
	}

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public override bool IsEmpty
	{
		[IsReadOnly]
		 get { } //Length: 60
	}

	public override T Item
	{
		 get { } //Length: 113
		 set { } //Length: 110
	}

	public override int Length
	{
		[IsReadOnly]
		 get { } //Length: 36
		 set { } //Length: 73
	}

	public NativeList`1(AllocatorHandle allocator) { }

	public NativeList`1(int initialCapacity, AllocatorHandle allocator) { }

	public void Add(in T value) { }

	public void AddNoResize(T value) { }

	public void AddRange(void* ptr, int count) { }

	public void AddRange(NativeArray array) { }

	public void AddRangeNoResize(void* ptr, int count) { }

	public void AddRangeNoResize(NativeList list) { }

	public void AddReplicate(in T value, int count) { }

	public NativeArray AsArray() { }

	public NativeArray AsDeferredJobArray() { }

	public ReadOnly AsParallelReader() { }

	public ParallelWriter AsParallelWriter() { }

	public ReadOnly AsReadOnly() { }

	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckArgPositive(int value) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void CheckHandleMatches(AllocatorHandle handle) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckIndexInRange(int value, int length) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckInitialCapacity(int initialCapacity) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckSufficientCapacity(int capacity, int length) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckTotalSize(int initialCapacity, long totalSize) { }

	public override void Clear() { }

	public void CopyFrom(in NativeList other) { }

	public void CopyFrom(in UnsafeList other) { }

	public void CopyFrom(in NativeArray other) { }

	public override JobHandle Dispose(JobHandle inputDeps) { }

	public override void Dispose() { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	internal void Dispose(ref U allocator) { }

	public override T ElementAt(int index) { }

	[IsReadOnly]
	public override int get_Capacity() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	[IsReadOnly]
	public override bool get_IsEmpty() { }

	public override T get_Item(int index) { }

	[IsReadOnly]
	public override int get_Length() { }

	public Enumerator GetEnumerator() { }

	public UnsafeList* GetUnsafeList() { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	internal void Initialize(int initialCapacity, ref U allocator) { }

	public void InsertRange(int index, int count) { }

	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	internal static NativeList New(int initialCapacity, ref U allocator) { }

	[Obsolete("Implicit cast from `NativeList<T>` to `NativeArray<T>` has been deprecated; Use '.AsArray()' method to do explicit cast instead.", False)]
	public static NativeArray op_Implicit(NativeList nativeList) { }

	public void RemoveAt(int index) { }

	public void RemoveAtSwapBack(int index) { }

	public void RemoveRange(int index, int count) { }

	public void RemoveRangeSwapBack(int index, int count) { }

	public void Resize(int length, NativeArrayOptions options) { }

	public void ResizeUninitialized(int length) { }

	public override void set_Capacity(int value) { }

	public override void set_Item(int index, T value) { }

	public override void set_Length(int value) { }

	public void SetCapacity(int capacity) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public NativeArray ToArray(AllocatorHandle allocator) { }

	public void TrimExcess() { }

}

