namespace Bsg.GameSettings;

public interface IPresetManager`1
{

	public IReadOnlyList Presets
	{
		 get { } //Length: 0
	}

	public Task CreateNewPreset(string name, T settingsGroup) { }

	public IReadOnlyList get_Presets() { }

	public Task RefreshPresetList() { }

	public Task RemovePreset(SettingsPreset preset) { }

}

