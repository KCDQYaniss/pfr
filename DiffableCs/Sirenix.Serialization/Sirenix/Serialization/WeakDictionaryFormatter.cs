namespace Sirenix.Serialization;

internal sealed class WeakDictionaryFormatter : WeakBaseFormatter
{
	private readonly bool KeyIsValueType; //Field offset: 0x40
	private readonly Serializer EqualityComparerSerializer; //Field offset: 0x48
	private readonly Serializer KeyReaderWriter; //Field offset: 0x50
	private readonly Serializer ValueReaderWriter; //Field offset: 0x58
	private readonly ConstructorInfo ComparerConstructor; //Field offset: 0x60
	private readonly PropertyInfo ComparerProperty; //Field offset: 0x68
	private readonly PropertyInfo CountProperty; //Field offset: 0x70
	private readonly Type KeyType; //Field offset: 0x78
	private readonly Type ValueType; //Field offset: 0x80

	public WeakDictionaryFormatter(Type serializedType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual object GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

