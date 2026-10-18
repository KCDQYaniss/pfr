namespace EFT;

public struct ConditionalProgressData
{
	public string RealConditionalId; //Field offset: 0x0
	public int ConditionalIdHash; //Field offset: 0x8
	public OneAndList Conditions; //Field offset: 0x10

	public virtual string ToString() { }

}

