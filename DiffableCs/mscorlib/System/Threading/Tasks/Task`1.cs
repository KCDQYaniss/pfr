namespace System.Threading.Tasks;

[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView`1))]
public class Task`1 : Task
{
	public static class TaskWhenAnyCast
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal Task <.cctor>b__1_0(Task completed) { }

		}

		internal static readonly Func Value; //Field offset: 0x0

		private static TaskWhenAnyCast() { }

	}

	private static TaskFactory s_defaultFactory; //Field offset: 0x0
	internal TResult m_result; //Field offset: 0x0

	public static TaskFactory Factory
	{
		 get { } //Length: 575
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	public TResult Result
	{
		 get { } //Length: 353
	}

	internal TResult ResultOnSuccess
	{
		internal get { } //Length: 27
	}

	internal Task`1() { }

	internal Task`1(object state, TaskCreationOptions options) { }

	internal Task`1(TResult result) { }

	internal Task`1(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }

	public Task`1(Func function, CancellationToken cancellationToken) { }

	public Task`1(Func function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }

	internal Task`1(Func valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	internal Task`1(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	public Task ContinueWith(Func continuationFunction, TaskContinuationOptions continuationOptions) { }

	public Task ContinueWith(Func continuationFunction, TaskScheduler scheduler) { }

	internal Task ContinueWith(Action continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	public Task ContinueWith(Action continuationAction, TaskContinuationOptions continuationOptions) { }

	public Task ContinueWith(Action continuationAction, TaskScheduler scheduler) { }

	public Task ContinueWith(Action continuationAction) { }

	internal Task ContinueWith(Func continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	public Task ContinueWith(Func continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	internal void DangerousSetResult(TResult result) { }

	public static TaskFactory get_Factory() { }

	public TResult get_Result() { }

	internal TResult get_ResultOnSuccess() { }

	public TaskAwaiter GetAwaiter() { }

	internal TResult GetResultCore(bool waitCompletionNotification) { }

	internal virtual void InnerInvoke() { }

	internal static Task StartNew(Task parent, Func function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	internal static Task StartNew(Task parent, Func function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	internal bool TrySetResult(TResult result) { }

}

