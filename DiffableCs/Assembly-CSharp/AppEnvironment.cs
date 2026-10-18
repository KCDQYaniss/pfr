//Type is in global namespace

public static class AppEnvironment
{
	public const string DEFAULT_BACKEND_URL = "https://prod.escapefromtarkov.com"; //Field offset: 0x0
	public static readonly GitVersion GitVersion; //Field offset: 0x0
	private static string _cachedBackendUrl; //Field offset: 0x8
	[CompilerGenerated]
	private static ApplicationConfig <Config>k__BackingField; //Field offset: 0x10

	public static string BackendCacheDir
	{
		 get { } //Length: 157
	}

	public static string BackendUrl
	{
		 get { } //Length: 1011
	}

	public static ApplicationConfig Config
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		 set { } //Length: 183
	}

	public static string ConfigFilePath
	{
		 get { } //Length: 157
	}

	private static AppEnvironment() { }

	public static string get_BackendCacheDir() { }

	public static string get_BackendUrl() { }

	[CompilerGenerated]
	public static ApplicationConfig get_Config() { }

	public static string get_ConfigFilePath() { }

	private static string GetOrCreateConfigJson() { }

	public static bool LoadApplicationConfig(ApplicationConfig default = null) { }

	public static ApplicationConfig MergeConfigWith(CommandLine commandLine) { }

	[CompilerGenerated]
	public static void set_Config(ApplicationConfig value) { }

	private static void TrySetConfigValue(JObject jObject, string commandKey, string commandValue) { }

}

