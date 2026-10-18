namespace Sirenix.Serialization;

public sealed class WeakSelfFormatterFormatter : WeakBaseFormatter
{

	public WeakSelfFormatterFormatter(Type serializedType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

