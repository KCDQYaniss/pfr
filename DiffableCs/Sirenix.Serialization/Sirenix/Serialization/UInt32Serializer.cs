namespace Sirenix.Serialization;

public sealed class UInt32Serializer : Serializer
{

	public UInt32Serializer() { }

	public virtual uint ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, uint value, IDataWriter writer) { }

}

