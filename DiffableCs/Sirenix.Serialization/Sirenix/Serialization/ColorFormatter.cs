namespace Sirenix.Serialization;

public class ColorFormatter : MinimalBaseFormatter
{
	private static readonly Serializer FloatSerializer; //Field offset: 0x0

	private static ColorFormatter() { }

	public ColorFormatter() { }

	protected virtual void Read(ref Color value, IDataReader reader) { }

	protected virtual void Write(ref Color value, IDataWriter writer) { }

}

