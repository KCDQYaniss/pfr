//Type is in global namespace

internal sealed class SeasonsMaterialsSlice : SerializedMonoBehaviour, ISeasonsMaterial
{
	[CompilerGenerated]
	private struct <LoadAutumn>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsMaterialsSlice <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAutumnLate>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsMaterialsSlice <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadSpring>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsMaterialsSlice <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadSpringEarly>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsMaterialsSlice <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadSummer>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsMaterialsSlice <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadWinter>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsMaterialsSlice <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	public SeasonsMaterialsGroup _group; //Field offset: 0x60
	[SerializeField]
	public GPUInstancerDetailManager _manager; //Field offset: 0x68

	private static AbstractLogger Logger
	{
		private get { } //Length: 7
	}

	public SeasonsMaterialsSlice() { }

	public override void Fix() { }

	private static AbstractLogger get_Logger() { }

	[AsyncStateMachine(typeof(<LoadAutumn>d__10))]
	public override Task LoadAutumn() { }

	[AsyncStateMachine(typeof(<LoadAutumnLate>d__11))]
	public override Task LoadAutumnLate() { }

	[AsyncStateMachine(typeof(<LoadSpring>d__8))]
	public override Task LoadSpring() { }

	[AsyncStateMachine(typeof(<LoadSpringEarly>d__9))]
	public override Task LoadSpringEarly() { }

	[AsyncStateMachine(typeof(<LoadSummer>d__6))]
	public override Task LoadSummer() { }

	[AsyncStateMachine(typeof(<LoadWinter>d__7))]
	public override Task LoadWinter() { }

	private void OnDestroy() { }

	private void Start() { }

	public override void Unload() { }

}

