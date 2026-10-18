namespace Sirenix.Serialization;

internal sealed class DoubleLookupDictionaryFormatter`3 : BaseFormatter
{
	private static readonly Serializer PrimaryReaderWriter; //Field offset: 0x0
	private static readonly Serializer InnerReaderWriter; //Field offset: 0x0

	private static DoubleLookupDictionaryFormatter`3() { }

	public DoubleLookupDictionaryFormatter`3() { }

	protected virtual void DeserializeImplementation(ref DoubleLookupDictionary value, IDataReader reader) { }

	protected virtual DoubleLookupDictionary GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref DoubleLookupDictionary value, IDataWriter writer) { }

}

