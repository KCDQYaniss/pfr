namespace EFT.UI.Screens;

public interface IScreenManager
{

	public Enum CurrentScreenType
	{
		 get { } //Length: 0
	}

	public Task CloseAllScreens(bool forced) { }

	public void CloseAllScreensForced() { }

	public Enum get_CurrentScreenType() { }

}

