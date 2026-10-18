namespace BitPacking;

public struct FloatQuantizer
{
	public readonly float Min; //Field offset: 0x0
	public readonly float Max; //Field offset: 0x4
	public readonly float Resolution; //Field offset: 0x8
	public readonly int BitsRequired; //Field offset: 0xC
	public readonly float Delta; //Field offset: 0x10
	public readonly int MaxIntegerValue; //Field offset: 0x14
	public readonly bool CheckBounds; //Field offset: 0x18

	public FloatQuantizer(float min, float max, float resolution, bool checkBounds = false) { }

	public virtual string ToString() { }

}

