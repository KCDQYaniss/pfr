namespace BitPacking;

public struct LimitedFloatSerializationSettings
{
	public readonly float Min; //Field offset: 0x0
	public readonly float Max; //Field offset: 0x4
	public readonly float Resolution; //Field offset: 0x8
	public readonly BitPackingTag Tag; //Field offset: 0xC

	public LimitedFloatSerializationSettings(float min, float max, float resolution, BitPackingTag tag) { }

}

