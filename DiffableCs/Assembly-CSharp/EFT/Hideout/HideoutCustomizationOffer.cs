namespace EFT.Hideout;

public abstract class HideoutCustomizationOffer : IConditional
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__45_0; //Field offset: 0x8
		public static Func <>9__46_0; //Field offset: 0x10
		public static Func <>9__46_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <GetCondition>b__45_0(KeyValuePair collection) { }

		internal IEnumerable <GetVisibilityCondition>b__46_0(KeyValuePair collection) { }

		internal IEnumerable <GetVisibilityCondition>b__46_1(Condition x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public MongoID conditionId; //Field offset: 0x10

		public <>c__DisplayClass45_0() { }

		internal bool <GetCondition>b__1(Condition cond) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public MongoID conditionId; //Field offset: 0x10

		public <>c__DisplayClass46_0() { }

		internal bool <GetVisibilityCondition>b__2(Condition cond) { }

	}

	[JsonProperty("type")]
	public EHideoutCustomizationType Type; //Field offset: 0x10
	[JsonProperty("systemName")]
	public string SystemName; //Field offset: 0x18
	[JsonProperty("conditions")]
	private ConditionCollection _conditionCollection; //Field offset: 0x20
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ConditionsDict <Conditions>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly ConditionCounterManager <ConditionCountersManager>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Dictionary <ProgressCheckers>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly CompletedConditionsCollection <CompletedConditions>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private EQuestStatus <QuestStatus>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly EQuestStatus[] <CurrentStatusTransitions>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly ETaskPlayerSide <PlayerSide>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private readonly bool <InstantComplete>k__BackingField; //Field offset: 0x64

	public override CompletedConditionsCollection CompletedConditions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override ConditionCounterManager ConditionCountersManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private override ConditionsDict Conditions
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override EQuestStatus[] CurrentStatusTransitions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[JsonIgnore]
	public string Description
	{
		 get { } //Length: 171
	}

	[JsonProperty("id")]
	public private override string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override bool InstantComplete
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override ETaskPlayerSide PlayerSide
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public private override Dictionary ProgressCheckers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override EQuestStatus QuestStatus
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[JsonIgnore]
	public string Title
	{
		 get { } //Length: 171
	}

	protected HideoutCustomizationOffer() { }

	public override void CheckForStatusChange(bool fromServer, bool canFail, bool notify = true) { }

	public override bool CheckVisibilityStatus(Condition condition) { }

	public override void DisconnectConditions() { }

	[CompilerGenerated]
	public override CompletedConditionsCollection get_CompletedConditions() { }

	[CompilerGenerated]
	public override ConditionCounterManager get_ConditionCountersManager() { }

	[CompilerGenerated]
	public override ConditionsDict get_Conditions() { }

	[CompilerGenerated]
	public override EQuestStatus[] get_CurrentStatusTransitions() { }

	public string get_Description() { }

	[CompilerGenerated]
	public override string get_Id() { }

	[CompilerGenerated]
	public override bool get_InstantComplete() { }

	[CompilerGenerated]
	public override ETaskPlayerSide get_PlayerSide() { }

	[CompilerGenerated]
	public override Dictionary get_ProgressCheckers() { }

	[CompilerGenerated]
	public override EQuestStatus get_QuestStatus() { }

	public string get_Title() { }

	public override Condition GetCondition(MongoID conditionId) { }

	[CanBeNull]
	public override Condition GetVisibilityCondition(MongoID conditionId) { }

	public override bool IsConditionDone(Condition condition) { }

	public override bool IsDone() { }

	[OnDeserialized]
	private void OnDeserializing(StreamingContext context) { }

	[CompilerGenerated]
	private void set_Conditions(ConditionsDict value) { }

	[CompilerGenerated]
	private void set_Id(string value) { }

	[CompilerGenerated]
	private void set_ProgressCheckers(Dictionary value) { }

	[CompilerGenerated]
	private void set_QuestStatus(EQuestStatus value) { }

	public override void SetStatus(EQuestStatus status, bool notify, bool fromServer) { }

	protected void UpdateCompletedConditions(EQuestStatus status) { }

}

