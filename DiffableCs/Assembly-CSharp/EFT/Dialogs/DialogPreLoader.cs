namespace EFT.Dialogs;

public sealed class DialogPreLoader
{
	[CompilerGenerated]
	private struct <DownloadDialog>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DialogPreLoader <>4__this; //Field offset: 0x20
		public MongoID dialogId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadDialogsBatch>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public List dialogIds; //Field offset: 0x20
		public DialogPreLoader <>4__this; //Field offset: 0x28
		private List <batchDialogIds>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnsureDialogAndEmbedsLoaded>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MongoID dialogId; //Field offset: 0x20
		public DialogPreLoader <>4__this; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnsureDialogAndEmbedsLoadedBatched>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MongoID dialogId; //Field offset: 0x20
		public DialogPreLoader <>4__this; //Field offset: 0x38
		public HashSet visitedDialogs; //Field offset: 0x40
		private List <dialogsToProcess>5__2; //Field offset: 0x48
		private List <currentBatch>5__3; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnsureStartDialogLoaded>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MongoID traderId; //Field offset: 0x20
		public Nullable entryDialogId; //Field offset: 0x38
		public DialogPreLoader <>4__this; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IEftSession _session; //Field offset: 0x10
	private readonly QuestController _questController; //Field offset: 0x18
	private readonly Dictionary _currentDownloadingDialogs; //Field offset: 0x20

	public DialogPreLoader(IEftSession session, QuestController questController) { }

	private void CollectEmbeddedDialogsFromAction(DialogEmbedQuestDialogAction embed, List dialogsToProcess, HashSet visitedDialogs) { }

	private void CollectEmbeddedDialogsFromTemplate(TraderDialogTemplate template, List dialogsToProcess, HashSet visitedDialogs) { }

	[AsyncStateMachine(typeof(<DownloadDialog>d__10))]
	private Task DownloadDialog(MongoID dialogId) { }

	[AsyncStateMachine(typeof(<DownloadDialogsBatch>d__7))]
	private Task DownloadDialogsBatch(List dialogIds) { }

	[AsyncStateMachine(typeof(<EnsureDialogAndEmbedsLoaded>d__5))]
	public Task EnsureDialogAndEmbedsLoaded(MongoID dialogId) { }

	[AsyncStateMachine(typeof(<EnsureDialogAndEmbedsLoadedBatched>d__6))]
	private Task EnsureDialogAndEmbedsLoadedBatched(MongoID dialogId, HashSet visitedDialogs) { }

	[AsyncStateMachine(typeof(<EnsureStartDialogLoaded>d__4))]
	public Task EnsureStartDialogLoaded(MongoID traderId, Nullable entryDialogId = null) { }

}

