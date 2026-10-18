namespace EFT.SeasonBP;

public sealed class BattlePassController : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__32_0; //Field offset: 0x8
		public static Func <>9__34_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <GetItemsCount>b__32_0(BattlePassItem item2) { }

		internal BattlePassDocumentScheme <TrySelectItems>b__34_0(BattlePassDocumentScheme doc) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public BattlePassData battlePassData; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <.ctor>b__0(BattlePassProgressData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public InventoryController inventoryController; //Field offset: 0x10
		public BattlePassController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass24_0() { }

		internal void <InitInventoryController>b__0() { }

		internal void <InitInventoryController>g__AddItemHandler|1(AddItemEventArgs args) { }

		internal void <InitInventoryController>g__RefreshItemHandler|3(RefreshItemEventArgs args) { }

		internal void <InitInventoryController>g__RemoveItemHandler|2(RemoveItemEventArgs args) { }

	}

	[IsReadOnly]
	internal struct BattlePassRewardDocumentHandover
	{
		public readonly BattlePassDocumentScheme Document; //Field offset: 0x0
		public readonly int RequiredCount; //Field offset: 0x8

		public BattlePassRewardDocumentHandover(BattlePassDocumentScheme document, int requiredCount) { }

	}

	[IsReadOnly]
	internal struct BattlePassRewardHandover
	{
		public readonly IReadOnlyDictionary Items; //Field offset: 0x0
		public readonly IReadOnlyCollection MissingDocuments; //Field offset: 0x8
		public readonly int UniversalDocuments; //Field offset: 0x10

		public BattlePassRewardHandover(IReadOnlyDictionary items, IReadOnlyCollection missingDocuments, int universalDocuments) { }

	}

	private readonly BindableEvent _onItemsChanged; //Field offset: 0x10
	private readonly BindableEvent _onItemsCountChanged; //Field offset: 0x18
	private readonly List _battlePasses; //Field offset: 0x20
	private readonly Dictionary _items; //Field offset: 0x28
	private readonly CompositeDisposable _unsubscriber; //Field offset: 0x30
	public readonly BindableState UniversalDocuments; //Field offset: 0x38
	[CompilerGenerated]
	private InventoryController <InventoryController>k__BackingField; //Field offset: 0x40
	public readonly BattlePassDocumentScheme UniversalDocument; //Field offset: 0x48

	public IEnumerable BattlePasses
	{
		 get { } //Length: 5
	}

	public private InventoryController InventoryController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public IBindableEvent OnItemsChanged
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnItemsCountChanged
	{
		 get { } //Length: 5
	}

	public BattlePassController(BattlePassConfig config, IReadOnlyCollection progressDataList, IReadOnlyDictionary limits, int universalDocuments) { }

	[CompilerGenerated]
	internal static bool <InitInventoryController>g__TryGetItem|24_4(ItemEventArgs args, out BattlePassItem item) { }

	private void AddItem(BattlePassItem item) { }

	public OperationResult BuyItemBattlePassItem(BattlePass battlePass, int exchangeCount, IReadOnlyDictionary itemsToHandover, bool simulate) { }

	public OperationResult ClaimBattlePassReward(BattlePassReward reward, int universalDocuments, IReadOnlyDictionary itemsToHandover, bool simulate) { }

	public override void Dispose() { }

	public OperationResult ExchangeBattlePassDocuments(BattlePass battlePass, BattlePassDocumentScheme documentScheme, int exchangeCount, IReadOnlyDictionary itemsToHandover, bool simulate) { }

	private Option ExpandItems(IReadOnlyDictionary itemsToHandover) { }

	public IEnumerable get_BattlePasses() { }

	[CompilerGenerated]
	public InventoryController get_InventoryController() { }

	public IBindableEvent get_OnItemsChanged() { }

	public IBindableEvent get_OnItemsCountChanged() { }

	public int GetDocumentCount(BattlePassDocumentScheme document) { }

	private int GetItemsCount(Item item) { }

	public IBindableList GetItemsList(MongoID templateId) { }

	public BattlePassRewardHandover GetRewardHandover(BattlePassReward reward) { }

	public void Init(InventoryController inventoryController) { }

	private void InitInventoryController(InventoryController inventoryController) { }

	private void RefreshItem(BattlePassItem item) { }

	private void RemoveItem(BattlePassItem item) { }

	private void SelectItems(Item sourceItem, int neededCount, Dictionary selectedItems) { }

	[CompilerGenerated]
	private void set_InventoryController(InventoryController value) { }

	public List ToDescriptor() { }

	public bool TrySelectDocumentItems(IEnumerable documents, out Dictionary items) { }

	private bool TrySelectItems(IEnumerable documents, out Dictionary selectedItems) { }

}

