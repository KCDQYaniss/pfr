namespace EFT.InventoryLogic;

public struct IntRect
{
	public int X; //Field offset: 0x0
	public int Y; //Field offset: 0x4
	public int Width; //Field offset: 0x8
	public int Height; //Field offset: 0xC

	public IntRect(int x, int y, int width, int height) { }

	public bool Equals(IntRect other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

