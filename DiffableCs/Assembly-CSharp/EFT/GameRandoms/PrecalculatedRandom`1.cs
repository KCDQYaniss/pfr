namespace EFT.GameRandoms;

public class PrecalculatedRandom`1
{
	private int _nextValueId; //Field offset: 0x0
	protected readonly int _valuesCount; //Field offset: 0x0
	protected readonly T[] _randomValues; //Field offset: 0x0

	public int NextValueId
	{
		 get { } //Length: 164
	}

	public int ValuesCount
	{
		 get { } //Length: 4
	}

	public PrecalculatedRandom`1(int randomsCount, int nextValueID = 0) { }

	public int get_NextValueId() { }

	public int get_ValuesCount() { }

	public T GetRandom(int randomIndex) { }

	public T Next() { }

}

