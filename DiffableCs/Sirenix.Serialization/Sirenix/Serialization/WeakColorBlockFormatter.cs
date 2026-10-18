namespace Sirenix.Serialization;

public class WeakColorBlockFormatter : WeakBaseFormatter
{
	private static readonly Serializer FloatSerializer; //Field offset: 0x0
	private static readonly Serializer ColorSerializer; //Field offset: 0x8
	private readonly PropertyInfo normalColor; //Field offset: 0x40
	private readonly PropertyInfo highlightedColor; //Field offset: 0x48
	private readonly PropertyInfo pressedColor; //Field offset: 0x50
	private readonly PropertyInfo disabledColor; //Field offset: 0x58
	private readonly PropertyInfo colorMultiplier; //Field offset: 0x60
	private readonly PropertyInfo fadeDuration; //Field offset: 0x68

	private static WeakColorBlockFormatter() { }

	public WeakColorBlockFormatter(Type colorBlockType) { }

	protected virtual void DeserializeImplementation(ref object value, IDataReader reader) { }

	protected virtual void SerializeImplementation(ref object value, IDataWriter writer) { }

}

