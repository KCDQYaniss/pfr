namespace System.Threading.Tasks;

public class TaskFactory
{
	public sealed class CompleteOnInvokePromise : Task, ITaskCompletionAction
	{
		private IList _tasks; //Field offset: 0x58

		public override bool InvokeMayRunArbitraryCode
		{
			 get { } //Length: 3
		}

		public CompleteOnInvokePromise(IList tasks) { }

		public override bool get_InvokeMayRunArbitraryCode() { }

		public override void Invoke(Task completingTask) { }

	}

	private readonly CancellationToken m_defaultCancellationToken; //Field offset: 0x10
	private readonly TaskScheduler m_defaultScheduler; //Field offset: 0x18
	private readonly TaskCreationOptions m_defaultCreationOptions; //Field offset: 0x20
	private readonly TaskContinuationOptions m_defaultContinuationOptions; //Field offset: 0x24

	public TaskFactory() { }

	public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }

	internal static Task CommonCWAnyLogic(IList tasks) { }

	public Task FromAsync(Func beginMethod, Action endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }

	public Task FromAsync(Func beginMethod, Action endMethod, TArg1 arg1, TArg2 arg2, object state) { }

	public Task FromAsync(Func beginMethod, Action endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }

	public Task FromAsync(Func beginMethod, Action endMethod, TArg1 arg1, object state) { }

	private TaskScheduler GetDefaultScheduler(Task currTask) { }

	public Task StartNew(Action action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	public Task StartNew(Action action, CancellationToken cancellationToken) { }

	public Task StartNew(Action action) { }

	public Task StartNew(Func function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	public Task StartNew(Func function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

}

