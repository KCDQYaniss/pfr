namespace EFT;

public class NarrateScene
{
	[CompilerGenerated]
	private struct <Load>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NarrateScene <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Unload>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NarrateScene <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly HashSet _currentScenes; //Field offset: 0x0
	private readonly string _sceneName; //Field offset: 0x10

	private static NarrateScene() { }

	public NarrateScene(string sceneName) { }

	public static void CacheCurrentScenes() { }

	private bool IsLoaded() { }

	[AsyncStateMachine(typeof(<Load>d__5))]
	public Task Load() { }

	[AsyncStateMachine(typeof(<Unload>d__6))]
	public Task Unload() { }

}

