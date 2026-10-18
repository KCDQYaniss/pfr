namespace Sirenix.Serialization;

public sealed class WeakKeyValuePairFormatter : WeakBaseFormatter
{
	private readonly Serializer KeySerializer; //Field offset: 0x40
	private readonly Serializer ValueSerializer; //Field offset: 0x48
	private readonly PropertyInfo KeyProperty; //Field offset: 0x50
	private readonly PropertyInfo ValueProperty; //Field offset: 0x58

	public WeakKeyValuePairFormatter(Type serializedType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

