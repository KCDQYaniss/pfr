namespace Sirenix.Serialization;

public sealed class WeakGenericCollectionFormatter : WeakBaseFormatter
{
	private readonly Serializer ValueReaderWriter; //Field offset: 0x40
	private readonly Type ElementType; //Field offset: 0x48
	private readonly PropertyInfo CountProperty; //Field offset: 0x50
	private readonly MethodInfo AddMethod; //Field offset: 0x58

	public WeakGenericCollectionFormatter(Type collectionType, Type elementType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual object GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

