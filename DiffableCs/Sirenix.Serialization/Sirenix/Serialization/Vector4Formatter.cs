namespace Sirenix.Serialization;

public class Vector4Formatter : MinimalBaseFormatter
{
	private static readonly Serializer FloatSerializer; //Field offset: 0x0

	private static Vector4Formatter() { }

	public Vector4Formatter() { }

	protected virtual void Read(ref Vector4 value, IDataReader reader) { }

	protected virtual void Write(ref Vector4 value, IDataWriter writer) { }

}

