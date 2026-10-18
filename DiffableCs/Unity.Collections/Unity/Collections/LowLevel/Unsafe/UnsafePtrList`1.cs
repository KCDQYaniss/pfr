namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafePtrListDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
public struct UnsafePtrList`1 : INativeDisposable, IDisposable, IEnumerable, IEnumerable
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal struct ParallelReader
	{
		[NativeDisableUnsafePtrRestriction]
		public readonly T** Ptr; //Field offset: 0x0
		public readonly int Length; //Field offset: 0x0

		internal ParallelReader(T** ptr, int length) { }

		public bool Contains(void* ptr) { }

		public int IndexOf(void* ptr) { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		public readonly T** Ptr; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		public UnsafeList* ListData; //Field offset: 0x0

		internal ParallelWriter(T** ptr, UnsafeList* listData) { }

		public void AddNoResize(T* value) { }

		public void AddRangeNoResize(T** ptr, int count) { }

		public void AddRangeNoResize(UnsafePtrList list) { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	internal struct ReadOnly
	{
		[NativeDisableUnsafePtrRestriction]
		public readonly T** Ptr; //Field offset: 0x0
		public readonly int Length; //Field offset: 0x0

		public bool IsCreated
		{
			[IsReadOnly]
			 get { } //Length: 8
		}

		public bool IsEmpty
		{
			[IsReadOnly]
			 get { } //Length: 138
		}

		internal ReadOnly(T** ptr, int length) { }

		public bool Contains(void* ptr) { }

		[IsReadOnly]
		public bool get_IsCreated() { }

		[IsReadOnly]
		public bool get_IsEmpty() { }

		public int IndexOf(void* ptr) { }

	}

	[NativeDisableUnsafePtrRestriction]
	public readonly T** Ptr; //Field offset: 0x0
	public readonly int m_length; //Field offset: 0x0
	public readonly int m_capacity; //Field offset: 0x0
	public readonly AllocatorHandle Allocator; //Field offset: 0x0
	private readonly int padding; //Field offset: 0x0

	public int Capacity
	{
		[IsReadOnly]
		 get { } //Length: 197
		 set { } //Length: 170
	}

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public bool IsEmpty
	{
		[IsReadOnly]
		 get { } //Length: 208
	}

	public T* Item
	{
		 get { } //Length: 11
		 set { } //Length: 11
	}

	public int Length
	{
		[IsReadOnly]
		 get { } //Length: 192
		 set { } //Length: 170
	}

	public UnsafePtrList`1(T** ptr, int length) { }

	public UnsafePtrList`1(int initialCapacity, AllocatorHandle allocator, NativeArrayOptions options = 0) { }

	public void Add(in IntPtr value) { }

	public void Add(void* value) { }

	public void AddNoResize(void* value) { }

	public void AddRange(UnsafePtrList list) { }

	public void AddRange(void* ptr, int length) { }

	public void AddRangeNoResize(void** ptr, int count) { }

	public void AddRangeNoResize(UnsafePtrList list) { }

	public ParallelReader AsParallelReader() { }

	public ParallelWriter AsParallelWriter() { }

	public ReadOnly AsReadOnly() { }

	public void Clear() { }

	public bool Contains(void* ptr) { }

	public static UnsafePtrList* Create(T** ptr, int length) { }

	public static UnsafePtrList* Create(int initialCapacity, AllocatorHandle allocator, NativeArrayOptions options = 0) { }

	public static void Destroy(UnsafePtrList* listData) { }

	public override void Dispose() { }

	public override JobHandle Dispose(JobHandle inputDeps) { }

	public T* ElementAt(int index) { }

	[IsReadOnly]
	public int get_Capacity() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	[IsReadOnly]
	public bool get_IsEmpty() { }

	public T* get_Item(int index) { }

	[IsReadOnly]
	public int get_Length() { }

	public int IndexOf(void* ptr) { }

	public void InsertRangeWithBeginEnd(int begin, int end) { }

	public void RemoveAt(int index) { }

	public void RemoveAtSwapBack(int index) { }

	public void RemoveRange(int index, int count) { }

	public void RemoveRangeSwapBack(int index, int count) { }

	public void Resize(int length, NativeArrayOptions options = 0) { }

	public void set_Capacity(int value) { }

	public void set_Item(int index, T* value) { }

	public void set_Length(int value) { }

	public void SetCapacity(int capacity) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<System.IntPtr>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void TrimExcess() { }

}

