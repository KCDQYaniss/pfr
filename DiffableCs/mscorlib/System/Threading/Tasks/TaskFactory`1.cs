namespace System.Threading.Tasks;

public class TaskFactory`1
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public Func endFunction; //Field offset: 0x0
		public Action endAction; //Field offset: 0x0
		public Task promise; //Field offset: 0x0

		public <>c__DisplayClass35_0() { }

		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0`1
	{
		public Func endFunction; //Field offset: 0x0
		public Action endAction; //Field offset: 0x0
		public Task promise; //Field offset: 0x0

		public <>c__DisplayClass38_0`1() { }

		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0`2
	{
		public Func endFunction; //Field offset: 0x0
		public Action endAction; //Field offset: 0x0
		public Task promise; //Field offset: 0x0

		public <>c__DisplayClass41_0`2() { }

		internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }

	}

	private sealed class FromAsyncTrimPromise`1 : Task
	{
		internal static readonly AsyncCallback s_completeFromAsyncResult; //Field offset: 0x0
		private TInstance m_thisRef; //Field offset: 0x0
		private Func m_endMethod; //Field offset: 0x0

		private static FromAsyncTrimPromise`1() { }

		internal FromAsyncTrimPromise`1(TInstance thisRef, Func endMethod) { }

		internal void Complete(TInstance thisRef, Func endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }

		internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }

	}

	private CancellationToken m_defaultCancellationToken; //Field offset: 0x0
	private TaskScheduler m_defaultScheduler; //Field offset: 0x0
	private TaskCreationOptions m_defaultCreationOptions; //Field offset: 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; //Field offset: 0x0

	public TaskFactory`1() { }

	public TaskFactory`1(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	public Task FromAsync(Func beginMethod, Func endMethod, object state) { }

	public Task FromAsync(Func beginMethod, Func endMethod, TArg1 arg1, object state) { }

	private static void FromAsyncCoreLogic(IAsyncResult iar, Func endFunction, Action endAction, Task promise, bool requiresSynchronization) { }

	internal static Task FromAsyncImpl(Func beginMethod, Func endFunction, Action endAction, object state, TaskCreationOptions creationOptions) { }

	internal static Task FromAsyncImpl(Func beginMethod, Func endFunction, Action endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }

	internal static Task FromAsyncImpl(Func beginMethod, Func endFunction, Action endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }

	internal static Task FromAsyncTrim(TInstance thisRef, TArgs args, Func beginMethod, Func endMethod) { }

	private TaskScheduler GetDefaultScheduler(Task currTask) { }

	public Task StartNew(Func function, CancellationToken cancellationToken) { }

	public Task StartNew(Func function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

}

