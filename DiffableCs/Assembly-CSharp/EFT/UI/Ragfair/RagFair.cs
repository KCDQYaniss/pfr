namespace EFT.UI.Ragfair;

public sealed class RagFair
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__160_0; //Field offset: 0x8
		public static Func <>9__160_1; //Field offset: 0x10
		public static Func <>9__163_0; //Field offset: 0x18
		public static Func <>9__163_2; //Field offset: 0x20
		public static Func <>9__163_3; //Field offset: 0x28
		public static Func <>9__163_4; //Field offset: 0x30
		public static Func <>9__179_0; //Field offset: 0x38
		public static Func <>9__180_0; //Field offset: 0x40
		public static Func <>9__180_1; //Field offset: 0x48
		public static Func <>9__180_2; //Field offset: 0x50
		public static Func <>9__180_3; //Field offset: 0x58
		public static Func <>9__180_4; //Field offset: 0x60
		public static Func <>9__180_5; //Field offset: 0x68
		public static Func <>9__180_6; //Field offset: 0x70
		public static Func <>9__180_7; //Field offset: 0x78
		public static Func <>9__180_8; //Field offset: 0x80
		public static Func <>9__180_9; //Field offset: 0x88
		public static Func <>9__180_10; //Field offset: 0x90
		public static Func <>9__180_11; //Field offset: 0x98
		public static Func <>9__197_0; //Field offset: 0xA0
		public static Func <>9__210_0; //Field offset: 0xA8
		public static Func <>9__213_1; //Field offset: 0xB0
		public static Func <>9__222_0; //Field offset: 0xB8
		public static Func <>9__222_1; //Field offset: 0xC0
		public static Func <>9__224_0; //Field offset: 0xC8
		public static Func <>9__224_1; //Field offset: 0xD0
		public static Func <>9__224_2; //Field offset: 0xD8

		private static <>c() { }

		public <>c() { }

		internal bool <ClearWishListCache>b__210_0(FilterRule key) { }

		internal bool <FilterNodes>b__179_0(Offer x) { }

		internal int <OnFilterRemoved>b__224_0(KeyValuePair x) { }

		internal string <OnFilterRemoved>b__224_1(KeyValuePair x) { }

		internal bool <OnFilterRemoved>b__224_2(KeyValuePair x) { }

		internal string <OrderOffers>b__180_0(Offer x) { }

		internal string <OrderOffers>b__180_1(Offer x) { }

		internal DateTime <OrderOffers>b__180_10(Offer x) { }

		internal DateTime <OrderOffers>b__180_11(Offer x) { }

		internal bool <OrderOffers>b__180_2(Offer x) { }

		internal bool <OrderOffers>b__180_3(Offer x) { }

		internal string <OrderOffers>b__180_4(Offer x) { }

		internal int <OrderOffers>b__180_5(Offer x) { }

		internal string <OrderOffers>b__180_6(Offer x) { }

		internal int <OrderOffers>b__180_7(Offer x) { }

		internal int <OrderOffers>b__180_8(Offer x) { }

		internal int <OrderOffers>b__180_9(Offer x) { }

		internal string <Purchase>b__197_0(CommodityToPurchase x) { }

		internal bool <RemoveCancellableFilter>b__213_1(CancellableFilter foundFilter) { }

		internal bool <SetSearches>b__222_0(RagfairSearch search) { }

		internal bool <SetSearches>b__222_1(RagfairSearch search) { }

		internal float <UpdateSettings>b__160_0(OfferCount x) { }

		internal float <UpdateSettings>b__160_1(OfferCount x) { }

		internal IEnumerable <UpdateWishlist>b__163_0(HandbookNode x) { }

		internal HandbookNode <UpdateWishlist>b__163_2(HandbookNode x) { }

		internal string <UpdateWishlist>b__163_3(HandbookNode x) { }

		internal HandbookNode <UpdateWishlist>b__163_4(HandbookNode x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass162_0
	{
		public NotificationRagfairOfferSold <offerSold>5__2; //Field offset: 0x10

		public <>c__DisplayClass162_0() { }

		internal bool <NotificationReceivedHandler>b__0(Offer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass163_0
	{
		public IReadOnlyDictionary wishlist; //Field offset: 0x10
		public RagFair <>4__this; //Field offset: 0x18

		public <>c__DisplayClass163_0() { }

		internal bool <UpdateWishlist>b__1(HandbookNode y) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass168_0
	{
		public List ragfairSearches; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass172_0
	{
		public string templateId; //Field offset: 0x10

		public <>c__DisplayClass172_0() { }

		internal bool <ProceedWithOffers>b__0(Offer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass196_0
	{
		public Action prices; //Field offset: 0x10

		public <>c__DisplayClass196_0() { }

		internal void <GetMarketPrices>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass199_0
	{
		public RagFair <>4__this; //Field offset: 0x10
		public Action callback; //Field offset: 0x18

		public <>c__DisplayClass199_0() { }

		internal void <AddOffer>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass200_0
	{
		public string offerId; //Field offset: 0x10

		public <>c__DisplayClass200_0() { }

		internal bool <RemoveOfferFromList>b__0(Offer x) { }

		internal bool <RemoveOfferFromList>b__1(Offer x) { }

		internal bool <RemoveOfferFromList>b__2(Offer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass201_0
	{
		public RagFair <>4__this; //Field offset: 0x10
		public Offer offer; //Field offset: 0x18

		public <>c__DisplayClass201_0() { }

		internal void <RemoveOffer>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass202_0
	{
		public RagFair <>4__this; //Field offset: 0x10
		public Offer offer; //Field offset: 0x18
		public DateTime oldEndTime; //Field offset: 0x20

		public <>c__DisplayClass202_0() { }

		internal void <RenewOffer>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass212_0
	{
		public RagFair <>4__this; //Field offset: 0x10
		public EFilterType type; //Field offset: 0x18

		public <>c__DisplayClass212_0() { }

		internal void <AddCancellableFilter>b__0(CancellableFilter filter, bool sendCallback) { }

		internal bool <AddCancellableFilter>b__1(CancellableFilter x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass212_1
	{
		public EFilterType item; //Field offset: 0x10

		public <>c__DisplayClass212_1() { }

		internal bool <AddCancellableFilter>b__2(CancellableFilter x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass213_0
	{
		public EFilterType item; //Field offset: 0x10

		public <>c__DisplayClass213_0() { }

		internal bool <RemoveCancellableFilter>b__2(CancellableFilter x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass222_0
	{
		public object value; //Field offset: 0x10
		public RagFair <>4__this; //Field offset: 0x18

		public <>c__DisplayClass222_0() { }

		internal void <SetSearches>g__ManageFoundOffer|2(Offer offer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass222_1
	{
		public long longId; //Field offset: 0x10
		public FilterRule ruleToApply; //Field offset: 0x18
		public <>c__DisplayClass222_0 CS$<>8__locals1; //Field offset: 0x90

		public <>c__DisplayClass222_1() { }

		internal void <SetSearches>b__3(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass222_2
	{
		public RagfairSearch filter; //Field offset: 0x10

		public <>c__DisplayClass222_2() { }

		internal bool <SetSearches>b__4(CancellableFilter x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass227_0
	{
		public float rating; //Field offset: 0x10

		public <>c__DisplayClass227_0() { }

		internal bool <GetMaxOffersCount>b__0(OfferCount x) { }

	}

	[CompilerGenerated]
	private struct <ExpirationAwaiter>d__195 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RagFair <>4__this; //Field offset: 0x20
		public float timeSeconds; //Field offset: 0x28
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetOffers>d__171 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RagFair <>4__this; //Field offset: 0x20
		public FilterRule filterRule; //Field offset: 0x28
		public bool updateCategories; //Field offset: 0xA0
		private bool <updateOffersCount>5__2; //Field offset: 0xA1
		private Result <getOffersResult>5__3; //Field offset: 0xA8
		private TaskAwaiter <>u__1; //Field offset: 0xC0
		private YieldAwaiter <>u__2; //Field offset: 0xC8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PurchaseInternal>d__198 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RagFair <>4__this; //Field offset: 0x20
		public CommoditiesToPurchase purchases; //Field offset: 0x28
		public string[] offerIds; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartHourTimer>d__194 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Offer timeOffer; //Field offset: 0x20
		public RagFair <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartZeroTimer>d__193 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Offer offer; //Field offset: 0x20
		public RagFair <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class Cache : Dictionary
	{

		public Cache() { }

		public void Remove(string offerId) { }

	}

	private sealed class CachedRagfairInfo
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			public string offerId; //Field offset: 0x10

			public <>c__DisplayClass5_0() { }

			internal bool <TryRemove>b__0(Offer x) { }

		}

		public readonly Dictionary Categories; //Field offset: 0x10
		[CompilerGenerated]
		private readonly List <OffersList>k__BackingField; //Field offset: 0x18

		public List OffersList
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public CachedRagfairInfo(List offers, Dictionary categories) { }

		[CompilerGenerated]
		public List get_OffersList() { }

		public void TryRemove(string offerId) { }

	}

	internal enum ERagFairStatus
	{
		Available = 0,
		Disabled = 1,
		LevelCapped = 2,
		Banned = 3,
	}

	internal enum ESetFilterSource
	{
		FilterWindow = 0,
		IdSelected = 1,
	}

	internal enum EUpdatePagesStatus
	{
		Default = 0,
		DoNotUpdate = -1,
		DoNotUpdateCached = -2,
	}

	private const string RAGFAIR_TRADER_OFFERS_ONLY_FORCED = "Ragfair/AddOfferBlockedByPerk{0}"; //Field offset: 0x0
	private const string DEFAULT_FILTER_SAVED_NAME = "DefaultFilterRule"; //Field offset: 0x0
	public const string NOT_ENOUGH_MONEY_HEADER = "ragfair/Not enough money"; //Field offset: 0x0
	public const string LOCK_BY_LEVEL_HINT = "ragfair/UnlockAtLevel{0}"; //Field offset: 0x0
	public const string LOCK_BY_LEVEL_ATTRIBUTE = "ragfair/UnlockAtLevelAttribute"; //Field offset: 0x0
	public const string NOT_FOR_RAGFAIR = "ragfair/This item cannot be placed at ragfair"; //Field offset: 0x0
	public const string NOT_FOR_SELL = "ragfair/NotForSell"; //Field offset: 0x0
	[CompilerGenerated]
	private static RagfairSettings <Settings>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static RagfairIconsLoader <IconsLoader>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Action OnOfferSelected; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnSelectedOffersCleared; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnMoneySpend; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnFilterRuleChanged; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnOfferProcessing; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnPurchaseProcessing; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnYourOfferSold; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnGettingOffersProcessing; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnRagfairSearch; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnFindById; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnRatingUpdated; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnNodePriceUpdated; //Field offset: 0x68
	[CompilerGenerated]
	private Action OnOfferRemoved; //Field offset: 0x70
	public readonly CancellableFilters CancellableFilters; //Field offset: 0x78
	private readonly Dictionary _errorKeys; //Field offset: 0x80
	public readonly FilterRule DefaultFilterRule; //Field offset: 0x88
	private readonly FilterRule _weaponBuildsFilterRule; //Field offset: 0x100
	public readonly FilterRule WishListFilterRule; //Field offset: 0x178
	private readonly FilterRule _myOffersFilterRule; //Field offset: 0x1F0
	public readonly BindableEvent OnFilteredOffersCountChanged; //Field offset: 0x268
	public readonly BindableEvent OnStatusChanged; //Field offset: 0x270
	private readonly List _selectedOffers; //Field offset: 0x278
	private readonly Cache _cachedInfo; //Field offset: 0x280
	private readonly IEftSession _session; //Field offset: 0x288
	private readonly Dictionary _defaultRules; //Field offset: 0x290
	private readonly Dictionary _savedRules; //Field offset: 0x298
	public OffersWithNodes Offers; //Field offset: 0x2A0
	public OffersWithNodes MyOffersFiltered; //Field offset: 0x2A8
	public OffersWithNodes WeaponBuildsFiltered; //Field offset: 0x2B0
	public readonly Dictionary LastSelectedIds; //Field offset: 0x2B8
	public bool ForceNextUpdate; //Field offset: 0x2C0
	private Profile _profile; //Field offset: 0x2C8
	private Handbook _handbook; //Field offset: 0x2D0
	private FilterRule _previousRule; //Field offset: 0x2D8
	private string _backEndSelectedCategory; //Field offset: 0x350
	private WishlistManager _wishlistManager; //Field offset: 0x358
	private bool _uiStateWarmed; //Field offset: 0x360
	private CancellationTokenSource _offerCancelTokenSource; //Field offset: 0x368
	[CompilerGenerated]
	private ERagFairStatus <Status>k__BackingField; //Field offset: 0x370
	[CompilerGenerated]
	private int <OffersPerPageCount>k__BackingField; //Field offset: 0x374
	[CompilerGenerated]
	private bool <IsRatingGrowing>k__BackingField; //Field offset: 0x378
	[CompilerGenerated]
	private List <WeaponBuilds>k__BackingField; //Field offset: 0x380
	[CompilerGenerated]
	private HandbookNodes <Wishlist>k__BackingField; //Field offset: 0x388
	[CompilerGenerated]
	private FilterRule <FilterRule>k__BackingField; //Field offset: 0x390
	[CompilerGenerated]
	private bool <GettingOffers>k__BackingField; //Field offset: 0x408
	[CompilerGenerated]
	private bool <UpdatingCategories>k__BackingField; //Field offset: 0x409
	[CompilerGenerated]
	private bool <IsPurchaseInProgress>k__BackingField; //Field offset: 0x40A
	[CompilerGenerated]
	private List <MyOffers>k__BackingField; //Field offset: 0x410
	private float _myRating; //Field offset: 0x418

	public event Action OnFilterRuleChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnFindById
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnGettingOffersProcessing
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnMoneySpend
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnNodePriceUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnOfferProcessing
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnOfferRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnOfferSelected
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnPurchaseProcessing
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnRagfairSearch
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnRatingUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSelectedOffersCleared
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnYourOfferSold
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool Available
	{
		 get { } //Length: 11
	}

	public string CategoryName
	{
		 get { } //Length: 559
	}

	public bool Disabled
	{
		 get { } //Length: 11
	}

	public private FilterRule FilterRule
	{
		[CompilerGenerated]
		 get { } //Length: 93
		[CompilerGenerated]
		private set { } //Length: 164
	}

	public private bool GettingOffers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool HasMinLevel
	{
		 get { } //Length: 196
	}

	public private static RagfairIconsLoader IconsLoader
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		private set { } //Length: 183
	}

	public bool IsBuildFilterActive
	{
		 get { } //Length: 42
	}

	public private bool IsPurchaseInProgress
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IsRatingGrowing
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public int MaxOffersCount
	{
		 get { } //Length: 16
	}

	private List MyOffers
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int MyOffersCount
	{
		 get { } //Length: 68
	}

	public private float MyRating
	{
		 get { } //Length: 9
		private set { } //Length: 193
	}

	public private int OffersPerPageCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public static Color RagfiarAttributeColor
	{
		 get { } //Length: 31
	}

	public private static RagfairSettings Settings
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		private set { } //Length: 167
	}

	public private ERagFairStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool TraderOffersOnlyForced
	{
		 get { } //Length: 188
	}

	public string TraderOffersOnlyForcedTooltip
	{
		 get { } //Length: 483
	}

	public ITradingSession TradingSession
	{
		 get { } //Length: 8
	}

	public private bool UpdatingCategories
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private List WeaponBuilds
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private HandbookNodes Wishlist
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static RagFair() { }

	public RagFair(IEftSession session) { }

	[CompilerGenerated]
	private void <.ctor>b__150_0(int x) { }

	[CompilerGenerated]
	internal static void <AddSearchesInRule>g__AddSearch|168_0(EFilterType type, int value, int defaultValue, ref <>c__DisplayClass168_0 unnamed_param_3) { }

	[CompilerGenerated]
	private bool <get_CategoryName>b__145_0(HandbookData category) { }

	[CompilerGenerated]
	private bool <IsOfferAcceptable>b__181_0(IExchangeRequirement x) { }

	[CompilerGenerated]
	private void <RefreshItemPrices>b__225_0(Result prices) { }

	[CompilerGenerated]
	private CancellableFilter <RemoveCancellableFilter>b__213_0(EFilterType item) { }

	[CompilerGenerated]
	private void <WarmupUiState>b__161_0(int _, int _) { }

	[CompilerGenerated]
	private void <WarmupUiState>b__161_1(EBanType banType) { }

	[CompilerGenerated]
	public void add_OnFilterRuleChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnFindById(Action value) { }

	[CompilerGenerated]
	public void add_OnGettingOffersProcessing(Action value) { }

	[CompilerGenerated]
	public void add_OnMoneySpend(Action value) { }

	[CompilerGenerated]
	public void add_OnNodePriceUpdated(Action value) { }

	[CompilerGenerated]
	public void add_OnOfferProcessing(Action value) { }

	[CompilerGenerated]
	public void add_OnOfferRemoved(Action value) { }

	[CompilerGenerated]
	public void add_OnOfferSelected(Action value) { }

	[CompilerGenerated]
	public void add_OnPurchaseProcessing(Action value) { }

	[CompilerGenerated]
	public void add_OnRagfairSearch(Action value) { }

	[CompilerGenerated]
	public void add_OnRatingUpdated(Action value) { }

	[CompilerGenerated]
	public void add_OnSelectedOffersCleared(Action value) { }

	[CompilerGenerated]
	public void add_OnYourOfferSold(Action value) { }

	private void AddCancellableFilter(EFilterType type, string name) { }

	public void AddMyOffers(Offer[] offers) { }

	public void AddOffer(bool sellInOnePiece, string[] items, BarterTemplate[] requirements, Action callback) { }

	public void AddSearchesInRule(FilterRule rule, bool setRule) { }

	public void AddToWishList(string id) { }

	public void ApplyRule(EViewListType listType) { }

	private void BeginPurchaseProcessing() { }

	public bool CanBeSelectedAtRagfair(Item item, ItemController itemController, out string error) { }

	public static bool CanUseForBarterExchange(Item item) { }

	public static bool CanUseForBarterExchange(Item item, out string error) { }

	public void ClearCachedInfo() { }

	public void ClearOffers() { }

	private void ClearOfferTimers() { }

	public void ClearSavedFilters() { }

	private void ClearWishListCache() { }

	private OffersWithNodes CreateOffersWithNodes() { }

	private void DeselectOffer(Offer offer) { }

	private void EndPurchaseProcessing() { }

	[AsyncStateMachine(typeof(<ExpirationAwaiter>d__195))]
	private Task ExpirationAwaiter(float timeSeconds) { }

	public void ExternalRagfairSearch(RagfairSearch search) { }

	public void FilterMyOffers() { }

	private void FilterNodes(EViewListType type, OffersWithNodes filteredList, List cachedNodes) { }

	public void FilterWeaponBuildOffers() { }

	public void ForceSetFilterRule(FilterRule newRule) { }

	public bool get_Available() { }

	public string get_CategoryName() { }

	public bool get_Disabled() { }

	[CompilerGenerated]
	public FilterRule get_FilterRule() { }

	[CompilerGenerated]
	public bool get_GettingOffers() { }

	public bool get_HasMinLevel() { }

	[CompilerGenerated]
	public static RagfairIconsLoader get_IconsLoader() { }

	public bool get_IsBuildFilterActive() { }

	[CompilerGenerated]
	public bool get_IsPurchaseInProgress() { }

	[CompilerGenerated]
	public bool get_IsRatingGrowing() { }

	public int get_MaxOffersCount() { }

	[CompilerGenerated]
	private List get_MyOffers() { }

	public int get_MyOffersCount() { }

	public float get_MyRating() { }

	[CompilerGenerated]
	public int get_OffersPerPageCount() { }

	public static Color get_RagfiarAttributeColor() { }

	[CompilerGenerated]
	public static RagfairSettings get_Settings() { }

	[CompilerGenerated]
	public ERagFairStatus get_Status() { }

	public bool get_TraderOffersOnlyForced() { }

	public string get_TraderOffersOnlyForcedTooltip() { }

	public ITradingSession get_TradingSession() { }

	[CompilerGenerated]
	public bool get_UpdatingCategories() { }

	[CompilerGenerated]
	public List get_WeaponBuilds() { }

	[CompilerGenerated]
	public HandbookNodes get_Wishlist() { }

	public static string GetAddOffersTempDisabledText() { }

	private static string GetFilterName(EViewListType viewListType) { }

	public string GetFormattedStatusDescription() { }

	public static string GetLocalizedLevelLockHint(int level) { }

	public void GetMarketPrices(string templateId, Action prices) { }

	public int GetMaxOffersCount(float rating) { }

	public OffersWithNodes GetMyOffersFiltered() { }

	[AsyncStateMachine(typeof(<GetOffers>d__171))]
	public Task GetOffers(bool updateCategories, FilterRule filterRule) { }

	private FilterRule GetPreferredRule(EViewListType viewListType) { }

	public string GetRawStatusDescription() { }

	private string GetStatusDescription(bool formatted) { }

	public OffersWithNodes GetWeaponBuildsFiltered() { }

	private void HandleDefaultFilter(EViewListType viewListType) { }

	private void HandleNewOffers(ICollection newOffers, bool updateCategories, bool updateOffersCount, Dictionary newCategories) { }

	public static bool IsAddOffersTemporaryDisabled() { }

	public bool IsCategoryOrItemLockedByLevel(string id, out int unlockLevel) { }

	public static bool IsCategoryOrItemLockedByLevel(string id, int playerLevel, Handbook handbook, out int level) { }

	public static bool IsCategoryOrItemLockedByLevelRecursive(string id, int playerLevel, Handbook handbook, out int unlockLevel) { }

	public bool IsCategoryOrItemLockedByLevelRecursive(string id, out int unlockLevel) { }

	private bool IsForcedTraderOffersFilter(EFilterType type) { }

	public bool IsItemOrChildLockedByLevelRecursive(Item item, out int unlockLevel) { }

	public static bool IsItemOrChildLockedByLevelRecursive(Item item, int playerLevel, Handbook handbook, out int unlockLevel) { }

	private bool IsOfferAcceptable(Offer offer) { }

	public bool IsSelected(Offer offer) { }

	private FilterRule NormalizeFilterRule(FilterRule rule) { }

	private void NotificationReceivedHandler(Notification notification) { }

	public bool OfferAlreadyReported(long offerId) { }

	public void OfferSold(Offer offer, int count, string handbookId) { }

	private FilterRule OnFilterRemoved(EFilterType filterType, FilterRule resetRule, bool sendCallback, bool displayChange = true) { }

	private IEnumerable OrderOffers(IOrderedEnumerable offers) { }

	private void ProceedOffersErrors(Result result) { }

	private ValueTuple ProceedWithOffers(OffersList result, Dictionary buildItems, bool updateCategories, bool updateOffersCount) { }

	private void ProcessOffer(IEnumerable offerIds, bool value) { }

	private void ProcessOffer(string offerId, bool value) { }

	public Task Purchase(CommoditiesToPurchase purchases) { }

	[AsyncStateMachine(typeof(<PurchaseInternal>d__198))]
	private Task PurchaseInternal(CommoditiesToPurchase purchases, string[] offerIds) { }

	public void RefreshItemPrices() { }

	[CompilerGenerated]
	public void remove_OnFilterRuleChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnFindById(Action value) { }

	[CompilerGenerated]
	public void remove_OnGettingOffersProcessing(Action value) { }

	[CompilerGenerated]
	public void remove_OnMoneySpend(Action value) { }

	[CompilerGenerated]
	public void remove_OnNodePriceUpdated(Action value) { }

	[CompilerGenerated]
	public void remove_OnOfferProcessing(Action value) { }

	[CompilerGenerated]
	public void remove_OnOfferRemoved(Action value) { }

	[CompilerGenerated]
	public void remove_OnOfferSelected(Action value) { }

	[CompilerGenerated]
	public void remove_OnPurchaseProcessing(Action value) { }

	[CompilerGenerated]
	public void remove_OnRagfairSearch(Action value) { }

	[CompilerGenerated]
	public void remove_OnRatingUpdated(Action value) { }

	[CompilerGenerated]
	public void remove_OnSelectedOffersCleared(Action value) { }

	[CompilerGenerated]
	public void remove_OnYourOfferSold(Action value) { }

	public void RemoveCancellableFilter(CancellableFilter filter, bool sendCallback) { }

	public void RemoveFromWishList(string id) { }

	public void RemoveOffer(Offer offer) { }

	public void RemoveOfferFromList(string offerId) { }

	public void RenewOffer(Offer offer, bool priority, int renewTime) { }

	public void ReportOffer(Offer offer, Callback callback) { }

	private void SaveFilter(FilterRule rule) { }

	public void SaveRuleAsDefault() { }

	private void SelectOffer(Offer offer) { }

	[CompilerGenerated]
	private void set_FilterRule(FilterRule value) { }

	[CompilerGenerated]
	private void set_GettingOffers(bool value) { }

	[CompilerGenerated]
	private static void set_IconsLoader(RagfairIconsLoader value) { }

	[CompilerGenerated]
	private void set_IsPurchaseInProgress(bool value) { }

	[CompilerGenerated]
	private void set_IsRatingGrowing(bool value) { }

	[CompilerGenerated]
	private void set_MyOffers(List value) { }

	private void set_MyRating(float value) { }

	[CompilerGenerated]
	private void set_OffersPerPageCount(int value) { }

	[CompilerGenerated]
	private static void set_Settings(RagfairSettings value) { }

	[CompilerGenerated]
	private void set_Status(ERagFairStatus value) { }

	[CompilerGenerated]
	private void set_UpdatingCategories(bool value) { }

	[CompilerGenerated]
	private void set_WeaponBuilds(List value) { }

	[CompilerGenerated]
	private void set_Wishlist(HandbookNodes value) { }

	public void SetFilterRule(FilterRule rule, bool clear, bool updateCategories = true, ESetFilterSource source = 0) { }

	public void SetMyRating(float rating, bool isGrowing) { }

	public void SetSearch(RagfairSearch search, bool sendBackendData) { }

	private void SetSearches(EViewListType viewListType, RagfairSearch[] searches, bool sendBackendData, out FilterRule newRule) { }

	private void SetTimersForMyOffers(IEnumerable offers) { }

	public bool ShouldShowCategoryOrItemLevelLock(string id, out int unlockLevel) { }

	[AsyncStateMachine(typeof(<StartHourTimer>d__194))]
	private Task StartHourTimer(Offer timeOffer) { }

	[AsyncStateMachine(typeof(<StartZeroTimer>d__193))]
	private Task StartZeroTimer(Offer offer) { }

	public void SwitchOfferSelection(Offer offer) { }

	private void UpdateCategories(OffersWithNodes offers, Dictionary categories) { }

	public void UpdateMyOffers(Offer[] newOffers) { }

	public void UpdateMyOffersProfileIcon() { }

	private static void UpdateNodes(HandbookNodes nodes, Dictionary categories) { }

	private void UpdateOfferTimers() { }

	private void UpdateRagfairStatus() { }

	public void UpdateSettings(RagfairSettings settings, Profile profile) { }

	public void UpdateWishlist() { }

	private void ValidateOffersMaxRestriction(IEnumerable offers) { }

	public void WarmupUiState() { }

}

