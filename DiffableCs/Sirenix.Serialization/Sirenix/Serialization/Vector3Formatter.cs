namespace Sirenix.Serialization;

public class Vector3Formatter : MinimalBaseFormatter
{
	private static readonly Serializer FloatSerializer; //Field offset: 0x0

	private static Vector3Formatter() { }

	public Vector3Formatter() { }

	protected virtual void Read(ref Vector3 value, IDataReader reader) { }

	protected virtual void Write(ref Vector3 value, IDataWriter writer) { }

}

