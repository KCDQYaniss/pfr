namespace Sirenix.Serialization;

public sealed class GenericCollectionFormatter`2 : BaseFormatter
{
	private static Serializer valueReaderWriter; //Field offset: 0x0

	private static GenericCollectionFormatter`2() { }

	public GenericCollectionFormatter`2() { }

	protected virtual void DeserializeImplementation(ref TCollection value, IDataReader reader) { }

	protected virtual TCollection GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref TCollection value, IDataWriter writer) { }

}

