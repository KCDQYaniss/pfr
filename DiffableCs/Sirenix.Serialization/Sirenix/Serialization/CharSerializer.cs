namespace Sirenix.Serialization;

public sealed class CharSerializer : Serializer
{

	public CharSerializer() { }

	public virtual char ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, char value, IDataWriter writer) { }

}

