namespace System.Runtime.CompilerServices;

public struct AsyncTaskMethodBuilder`1
{
	internal static readonly Task s_defaultResultTask; //Field offset: 0x0
	private AsyncMethodBuilderCore m_coreState; //Field offset: 0x0
	private Task m_task; //Field offset: 0x0

	public Task Task
	{
		 get { } //Length: 276
	}

	private static AsyncTaskMethodBuilder`1() { }

	public void AwaitOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	public static AsyncTaskMethodBuilder Create() { }

	public Task get_Task() { }

	internal static Task GetTaskForResult(TResult result) { }

	public void SetException(Exception exception) { }

	public void SetResult(TResult result) { }

	internal void SetResult(Task completedTask) { }

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[DebuggerStepThrough]
	public void Start(ref TStateMachine stateMachine) { }

}

