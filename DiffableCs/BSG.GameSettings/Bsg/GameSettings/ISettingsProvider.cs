namespace Bsg.GameSettings;

public interface ISettingsProvider
{

	public Task Load(T settingsGroup) { }

	public Task Save(T settingsGroup) { }

}

