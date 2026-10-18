namespace Unity.Collections;

[DebuggerDisplay("Length = {m_Length}")]
[DebuggerTypeProxy(typeof(NativeArrayDebugView`1))]
[DefaultMember("Item")]
[NativeContainer]
[NativeContainerSupportsDeallocateOnJobCompletion]
[NativeContainerSupportsDeferredConvertListToArray]
[NativeContainerSupportsMinMaxWriteRestriction]
public struct NativeArray`1 : IDisposable, IEnumerable, IEnumerable, IEquatable
{
	[ExcludeFromDocs]
	internal struct Enumerator : IEnumerator, IEnumerator, IDisposable
	{
		private NativeArray m_Array; //Field offset: 0x0
		private int m_Index; //Field offset: 0x0
		private T value; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 29
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 116
		}

		public Enumerator(ref NativeArray array) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DebuggerDisplay("Length = {Length}")]
	[DebuggerTypeProxy(typeof(NativeArrayReadOnlyDebugView`1))]
	[DefaultMember("Item")]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct ReadOnly : IEnumerable, IEnumerable
	{
		[ExcludeFromDocs]
		internal struct Enumerator : IEnumerator, IEnumerator, IDisposable
		{
			private ReadOnly m_Array; //Field offset: 0x0
			private int m_Index; //Field offset: 0x0
			private T value; //Field offset: 0x0

			public override T Current
			{
				 get { } //Length: 29
			}

			private override object System.Collections.IEnumerator.Current
			{
				private get { } //Length: 116
			}

			public Enumerator(in ReadOnly array) { }

			public override void Dispose() { }

			public override T get_Current() { }

			public override bool MoveNext() { }

			public override void Reset() { }

			private override object System.Collections.IEnumerator.get_Current() { }

		}

		[NativeDisableUnsafePtrRestriction]
		internal void* m_Buffer; //Field offset: 0x0
		internal int m_Length; //Field offset: 0x0

		public T Item
		{
			 get { } //Length: 108
		}

		public int Length
		{
			 get { } //Length: 6
		}

		internal ReadOnly(void* buffer, int length) { }

		public T get_Item(int index) { }

		public int get_Length() { }

		public Enumerator GetEnumerator() { }

		private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal void* m_Buffer; //Field offset: 0x0
	internal int m_Length; //Field offset: 0x0
	internal Allocator m_AllocatorLabel; //Field offset: 0x0

	public bool IsCreated
	{
		 get { } //Length: 8
	}

	public T Item
	{
		 get { } //Length: 108
		[WriteAccessRequired]
		 set { } //Length: 89
	}

	public int Length
	{
		 get { } //Length: 6
	}

	public NativeArray`1(int length, Allocator allocator, NativeArrayOptions options = 1) { }

	public NativeArray`1(T[] array, Allocator allocator) { }

	public NativeArray`1(NativeArray array, Allocator allocator) { }

	private static void Allocate(int length, Allocator allocator, out NativeArray array) { }

	public ReadOnly AsReadOnly() { }

	public static void Copy(T[] src, NativeArray dst) { }

	public static void Copy(NativeArray src, T[] dst) { }

	public static void Copy(NativeArray src, NativeArray dst, int length) { }

	public static void Copy(NativeArray src, T[] dst, int length) { }

	public static void Copy(NativeArray src, int srcIndex, NativeArray dst, int dstIndex, int length) { }

	public static void Copy(NativeArray src, NativeArray dst) { }

	[WriteAccessRequired]
	public void CopyFrom(T[] array) { }

	[WriteAccessRequired]
	public void CopyFrom(NativeArray array) { }

	private static void CopySafe(NativeArray src, int srcIndex, NativeArray dst, int dstIndex, int length) { }

	private static void CopySafe(T[] src, int srcIndex, NativeArray dst, int dstIndex, int length) { }

	private static void CopySafe(NativeArray src, int srcIndex, T[] dst, int dstIndex, int length) { }

	public void CopyTo(T[] array) { }

	public JobHandle Dispose(JobHandle inputDeps) { }

	[WriteAccessRequired]
	public override void Dispose() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(NativeArray other) { }

	public bool get_IsCreated() { }

	public T get_Item(int index) { }

	public int get_Length() { }

	public Enumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	public NativeArray GetSubArray(int start, int length) { }

	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public T[] ToArray() { }

}

