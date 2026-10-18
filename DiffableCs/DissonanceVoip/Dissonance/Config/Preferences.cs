namespace Dissonance.Config;

internal static class Preferences
{

	public static void Get(string key, ref T output, Func get, Log log) { }

	internal static bool GetBool(string key, bool defaultValue) { }

	public static void Set(string key, ref T field, T value, Action save, Log log, IEqualityComparer equality = null, bool setAtRuntime = true) { }

	internal static void SetBool(string key, bool value) { }

}

