namespace EFT.UI;

public interface IWelcomeScreenController
{

	public event Action OnShowNextScreen
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public ILocalizationLoader LocalizationLoader
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnShowNextScreen(Action value) { }

	public ILocalizationLoader get_LocalizationLoader() { }

	[CompilerGenerated]
	public void remove_OnShowNextScreen(Action value) { }

	public void ShowNextScreen() { }

	public void ShowScreen(EScreenState state) { }

}

