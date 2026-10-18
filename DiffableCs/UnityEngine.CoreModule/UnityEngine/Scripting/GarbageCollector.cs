namespace UnityEngine.Scripting;

[NativeHeader("Runtime/Scripting/GarbageCollector.h")]
public static class GarbageCollector
{
	internal enum Mode
	{
		Disabled = 0,
		Enabled = 1,
		Manual = 2,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action GCModeChanged; //Field offset: 0x0

	public static Mode GCMode
	{
		 get { } //Length: 69
		 set { } //Length: 219
	}

	[NativeMethod("CollectIncrementalWrapper")]
	[NativeThrows]
	public static bool CollectIncremental(ulong nanoseconds = 0) { }

	public static Mode get_GCMode() { }

	private static Mode GetMode() { }

	public static void set_GCMode(Mode value) { }

	[NativeThrows]
	private static void SetMode(Mode mode) { }

}

