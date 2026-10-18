namespace EFT;

public abstract class FinalConditionChecks
{
	private sealed class EndingConditionsConnectors : ConditionsConnectorsManager, IDisposable
	{

		public EndingConditionsConnectors(Profile profile, InventoryController inventoryController, QuestBook questBook) { }

		public override void Dispose() { }

		public virtual EPlayerItems GetPlayerItemSource(ConditionItem condition) { }

		public virtual void SetConditionCurrentValue(Profile profile, TempConditional conditional, Condition condition, double value, bool notify = true) { }

	}

	private sealed class TempConditional : IConditional, IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__35_0; //Field offset: 0x8
			public static Func <>9__36_0; //Field offset: 0x10
			public static Func <>9__36_1; //Field offset: 0x18

			private static <>c() { }

			public <>c() { }

			internal IEnumerable <GetCondition>b__35_0(KeyValuePair collection) { }

			internal IEnumerable <GetVisibilityCondition>b__36_0(KeyValuePair collection) { }

			internal IEnumerable <GetVisibilityCondition>b__36_1(Condition x) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass35_0
		{
			public MongoID conditionId; //Field offset: 0x10

			public <>c__DisplayClass35_0() { }

			internal bool <GetCondition>b__1(Condition cond) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass36_0
		{
			public MongoID conditionId; //Field offset: 0x10

			public <>c__DisplayClass36_0() { }

			internal bool <GetVisibilityCondition>b__2(Condition cond) { }

		}

		[CompilerGenerated]
		private readonly string <Id>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly ConditionsDict <Conditions>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private readonly ConditionCounterManager <ConditionCountersManager>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private readonly Dictionary <ProgressCheckers>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private readonly CompletedConditionsCollection <CompletedConditions>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private EQuestStatus <QuestStatus>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private readonly bool <InstantComplete>k__BackingField; //Field offset: 0x3C
		[CompilerGenerated]
		private readonly Profile <Profile>k__BackingField; //Field offset: 0x40

		public override CompletedConditionsCollection CompletedConditions
		{
			[CompilerGenerated]
			 get { } //Length: 76
		}

		public override ConditionCounterManager ConditionCountersManager
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override ConditionsDict Conditions
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override EQuestStatus[] CurrentStatusTransitions
		{
			 get { } //Length: 88
		}

		public override string Id
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override bool InstantComplete
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override ETaskPlayerSide PlayerSide
		{
			 get { } //Length: 6
		}

		public Profile Profile
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override Dictionary ProgressCheckers
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public private override EQuestStatus QuestStatus
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public TempConditional(string id, Profile profile, ConditionsDict conditions) { }

		public override void CheckForStatusChange(bool fromServer, bool canFail, bool notify = true) { }

		public override bool CheckVisibilityStatus(Condition condition) { }

		public override void DisconnectConditions() { }

		public override void Dispose() { }

		[CompilerGenerated]
		public override CompletedConditionsCollection get_CompletedConditions() { }

		[CompilerGenerated]
		public override ConditionCounterManager get_ConditionCountersManager() { }

		[CompilerGenerated]
		public override ConditionsDict get_Conditions() { }

		public override EQuestStatus[] get_CurrentStatusTransitions() { }

		[CompilerGenerated]
		public override string get_Id() { }

		[CompilerGenerated]
		public override bool get_InstantComplete() { }

		public override ETaskPlayerSide get_PlayerSide() { }

		[CompilerGenerated]
		public Profile get_Profile() { }

		[CompilerGenerated]
		public override Dictionary get_ProgressCheckers() { }

		[CompilerGenerated]
		public override EQuestStatus get_QuestStatus() { }

		[CanBeNull]
		public override Condition GetCondition(MongoID conditionId) { }

		[CanBeNull]
		public override Condition GetVisibilityCondition(MongoID conditionId) { }

		public override bool IsConditionDone(Condition condition) { }

		public override bool IsDone() { }

		[CompilerGenerated]
		private void set_QuestStatus(EQuestStatus value) { }

		public override void SetStatus(EQuestStatus status, bool notify, bool fromServer) { }

	}


	protected FinalConditionChecks() { }

	public static bool TryGetEnding(IEftSession session, Profile profile, InventoryController inventoryController, QuestBook questBook, out EndingElement ending, out EFinalType finalType) { }

	public static bool TryParseEndingType(IPlayerProfileDataContainer profile, FinalsResponse finalsResponse, out EFinalType finalType) { }

	private static bool TryParseEndingType(string endingId, FinalsResponse finalsResponse, out EFinalType finalType) { }

}

