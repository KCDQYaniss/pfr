namespace Sirenix.Serialization;

public sealed class WeakArrayFormatter : WeakBaseFormatter
{
	private readonly Serializer ValueReaderWriter; //Field offset: 0x40
	private readonly Type ElementType; //Field offset: 0x48

	public WeakArrayFormatter(Type arrayType, Type elementType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual object GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

