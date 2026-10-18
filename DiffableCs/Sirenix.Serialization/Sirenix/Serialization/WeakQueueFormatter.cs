namespace Sirenix.Serialization;

public class WeakQueueFormatter : WeakBaseFormatter
{
	private readonly Serializer ElementSerializer; //Field offset: 0x40
	private readonly bool IsPlainQueue; //Field offset: 0x48
	private MethodInfo EnqueueMethod; //Field offset: 0x50

	public WeakQueueFormatter(Type serializedType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual object GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

