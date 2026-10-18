namespace EFT.Quests;

public abstract class ConditionalController`1 : IConditionalController, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__46_2; //Field offset: 0x0
		public static Func <>9__46_0; //Field offset: 0x0
		public static Func <>9__46_1; //Field offset: 0x0
		public static Func <>9__50_1; //Field offset: 0x0
		public static Func <>9__54_0; //Field offset: 0x0
		public static Func <>9__54_1; //Field offset: 0x0
		public static Func <>9__54_2; //Field offset: 0x0
		public static Func <>9__54_3; //Field offset: 0x0
		public static Func <>9__60_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <ApplyRewardInternal>b__46_0(QuestReward r) { }

		internal string <ApplyRewardInternal>b__46_1(QuestReward r) { }

		internal bool <ApplyRewardInternal>b__46_2(QuestReward r) { }

		internal int <CanHandoverItems>b__50_1(Item item) { }

		internal string <CheckHitConditionCounter>b__60_0(Mod x) { }

		internal bool <NotifyRewards>b__54_0(QuestReward reward) { }

		internal bool <NotifyRewards>b__54_1(QuestReward r) { }

		internal bool <NotifyRewards>b__54_2(QuestReward r) { }

		internal string <NotifyRewards>b__54_3(QuestReward r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public TraderInfo traderInfo; //Field offset: 0x0
		public ConditionalController <>4__this; //Field offset: 0x0

		public <>c__DisplayClass35_0() { }

		internal void <Run>b__1() { }

		internal void <Run>g__SoldToTraderHandler|0(string templateId, int count) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public string conditionalId; //Field offset: 0x0
		public MongoID conditionId; //Field offset: 0x0

		public <>c__DisplayClass50_0() { }

		internal bool <CanHandoverItems>b__0(TConditional conditional) { }

		internal bool <CanHandoverItems>b__2(KeyValuePair checker) { }

	}

	[CompilerGenerated]
	private Action OnConditionalStatusChanged; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnTraderAssortmentChanged; //Field offset: 0x0
	[CompilerGenerated]
	private Action AchievementUnlocked; //Field offset: 0x0
	[CompilerGenerated]
	private Action LocationUnlocked; //Field offset: 0x0
	public readonly Profile Profile; //Field offset: 0x0
	protected readonly InventoryController InventoryController; //Field offset: 0x0
	[CompilerGenerated]
	private ConditionsConnectorsManager <ConditionsConnectorsManager>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ConditionalBook <ConditionalBook>k__BackingField; //Field offset: 0x0
	protected bool UpdateConditionalsOnValueChanged; //Field offset: 0x0
	private readonly CompositeDisposable _disposable; //Field offset: 0x0

	public event Action AchievementUnlocked
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action LocationUnlocked
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnConditionalStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnTraderAssortmentChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	protected override bool CanFailConditionals
	{
		 get { } //Length: 3
	}

	public private ConditionalBook ConditionalBook
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ConditionsConnectorsManager ConditionsConnectorsManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override bool FromServer
	{
		 get { } //Length: 3
	}

	protected override bool InRaid
	{
		 get { } //Length: 20
	}

	protected ConditionalController`1(Profile profile, InventoryController inventoryController) { }

	[CompilerGenerated]
	public void add_AchievementUnlocked(Action value) { }

	[CompilerGenerated]
	public void add_LocationUnlocked(Action value) { }

	[CompilerGenerated]
	public void add_OnConditionalStatusChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnTraderAssortmentChanged(Action value) { }

	protected override void AddQuestNote(TConditional conditional, Condition condition, QuestNoteTemplate note) { }

	public void AddStatusNote(TConditional conditional, EQuestStatus status) { }

	public abstract OperationResult ApplyReward(TConditional conditional, ItemController itemController, bool simulate) { }

	protected OperationResult ApplyRewardInternal(TConditional conditional, ItemController itemController, bool simulate) { }

	public void CallAchievementUnlockedEvent(string achId) { }

	public void CallLocationUnlockedEvent(IEnumerable locations) { }

	public bool CanHandoverItems(string conditionalId, MongoID conditionId, bool partialHandover = false) { }

	public override void CheckExitConditionCounters(ExitStatus exitStatus, float pastTime, string locationId, string exitName, HealthEffects effects, List zoneIds) { }

	public override void CheckHealthEffectsCounter(HealthEffects effects, string locationId, List zoneIds) { }

	[CanBeNull]
	private HitConditionCheck CheckHitConditionCounter(string target, List targetEquipment, Item weapon, EBodyPart bodyPart, float distance, string role, int hour, HealthEffects enemyEffects) { }

	public override void CheckKillConditionCounter(string target, string enemyProfileId, List targetEquipment, Item weapon, EBodyPart bodyPart, string locationId, float distance, string role, int hour, HealthEffects enemyEffects, HealthEffects effects, List zoneIds, string[] buffs) { }

	public void CheckMapTransitConditions(TransitController transitController) { }

	public override void CheckShootFlareCounter(string zoneID) { }

	public override void CheckShotConditionCounter(string target, string enemyProfileId, List targetEquipment, Item weapon, EBodyPart bodyPart, string locationId, float distance, string role, int hour, HealthEffects enemyEffects, HealthEffects effects, List zoneIds, string[] buffs) { }

	public override void CheckTriggerConditionCounter(string target, HealthEffects effects, string locationId) { }

	public void CheckUnderArtillery() { }

	public override void CheckUseItemCounter(string target, float count, string locationId, List zoneIds) { }

	protected abstract ConditionalBook CreateConditionalList() { }

	public override void Dispose() { }

	protected override bool get_CanFailConditionals() { }

	[CompilerGenerated]
	public ConditionalBook get_ConditionalBook() { }

	[CompilerGenerated]
	public ConditionsConnectorsManager get_ConditionsConnectorsManager() { }

	public override bool get_FromServer() { }

	protected override bool get_InRaid() { }

	public static Item[] GetItemsForCondition(Inventory inventory, ConditionItem condition, EPlayerItems source) { }

	public Item[] GetItemsForCondition(ConditionItem condition) { }

	private void IncreaseSellToTraderCounter(string traderId, string templateId, int count) { }

	public override void Init() { }

	protected abstract void InitConditionsConnectorsManager() { }

	protected override bool IsGroupQuestCounterEventEnabledForPartyRelay(EGroupQuestCounterEvent counterEvent) { }

	protected override void ManageConditional(TConditional conditional) { }

	protected override void ManageConditionsConnections(TConditional conditional) { }

	protected override void NotifyRewards(TConditional conditional, EQuestStatus status) { }

	protected override void OnConditionalStatusChangedEvent(TConditional conditional, bool notify) { }

	protected override void OnConditionValueChanged(TConditional conditional, EQuestStatus status, Condition condition, bool notify = true) { }

	private void QuestNoteHandler(TConditional conditional) { }

	protected override void RelayPartySharedConditionProgress(EGroupQuestCounterEvent counterEvent, int valueToAdd, ConditionCheck[] checks) { }

	[CompilerGenerated]
	public void remove_AchievementUnlocked(Action value) { }

	[CompilerGenerated]
	public void remove_LocationUnlocked(Action value) { }

	[CompilerGenerated]
	public void remove_OnConditionalStatusChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnTraderAssortmentChanged(Action value) { }

	private void RemovedConditionalHandlers(TConditional conditional) { }

	public void ResetCurrentNullableCounters() { }

	public override void Run() { }

	[CompilerGenerated]
	private void set_ConditionalBook(ConditionalBook value) { }

	[CompilerGenerated]
	protected void set_ConditionsConnectorsManager(ConditionsConnectorsManager value) { }

	public abstract void SetConditionalStatus(TConditional conditional, EQuestStatus status) { }

	private void ShowConditionChangedNotificationHandler(TConditional conditional) { }

	private void TestConditionsWithPartyRelay(EGroupQuestCounterEvent counterEvent, int valueToAdd, ConditionCheck[] checks) { }

	protected abstract void TryNotifyConditionalStatusChanged(TConditional conditional) { }

	protected abstract void TryNotifyConditionChanged(TConditional achievement) { }

	protected abstract Task TryToInstantComplete(TConditional conditional) { }

}

