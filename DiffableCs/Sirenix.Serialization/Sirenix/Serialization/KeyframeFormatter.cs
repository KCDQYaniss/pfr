namespace Sirenix.Serialization;

public class KeyframeFormatter : MinimalBaseFormatter
{
	private static readonly Serializer FloatSerializer; //Field offset: 0x0
	private static readonly Serializer IntSerializer; //Field offset: 0x8
	private static readonly bool Is_In_2018_1_Or_Above; //Field offset: 0x10
	private static IFormatter Formatter; //Field offset: 0x18

	private static KeyframeFormatter() { }

	public KeyframeFormatter() { }

	protected virtual void Read(ref Keyframe value, IDataReader reader) { }

	protected virtual void Write(ref Keyframe value, IDataWriter writer) { }

}

