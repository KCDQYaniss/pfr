namespace EFT.Quests;

public abstract class ConditionsConnectorsManager`1
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_5; //Field offset: 0x0
		public static Func <>9__41_1; //Field offset: 0x0
		public static Func <>9__41_2; //Field offset: 0x0
		public static Func <>9__42_0; //Field offset: 0x0
		public static Func <>9__42_1; //Field offset: 0x0
		public static Func <>9__54_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal double <ConnectConditionQuest>b__17_5(ConditionProgressChecker _) { }

		internal string <HasMatchingTargets>b__42_0(string x) { }

		internal string <HasMatchingTargets>b__42_1(string x) { }

		internal IEnumerable <TestConditionsExcept>b__54_0(KeyValuePair x) { }

		internal bool <TryGetExternalItemCondition>b__41_1(Quest x) { }

		internal IEnumerable <TryGetExternalItemCondition>b__41_2(Quest x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0

		public <>c__DisplayClass13_0() { }

		internal double <SetDefaultConditionValueGetter>g__CurrentValueGetter|0(ConditionProgressChecker checker) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public TConditional conditional; //Field offset: 0x0
		public Predicate <>9__0; //Field offset: 0x0

		public <>c__DisplayClass16_0() { }

		internal bool <ManageConditionsConnections>b__0(TConditional data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public Quest conditionQuest; //Field offset: 0x0
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional quest; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public ConditionQuest condition; //Field offset: 0x0
		public ConditionProgressChecker conditionHandler; //Field offset: 0x0

		public <>c__DisplayClass17_0() { }

		internal double <ConnectConditionQuest>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionQuest>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionQuest>b__2(ConditionProgressChecker _) { }

		internal void <ConnectConditionQuest>b__6() { }

		internal float <ConnectConditionQuest>g__GetCurrentValue|3() { }

		internal void <ConnectConditionQuest>g__OnQuestStatusChanged|4(Quest _, bool __) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_1
	{
		public IEnumerator timer; //Field offset: 0x0

		public <>c__DisplayClass17_1() { }

		internal void <ConnectConditionQuest>b__7(ConditionProgressChecker _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public ConditionVisitPlace condition; //Field offset: 0x0

		public <>c__DisplayClass18_0() { }

		internal double <ConnectConditionVisitPlace>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionVisitPlace>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionVisitPlace>b__2(ConditionProgressChecker _) { }

		internal float <ConnectConditionVisitPlace>g__GetCurrentValue|3() { }

		internal void <ConnectConditionVisitPlace>g__OnCounterChanged|4(Identifier counter) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public ConditionLocationTrigger condition; //Field offset: 0x0

		public <>c__DisplayClass19_0() { }

		internal double <ConnectConditionLocationTrigger>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionLocationTrigger>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionLocationTrigger>b__2(ConditionProgressChecker _) { }

		internal float <ConnectConditionLocationTrigger>g__GetCurrentValue|3() { }

		internal void <ConnectConditionLocationTrigger>g__OnCounterChanged|4(Identifier counter) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public CountersCollection countersCollection; //Field offset: 0x0
		public ConditionSearchAndDestroy condition; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0

		public <>c__DisplayClass20_0() { }

		internal double <ConnectConditionSearchAndDestroy>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionSearchAndDestroy>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionSearchAndDestroy>b__2(ConditionProgressChecker _) { }

		internal int <ConnectConditionSearchAndDestroy>g__GetCurrentValue|3() { }

		internal void <ConnectConditionSearchAndDestroy>g__OnCounterChanged|4(Identifier counter) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public ConditionStatistic condition; //Field offset: 0x0
		public CountersCollection countersCollection; //Field offset: 0x0
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0

		public <>c__DisplayClass21_0() { }

		internal double <ConnectConditionStatistic>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionStatistic>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionStatistic>g__OnCounterChanged|2(Identifier counter) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public ConditionCompleteCondition condition; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0

		public <>c__DisplayClass22_0() { }

		internal double <ConnectConditionCompletedCondition>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionCompletedCondition>b__1(ConditionProgressChecker _) { }

		internal bool <ConnectConditionCompletedCondition>g__CheckConditionComplete|2() { }

		internal void <ConnectConditionCompletedCondition>g__ConditionChangeHandler|3(TConditional _, EQuestStatus __, Condition changedCondition, bool ___) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public ConditionExamineItem condition; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0

		public <>c__DisplayClass23_0() { }

		internal double <ConnectConditionExamineItem>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionExamineItem>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionExamineItem>g__ExamineHandler|2(MongoID itemId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public ConditionLaunchFlare condition; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0

		public <>c__DisplayClass24_0() { }

		internal double <ConnectConditionLaunchFlare>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionLaunchFlare>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionLaunchFlare>g__ExamineHandler|2(MongoID itemId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0`1
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditionZone condition; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public Func <>9__4; //Field offset: 0x0
		public Predicate <>9__5; //Field offset: 0x0

		public <>c__DisplayClass25_0`1() { }

		internal double <ConnectConditionLeaveItemAtLocation>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionLeaveItemAtLocation>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionLeaveItemAtLocation>b__2(ConditionProgressChecker _) { }

		internal bool <ConnectConditionLeaveItemAtLocation>b__4(DroppedItem x) { }

		internal bool <ConnectConditionLeaveItemAtLocation>b__5(DroppedItem x) { }

		internal void <ConnectConditionLeaveItemAtLocation>g__OnItemZoneDropped|3(string item, string zone) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public ConditionCompletableItem condition; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0

		public <>c__DisplayClass26_0() { }

		internal double <ConnectConditionCompletableItem>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionCompletableItem>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionCompletableItem>g__CompletableItemProgressChanged|2(MongoID templateId, bool completed) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public ConditionTraderStanding condition; //Field offset: 0x0

		public <>c__DisplayClass27_0() { }

		internal double <ConnectConditionTraderStanding>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionTraderStanding>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionTraderStanding>b__2(ConditionProgressChecker _) { }

		internal float <ConnectConditionTraderStanding>g__GetCurrentValue|3() { }

		internal void <ConnectConditionTraderStanding>g__OnTraderStandingChanged|4(TraderInfo traderInfo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public ConditionTraderLoyalty condition; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0

		public <>c__DisplayClass28_0() { }

		internal double <ConnectConditionTraderLoyalty>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionTraderLoyalty>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionTraderLoyalty>b__2(ConditionProgressChecker _) { }

		internal float <ConnectConditionTraderLoyalty>g__GetCurrentValue|3() { }

		internal void <ConnectConditionTraderLoyalty>g__OnTraderLoyaltyChanged|4(TraderInfo traderInfo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public TaskConditionCounter counter; //Field offset: 0x0
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public ConditionSellItemToTrader condition; //Field offset: 0x0

		public <>c__DisplayClass29_0() { }

		internal double <ConnectConditionSellItemToTrader>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionSellItemToTrader>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionSellItemToTrader>b__2(ConditionProgressChecker _) { }

		internal float <ConnectConditionSellItemToTrader>g__GetCurrentValue|3() { }

		internal void <ConnectConditionSellItemToTrader>g__OnCounterChanged|4(TaskConditionCounter taskConditionCounter) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public TaskConditionCounter counter; //Field offset: 0x0
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public ConditionCounterCreator condition; //Field offset: 0x0

		public <>c__DisplayClass30_0() { }

		internal double <ConnectConditionCounterCreator>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionCounterCreator>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionCounterCreator>b__2(ConditionProgressChecker _) { }

		internal float <ConnectConditionCounterCreator>g__GetCurrentValue|3() { }

		internal void <ConnectConditionCounterCreator>g__OnValueChanged|4(TaskConditionCounter _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public ConditionSkill condition; //Field offset: 0x0
		public Skill skill; //Field offset: 0x0

		public <>c__DisplayClass31_0() { }

		internal double <ConnectConditionSkill>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionSkill>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionSkill>b__2(ConditionProgressChecker _) { }

		internal float <ConnectConditionSkill>g__GetCurrentValue|3() { }

		internal void <ConnectConditionSkill>g__OnUserSkillChanged|4(BaseSkill baseSkill) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public ConditionLevel condition; //Field offset: 0x0

		public <>c__DisplayClass32_0() { }

		internal double <ConnectConditionLevel>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionLevel>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionLevel>b__2(ConditionProgressChecker _) { }

		internal float <ConnectConditionLevel>g__GetCurrentValue|3() { }

		internal void <ConnectConditionLevel>g__OnUserLevelChanged|4(int level, int diff) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public ConditionPrestigeLevel condition; //Field offset: 0x0

		public <>c__DisplayClass33_0() { }

		internal double <ConnectConditionPrestigeLevel>b__0(ConditionProgressChecker _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public ConditionSelectModifiers condition; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0

		public <>c__DisplayClass34_0() { }

		internal double <ConnectConditionSelectModifiers>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionSelectModifiers>b__1(ConditionProgressChecker _) { }

		internal int <ConnectConditionSelectModifiers>g__GetCurrentValue|2() { }

		internal void <ConnectConditionSelectModifiers>g__OnModifiersChanged|3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public ConditionGlobalVariableValue condition; //Field offset: 0x0

		public <>c__DisplayClass35_0() { }

		internal double <ConnectConditionGlobalVariableValue>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionGlobalVariableValue>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionGlobalVariableValue>b__2(ConditionProgressChecker _) { }

		internal float <ConnectConditionGlobalVariableValue>g__GetCurrentValue|3() { }

		internal void <ConnectConditionGlobalVariableValue>g__OnProfileVariableChanged|4(MongoID variableId, int variableValue) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public TaskConditionCounter counter; //Field offset: 0x0
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public ConditionHandoverItem condition; //Field offset: 0x0

		public <>c__DisplayClass36_0() { }

		internal double <ConnectConditionHandoverItem>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionHandoverItem>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionHandoverItem>b__2(ConditionProgressChecker _) { }

		internal float <ConnectConditionHandoverItem>g__GetCurrentValue|3() { }

		internal void <ConnectConditionHandoverItem>g__OnCounterChanged|4(TaskConditionCounter taskConditionCounter) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public ConditionFindItem condition; //Field offset: 0x0
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0

		public <>c__DisplayClass37_0() { }

		internal double <ConnectConditionFindItem>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionFindItem>b__2(ConditionProgressChecker _) { }

		internal void <ConnectConditionFindItem>b__3(ConditionProgressChecker _) { }

		internal void <ConnectConditionFindItem>g__ConditionChangeHandler|1(TConditional externalConditional, EQuestStatus _, Condition externalCondition, bool __) { }

		internal float <ConnectConditionFindItem>g__GetCurrentValue|4() { }

		internal void <ConnectConditionFindItem>g__OnAddItem|5(AddItemEventArgs eventArgs) { }

		internal void <ConnectConditionFindItem>g__OnRemoveItem|6(RemoveItemEventArgs eventArgs) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public TaskConditionCounter counter; //Field offset: 0x0
		public ConditionsConnectorsManager <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public ConditionWeaponAssembly condition; //Field offset: 0x0

		public <>c__DisplayClass38_0() { }

		internal double <ConnectConditionWeaponAssembly>b__0(ConditionProgressChecker _) { }

		internal void <ConnectConditionWeaponAssembly>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionWeaponAssembly>b__2(ConditionProgressChecker _) { }

		internal float <ConnectConditionWeaponAssembly>g__GetCurrentValue|3() { }

		internal void <ConnectConditionWeaponAssembly>g__OnCounterChanged|4(TaskConditionCounter taskConditionCounter) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public QuestBook questBook; //Field offset: 0x0
		public ConditionFindItem condition; //Field offset: 0x0
		public Func <>9__0; //Field offset: 0x0
		public Func <>9__4; //Field offset: 0x0
		public Func <>9__3; //Field offset: 0x0

		public <>c__DisplayClass41_0() { }

		internal Quest <TryGetExternalItemCondition>b__0(ConditionQuest x) { }

		internal IEnumerable <TryGetExternalItemCondition>b__3(KeyValuePair x) { }

		internal bool <TryGetExternalItemCondition>b__4(ConditionMultipleTargets questCondition) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public Condition exceptCondition; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0

		public <>c__DisplayClass54_0() { }

		internal bool <TestConditionsExcept>b__1(Condition x) { }

		internal bool <TestConditionsExcept>b__2(Condition condition) { }

	}

	[CompilerGenerated]
	private sealed class <GetItemsForConditionIEnumerable>d__44 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private Item <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private Inventory inventory; //Field offset: 0x0
		public Inventory <>3__inventory; //Field offset: 0x0
		private EPlayerItems source; //Field offset: 0x0
		public EPlayerItems <>3__source; //Field offset: 0x0
		private ConditionItem condition; //Field offset: 0x0
		public ConditionItem <>3__condition; //Field offset: 0x0
		private IBaseHandbook <handbook>5__2; //Field offset: 0x0
		private IEnumerator <>7__wrap2; //Field offset: 0x0

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetItemsForConditionIEnumerable>d__44(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class ConditionValueChangeDelegate : MulticastDelegate
	{

		public ConditionValueChangeDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TConditional conditional, EQuestStatus status, Condition condition, bool notify, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TConditional conditional, EQuestStatus status, Condition condition, bool notify) { }

	}

	[CompilerGenerated]
	private ConditionValueChangeDelegate OnConditionValueChanged; //Field offset: 0x0
	protected readonly Profile Profile; //Field offset: 0x0
	private readonly QuestBook _questBook; //Field offset: 0x0
	private readonly InventoryController _inventoryController; //Field offset: 0x0
	private readonly Dictionary _missedQuestsPendingConditions; //Field offset: 0x0

	public event ConditionValueChangeDelegate OnConditionValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected ConditionsConnectorsManager`1(Profile profile, InventoryController inventoryController, QuestBook questBook) { }

	[CompilerGenerated]
	public void add_OnConditionValueChanged(ConditionValueChangeDelegate value) { }

	private static bool CheckForValidParent(Item item) { }

	private static bool CheckItemPredicate(Inventory inventory, ConditionItem condition, Item currentItem) { }

	private static bool CheckRecodableComponent(Item item, ConditionItem conditionItem) { }

	public void ClearConditions(TConditional conditional) { }

	private void ConnectCondition(TConditional conditional, EQuestStatus status, Condition condition) { }

	private void ConnectConditionCompletableItem(TConditional conditional, EQuestStatus status, ConditionCompletableItem condition) { }

	private void ConnectConditionCompletedCondition(TConditional conditional, ConditionCompleteCondition condition, EQuestStatus status) { }

	private void ConnectConditionCounterCreator(TConditional conditional, EQuestStatus status, ConditionCounterCreator condition) { }

	private void ConnectConditionExamineItem(TConditional conditional, ConditionExamineItem condition, EQuestStatus status) { }

	private void ConnectConditionFindItem(TConditional conditional, EQuestStatus status, ConditionFindItem condition) { }

	private void ConnectConditionGlobalVariableValue(TConditional conditional, EQuestStatus status, ConditionGlobalVariableValue condition) { }

	private void ConnectConditionHandoverItem(TConditional conditional, EQuestStatus status, ConditionHandoverItem condition) { }

	private void ConnectConditionLaunchFlare(TConditional conditional, ConditionLaunchFlare condition, EQuestStatus status) { }

	private void ConnectConditionLeaveItemAtLocation(TConditional conditional, EQuestStatus status, TConditionZone condition) { }

	private void ConnectConditionLevel(TConditional conditional, EQuestStatus status, ConditionLevel condition) { }

	private void ConnectConditionLocationTrigger(TConditional conditional, EQuestStatus status, ConditionLocationTrigger condition) { }

	private void ConnectConditionPrestigeLevel(TConditional conditional, ConditionPrestigeLevel condition) { }

	private void ConnectConditionQuest(TConditional quest, EQuestStatus status, ConditionQuest condition) { }

	private void ConnectConditionSearchAndDestroy(TConditional conditional, EQuestStatus status, ConditionSearchAndDestroy condition) { }

	private void ConnectConditionSelectModifiers(TConditional conditional, EQuestStatus status, ConditionSelectModifiers condition) { }

	private void ConnectConditionSellItemToTrader(TConditional conditional, EQuestStatus status, ConditionSellItemToTrader condition) { }

	private void ConnectConditionSkill(TConditional conditional, EQuestStatus status, ConditionSkill condition) { }

	private void ConnectConditionStatistic(TConditional conditional, EQuestStatus status, ConditionStatistic condition) { }

	private void ConnectConditionTraderLoyalty(TConditional conditional, EQuestStatus status, ConditionTraderLoyalty condition) { }

	private void ConnectConditionTraderStanding(TConditional conditional, EQuestStatus status, ConditionTraderStanding condition) { }

	private void ConnectConditionVisitPlace(TConditional conditional, EQuestStatus status, ConditionVisitPlace condition) { }

	private void ConnectConditionWeaponAssembly(TConditional conditional, EQuestStatus status, ConditionWeaponAssembly condition) { }

	private static bool ContainsPass(Item item, ConditionItem condition, IBaseHandbook handbook) { }

	private static bool FindInItemPass(Item item, ConditionItem condition) { }

	private double FinishedValueGetter(TConditional conditional, ConditionProgressChecker checker) { }

	private void ForceReset(TConditional conditional, EQuestStatus status, Condition condition) { }

	protected override int GetFindItemConditionCount(TConditional conditional, ConditionFindItem condition) { }

	protected override int GetItemsForConditionCount(Inventory inventory, ConditionFindItem condition) { }

	[IteratorStateMachine(typeof(<GetItemsForConditionIEnumerable>d__44))]
	public static IEnumerable GetItemsForConditionIEnumerable(Inventory inventory, ConditionItem condition, EPlayerItems source) { }

	public abstract EPlayerItems GetPlayerItemSource(ConditionItem condition) { }

	private static bool HasLockedSelfOrMergedParent(Item item) { }

	private static bool HasMatchingTargets(ConditionFindItem itemCondition, ConditionMultipleTargets externalCondition) { }

	protected override void InvokeConditionsConnector(TConditional conditional, EQuestStatus status, Condition condition) { }

	public void InvokeConditionValueChanged(TConditional conditional, EQuestStatus status, Condition condition, bool notify) { }

	private static bool IsInLockedSlot(Item item) { }

	public static bool IsItemValidForCondition(Inventory inventory, ConditionItem condition, Item item, IBaseHandbook handbook) { }

	public void ManageConditionsConnections(TConditional conditional) { }

	[CompilerGenerated]
	public void remove_OnConditionValueChanged(ConditionValueChangeDelegate value) { }

	public abstract void SetConditionCurrentValue(Profile profile, TConditional conditional, Condition condition, double value, bool notify = true) { }

	public void SetDefaultConditionValueGetter(TConditional conditional) { }

	protected bool TestConditionsExcept(TConditional conditional, Condition exceptCondition) { }

	private static bool TryGetExternalItemCondition(QuestBook questBook, TConditional conditional, ConditionFindItem condition, bool forced, out ConditionMultipleTargets foundCondition) { }

	private static bool TryGetOwnParentCondition(TConditional conditional, ConditionFindItem condition, bool forced, out ConditionMultipleTargets foundCondition) { }

	private static bool VitalPartsAcceptable(Item item) { }

}

