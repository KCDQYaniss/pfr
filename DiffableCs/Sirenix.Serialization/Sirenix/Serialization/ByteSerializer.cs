namespace Sirenix.Serialization;

public sealed class ByteSerializer : Serializer
{

	public ByteSerializer() { }

	public virtual byte ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, byte value, IDataWriter writer) { }

}

