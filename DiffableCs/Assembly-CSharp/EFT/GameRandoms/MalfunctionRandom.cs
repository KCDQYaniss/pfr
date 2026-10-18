namespace EFT.GameRandoms;

public class MalfunctionRandom
{
	private int _seed; //Field offset: 0x10
	private int _nextSeed; //Field offset: 0x14

	public MalfunctionRandom(int seed) { }

	public void Deserialize(NetworkReader reader) { }

	public float GetNextRandom() { }

	public float GetRandomFloat() { }

	public void Serialize(NetworkWriter writer) { }

}

