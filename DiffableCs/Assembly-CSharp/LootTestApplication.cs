//Type is in global namespace

public class LootTestApplication : ClientApplication
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x8
		public static Func <>9__0_1; //Field offset: 0x10
		public static Func <>9__0_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <StartTask>b__0_0(KeyValuePair x) { }

		internal IEnumerable <StartTask>b__0_1(KeyValuePair x) { }

		internal string <StartTask>b__0_2(ResourceKey x) { }

	}

	[CompilerGenerated]
	private struct <StartTask>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LootTestApplication <>4__this; //Field offset: 0x20
		private ItemFactory <itemFactory>5__2; //Field offset: 0x28
		private int <i>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private OperationAwaiter <>u__2; //Field offset: 0x40
		private TaskAwaiter <>u__3; //Field offset: 0x48
		private TaskAwaiter <>u__4; //Field offset: 0x50
		private OperationAwaiter <>u__5; //Field offset: 0x58
		private IEnumerator <>7__wrap3; //Field offset: 0x60
		private Item <item>5__5; //Field offset: 0x68
		private YieldAwaiter <>u__6; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public LootTestApplication() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[AsyncStateMachine(typeof(<StartTask>d__0))]
	protected virtual Task StartTask() { }

}

