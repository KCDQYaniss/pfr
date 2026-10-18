namespace EFT;

public interface ILocalizationLoader
{

	public Task LoadLocale(string locale = null) { }

	public Task LoadMainMenuLocale(string locale = null) { }

}

