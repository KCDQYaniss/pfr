namespace EFT.UI.Insurance;

public sealed class InsuranceCompany : IAddHandler, IItemRelatedView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__29_0; //Field offset: 0x8
		public static Func <>9__33_0; //Field offset: 0x10
		public static Func <>9__37_0; //Field offset: 0x18
		public static Func <>9__37_1; //Field offset: 0x20
		public static Func <>9__39_0; //Field offset: 0x28
		public static Func <>9__39_1; //Field offset: 0x30
		public static Func <>9__41_2; //Field offset: 0x38
		public static Func <>9__56_0; //Field offset: 0x40
		public static Func <>9__56_1; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <get_AllItemsToInsure>b__29_0(InsuredItem x) { }

		internal string <GetInsurePriceAsync>b__56_0(Trader x) { }

		internal string <GetInsurePriceAsync>b__56_1(InsuredItem x) { }

		internal Item <GetItemChildren>b__37_0(Mod x) { }

		internal IEnumerable <GetItemChildren>b__37_1(IContainer x) { }

		internal Item <GetItemChildren>b__39_0(Slot x) { }

		internal IEnumerable <GetItemChildren>b__39_1(IContainer x) { }

		internal string <InsureItems>b__41_2(InsuredItem x) { }

		internal string <RegisterInsuredItems>b__33_0(InsuredProfileItems x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public InsurePrices selectedSummary; //Field offset: 0x10

		public <>c__DisplayClass35_0() { }

		internal bool <ItemsPrice>b__0(InsuredItem item) { }

		internal int <ItemsPrice>b__1(InsuredItem item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public InsuredItem item; //Field offset: 0x10
		public InsuranceCompany <>4__this; //Field offset: 0x18

		public <>c__DisplayClass40_0() { }

		internal bool <GetFlattenChildren>b__0(InsuredItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public InsuranceCompany <>4__this; //Field offset: 0x10
		public InsuredItem[] appropriateItems; //Field offset: 0x18
		public Trader insurer; //Field offset: 0x20
		public Callback callback; //Field offset: 0x28

		public <>c__DisplayClass41_0() { }

		internal bool <InsureItems>b__0(InsuredItem x) { }

		internal bool <InsureItems>b__1(InsuredItem x) { }

		internal void <InsureItems>b__3(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public Type itemType; //Field offset: 0x10

		public <>c__DisplayClass51_0() { }

		internal bool <ItemTypeAvailable>b__0(Type type) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public string itemId; //Field offset: 0x10

		public <>c__DisplayClass53_0() { }

		internal bool <Insured>b__0(InsuredItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public string itemId; //Field offset: 0x10

		public <>c__DisplayClass54_0() { }

		internal bool <InInsuranceQueue>b__0(InsuredItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public List newItems; //Field offset: 0x10
		public InsuranceCompany <>4__this; //Field offset: 0x18
		public Action callback; //Field offset: 0x20

		public <>c__DisplayClass56_0() { }

		internal void <GetInsurePriceAsync>b__2(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public string traderId; //Field offset: 0x10

		public <>c__DisplayClass57_0() { }

		internal bool <ProcessItem>b__0(Trader trader) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass58_0() { }

		internal bool <EFT.IAddHandler.OnItemAdded>b__0(InsuredProfileItems x) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__FindOrCreate; //Field offset: 0x0
		public static Func <1>__FindOrCreate; //Field offset: 0x8

	}

	internal enum EInsuranceError
	{
		NothingToInsure = 0,
		NotEnoughMoney = 1,
		InvalidItem = 2,
		NoPrices = 3,
	}

	internal sealed class InsuranceLogger : AbstractLogger
	{
		private static InsuranceLogger _instance; //Field offset: 0x0

		public static InsuranceLogger Instance
		{
			 get { } //Length: 311
		}

		private InsuranceLogger() { }

		public static InsuranceLogger get_Instance() { }

	}

	internal struct PriceData
	{
		public int Price; //Field offset: 0x0
		public Nullable Error; //Field offset: 0x4

		public PriceData(int price, Nullable error) { }

	}

	public const string ITEM_CAN_NOT_BE_INSURED = "Item is not available for insurance"; //Field offset: 0x0
	public static readonly Dictionary AllInsuredItemsTemplates; //Field offset: 0x0
	[CompilerGenerated]
	private readonly UpdatableBindableList <ItemsToInsure>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly UpdatableBindableList <InsuredItems>k__BackingField; //Field offset: 0x18
	private readonly Type[] _restrictedTypes; //Field offset: 0x20
	public readonly BindableEvent OnItemCovered; //Field offset: 0x28
	public readonly BindableEvent OnItemUncovered; //Field offset: 0x30
	public readonly BindableEvent OnItemInsured; //Field offset: 0x38
	public string SelectedInsurerId; //Field offset: 0x40
	private readonly ITradingSession _session; //Field offset: 0x48
	private readonly Profile _profile; //Field offset: 0x50
	public readonly InsureSummary InsureSummary; //Field offset: 0x58
	private List _missingInsuredItems; //Field offset: 0x60

	public List AllItemsToInsure
	{
		 get { } //Length: 492
	}

	public bool HasInsurers
	{
		 get { } //Length: 294
	}

	public UpdatableBindableList InsuredItems
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IEnumerable Insurers
	{
		 get { } //Length: 113
	}

	public UpdatableBindableList ItemsToInsure
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public InsuranceLogger Logger
	{
		 get { } //Length: 311
	}

	public PriceData OverallPrice
	{
		 get { } //Length: 1161
	}

	public Trader SelectedInsurer
	{
		 get { } //Length: 73
	}

	private static InsuranceCompany() { }

	public InsuranceCompany(ITradingSession session, Profile profile) { }

	private void AddChildrenRecursively(InsuredItem item) { }

	public void AddItemToInsuranceQueue(InsuredItem item, bool addChildren = true, bool playSound = true) { }

	public void AddItemToInsuranceQueue(Item item, bool addChildren, bool playSound) { }

	private bool CanAddToQueue(InsuredItem item) { }

	public void ClearInsuranceQueue() { }

	public void ClearInsuredItems() { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs arg) { }

	public bool Examined(Item item) { }

	public List get_AllItemsToInsure() { }

	public bool get_HasInsurers() { }

	[CompilerGenerated]
	public UpdatableBindableList get_InsuredItems() { }

	public IEnumerable get_Insurers() { }

	[CompilerGenerated]
	public UpdatableBindableList get_ItemsToInsure() { }

	public InsuranceLogger get_Logger() { }

	public PriceData get_OverallPrice() { }

	public Trader get_SelectedInsurer() { }

	public List GetFlattenChildren(InsuredItem item) { }

	public void GetInsurePriceAsync(IEnumerable items, Action callback) { }

	public List GetItemChildren(Item item) { }

	public List GetItemChildren(InsuredItem insuredItem) { }

	public int GetParentsCount(InsuredItem item, int count) { }

	public bool InInsuranceQueue(string itemId) { }

	public bool Insured(string itemId) { }

	public void InsureItems(List items, Callback callback) { }

	public int ItemsPrice(List items) { }

	private bool ItemTypeAvailable(Type itemType) { }

	public bool ItemTypeAvailableForInsurance(InsuredItem item) { }

	public bool ItemTypeAvailableForInsurance(Item item) { }

	private void ProcessItem(Dictionary traderToPrices, InsuredItem item) { }

	public void RegisterInsuredItems(IEnumerable insuredItems, IEnumerable playerItems) { }

	private InsuredItem RegisterSingleItem(InsuredProfileItems preinsuredItem, Item actualItem) { }

	public void RemoveItemFromInsuranceQueue(InsuredItem item, bool removeChildren = true) { }

	public void RemoveItemFromInsuranceQueue(Item item, bool removeChildren = true) { }

	public void UpdateInsuranceItemsPrices(IEnumerable items, Action callback) { }

}

