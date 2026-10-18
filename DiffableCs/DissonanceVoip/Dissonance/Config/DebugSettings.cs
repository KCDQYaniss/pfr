namespace Dissonance.Config;

public class DebugSettings : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__15_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__15_0(LogCategory c) { }

	}

	private const string SettingsFileResourceName = "DebugSettings"; //Field offset: 0x0
	public static readonly string SettingsFilePath; //Field offset: 0x0
	private const LogLevel DefaultLevel = 0; //Field offset: 0x0
	private static DebugSettings _instance; //Field offset: 0x8
	[SerializeField]
	private List _levels; //Field offset: 0x18
	public bool EnableRecordingDiagnostics; //Field offset: 0x20
	public bool RecordMicrophoneRawAudio; //Field offset: 0x21
	public bool RecordPreprocessorOutput; //Field offset: 0x22
	public bool EnablePlaybackDiagnostics; //Field offset: 0x23
	public bool RecordDecodedAudio; //Field offset: 0x24
	public bool RecordFinalAudio; //Field offset: 0x25
	public bool EnableNetworkSimulation; //Field offset: 0x26
	public float PacketLoss; //Field offset: 0x28

	[NotNull]
	public static DebugSettings Instance
	{
		 get { } //Length: 462
	}

	private static DebugSettings() { }

	public DebugSettings() { }

	public static DebugSettings get_Instance() { }

	public LogLevel GetLevel(int category) { }

	private static DebugSettings Load() { }

	public static void Preload() { }

	public void SetLevel(int category, LogLevel level) { }

}

