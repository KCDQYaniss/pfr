namespace EFT.Quests;

public sealed class ConditionsConnectorsManagerQuestClientBackend : ConditionsConnectorsManagerClientBackend
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal double <ConnectConditionAchievement>b__5_0(ConditionProgressChecker _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Achievement achievement; //Field offset: 0x10
		public ConditionsConnectorsManagerQuestClientBackend <>4__this; //Field offset: 0x18
		public Quest conditional; //Field offset: 0x20
		public EQuestStatus status; //Field offset: 0x28
		public ConditionAchievementUnlocked condition; //Field offset: 0x30

		public <>c__DisplayClass5_0() { }

		internal void <ConnectConditionAchievement>b__1(ConditionProgressChecker _) { }

		internal double <ConnectConditionAchievement>g__ConditionValueChangedGetter|3(ConditionProgressChecker _) { }

		internal void <ConnectConditionAchievement>g__OnQuestStatusChanged|2(Achievement _, bool __) { }

	}

	private readonly AchievementsBook _achievementsBook; //Field offset: 0x50

	public ConditionsConnectorsManagerQuestClientBackend(Profile profile, InventoryController inventoryController, QuestBook conditionalBook, AchievementsBook achievementsBook, IQuestSession session, bool inRaid) { }

	private void ConnectConditionAchievement(Quest conditional, EQuestStatus status, ConditionAchievementUnlocked condition) { }

	protected virtual int GetFindItemConditionCount(Quest quest, ConditionFindItem condition) { }

	protected virtual int GetItemsForConditionCount(Inventory inventory, ConditionFindItem condition) { }

	protected virtual void InvokeConditionsConnector(Quest conditional, EQuestStatus status, Condition condition) { }

}

