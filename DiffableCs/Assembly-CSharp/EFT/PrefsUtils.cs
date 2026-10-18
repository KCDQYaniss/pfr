namespace EFT;

public static class PrefsUtils
{
	private static bool _resetRequired; //Field offset: 0x0
	private static string _profileId; //Field offset: 0x8
	private static readonly List _resettableKeys; //Field offset: 0x10
	private static readonly HashSet _legacyGlobalKeysToPreserveOnReset; //Field offset: 0x18

	private static PrefsUtils() { }

	public static bool GetBool(string variable, bool defaultValue = false) { }

	public static bool GetBoolForProfile(string variable, bool defaultValue = false) { }

	public static int GetInt(string variable, int defaultValue = 0) { }

	public static int GetIntForProfile(string variable, int defaultValue = 0) { }

	private static string GetKeyForProfile(string variable) { }

	public static string GetString(string variable, string value = null) { }

	public static string GetStringForProfile(string variable, string defaultValue = null) { }

	public static bool HasKeyForProfile(string variable) { }

	public static void Init(string profileId) { }

	public static void RegisterKeyToReset(string key, bool preserveLegacyGlobalKey = false) { }

	public static void ResetPrefs() { }

	public static void SetBool(string variable, bool value) { }

	public static void SetBoolForProfile(string variable, bool value) { }

	public static void SetInt(string variable, int value) { }

	public static void SetIntForProfile(string variable, int value) { }

	public static void SetString(string variable, string value) { }

	public static void SetStringForProfile(string variable, string value) { }

}

