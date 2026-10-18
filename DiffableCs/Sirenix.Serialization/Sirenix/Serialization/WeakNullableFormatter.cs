namespace Sirenix.Serialization;

public sealed class WeakNullableFormatter : WeakBaseFormatter
{
	private readonly Serializer ValueSerializer; //Field offset: 0x40

	public WeakNullableFormatter(Type nullableType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual object GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

