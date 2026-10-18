namespace Sirenix.Serialization;

public class WeakStackFormatter : WeakBaseFormatter
{
	private readonly Serializer ElementSerializer; //Field offset: 0x40
	private readonly bool IsPlainStack; //Field offset: 0x48
	private readonly MethodInfo PushMethod; //Field offset: 0x50

	public WeakStackFormatter(Type serializedType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual object GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

