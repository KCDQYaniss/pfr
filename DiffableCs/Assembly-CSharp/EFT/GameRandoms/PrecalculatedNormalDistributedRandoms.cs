namespace EFT.GameRandoms;

public class PrecalculatedNormalDistributedRandoms : PrecalculatedRandom
{
	private const float DEFAULT_MEAN = 0; //Field offset: 0x0
	private const float DEFAULT_STD_DEV = 1; //Field offset: 0x0
	private static readonly float[] _PERCENTAGE_RANGE; //Field offset: 0x0
	private readonly int _seed; //Field offset: 0x20

	public int Seed
	{
		 get { } //Length: 4
	}

	private static PrecalculatedNormalDistributedRandoms() { }

	public PrecalculatedNormalDistributedRandoms(int randomsCount, int seed, int nextValueID = 0) { }

	public PrecalculatedNormalDistributedRandoms(RandomsSetupInfo setupInfo) { }

	public int get_Seed() { }

	public float GetNormalDistributedValue(int randomIndex, float mean, float stdDev) { }

}

