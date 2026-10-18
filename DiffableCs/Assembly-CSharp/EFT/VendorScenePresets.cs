namespace EFT;

public class VendorScenePresets
{
	[CompilerGenerated]
	private struct <Load>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public VendorScenePresets <>4__this; //Field offset: 0x20
		public ETraderType vendor; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Unload>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public VendorScenePresets <>4__this; //Field offset: 0x20
		public ETraderType vendor; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnloadAll>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public VendorScenePresets <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public readonly Dictionary narratePresets; //Field offset: 0x10
	private readonly HashSet _tasks; //Field offset: 0x18

	public VendorScenePresets() { }

	public bool GetSceneInfo(ETraderType vendor, out VendorScenePreset scenePreset) { }

	public bool IsValid(ETraderType vendor, out VendorScenePreset sceneInfo) { }

	[AsyncStateMachine(typeof(<Load>d__3))]
	public Task Load(ETraderType vendor) { }

	[AsyncStateMachine(typeof(<Unload>d__4))]
	public Task Unload(ETraderType vendor) { }

	[AsyncStateMachine(typeof(<UnloadAll>d__5))]
	public Task UnloadAll() { }

}

