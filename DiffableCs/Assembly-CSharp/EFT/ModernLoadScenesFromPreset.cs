namespace EFT;

public static class ModernLoadScenesFromPreset
{
	[CompilerGenerated]
	private struct <Load>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ResourceKey preset; //Field offset: 0x20
		private Token <resources>5__2; //Field offset: 0x28
		private ScenesPreset <scenesPreset>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private SceneResourceKey[] <>7__wrap3; //Field offset: 0x40
		private int <>7__wrap4; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadScene>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string sceneName; //Field offset: 0x20
		public LoadSceneMode loadSceneMode; //Field offset: 0x28
		public Action progressCallback; //Field offset: 0x30
		private AsyncOperation <asyncOperation>5__2; //Field offset: 0x38
		private float <progress>5__3; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x44

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Unload>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SceneToken sceneToken; //Field offset: 0x20
		private SceneResourceKey[] <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnloadScene>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string sceneName; //Field offset: 0x20
		public Action progressCallback; //Field offset: 0x28
		private AsyncOperation <asyncOperation>5__2; //Field offset: 0x30
		private float <progress>5__3; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x3C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class SceneToken
	{
		public ScenesPreset ScenesPreset; //Field offset: 0x10
		public Token Resources; //Field offset: 0x18

		public SceneToken() { }

	}


	[AsyncStateMachine(typeof(<Load>d__1))]
	public static Task Load(ResourceKey preset) { }

	[AsyncStateMachine(typeof(<LoadScene>d__3))]
	public static Task LoadScene(string sceneName, LoadSceneMode loadSceneMode, Action progressCallback = null) { }

	[AsyncStateMachine(typeof(<Unload>d__2))]
	public static Task Unload(SceneToken sceneToken) { }

	[AsyncStateMachine(typeof(<UnloadScene>d__4))]
	public static Task UnloadScene(string sceneName, Action progressCallback = null) { }

}

