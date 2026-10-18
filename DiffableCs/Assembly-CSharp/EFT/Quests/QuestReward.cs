namespace EFT.Quests;

public class QuestReward
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public QuestReward <>4__this; //Field offset: 0x10
		public ReferenceGrid grid; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal FlatItem <GetItem>g__CloneFlatItem|0(FlatItem flatItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public QuestReward <>4__this; //Field offset: 0x10
		public Dictionary idCache; //Field offset: 0x18
		public Grid grid; //Field offset: 0x20

		public <>c__DisplayClass16_0() { }

		internal FlatItem <TryAppendClaimResults>g__CloneFlatItem|0(FlatItem flatItem) { }

	}

	public ERewardType type; //Field offset: 0x10
	public string target; //Field offset: 0x18
	public string traderId; //Field offset: 0x20
	public int loyaltyLevel; //Field offset: 0x28
	public float value; //Field offset: 0x2C
	public bool findInRaid; //Field offset: 0x30
	public FlatItem[] items; //Field offset: 0x38
	public bool unknown; //Field offset: 0x40
	public bool isImportant; //Field offset: 0x41
	public bool isDeliverByMail; //Field offset: 0x42
	private readonly MongoID _stashId; //Field offset: 0x48

	public QuestReward() { }

	public static void ApplyStandingsFromAccumulator(Dictionary standingsAccumulator, Profile profile) { }

	[CanBeNull]
	public Item GetItem() { }

	public void TryAddStandingToAccumulator(ref Dictionary standingsAccumulator) { }

	public void TryAddVariableToAccumulator(ref Dictionary variablesAccumulator) { }

	public void TryAddXPToAccumulator(ref float xpAccumulator) { }

	public OperationResult TryAppendClaimResults(ItemController itemController, List results, out int clonedCount) { }

}

