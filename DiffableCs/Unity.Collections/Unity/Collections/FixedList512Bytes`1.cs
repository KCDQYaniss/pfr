namespace Unity.Collections;

[DebuggerTypeProxy(typeof(FixedList512BytesDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
public struct FixedList512Bytes`1 : INativeList, IIndexable, IEnumerable, IEnumerable, IEquatable, IComparable, IEquatable, IComparable, IEquatable, IComparable, IEquatable, IComparable, IEquatable, IComparable
{
	internal struct Enumerator : IEnumerator, IEnumerator, IDisposable
	{
		private FixedList512Bytes m_List; //Field offset: 0x0
		private int m_Index; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 71
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 163
		}

		public Enumerator(ref FixedList512Bytes list) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[SerializeField]
	internal FixedBytes512Align8 data; //Field offset: 0x0

	internal byte* buffer
	{
		[IsReadOnly]
		internal get { } //Length: 62
	}

	internal byte* Buffer
	{
		[IsReadOnly]
		internal get { } //Length: 124
	}

	public override int Capacity
	{
		[IsReadOnly]
		 get { } //Length: 45
		 set { } //Length: 3
	}

	[CreateProperty]
	private IEnumerable Elements
	{
		private get { } //Length: 54
	}

	public override bool IsEmpty
	{
		[IsReadOnly]
		 get { } //Length: 72
	}

	public override T Item
	{
		[IsReadOnly]
		 get { } //Length: 125
		 set { } //Length: 125
	}

	internal ushort length
	{
		[IsReadOnly]
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	[CreateProperty]
	public override int Length
	{
		[IsReadOnly]
		 get { } //Length: 36
		 set { } //Length: 47
	}

	internal int LengthInBytes
	{
		internal get { } //Length: 100
	}

	public FixedList512Bytes`1(in FixedList64Bytes other) { }

	public FixedList512Bytes`1(in FixedList4096Bytes other) { }

	public FixedList512Bytes`1(in FixedList32Bytes other) { }

	public FixedList512Bytes`1(in FixedList128Bytes other) { }

	public void Add(in T item) { }

	public void AddNoResize(in T item) { }

	public void AddRange(void* ptr, int length) { }

	public void AddRangeNoResize(void* ptr, int length) { }

	public void AddReplicate(in T value, int count) { }

	public override void Clear() { }

	public override int CompareTo(FixedList32Bytes other) { }

	public override int CompareTo(FixedList64Bytes other) { }

	public override int CompareTo(FixedList128Bytes other) { }

	public override int CompareTo(FixedList4096Bytes other) { }

	public override int CompareTo(FixedList512Bytes other) { }

	public override T ElementAt(int index) { }

	public override bool Equals(FixedList512Bytes other) { }

	public override bool Equals(FixedList128Bytes other) { }

	public override bool Equals(FixedList4096Bytes other) { }

	public override bool Equals(FixedList64Bytes other) { }

	[ExcludeFromBurstCompatTesting("Takes managed object")]
	public virtual bool Equals(object obj) { }

	public override bool Equals(FixedList32Bytes other) { }

	[IsReadOnly]
	internal byte* get_buffer() { }

	[IsReadOnly]
	internal byte* get_Buffer() { }

	[IsReadOnly]
	public override int get_Capacity() { }

	private IEnumerable get_Elements() { }

	[IsReadOnly]
	public override bool get_IsEmpty() { }

	[IsReadOnly]
	public override T get_Item(int index) { }

	[IsReadOnly]
	internal ushort get_length() { }

	[IsReadOnly]
	public override int get_Length() { }

	internal int get_LengthInBytes() { }

	public Enumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	internal int Initialize(in FixedList4096Bytes other) { }

	internal int Initialize(in FixedList64Bytes other) { }

	internal int Initialize(in FixedList32Bytes other) { }

	internal int Initialize(in FixedList128Bytes other) { }

	public void Insert(int index, in T item) { }

	public void InsertRange(int index, int count) { }

	public void InsertRangeWithBeginEnd(int begin, int end) { }

	public static bool op_Equality(in FixedList512Bytes a, in FixedList128Bytes b) { }

	public static bool op_Equality(in FixedList512Bytes a, in FixedList512Bytes b) { }

	public static bool op_Equality(in FixedList512Bytes a, in FixedList4096Bytes b) { }

	public static bool op_Equality(in FixedList512Bytes a, in FixedList32Bytes b) { }

	public static bool op_Equality(in FixedList512Bytes a, in FixedList64Bytes b) { }

	public static FixedList512Bytes op_Implicit(in FixedList128Bytes other) { }

	public static FixedList512Bytes op_Implicit(in FixedList4096Bytes other) { }

	public static FixedList512Bytes op_Implicit(in FixedList32Bytes other) { }

	public static FixedList512Bytes op_Implicit(in FixedList64Bytes other) { }

	public static bool op_Inequality(in FixedList512Bytes a, in FixedList64Bytes b) { }

	public static bool op_Inequality(in FixedList512Bytes a, in FixedList512Bytes b) { }

	public static bool op_Inequality(in FixedList512Bytes a, in FixedList4096Bytes b) { }

	public static bool op_Inequality(in FixedList512Bytes a, in FixedList32Bytes b) { }

	public static bool op_Inequality(in FixedList512Bytes a, in FixedList128Bytes b) { }

	public void RemoveAt(int index) { }

	public void RemoveAtSwapBack(int index) { }

	public void RemoveRange(int index, int count) { }

	public void RemoveRangeSwapBack(int index, int count) { }

	public override void set_Capacity(int value) { }

	public override void set_Item(int index, T value) { }

	internal void set_length(ushort value) { }

	public override void set_Length(int value) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[ExcludeFromBurstCompatTesting("Returns managed array")]
	public T[] ToArray() { }

	public NativeArray ToNativeArray(AllocatorHandle allocator) { }

}

