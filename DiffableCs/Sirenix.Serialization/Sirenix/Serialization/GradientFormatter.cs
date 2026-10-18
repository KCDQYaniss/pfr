namespace Sirenix.Serialization;

public class GradientFormatter : MinimalBaseFormatter
{
	private static readonly Serializer AlphaKeysSerializer; //Field offset: 0x0
	private static readonly Serializer ColorKeysSerializer; //Field offset: 0x8
	private static readonly PropertyInfo ModeProperty; //Field offset: 0x10
	private static readonly Serializer EnumSerializer; //Field offset: 0x18

	private static GradientFormatter() { }

	public GradientFormatter() { }

	protected virtual Gradient GetUninitializedObject() { }

	protected virtual void Read(ref Gradient value, IDataReader reader) { }

	protected virtual void Write(ref Gradient value, IDataWriter writer) { }

}

