namespace Sirenix.Serialization;

public class Vector2Formatter : MinimalBaseFormatter
{
	private static readonly Serializer FloatSerializer; //Field offset: 0x0

	private static Vector2Formatter() { }

	public Vector2Formatter() { }

	protected virtual void Read(ref Vector2 value, IDataReader reader) { }

	protected virtual void Write(ref Vector2 value, IDataWriter writer) { }

}

