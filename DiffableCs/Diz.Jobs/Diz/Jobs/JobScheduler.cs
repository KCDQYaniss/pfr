namespace Diz.Jobs;

public class JobScheduler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <Start>d__50 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public JobScheduler <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Start>d__50(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class Stats
	{
		public long WorkCpuLoad; //Field offset: 0x10
		public float WorkCpuLoadPercent; //Field offset: 0x18
		public SimpleAverage AvgWorkCpuLoad; //Field offset: 0x20
		public float MaxWorkCpuLoadPercent; //Field offset: 0x28

		public Stats() { }

		public virtual string ToString() { }

	}

	public static int FreeTimeWindowFrame; //Field offset: 0x0
	private const int _predefinedBufferAllocation = 1024; //Field offset: 0x0
	public static float MaxAvgFrameLoad; //Field offset: 0x4
	private static MovingAverage _avgFrameTime; //Field offset: 0x8
	public static readonly Stats WorkingStats; //Field offset: 0x10
	private static bool _isManualUpdateInProgress; //Field offset: 0x18
	private static List _continuations; //Field offset: 0x20
	private static List _continuationsDoubleBuffer; //Field offset: 0x28
	private static List _delayedContinuations; //Field offset: 0x30
	private static List _delayedContinuationsDoubleBuffer; //Field offset: 0x38
	private static List _workingSet; //Field offset: 0x40
	private static ExecuteConditionJobFinish _executeConditionJobFinish; //Field offset: 0x48
	internal static readonly JobAwaiter JobAwaiter; //Field offset: 0x50
	private static readonly JobAwaitable _jobAwaitable; //Field offset: 0x58
	internal static ContinuationProfiler ContinuationProfiler; //Field offset: 0x60
	private static readonly WaitForEndOfFrame _waitForEndOfFrame; //Field offset: 0x68
	private ExecuteConditionGeneral _executeConditionGeneral; //Field offset: 0x20
	private readonly Stopwatch _stopwatch; //Field offset: 0x28
	private readonly Stopwatch _loop; //Field offset: 0x30
	private bool _forcedMode; //Field offset: 0x38
	public float DefaultForceModeMultiplier; //Field offset: 0x3C
	private float _forceModeMult; //Field offset: 0x40
	[CompilerGenerated]
	private long <FrameTicks>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private byte <SlowFrames>k__BackingField; //Field offset: 0x50
	private int _slowFrames; //Field offset: 0x54
	private int _continuationsToExecuteCount; //Field offset: 0x58

	public static int AvgTimeBufferSize
	{
		 get { } //Length: 97
		 set { } //Length: 236
	}

	public long FrameTicks
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	private static bool HasContinuations
	{
		private get { } //Length: 208
	}

	private bool HasFrameTime
	{
		private get { } //Length: 63
	}

	private bool HasLoopTicks
	{
		private get { } //Length: 98
	}

	public bool IsForceModeEnabled
	{
		 get { } //Length: 5
	}

	public long LoopTicks
	{
		 get { } //Length: 13
	}

	public static int QueueLength
	{
		 get { } //Length: 123
	}

	public byte SlowFrames
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static JobScheduler() { }

	public JobScheduler() { }

	[CompilerGenerated]
	private bool <Init>b__45_0(JobContinuation continuation) { }

	internal static void AddContinuation(Action action, JobYield jobYield) { }

	private void ExecuteContinuations() { }

	public static bool ForceExecuteContinuations(JobYield jobYield) { }

	private static void ForceProcessContinuations(List continuations) { }

	public static int get_AvgTimeBufferSize() { }

	[CompilerGenerated]
	public long get_FrameTicks() { }

	private static bool get_HasContinuations() { }

	private bool get_HasFrameTime() { }

	private bool get_HasLoopTicks() { }

	public bool get_IsForceModeEnabled() { }

	public long get_LoopTicks() { }

	public static int get_QueueLength() { }

	[CompilerGenerated]
	public byte get_SlowFrames() { }

	public static string GetPerformanceReport() { }

	public void Init(bool enableContinuationProfiler) { }

	private void LateUpdate() { }

	private void ManualUpdate(IConditionExecutor executeCondition) { }

	private void ProcessContinuations(ref List continuations, ref List continuationsDoubleBuffer, List delayedContinuations, IConditionExecutor executeCondition) { }

	public static void set_AvgTimeBufferSize(int value) { }

	[CompilerGenerated]
	public void set_FrameTicks(long value) { }

	[CompilerGenerated]
	public void set_SlowFrames(byte value) { }

	public void SetForceMode(bool enable, float forceModeMultiplier = -1) { }

	public void SetTargetFrameRate(int frameRate) { }

	[IteratorStateMachine(typeof(<Start>d__50))]
	private IEnumerator Start() { }

	public static IJobAwaitable Yield(EJobPriority priority = 1, JobYield jobYield = null) { }

}

