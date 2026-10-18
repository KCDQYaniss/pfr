namespace EFT.GameRandoms;

public class PrecalculatedFloatRandoms : PrecalculatedRandom
{
	private readonly int _seed; //Field offset: 0x20

	public int Seed
	{
		 get { } //Length: 4
	}

	public PrecalculatedFloatRandoms(int randomsCount, int seed, int nextValueID = 0) { }

	public PrecalculatedFloatRandoms(RandomsSetupInfo setupInfo) { }

	public int get_Seed() { }

}

