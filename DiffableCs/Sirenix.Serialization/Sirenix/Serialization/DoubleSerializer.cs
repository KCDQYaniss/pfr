namespace Sirenix.Serialization;

public sealed class DoubleSerializer : Serializer
{

	public DoubleSerializer() { }

	public virtual double ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, double value, IDataWriter writer) { }

}

