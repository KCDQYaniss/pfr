namespace Sirenix.Serialization;

public sealed class UInt16Serializer : Serializer
{

	public UInt16Serializer() { }

	public virtual ushort ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, ushort value, IDataWriter writer) { }

}

