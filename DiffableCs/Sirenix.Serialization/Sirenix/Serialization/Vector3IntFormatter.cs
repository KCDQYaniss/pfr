namespace Sirenix.Serialization;

public class Vector3IntFormatter : MinimalBaseFormatter
{
	private static readonly Serializer Serializer; //Field offset: 0x0

	private static Vector3IntFormatter() { }

	public Vector3IntFormatter() { }

	protected virtual void Read(ref Vector3Int value, IDataReader reader) { }

	protected virtual void Write(ref Vector3Int value, IDataWriter writer) { }

}

