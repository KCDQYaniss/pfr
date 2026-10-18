namespace Sirenix.Serialization;

public class ListFormatter`1 : BaseFormatter
{
	private static readonly Serializer TSerializer; //Field offset: 0x0

	private static ListFormatter`1() { }

	public ListFormatter`1() { }

	protected virtual void DeserializeImplementation(ref List value, IDataReader reader) { }

	protected virtual List GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref List value, IDataWriter writer) { }

}

