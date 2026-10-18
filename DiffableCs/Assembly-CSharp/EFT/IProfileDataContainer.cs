namespace EFT;

public interface IProfileDataContainer
{

	public string Nickname
	{
		 get { } //Length: 0
	}

	public int PrestigeLevel
	{
		 get { } //Length: 0
	}

	public string ProfileId
	{
		 get { } //Length: 0
	}

	public EPlayerSide Side
	{
		 get { } //Length: 0
	}

	public string get_Nickname() { }

	public int get_PrestigeLevel() { }

	public string get_ProfileId() { }

	public EPlayerSide get_Side() { }

}

