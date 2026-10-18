namespace EFT.Quests;

public abstract class ConditionsConnectorsManagerClientGame`1 : ConditionsConnectorsManagerClient
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public ConditionsConnectorsManagerClientGame <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public EQuestStatus status; //Field offset: 0x0
		public Condition condition; //Field offset: 0x0

		public <>c__DisplayClass5_0() { }

		internal double <ConnectServerCondition>b__0(ConditionProgressChecker _) { }

	}

	private readonly Dictionary _conditionsCurrentValues; //Field offset: 0x0
	private readonly ConditionalBook _conditionalBook; //Field offset: 0x0

	protected ConditionsConnectorsManagerClientGame`1(Profile profile, InventoryController inventoryController, ConditionalBook conditionalBook, QuestBook questBook, IQuestSession session) { }

	private void ConnectServerCondition(TConditional conditional, EQuestStatus status, Condition condition) { }

	private double GetConditionCurrentValue(TConditional conditional, EQuestStatus status, Condition condition) { }

	public virtual EPlayerItems GetPlayerItemSource(ConditionItem condition) { }

	protected virtual void InvokeConditionsConnector(TConditional conditional, EQuestStatus status, Condition condition) { }

	public virtual void SetConditionCurrentValue(Profile profile, TConditional conditional, Condition condition, double value, bool notify = true) { }

	public void SetConditionValueFromServer(int conditionalId, EQuestStatus status, MongoID conditionId, double value, bool notify = true) { }

}

