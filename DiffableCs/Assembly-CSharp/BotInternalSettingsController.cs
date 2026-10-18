//Type is in global namespace

public static class BotInternalSettingsController
{
	private const string corePath = "Settings/{0}_{1}_BotGlobalSettings"; //Field offset: 0x0
	private const string corePathPve = "Settings/PvE/{0}_{1}_PvE_BotGlobalSettings"; //Field offset: 0x0
	private static readonly string PATH_TO_SAVE; //Field offset: 0x0
	private static readonly string EXTERNAL_PATH; //Field offset: 0x8
	private static readonly string EXTERNAL_PATH_PVE; //Field offset: 0x10
	private static readonly string PATH_INTERNAL; //Field offset: 0x18
	private static readonly string PATH_INTERNAL_PVE; //Field offset: 0x20
	private static TwoDimensionalDictionary AllSettingsPvp; //Field offset: 0x28
	private static TwoDimensionalDictionary AllSettingsPve; //Field offset: 0x30
	public static BotGlobalsCoreSettings Core; //Field offset: 0x38
	private static Dictionary MappingSettings; //Field offset: 0x40
	private static Dictionary ExcludedDifficulties; //Field offset: 0x48
	private static bool _isLoaded; //Field offset: 0x50
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"role", "difficulty"})]
	private static readonly HashSet _loggedExcludedWaveDifficulties; //Field offset: 0x58

	private static WildSpawnType[] UsableSettings
	{
		private get { } //Length: 450
	}

	private static BotInternalSettingsController() { }

	private static TwoDimensionalDictionary AllSettings(bool isPve) { }

	public static BotDifficulty CheckOnExclude(BotDifficulty d, WildSpawnType wst) { }

	private static WildSpawnType[] get_UsableSettings() { }

	private static string GetExternalPath(bool isPve, string baseDirectory = null) { }

	private static string GetInternalPath(bool isPve) { }

	public static BotSettingsComponents GetSettings(BotDifficulty difficulty, WildSpawnType role, bool isPve) { }

	public static void Load() { }

	private static BotSettingsComponents LoadByDifficulty(BotDifficulty d, WildSpawnType role, bool external, bool isPve, string baseDirectory) { }

	public static BotSettingsComponents LoadByDifficulty(BotDifficulty d, WildSpawnType role, bool external, bool isPve) { }

	public static string LoadCoreByString() { }

	[CanBeNull]
	public static string LoadDifficultyStringInternal(BotDifficulty botDifficulty, WildSpawnType role, bool isPve) { }

	public static bool LoadExternal() { }

	private static bool LoadExternal(string baseDirectory) { }

	public static bool LoadInternal(out BotGlobalsCoreSettings core) { }

	public static string LoadInternalCoreByString() { }

	public static void LogExcludedWaveDifficulty(WildSpawnType role, BotDifficulty difficulty) { }

	private static WildSpawnType Remap(WildSpawnType role) { }

	public static void Save(bool codeSettings, bool isPve) { }

	public static void Save(BotDifficulty difficulty, WildSpawnType botRole, BotSettingsComponents internalSettings, Func jsonPostprocessor = null) { }

	public static void Save(TwoDimensionalDictionary internalSettings) { }

	private static void Save2File(string path, string data) { }

	private static void SaveByDifficulty(BotDifficulty botDifficulty, WildSpawnType role, BotSettingsComponents settings, Func jsonPostprocessor = null) { }

	private static void SaveByDifficulty(BotDifficulty botDifficulty, WildSpawnType role, bool dropSettings, bool isPve) { }

	public static void SaveDifficultyStringInternal(BotDifficulty botDifficulty, WildSpawnType role, bool isPve, string data) { }

}

