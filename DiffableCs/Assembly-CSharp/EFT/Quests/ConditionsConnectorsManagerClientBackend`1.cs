namespace EFT.Quests;

public abstract class ConditionsConnectorsManagerClientBackend`1 : ConditionsConnectorsManagerClient
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public ConditionHideoutArea condition; //Field offset: 0x0
		public ConditionsConnectorsManagerClientBackend <>4__this; //Field offset: 0x0
		public HideoutRepresentation hideout; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public Func <>9__4; //Field offset: 0x0

		public <>c__DisplayClass5_0() { }

		internal bool <ConnectConditionHideoutArea>b__0(AreaInfo area) { }

		internal double <ConnectConditionHideoutArea>b__1(ConditionProgressChecker _) { }

		internal void <ConnectConditionHideoutArea>b__2(ConditionProgressChecker _) { }

		internal bool <ConnectConditionHideoutArea>b__4(AreaInfo area) { }

		internal void <ConnectConditionHideoutArea>g__OnAreaLevelChanged|3() { }

	}

	private readonly bool _isPveOffline; //Field offset: 0x0
	private readonly bool _inRaid; //Field offset: 0x0

	protected ConditionsConnectorsManagerClientBackend`1(Profile profile, InventoryController inventoryController, QuestBook questBook, IQuestSession session, bool inRaid) { }

	private void ConnectConditionHideoutArea(TConditional conditional, EQuestStatus status, ConditionHideoutArea condition) { }

	protected virtual int GetFindItemConditionCount(TConditional quest, ConditionFindItem condition) { }

	public virtual EPlayerItems GetPlayerItemSource(ConditionItem condition) { }

	protected virtual void InvokeConditionsConnector(TConditional conditional, EQuestStatus status, Condition condition) { }

	public virtual void SetConditionCurrentValue(Profile profile, TConditional conditional, Condition condition, double value, bool notify = true) { }

}

