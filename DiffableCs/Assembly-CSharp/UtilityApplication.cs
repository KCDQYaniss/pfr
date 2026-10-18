//Type is in global namespace

public class UtilityApplication : ClientApplication
{
	[CompilerGenerated]
	private struct <StartJob>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UtilityApplication <>4__this; //Field offset: 0x20
		private ClientApplicationInitOperation <initOperation>5__2; //Field offset: 0x28
		private ClientLoginResult <loginResult>5__3; //Field offset: 0x30
		private IEasyAssets <easyAssets>5__4; //Field offset: 0x38
		private ObjectsFactory <objectsFactory>5__5; //Field offset: 0x40
		private ItemIconCreator <iconCreator>5__6; //Field offset: 0x48
		private OperationAwaiter <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58
		private YieldAwaiter <>u__3; //Field offset: 0x60
		private TaskAwaiter <>u__4; //Field offset: 0x68
		private TaskAwaiter <>u__5; //Field offset: 0x70
		private TaskAwaiter <>u__6; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartTask>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UtilityApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private string _locale; //Field offset: 0x58
	[SerializeField]
	private bool _loadTemplatesFromBackend; //Field offset: 0x60
	[SerializeField]
	private bool _dropCache; //Field offset: 0x61
	protected ItemFactory ItemFactory; //Field offset: 0x68

	public UtilityApplication() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[AsyncStateMachine(typeof(<StartJob>d__5))]
	private Task StartJob() { }

	[AsyncStateMachine(typeof(<StartTask>d__4))]
	protected virtual Task StartTask() { }

}

