namespace Sirenix.Serialization;

public sealed class NullableFormatter`1 : BaseFormatter
{
	private static readonly Serializer TSerializer; //Field offset: 0x0

	private static NullableFormatter`1() { }

	public NullableFormatter`1() { }

	protected virtual void DeserializeImplementation(ref Nullable value, IDataReader reader) { }

	protected virtual void SerializeImplementation(ref Nullable value, IDataWriter writer) { }

}

