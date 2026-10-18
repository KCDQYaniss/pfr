namespace Sirenix.Serialization;

public sealed class WeakMultiDimensionalArrayFormatter : WeakBaseFormatter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public IDataReader reader; //Field offset: 0x10
		public string name; //Field offset: 0x18
		public WeakMultiDimensionalArrayFormatter <>4__this; //Field offset: 0x20
		public int elements; //Field offset: 0x28
		public long length; //Field offset: 0x30

		public <>c__DisplayClass7_0() { }

		internal object <DeserializeImplementation>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public WeakMultiDimensionalArrayFormatter <>4__this; //Field offset: 0x10
		public IDataWriter writer; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <SerializeImplementation>b__0(object v) { }

	}

	private const string RANKS_NAME = "ranks"; //Field offset: 0x0
	private const char RANKS_SEPARATOR = '\u7C'; //Field offset: 0x0
	private readonly int ArrayRank; //Field offset: 0x40
	private readonly Type ElementType; //Field offset: 0x48
	private readonly Serializer ValueReaderWriter; //Field offset: 0x50

	public WeakMultiDimensionalArrayFormatter(Type arrayType, Type elementType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual object GetUninitializedObject() { }

	private void IterateArrayRead(Array a, Action read) { }

	private void IterateArrayRead(Array a, int rank, int[] indices, Action read) { }

	private void IterateArrayWrite(Array a, Func write) { }

	private void IterateArrayWrite(Array a, int rank, int[] indices, Func write) { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

