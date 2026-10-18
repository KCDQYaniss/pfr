namespace Sirenix.Serialization;

public sealed class UIntPtrSerializer : Serializer
{

	public UIntPtrSerializer() { }

	public virtual UIntPtr ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, UIntPtr value, IDataWriter writer) { }

}

