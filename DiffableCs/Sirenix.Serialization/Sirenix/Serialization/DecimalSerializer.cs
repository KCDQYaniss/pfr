namespace Sirenix.Serialization;

public sealed class DecimalSerializer : Serializer
{

	public DecimalSerializer() { }

	public virtual decimal ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, decimal value, IDataWriter writer) { }

}

