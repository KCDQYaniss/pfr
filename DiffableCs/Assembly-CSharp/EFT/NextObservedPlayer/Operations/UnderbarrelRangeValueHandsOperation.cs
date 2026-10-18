namespace EFT.NextObservedPlayer.Operations;

public class UnderbarrelRangeValueHandsOperation : BaseHandsOperation
{
	[CompilerGenerated]
	private struct <ChangeRangeValue>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UnderbarrelRangeValueHandsOperation <>4__this; //Field offset: 0x20
		public int currentValue; //Field offset: 0x28
		public int targetValue; //Field offset: 0x2C
		public SafeTaskCompleteSource safeTaskCompleteSource; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct OperationCallbacks : IHandsOperationResult
	{
		[CompilerGenerated]
		private Task <Complete>k__BackingField; //Field offset: 0x0

		public override Task Complete
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 82
		}

		[CompilerGenerated]
		[IsReadOnly]
		public override Task get_Complete() { }

		[CompilerGenerated]
		public void set_Complete(Task value) { }

	}

	private readonly SafeTaskCompleteSource _safeTaskCompleteSource; //Field offset: 0x20

	public UnderbarrelRangeValueHandsOperation() { }

	[AsyncStateMachine(typeof(<ChangeRangeValue>d__5))]
	private Task ChangeRangeValue(SafeTaskCompleteSource safeTaskCompleteSource, int targetValue, int currentValue) { }

	public static UnderbarrelRangeValueHandsOperation CreateInstance() { }

	public virtual void FastForward() { }

	public virtual OperationCallbacks Start(UnderbarrelRangeValueCommandMessage input) { }

}

