namespace EFT.Utilities;

public interface IRaidCounter
{

	public int CurrentRaidNum
	{
		 get { } //Length: 0
	}

	public int CurrentTotalRaidNum
	{
		 get { } //Length: 0
	}

	public int get_CurrentRaidNum() { }

	public int get_CurrentTotalRaidNum() { }

}

