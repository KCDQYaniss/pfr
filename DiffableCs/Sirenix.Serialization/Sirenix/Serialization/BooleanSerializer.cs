namespace Sirenix.Serialization;

public sealed class BooleanSerializer : Serializer
{

	public BooleanSerializer() { }

	public virtual bool ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, bool value, IDataWriter writer) { }

}

