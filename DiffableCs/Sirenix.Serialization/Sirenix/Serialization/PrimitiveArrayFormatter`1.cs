namespace Sirenix.Serialization;

public sealed class PrimitiveArrayFormatter`1 : MinimalBaseFormatter
{

	public PrimitiveArrayFormatter`1() { }

	protected virtual T[] GetUninitializedObject() { }

	protected virtual void Read(ref T[] value, IDataReader reader) { }

	protected virtual void Write(ref T[] value, IDataWriter writer) { }

}

