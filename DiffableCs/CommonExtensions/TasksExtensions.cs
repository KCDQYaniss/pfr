//Type is in global namespace

[Extension]
public static class TasksExtensions
{
	[CompilerGenerated]
	private struct <Await>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken token; //Field offset: 0x20
		public Task task; //Field offset: 0x28
		private CancellationTokenRegistration <subscriber>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Delay>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public float seconds; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FailIfCancelled>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken token; //Field offset: 0x20
		public Task task; //Field offset: 0x28
		private CancellationTokenRegistration <subscriber>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitUntil>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Func predicate; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[IsReadOnly]
	internal struct OperationAwaiter : INotifyCompletion
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			public Action continuation; //Field offset: 0x10
			public IOperation operation; //Field offset: 0x18

			public <>c__DisplayClass2_0() { }

			internal void <OnCompleted>g__OnOperationCompletedEvent|0() { }

		}

		private readonly IOperation _operation; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 74
		}

		public OperationAwaiter(IOperation operation) { }

		public bool get_IsCompleted() { }

		public IOperation GetResult() { }

		public override void OnCompleted(Action continuation) { }

	}

	[IsReadOnly]
	internal struct OperationAwaiter`1 : INotifyCompletion
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			public Action continuation; //Field offset: 0x0
			public IOperation operation; //Field offset: 0x0

			public <>c__DisplayClass2_0() { }

			internal void <OnCompleted>g__OnOperationCompletedEvent|0() { }

		}

		private readonly IOperation _operation; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 74
		}

		public OperationAwaiter`1(IOperation operation) { }

		public bool get_IsCompleted() { }

		public IOperation GetResult() { }

		public override void OnCompleted(Action continuation) { }

	}

	[IsReadOnly]
	internal struct OperationAwaiter`2 : INotifyCompletion
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			public Action continuation; //Field offset: 0x0
			public IOperation operation; //Field offset: 0x0

			public <>c__DisplayClass2_0() { }

			internal void <OnCompleted>g__OnOperationCompletedEvent|0() { }

		}

		private readonly IOperation _operation; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 74
		}

		public OperationAwaiter`2(IOperation operation) { }

		public bool get_IsCompleted() { }

		public IOperation GetResult() { }

		public override void OnCompleted(Action continuation) { }

	}

	[IsReadOnly]
	internal struct OperationAwaiter`3 : INotifyCompletion
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass2_0
		{
			public Action continuation; //Field offset: 0x0
			public IOperation operation; //Field offset: 0x0

			public <>c__DisplayClass2_0() { }

			internal void <OnCompleted>g__OnOperationCompletedEvent|0() { }

		}

		private readonly IOperation _operation; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 74
		}

		public OperationAwaiter`3(IOperation operation) { }

		public bool get_IsCompleted() { }

		public IOperation GetResult() { }

		public override void OnCompleted(Action continuation) { }

	}

	private static readonly Action _handleFinishedTask; //Field offset: 0x0
	private static readonly Action _handleFinishedTaskWithErrorMessage; //Field offset: 0x8

	private static TasksExtensions() { }

	[Extension]
	private static Task Await(CancellationToken token, out CancellationTokenRegistration subscriber) { }

	[AsyncStateMachine(typeof(<Await>d__0))]
	[Extension]
	public static Task Await(Task task, CancellationToken token) { }

	[Extension]
	private static void CompleteTaskSource(TaskCompletionSource completionSource) { }

	[AsyncStateMachine(typeof(<Delay>d__16))]
	public static Task Delay(float seconds) { }

	[AsyncStateMachine(typeof(<FailIfCancelled>d__1))]
	[Extension]
	public static Task FailIfCancelled(Task task, CancellationToken token) { }

	[Extension]
	public static OperationAwaiter GetAwaiter(IOperation operation) { }

	[Extension]
	public static OperationAwaiter GetAwaiter(IOperation operation) { }

	[Extension]
	public static OperationAwaiter GetAwaiter(IOperation operation) { }

	[Extension]
	public static OperationAwaiter GetAwaiter(IOperation operation) { }

	[Extension]
	public static void HandleExceptions(Task task) { }

	[Extension]
	public static void HandleExceptions(Task task, object errorMessage) { }

	private static void HandleFinishedTask(Task task, object errorMessage) { }

	public static void HandleFinishedTask(Task task) { }

	private static void HandleFinishedTaskGeneric(Task task) { }

	[Extension]
	public static T ResultWithHandleExceptions(Task task) { }

	[Extension]
	public static T ResultWithHandleExceptions(Task task, object errorMessage) { }

	[Extension]
	public static void SetFromResult(TaskCompletionSource completionSource, Result result) { }

	[AsyncStateMachine(typeof(<WaitUntil>d__4))]
	public static Task WaitUntil(Func predicate, CancellationToken cancellationToken = null) { }

}

