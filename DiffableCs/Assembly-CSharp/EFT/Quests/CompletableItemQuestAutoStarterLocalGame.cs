namespace EFT.Quests;

public sealed class CompletableItemQuestAutoStarterLocalGame : CompletableItemQuestAutoStarter
{
	[CompilerGenerated]
	private struct <LoadAssociatedQuests>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CompletableItemQuestAutoStarterLocalGame <>4__this; //Field offset: 0x20
		public MongoID itemId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly QuestControllerClientLocalGame _questController; //Field offset: 0x28

	public CompletableItemQuestAutoStarterLocalGame(Profile profile, QuestControllerClientLocalGame questController, Func canAutoStartQuest) { }

	protected virtual void CompletableItemProgressChange(MongoID itemId, bool completed) { }

	[AsyncStateMachine(typeof(<LoadAssociatedQuests>d__3))]
	private Task LoadAssociatedQuests(MongoID itemId) { }

}

