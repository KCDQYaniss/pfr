namespace Sirenix.Serialization;

public class WeakHashSetFormatter : WeakBaseFormatter
{
	private readonly Serializer ElementSerializer; //Field offset: 0x40
	private readonly MethodInfo AddMethod; //Field offset: 0x48
	private readonly PropertyInfo CountProperty; //Field offset: 0x50

	public WeakHashSetFormatter(Type serializedType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual object GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

