namespace Sirenix.Serialization;

public class ArrayListFormatter : BaseFormatter
{
	private static readonly Serializer ObjectSerializer; //Field offset: 0x0

	private static ArrayListFormatter() { }

	public ArrayListFormatter() { }

	protected virtual void DeserializeImplementation(ref ArrayList value, IDataReader reader) { }

	protected virtual ArrayList GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref ArrayList value, IDataWriter writer) { }

}

