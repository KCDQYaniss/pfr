namespace EFT.InventoryLogic.Operations;

public sealed class QuestAcceptOperation : BaseQuestOperation
{
	[CompilerGenerated]
	private struct <ExecuteAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestAcceptOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private QuestAcceptResult _acceptResult; //Field offset: 0x50

	public QuestAcceptOperation(ushort id, ItemController controller, QuestAcceptResult acceptResult) { }

	public virtual void Dispose() { }

	[AsyncStateMachine(typeof(<ExecuteAsync>d__2))]
	protected virtual Task ExecuteAsync() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

