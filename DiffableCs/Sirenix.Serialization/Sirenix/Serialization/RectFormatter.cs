namespace Sirenix.Serialization;

public class RectFormatter : MinimalBaseFormatter
{
	private static readonly Serializer FloatSerializer; //Field offset: 0x0

	private static RectFormatter() { }

	public RectFormatter() { }

	protected virtual void Read(ref Rect value, IDataReader reader) { }

	protected virtual void Write(ref Rect value, IDataWriter writer) { }

}

