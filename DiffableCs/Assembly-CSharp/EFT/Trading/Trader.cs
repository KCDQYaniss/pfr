namespace EFT.Trading;

public sealed class Trader : IDisposable, IRepairer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__50_0; //Field offset: 0x8
		public static Func <>9__50_1; //Field offset: 0x10
		public static Func <>9__50_2; //Field offset: 0x18
		public static Func <>9__66_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal AvailableCustomization <ApplyWear>b__66_0(MongoID suite) { }

		internal bool <GetAssortmentPrice>b__50_0(Nullable price) { }

		internal ItemPrice <GetAssortmentPrice>b__50_1(Nullable price) { }

		internal int <GetAssortmentPrice>b__50_2(ItemPrice price) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public Trader <>4__this; //Field offset: 0x10
		public string side; //Field offset: 0x18
		public TaskCompletionSource result; //Field offset: 0x20

		public <>c__DisplayClass64_0() { }

		internal void <GetOffers>b__0(Result offers) { }

	}

	[CompilerGenerated]
	private struct <ApplyWear>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomizationSuite[] customizationSuites; //Field offset: 0x20
		public Trader <>4__this; //Field offset: 0x28
		private IEftSession <session>5__2; //Field offset: 0x30
		private BodyCustomization <oldCustomization>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshAssortment>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Trader <>4__this; //Field offset: 0x20
		public bool createIfNotExists; //Field offset: 0x28
		public bool ignoreTimeout; //Field offset: 0x29
		private Task <initialAssortmentTask>5__2; //Field offset: 0x30
		private Result <supplyDataResult>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58
		private TaskAwaiter <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TransferItemsToArena>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Trader <>4__this; //Field offset: 0x20
		public ArenaEftTransferItem[] items; //Field offset: 0x28
		public int transferTax; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateAssortment>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Trader <>4__this; //Field offset: 0x20
		public bool ignoreTimeout; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[IsReadOnly]
	internal struct ItemPrice
	{
		public readonly Nullable CurrencyId; //Field offset: 0x0
		public readonly int Amount; //Field offset: 0x20

		public ItemPrice(Nullable currencyId, int amount) { }

	}

	public readonly BindableEvent AssortmentChanged; //Field offset: 0x10
	public readonly BindableEvent AssortmentLoadingChanged; //Field offset: 0x18
	public readonly ItemController TraderController; //Field offset: 0x20
	public readonly string Id; //Field offset: 0x28
	private readonly ITradingSession _trading; //Field offset: 0x30
	private DateTime _lastAssortmentUpdate; //Field offset: 0x38
	private float _lastClothingUpdate; //Field offset: 0x40
	private string _lastClothingSide; //Field offset: 0x48
	private CustomizationOffer[] _availableOffers; //Field offset: 0x50
	private SupplyData _supplyData; //Field offset: 0x58
	[CompilerGenerated]
	private Assortment <CurrentAssortment>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private readonly TraderSettings <Settings>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly TraderInfo <Info>k__BackingField; //Field offset: 0x70
	private Task _assortmentTask; //Field offset: 0x78
	private Task _pricesTask; //Field offset: 0x80
	private bool _disposed; //Field offset: 0x88

	public bool AssortmentLoading
	{
		 get { } //Length: 150
	}

	public bool AssortmentUpdateTimeout
	{
		 get { } //Length: 105
	}

	public override float CurrencyCoefficient
	{
		 get { } //Length: 37
	}

	private Dictionary CurrencyCourses
	{
		private get { } //Length: 27
	}

	public private Assortment CurrentAssortment
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public TimeSpan DelayBeforeAssortmentUpdate
	{
		 get { } //Length: 283
	}

	public TraderInfo Info
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string LocalizedName
	{
		 get { } //Length: 181
	}

	public override int LoyaltyLevel
	{
		 get { } //Length: 26
	}

	public override int MaxLoyaltyLevel
	{
		 get { } //Length: 29
	}

	public bool PricesLoaded
	{
		 get { } //Length: 9
	}

	public override string RepairerId
	{
		 get { } //Length: 5
	}

	public TraderSettings Settings
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override double Standing
	{
		 get { } //Length: 28
	}

	public override MongoID[] Targets
	{
		 get { } //Length: 36
	}

	public Trader(ITradingSession trading, TraderInfo traderInfo) { }

	[AsyncStateMachine(typeof(<ApplyWear>d__66))]
	public Task ApplyWear(CustomizationSuite[] customizationSuites) { }

	public void BuyWear(string offerId, IEnumerable requirements, Callback onFinished) { }

	public override void Dispose() { }

	public bool get_AssortmentLoading() { }

	public bool get_AssortmentUpdateTimeout() { }

	public override float get_CurrencyCoefficient() { }

	private Dictionary get_CurrencyCourses() { }

	[CompilerGenerated]
	public Assortment get_CurrentAssortment() { }

	public TimeSpan get_DelayBeforeAssortmentUpdate() { }

	[CompilerGenerated]
	public TraderInfo get_Info() { }

	public override string get_LocalizedName() { }

	public override int get_LoyaltyLevel() { }

	public override int get_MaxLoyaltyLevel() { }

	public bool get_PricesLoaded() { }

	public override string get_RepairerId() { }

	[CompilerGenerated]
	public TraderSettings get_Settings() { }

	public override double get_Standing() { }

	public override MongoID[] get_Targets() { }

	public Task GetAllOffers() { }

	public override Task GetAndAssignAvatar(Image image, CancellationToken cancellationToken) { }

	public Nullable GetAssortmentPrice(Stash stash) { }

	public override Vector2 GetDegradationValues(RepairableComponent repairable, Item item) { }

	public virtual int GetHashCode() { }

	public int GetItemPriceOnScavSell(Item item, bool allowProhibited) { }

	public Task GetOffers(EPlayerSide side) { }

	private Task GetOffers(string side) { }

	public override double GetRepairPriceCoefficient(Item item) { }

	public override float GetRepairQuality(Item item) { }

	private string GetSideStr(bool usec, bool bear) { }

	public Nullable GetUserItemPrice(Item item) { }

	public void InsureItems(string[] items, Callback callback) { }

	private Task LoadAvatar() { }

	[AsyncStateMachine(typeof(<RefreshAssortment>d__57))]
	public Task RefreshAssortment(bool createIfNotExists, bool ignoreTimeout) { }

	public override Task RepairItems(RepairItem repairItem, RepairKit draggedRepairKit) { }

	public void ResetAssortmentTimeout() { }

	[CompilerGenerated]
	private void set_CurrentAssortment(Assortment value) { }

	[AsyncStateMachine(typeof(<TransferItemsToArena>d__56))]
	public Task TransferItemsToArena(ArenaEftTransferItem[] items, int transferTax) { }

	public override bool TryGetEnhancementChance(Item item, float receiveDurabilityPercent, out double enhancementChance) { }

	[AsyncStateMachine(typeof(<UpdateAssortment>d__67))]
	public Task UpdateAssortment(bool ignoreTimeout) { }

}

