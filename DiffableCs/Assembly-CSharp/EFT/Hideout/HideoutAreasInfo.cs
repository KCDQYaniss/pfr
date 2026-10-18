namespace EFT.Hideout;

public sealed class HideoutAreasInfo : SerializedScriptableObject
{
	[CompilerGenerated]
	private struct <Load>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private ResourceRequest <loadOperation>5__2; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Dictionary _areas; //Field offset: 0x58

	public IEnumerable Templates
	{
		 get { } //Length: 73
	}

	public HideoutAreasInfo() { }

	public IEnumerable get_Templates() { }

	[AsyncStateMachine(typeof(<Load>d__3))]
	public static void Load() { }

	[AsyncStateMachine(typeof(<LoadAsync>d__4))]
	public static Task LoadAsync() { }

}

