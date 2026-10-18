namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct TaskAwaiter`1 : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly Task m_task; //Field offset: 0x0

	public bool IsCompleted
	{
		 get { } //Length: 96
	}

	internal TaskAwaiter`1(Task task) { }

	public bool get_IsCompleted() { }

	[StackTraceHidden]
	public TResult GetResult() { }

	public override void OnCompleted(Action continuation) { }

	public override void UnsafeOnCompleted(Action continuation) { }

}

