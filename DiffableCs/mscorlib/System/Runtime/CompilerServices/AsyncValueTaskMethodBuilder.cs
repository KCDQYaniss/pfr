namespace System.Runtime.CompilerServices;

public struct AsyncValueTaskMethodBuilder
{
	private AsyncTaskMethodBuilder _methodBuilder; //Field offset: 0x0
	private bool _haveResult; //Field offset: 0x18
	private bool _useBuilder; //Field offset: 0x19

	public ValueTask Task
	{
		 get { } //Length: 258
	}

	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	public static AsyncValueTaskMethodBuilder Create() { }

	public ValueTask get_Task() { }

	public void SetException(Exception exception) { }

	public void SetResult() { }

	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	public void Start(ref TStateMachine stateMachine) { }

}

