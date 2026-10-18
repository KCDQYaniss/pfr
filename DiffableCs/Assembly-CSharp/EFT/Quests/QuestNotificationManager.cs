namespace EFT.Quests;

public sealed class QuestNotificationManager : IConditionalNotificationManager
{
	[CompilerGenerated]
	private struct <DisplayNotificationAfterSpriteLoad>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Quest quest; //Field offset: 0x20
		public QuestNotificationManager <>4__this; //Field offset: 0x28
		public string message; //Field offset: 0x30
		public Nullable soundType; //Field offset: 0x38
		public bool showImmediately; //Field offset: 0x40
		public bool isReward; //Field offset: 0x41
		public Nullable status; //Field offset: 0x44
		public IImageLoader imageLoader; //Field offset: 0x50
		private MainQuest <mainQuest>5__2; //Field offset: 0x58
		private QuestChapter <chapter>5__3; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string MAIN_QUEST_KEY = "MainQuest"; //Field offset: 0x0
	private const string QUEST_CHAPTER_KEY = "QuestChapter"; //Field offset: 0x0
	[CompilerGenerated]
	private readonly IImageLoader <ImageLoader>k__BackingField; //Field offset: 0x10

	public override IImageLoader ImageLoader
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public QuestNotificationManager(IImageLoader imageLoader) { }

	[CompilerGenerated]
	private string <NotifyReward>g__GetRewardSprite|8_1(QuestReward reward, string message) { }

	[CompilerGenerated]
	internal static string <NotifyReward>g__GetValueText|8_2(string valueText, QuestReward reward) { }

	[CompilerGenerated]
	internal static bool <NotifyReward>g__NeedHideItemName|8_0(QuestReward reward) { }

	[CompilerGenerated]
	internal static bool <TryGetRewardSpriteIndex>g__TryGetMoneyIndex|9_0(Money moneyItem, out int moneyIndex) { }

	private void DisplayCommonQuestNotification(Quest quest) { }

	private void DisplayMainQuestNotification(Quest quest) { }

	private void DisplayNotification(Quest quest, string message, Nullable soundType, bool showImmediately, bool isReward, Nullable status = null) { }

	[AsyncStateMachine(typeof(<DisplayNotificationAfterSpriteLoad>d__12))]
	private Task DisplayNotificationAfterSpriteLoad(IImageLoader imageLoader, Quest quest, string message, Nullable soundType, bool showImmediately, bool isReward, Nullable status = null) { }

	[CompilerGenerated]
	public override IImageLoader get_ImageLoader() { }

	public override void NotifyConditionalStatusChanged(Quest quest) { }

	public override void NotifyConditionChanged(Quest quest) { }

	public override void NotifyReward(Quest quest, EQuestStatus status) { }

	private bool TryGetRewardSpriteIndex(QuestReward reward, out int spriteIndex) { }

}

