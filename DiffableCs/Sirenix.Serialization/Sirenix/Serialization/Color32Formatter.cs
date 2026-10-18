namespace Sirenix.Serialization;

public class Color32Formatter : MinimalBaseFormatter
{
	private static readonly Serializer ByteSerializer; //Field offset: 0x0

	private static Color32Formatter() { }

	public Color32Formatter() { }

	protected virtual void Read(ref Color32 value, IDataReader reader) { }

	protected virtual void Write(ref Color32 value, IDataWriter writer) { }

}

