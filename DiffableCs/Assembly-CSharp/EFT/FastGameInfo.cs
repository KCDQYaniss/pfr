namespace EFT;

public class FastGameInfo
{
	private const string SCENES_JSON_CONFIG_PATH = "Assets/Editor/ScenesJsonConfig.asset"; //Field offset: 0x0
	private TarkovApplication _tarkovApplication; //Field offset: 0x10
	private string[] _mapsCollection; //Field offset: 0x18
	public bool IsAutoLoginEnabled; //Field offset: 0x20
	public bool UseLoginFromInspector; //Field offset: 0x21
	public string LoginForAutoLogin; //Field offset: 0x28
	[Password]
	public string PasswordForAutoLogin; //Field offset: 0x30
	[Header("Fast start enable settings")]
	public bool IsFastStartEnabled; //Field offset: 0x38
	public string FastGameMap; //Field offset: 0x40
	public bool IsLocalGame; //Field offset: 0x48
	public bool IsNoLootForLocalGame; //Field offset: 0x49
	public bool IsAIEnabledInLocalGame; //Field offset: 0x4A
	public bool IsLocationGameSessionLimit; //Field offset: 0x4B
	public bool IsCustomGameSessionLimit; //Field offset: 0x4C
	public int CustomGameSessionTimeLimit; //Field offset: 0x50

	public string[] MapsCollection
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public FastGameInfo() { }

	public string[] get_MapsCollection() { }

	private static IEnumerable GetAutoLoginGameModes() { }

	private void OnCustomTimeStateChanged() { }

	private void OnLocationTimeStateChanged() { }

	public void set_MapsCollection(string[] value) { }

}

