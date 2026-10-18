namespace EFT;

public interface IPlayerProfileDataContainer : IProfileDataContainer
{

	public EndingInfo Ending
	{
		 get { } //Length: 0
	}

	public EGameMode PrestigeGameMode
	{
		 get { } //Length: 0
	}

	public EndingInfo get_Ending() { }

	public EGameMode get_PrestigeGameMode() { }

}

