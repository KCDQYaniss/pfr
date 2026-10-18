namespace Audio;

public static class DebugAudioLogger
{

	[Conditional("UNITY_EDITOR")]
	public static void Log(string moduleName, EAudioLogLevel level, string message) { }

	[Conditional("UNITY_EDITOR")]
	public static void SetLogLevel(string moduleName, EAudioLogLevel level) { }

}

