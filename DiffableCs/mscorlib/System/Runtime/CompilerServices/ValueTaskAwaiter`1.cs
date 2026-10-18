namespace System.Runtime.CompilerServices;

[IsReadOnly]
public struct ValueTaskAwaiter`1 : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly ValueTask _value; //Field offset: 0x0

	public bool IsCompleted
	{
		 get { } //Length: 54
	}

	internal ValueTaskAwaiter`1(ValueTask value) { }

	public bool get_IsCompleted() { }

	[StackTraceHidden]
	public TResult GetResult() { }

	public override void OnCompleted(Action continuation) { }

	public override void UnsafeOnCompleted(Action continuation) { }

}

