namespace Sirenix.Serialization;

public sealed class Int16Serializer : Serializer
{

	public Int16Serializer() { }

	public virtual short ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, short value, IDataWriter writer) { }

}

