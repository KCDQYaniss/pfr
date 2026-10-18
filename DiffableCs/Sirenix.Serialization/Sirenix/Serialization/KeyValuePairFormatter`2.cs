namespace Sirenix.Serialization;

public sealed class KeyValuePairFormatter`2 : BaseFormatter
{
	private static readonly Serializer KeySerializer; //Field offset: 0x0
	private static readonly Serializer ValueSerializer; //Field offset: 0x0

	private static KeyValuePairFormatter`2() { }

	public KeyValuePairFormatter`2() { }

	protected virtual void DeserializeImplementation(ref KeyValuePair value, IDataReader reader) { }

	protected virtual void SerializeImplementation(ref KeyValuePair value, IDataWriter writer) { }

}

