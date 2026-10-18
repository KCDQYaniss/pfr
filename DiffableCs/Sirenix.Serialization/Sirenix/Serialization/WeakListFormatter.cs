namespace Sirenix.Serialization;

public class WeakListFormatter : WeakBaseFormatter
{
	private readonly Serializer ElementSerializer; //Field offset: 0x40

	public WeakListFormatter(Type serializedType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual object GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

