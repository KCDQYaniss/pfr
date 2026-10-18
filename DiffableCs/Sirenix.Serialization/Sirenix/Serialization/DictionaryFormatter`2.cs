namespace Sirenix.Serialization;

public sealed class DictionaryFormatter`2 : BaseFormatter
{
	private static readonly bool KeyIsValueType; //Field offset: 0x0
	private static readonly Serializer EqualityComparerSerializer; //Field offset: 0x0
	private static readonly Serializer KeyReaderWriter; //Field offset: 0x0
	private static readonly Serializer ValueReaderWriter; //Field offset: 0x0

	private static DictionaryFormatter`2() { }

	public DictionaryFormatter`2() { }

	protected virtual void DeserializeImplementation(ref Dictionary value, IDataReader reader) { }

	protected virtual Dictionary GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref Dictionary value, IDataWriter writer) { }

}

