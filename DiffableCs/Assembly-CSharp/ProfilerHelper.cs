//Type is in global namespace

public static class ProfilerHelper
{
	internal enum DetectType
	{
		Loop = 0,
		FixedUpdate = 1,
		SingleAVGFixedUpdate = 2,
		LoopWithoutFixedUpdate = 3,
		LoopWithSingleAVGFixedUpdateOnly = 4,
	}

	[Flags]
	internal enum EPauseReason
	{
		None = 0,
		Inventory = 1,
		Snapshot = 2,
		AltTab = 4,
		All = 7,
	}

	[CompilerGenerated]
	private static EPauseReason <PauseReason>k__BackingField; //Field offset: 0x0
	private static ProfilerSpikeAnalyzer _profilerSpikeAnalyzer; //Field offset: 0x8
	private static Rigidbody2D _mark; //Field offset: 0x10
	private static readonly Dictionary _lastMemoryValues; //Field offset: 0x18

	public static bool Paused
	{
		 get { } //Length: 137
	}

	public private static EPauseReason PauseReason
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		private set { } //Length: 88
	}

	private static ProfilingSettings Settings
	{
		private get { } //Length: 149
	}

	private static ProfilerHelper() { }

	public static bool get_Paused() { }

	[CompilerGenerated]
	public static EPauseReason get_PauseReason() { }

	private static ProfilingSettings get_Settings() { }

	[Conditional("DEBUG")]
	public static void InitMarks() { }

	[Conditional("DEBUG")]
	public static void MakeMark() { }

	public static void PrintMemoryUsage() { }

	private static void PrintMemoryValue(string description, long newValue) { }

	[CompilerGenerated]
	private static void set_PauseReason(EPauseReason value) { }

	[Conditional("DEBUG")]
	public static void StartSpikeAnalyzer(float triggerTime) { }

	[Conditional("DEBUG")]
	public static void StopSpikeAnalyzer(bool resetPauseState = true) { }

	[Conditional("DEBUG")]
	public static void TryPauseSpikeAnalyzer(EPauseReason pauseReason) { }

	[Conditional("DEBUG")]
	public static void TryResumeSpikeAnalyzer(EPauseReason pauseReason) { }

	[Conditional("DEBUG")]
	public static void TryStartSpikeAnalyzer() { }

	[Conditional("DEBUG")]
	public static void TryStopSpikeAnalyzer(bool resetPauseState = true) { }

}

