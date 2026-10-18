namespace BitPacking;

public struct LimitedIntSerializationSettings
{
	public readonly int Min; //Field offset: 0x0
	public readonly int Max; //Field offset: 0x4
	public readonly BitPackingTag Tag; //Field offset: 0x8

	public LimitedIntSerializationSettings(int min, int max, BitPackingTag tag) { }

}

