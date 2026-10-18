namespace EFT.Rendering.Clouds;

public struct WindOrientation
{
	internal enum WindOverrideMode
	{
		Custom = 0,
		Global = 1,
		Additive = 2,
		Multiply = 3,
	}

	public WindOverrideMode mode; //Field offset: 0x0
	public float customValue; //Field offset: 0x4
	public float additiveValue; //Field offset: 0x8
	public float multiplyValue; //Field offset: 0xC

	public virtual string ToString() { }

}

