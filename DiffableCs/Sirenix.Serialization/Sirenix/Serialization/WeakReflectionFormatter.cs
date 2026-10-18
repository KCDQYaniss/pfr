namespace Sirenix.Serialization;

public class WeakReflectionFormatter : WeakBaseFormatter
{

	public WeakReflectionFormatter(Type serializedType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

