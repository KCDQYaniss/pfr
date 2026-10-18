namespace GPUInstancer;

public abstract class GPUInstancerCell
{
	internal static readonly int[] _primes; //Field offset: 0x0
	public Bounds cellBounds; //Field offset: 0x10
	public Bounds cellInnerBounds; //Field offset: 0x28
	public int coordX; //Field offset: 0x40
	public int coordY; //Field offset: 0x44
	public int coordZ; //Field offset: 0x48
	public bool isActive; //Field offset: 0x4C

	private static GPUInstancerCell() { }

	protected GPUInstancerCell() { }

	public int CalculateHash() { }

	public static int CalculateHash(int coordX, int coordY, int coordZ) { }

}

