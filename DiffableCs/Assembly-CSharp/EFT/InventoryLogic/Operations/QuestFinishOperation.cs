namespace EFT.InventoryLogic.Operations;

public sealed class QuestFinishOperation : BaseQuestOperation
{
	[CompilerGenerated]
	private struct <ExecuteAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestFinishOperation <>4__this; //Field offset: 0x20
		private OperationResult <finishQuestResult>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly ConditionalFinishResult _finishResult; //Field offset: 0x50

	internal QuestFinishOperation(ushort id, ConditionalFinishResult finishResult) { }

	public virtual void Dispose() { }

	[AsyncStateMachine(typeof(<ExecuteAsync>d__2))]
	protected virtual Task ExecuteAsync() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

