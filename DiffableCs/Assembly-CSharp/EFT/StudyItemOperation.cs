namespace EFT;

public sealed class StudyItemOperation : StudyItemBaseOperation
{
	[CompilerGenerated]
	private struct <ProcessAudio>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StudyItemOperation <>4__this; //Field offset: 0x20
		private TapeItem <tapeItem>5__2; //Field offset: 0x28
		private float <studyTime>5__3; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x34

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class CompleteProgressItemCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("completableItemId")]
		public MongoID CompletableItemTemplateID; //Field offset: 0x20

		public virtual bool Queued
		{
			 get { } //Length: 3
		}

		public CompleteProgressItemCommand(MongoID completableItemTemplateID) { }

		public virtual bool get_Queued() { }

	}

	private float _studyProgress; //Field offset: 0x68
	private double _pauseTime; //Field offset: 0x70
	private double _startTime; //Field offset: 0x78

	public StudyItemOperation(ushort id, InventoryController inventoryController, CompletableItem item) { }

	public virtual void Pause() { }

	[AsyncStateMachine(typeof(<ProcessAudio>d__6))]
	protected virtual Task ProcessAudio() { }

	public virtual void Resume() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

