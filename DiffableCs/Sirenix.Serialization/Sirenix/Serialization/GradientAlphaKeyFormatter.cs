namespace Sirenix.Serialization;

public class GradientAlphaKeyFormatter : MinimalBaseFormatter
{
	private static readonly Serializer FloatSerializer; //Field offset: 0x0

	private static GradientAlphaKeyFormatter() { }

	public GradientAlphaKeyFormatter() { }

	protected virtual void Read(ref GradientAlphaKey value, IDataReader reader) { }

	protected virtual void Write(ref GradientAlphaKey value, IDataWriter writer) { }

}

