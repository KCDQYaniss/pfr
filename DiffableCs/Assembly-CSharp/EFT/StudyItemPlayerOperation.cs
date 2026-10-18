namespace EFT;

public sealed class StudyItemPlayerOperation : StudyItemBaseOperation, IServerDependentOperation
{
	[CompilerGenerated]
	private struct <ProcessAudio>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StudyItemPlayerOperation <>4__this; //Field offset: 0x20
		private float <percent>5__2; //Field offset: 0x28
		private TapeItem <tapeItem>5__3; //Field offset: 0x30
		private float <timeSeconds>5__4; //Field offset: 0x38
		private double <elapsedTime>5__5; //Field offset: 0x40
		private double <startTime>5__6; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private YieldAwaiter <>u__2; //Field offset: 0x58
		private TaskAwaiter <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CanBeNull]
	private readonly RecorderItem _recorder; //Field offset: 0x68
	private bool _terminateImmediate; //Field offset: 0x70

	public virtual bool BlockHands
	{
		 get { } //Length: 3
	}

	public TapeItem Tape
	{
		 get { } //Length: 119
	}

	public StudyItemPlayerOperation(ushort id, InventoryController controller, CompletableItem item, RecorderItem recorder) { }

	public virtual bool get_BlockHands() { }

	public TapeItem get_Tape() { }

	public virtual void Pause() { }

	[AsyncStateMachine(typeof(<ProcessAudio>d__9))]
	protected virtual Task ProcessAudio() { }

	public virtual void Resume() { }

	public void TerminateImmediate() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

