namespace EFT.PseudoRandom;

public class RandomXORShift
{
	private int _x; //Field offset: 0x10
	private int _y; //Field offset: 0x14
	private int _z; //Field offset: 0x18
	private int _localSeed; //Field offset: 0x1C

	public RandomXORShift(Seed seed) { }

	public Seed GetNewSeed() { }

	public int Random(int min, int max) { }

	private int XORShift() { }

}

