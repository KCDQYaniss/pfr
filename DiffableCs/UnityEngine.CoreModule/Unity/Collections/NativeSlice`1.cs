namespace Unity.Collections;

[DebuggerDisplay("Length = {Length}")]
[DebuggerTypeProxy(typeof(NativeSliceDebugView`1))]
[DefaultMember("Item")]
[NativeContainer]
[NativeContainerSupportsMinMaxWriteRestriction]
public struct NativeSlice`1 : IEnumerable, IEnumerable, IEquatable
{
	[ExcludeFromDocs]
	internal struct Enumerator : IEnumerator, IEnumerator, IDisposable
	{
		private NativeSlice m_Array; //Field offset: 0x0
		private int m_Index; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 191
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 235
		}

		public Enumerator(ref NativeSlice array) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal byte* m_Buffer; //Field offset: 0x0
	internal int m_Stride; //Field offset: 0x0
	internal int m_Length; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 234
		[WriteAccessRequired]
		 set { } //Length: 181
	}

	public int Length
	{
		 get { } //Length: 6
	}

	public int Stride
	{
		 get { } //Length: 4
	}

	public NativeSlice`1(NativeSlice slice, int start, int length) { }

	public NativeSlice`1(NativeArray array) { }

	public NativeSlice`1(NativeArray array, int start, int length) { }

	[WriteAccessRequired]
	public void CopyFrom(NativeSlice slice) { }

	[WriteAccessRequired]
	public void CopyFrom(T[] array) { }

	public override bool Equals(NativeSlice other) { }

	public virtual bool Equals(object obj) { }

	public T get_Item(int index) { }

	public int get_Length() { }

	public int get_Stride() { }

	public Enumerator GetEnumerator() { }

	public virtual int GetHashCode() { }

	public static NativeSlice op_Implicit(NativeArray array) { }

	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

	private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

