//Type is in global namespace

public static class InGameMemoryManagement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__21_0(string s) { }

	}

	[CompilerGenerated]
	private struct <CollectAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool force; //Field offset: 0x20
		private float <totalMemoryBeforeCleanUp>5__2; //Field offset: 0x24
		private float <startClearTime>5__3; //Field offset: 0x28
		private bool <needToClear>5__4; //Field offset: 0x2C
		private YieldAwaiter <>u__1; //Field offset: 0x2D

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct MemoryManagementSettings
	{
		public static readonly MemoryManagementSettings Default; //Field offset: 0x0
		public bool HeapPreAllocationEnabled; //Field offset: 0x0
		public int HeapPreAllocationMB; //Field offset: 0x4
		public bool OverrideRamCleanerSettings; //Field offset: 0x8
		public bool RamCleanerEnabled; //Field offset: 0x9
		public int GigabytesRequiredToDisableGCDuringRaid; //Field offset: 0xC
		public bool AggressiveGC; //Field offset: 0x10

		private static MemoryManagementSettings() { }

	}

	private const float COLLECT_DELAY = 600; //Field offset: 0x0
	private static float _lastCollectTime; //Field offset: 0x0
	[CompilerGenerated]
	private static MemoryManagementSettings <Settings>k__BackingField; //Field offset: 0x4
	public static Action Logger; //Field offset: 0x18

	private static float CurrentMemorySize
	{
		private get { } //Length: 84
	}

	public static bool GCEnabled
	{
		 get { } //Length: 75
		 set { } //Length: 1103
	}

	public private static MemoryManagementSettings Settings
	{
		[CompilerGenerated]
		 get { } //Length: 102
		[CompilerGenerated]
		private set { } //Length: 96
	}

	private static InGameMemoryManagement() { }

	public static float Collect(bool force = false) { }

	public static float Collect(int generation, GCCollectionMode gcMode, bool isBlocking, bool compacting, bool force) { }

	[AsyncStateMachine(typeof(<CollectAsync>d__17))]
	public static Task CollectAsync(bool force = false) { }

	public static void EmptyWorkingSet() { }

	private static bool EmptyWorkingSet(IntPtr hProcess) { }

	private static float get_CurrentMemorySize() { }

	public static bool get_GCEnabled() { }

	[CompilerGenerated]
	public static MemoryManagementSettings get_Settings() { }

	public static float GetTotalAllocatedMemoryGB() { }

	public static void Init(MemoryManagementSettings settings) { }

	public static void RunHeapPreAllocation() { }

	public static void set_GCEnabled(bool value) { }

	[CompilerGenerated]
	private static void set_Settings(MemoryManagementSettings value) { }

}

