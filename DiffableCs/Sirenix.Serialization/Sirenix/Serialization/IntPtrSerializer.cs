namespace Sirenix.Serialization;

public sealed class IntPtrSerializer : Serializer
{

	public IntPtrSerializer() { }

	public virtual IntPtr ReadValue(IDataReader reader) { }

	public virtual void WriteValue(string name, IntPtr value, IDataWriter writer) { }

}

