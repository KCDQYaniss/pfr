namespace Sirenix.Serialization;

public sealed class UInt64Serializer : Serializer
{

	public UInt64Serializer() { }

	public virtual ulong ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, ulong value, IDataWriter writer) { }

}

