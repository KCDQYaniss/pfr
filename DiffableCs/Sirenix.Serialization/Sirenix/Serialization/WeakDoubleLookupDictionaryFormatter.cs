namespace Sirenix.Serialization;

internal sealed class WeakDoubleLookupDictionaryFormatter : WeakBaseFormatter
{
	private readonly Serializer PrimaryReaderWriter; //Field offset: 0x40
	private readonly Serializer InnerReaderWriter; //Field offset: 0x48

	public WeakDoubleLookupDictionaryFormatter(Type serializedType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual object GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

