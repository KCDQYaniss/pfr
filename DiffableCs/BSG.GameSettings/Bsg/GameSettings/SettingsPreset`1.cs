namespace Bsg.GameSettings;

public sealed class SettingsPreset`1
{
	private readonly ISettingsProvider _provider; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x0

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public SettingsPreset`1(string name, ISettingsProvider provider) { }

	[CompilerGenerated]
	public string get_Name() { }

	public Task Load(T settingsGroup) { }

	public Task Save(T settingsGroup) { }

}

