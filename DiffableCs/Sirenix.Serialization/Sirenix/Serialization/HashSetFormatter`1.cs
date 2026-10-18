namespace Sirenix.Serialization;

public class HashSetFormatter`1 : BaseFormatter
{
	private static readonly Serializer TSerializer; //Field offset: 0x0

	private static HashSetFormatter`1() { }

	public HashSetFormatter`1() { }

	protected virtual void DeserializeImplementation(ref HashSet value, IDataReader reader) { }

	protected virtual HashSet GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref HashSet value, IDataWriter writer) { }

}

