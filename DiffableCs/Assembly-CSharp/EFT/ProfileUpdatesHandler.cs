namespace EFT;

public sealed class ProfileUpdatesHandler : IProfileUpdatesHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__27_0; //Field offset: 0x8
		public static Func <>9__27_3; //Field offset: 0x10
		public static Func <>9__27_4; //Field offset: 0x18
		public static Func <>9__27_1; //Field offset: 0x20
		public static Func <>9__27_2; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <ManageNewItems>b__27_0(ContainerCollection x) { }

		internal Dictionary <ManageNewItems>b__27_1(ContainerCollection x) { }

		internal bool <ManageNewItems>b__27_2(Item item) { }

		internal string <ManageNewItems>b__27_3(IContainer container) { }

		internal IContainer <ManageNewItems>b__27_4(IContainer container) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public string schemeId; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <ApplySchemeChanges>b__0(ProductionScheme scheme) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public Item topItem; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <ManageNewItems>b__5(FlatItem item) { }

	}

	private readonly Profile _profile; //Field offset: 0x10
	private readonly OfflineInventoryController _inventoryController; //Field offset: 0x18
	private readonly RagFair _ragFair; //Field offset: 0x20
	private readonly ItemFactory _itemFactory; //Field offset: 0x28
	private readonly HideoutRepresentation _hideout; //Field offset: 0x30
	[CanBeNull]
	private readonly QuestControllerClientBackend _questController; //Field offset: 0x38
	[CanBeNull]
	private readonly SeasonalRewardControllerClientBackend _seasonalRewardController; //Field offset: 0x40
	private readonly List _stashItems; //Field offset: 0x48

	private ProfileUpdatesHandler(Profile profile, OfflineInventoryController inventoryController, QuestControllerClientBackend questController, SeasonalRewardControllerClientBackend seasonalRewardController, RagFair ragFair) { }

	private void AddNewQuestNotes(IReadOnlyList noteIds) { }

	private void ApplyCompletableItemsChanges(Dictionary changedCompletable) { }

	private void ApplyExperience(int experience) { }

	private void ApplyMoneyTransferLimitData(TransferLimitsData limitsData) { }

	private void ApplyNewQuests(QuestTemplate[] quests) { }

	private void ApplyNewRepeatableQuests(RepeatableQuestsRange[] questRanges) { }

	private void ApplyPerkEffectParametersChanges(SeasonalPerkEffectParametersData parameters) { }

	private void ApplyPerksChanges(IReadOnlyCollection perkIds) { }

	private void ApplyQuestStatusData(QuestStatusData[] statuses) { }

	private void ApplySchemeChanges(Dictionary unlockedSchemes) { }

	private void ApplySeasonalRewardsChanges(Dictionary seasonalRewards) { }

	private void ApplySkillsChanges(SkillsDescriptor newSkills) { }

	private void ApplyStashChanges(StashChangesResponse stashChanges, Dictionary changesHideoutAreaStashes) { }

	private void ApplyTradersChanges(Dictionary tradersData) { }

	private void ApplyUniversalDocuments(Nullable docCount) { }

	private void ApplyVariableValues(Dictionary variableValues) { }

	public static void Bind(Profile profile, IEftSession backendSession, OfflineInventoryController inventoryController, QuestControllerClientBackend questController, SeasonalRewardControllerClientBackend seasonalRewardController = null) { }

	private override void EFT.IProfileUpdatesHandler.UpdateProfile(ProfileChanges changes) { }

	private void ManageChangedItems(List stashItems, FlatItem[] changedItems) { }

	private void ManageDeletedItems(List items, FlatItem[] deletedItems) { }

	private void ManageNewItems(FlatItem[] newItems) { }

}

