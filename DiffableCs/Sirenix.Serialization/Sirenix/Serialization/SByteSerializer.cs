namespace Sirenix.Serialization;

public sealed class SByteSerializer : Serializer
{

	public SByteSerializer() { }

	public virtual sbyte ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, sbyte value, IDataWriter writer) { }

}

