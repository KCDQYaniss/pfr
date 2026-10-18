namespace EFT.InventoryLogic;

public struct ExtraSize
{
	public int Left; //Field offset: 0x0
	public int Right; //Field offset: 0x4
	public int Up; //Field offset: 0x8
	public int Down; //Field offset: 0xC
	public int ForcedLeft; //Field offset: 0x10
	public int ForcedRight; //Field offset: 0x14
	public int ForcedUp; //Field offset: 0x18
	public int ForcedDown; //Field offset: 0x1C

	public IntVec2 Apply(int width, int height) { }

	public static ExtraSize Merge(ExtraSize op1, ExtraSize op2) { }

	public virtual string ToString() { }

}

