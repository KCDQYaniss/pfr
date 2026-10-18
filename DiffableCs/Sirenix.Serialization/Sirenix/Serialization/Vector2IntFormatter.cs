namespace Sirenix.Serialization;

public class Vector2IntFormatter : MinimalBaseFormatter
{
	private static readonly Serializer Serializer; //Field offset: 0x0

	private static Vector2IntFormatter() { }

	public Vector2IntFormatter() { }

	protected virtual void Read(ref Vector2Int value, IDataReader reader) { }

	protected virtual void Write(ref Vector2Int value, IDataWriter writer) { }

}

