namespace EFT;

public class Profile : IPlayerProfileDataContainer, IProfileDataContainer, IInventoryProfileInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x8
		public static Func <>9__0_1; //Field offset: 0x10
		public static Func <>9__0_2; //Field offset: 0x18
		public static Func <>9__0_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal PrestigeStatusData <.ctor>b__0_0(KeyValuePair data) { }

		internal MongoID <.ctor>b__0_1(KeyValuePair counter) { }

		internal TaskConditionCounter <.ctor>b__0_2(KeyValuePair counter) { }

		internal Bonus <.ctor>b__0_3(BonusDescriptor bonus) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public TraderInfo traderInfo; //Field offset: 0x10
		public Profile <>4__this; //Field offset: 0x18

		public <>c__DisplayClass0_0() { }

		internal void <.ctor>b__4() { }

		internal void <.ctor>b__5() { }

	}

	[CompilerGenerated]
	private sealed class <GetAllPrefabPaths>d__140 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ResourceKey <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Profile <>4__this; //Field offset: 0x28
		private bool allCustomization; //Field offset: 0x30
		public bool <>3__allCustomization; //Field offset: 0x31
		private CustomizationSolver <customizationSolver>5__2; //Field offset: 0x38
		private BodyCustomization <customization>5__3; //Field offset: 0x40
		private Enumerator <>7__wrap3; //Field offset: 0x48
		private IEnumerator <>7__wrap4; //Field offset: 0x80
		private IEnumerator <>7__wrap5; //Field offset: 0x88

		private override ResourceKey System.Collections.Generic.IEnumerator<EFT.ResourceKey>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetAllPrefabPaths>d__140(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private void <>m__Finally4() { }

		private void <>m__Finally5() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.ResourceKey>.GetEnumerator() { }

		[DebuggerHidden]
		private override ResourceKey System.Collections.Generic.IEnumerator<EFT.ResourceKey>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[GenerateBinarySerialization]
	internal sealed class BattlePassDocumentLimitData
	{
		[JsonProperty("nextResetTime")]
		public int NextResetTime; //Field offset: 0x10
		[JsonProperty("remainingLimit")]
		public int RemainingLimit; //Field offset: 0x14
		[JsonProperty("totalLimit")]
		public int TotalLimit; //Field offset: 0x18
		[JsonProperty("resetInterval")]
		public int ResetInterval; //Field offset: 0x1C

		public BattlePassDocumentLimitData() { }

	}

	internal enum ETraderType
	{
		None = -1,
		Lightkeeper = 0,
		Btr = 1,
		Ragman = 2,
		ArenaManager = 3,
		Prapor = 4,
		Terapevt = 5,
		Fence = 6,
		Mechanic = 7,
		Skier = 8,
		Peacekeeper = 9,
		MrKerman = 10,
		Voivode = 11,
		Jaeger = 12,
		Taran = 13,
		Radio = 14,
		Scientist = 15,
	}

	internal sealed class FenceTraderInfo : TraderInfo
	{
		[CompilerGenerated]
		private FenceLoyaltyLevel <FenceLoyalty>k__BackingField; //Field offset: 0xF0
		private readonly CountersCollection _sessionCounters; //Field offset: 0xF8
		private readonly float _charismaFenceDiscount; //Field offset: 0x100

		public int AvailableExitsCount
		{
			 get { } //Length: 29
		}

		public private FenceLoyaltyLevel FenceLoyalty
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public double FenceLoyaltyPriceModifier
		{
			 get { } //Length: 34
		}

		public FenceTraderInfo(MongoID id, TraderInfoDescriptor descriptor, Profile profile) { }

		public void AddStanding(double dif, EFenceStandingSource standingSource, bool charismaFenceDiscount = true) { }

		public virtual double ApplyPriceModifier(double basePrice) { }

		public int get_AvailableExitsCount() { }

		[CompilerGenerated]
		public FenceLoyaltyLevel get_FenceLoyalty() { }

		public double get_FenceLoyaltyPriceModifier() { }

		public int NewExfiltrationPrice(int price) { }

		[CompilerGenerated]
		private void set_FenceLoyalty(FenceLoyaltyLevel value) { }

		public virtual void SetStanding(double value) { }

		protected virtual void UpdateLevel() { }

	}

	[GenerateBinarySerialization]
	internal sealed class HealthInfo
	{
		[GenerateBinarySerialization]
		internal sealed class BodyPartInfo
		{
			[JsonProperty("Health")]
			public ValueInfo Health; //Field offset: 0x10
			[JsonProperty("Effects")]
			public Dictionary Effects; //Field offset: 0x18

			public BodyPartInfo() { }

		}

		[GenerateBinarySerialization]
		internal sealed class EffectInfo
		{
			[JsonProperty("Time")]
			public float Time; //Field offset: 0x10

			public EffectInfo() { }

		}

		[GenerateBinarySerialization]
		internal sealed class ValueInfo
		{
			[JsonProperty("Current")]
			public float Current; //Field offset: 0x10
			[JsonProperty("Minimum")]
			public float Minimum; //Field offset: 0x14
			[JsonProperty("Maximum")]
			public float Maximum; //Field offset: 0x18
			[JsonProperty("OverDamageReceivedMultiplier")]
			public float OverDamageReceivedMultiplier; //Field offset: 0x1C
			[JsonProperty("EnvironmentDamageMultiplier")]
			public float EnvironmentDamageMultiplier; //Field offset: 0x20

			public ValueInfo() { }

		}

		[JsonProperty("BodyParts")]
		public Dictionary BodyParts; //Field offset: 0x10
		[JsonProperty("Energy")]
		public ValueInfo Energy; //Field offset: 0x18
		[JsonProperty("Hydration")]
		public ValueInfo Hydration; //Field offset: 0x20
		[JsonProperty("Temperature")]
		public ValueInfo Temperature; //Field offset: 0x28
		[JsonProperty("Poison")]
		public ValueInfo Poison; //Field offset: 0x30
		[JsonProperty("UpdateTime")]
		public Nullable UpdateTime; //Field offset: 0x38

		public HealthInfo() { }

	}

	[GenerateBinarySerialization]
	internal sealed class MoneyTransferLimitData
	{
		[JsonProperty("nextResetTime")]
		public int nextResetTime; //Field offset: 0x10
		[JsonProperty("remainingLimit")]
		public int remainingLimit; //Field offset: 0x14
		[JsonProperty("totalLimit")]
		public int totalLimit; //Field offset: 0x18
		[JsonProperty("resetInterval")]
		public int resetInterval; //Field offset: 0x1C

		public MoneyTransferLimitData() { }

	}

	internal class TraderInfo : ITraderInfo
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__108_0; //Field offset: 0x8

			private static <>c() { }

			public <>c() { }

			internal ETraderType <.cctor>b__121_0(KeyValuePair kvp) { }

			internal MongoID <.cctor>b__121_1(KeyValuePair kvp) { }

			internal bool <CanBuyItem>b__108_0(Item subItem) { }

		}

		public const string LIGHT_KEEPER_TRADER_ID = "638f541a29ffd1183d187f57"; //Field offset: 0x0
		private const int DEFAULT_MAX_LOYALTY_LEVEL = 4; //Field offset: 0x0
		public const float DEFAULT_MAX_STANDING_LEVEL = 6; //Field offset: 0x0
		public const float LIGHTHOUSE_KEEPER_SERVICES_SCREW_UP_STANDING = 0.01; //Field offset: 0x0
		public const string SCIENTIST_ID = "69e0d6cc77b63940375b9173"; //Field offset: 0x0
		public const string PLAYER_TRADER_ID = "67f7af56c117b6140af2a607"; //Field offset: 0x0
		public const string RADIO_TRADER_ID = "68fe15990f29ba3fdbba9d55"; //Field offset: 0x0
		public const string TARAN_TRADER_ID = "68fe15910f29ba3fdbba9d54"; //Field offset: 0x0
		public const string MECHANIC_TRADER_ID = "5a7c2eca46aef81a7ca2145d"; //Field offset: 0x0
		public const string JAEGER_TRADER_ID = "5c0647fdd443bc2504c2d371"; //Field offset: 0x0
		public static readonly IReadOnlyDictionary TraderIdToType; //Field offset: 0x0
		public const string VOIVODE_TRADER_ID = "688246958448b05efd61d462"; //Field offset: 0x0
		public const string STORYTELLER_TRADER_ID = "6864e812f9fe664cb8b8e152"; //Field offset: 0x0
		public const string TERAPEVT_TRADER_ID = "54cb57776803fa99248b456e"; //Field offset: 0x0
		public const string PRAPOR_TRADER_ID = "54cb50c76803fa8b248b4571"; //Field offset: 0x0
		public const string SKIER_ID = "58330581ace78e27b8b10cee"; //Field offset: 0x0
		public const string PEACEKEEPER_ID = "5935c25fb3acc3127c3d8cd9"; //Field offset: 0x0
		public const string FENCE_ID = "579dc571d53a0658a154fbec"; //Field offset: 0x0
		public const string ARENA_MANAGER_TRADER_ID = "6617beeaa9cfa777ca915b7c"; //Field offset: 0x0
		public const string RAGMAN_TRADER_ID = "5ac3b934156ae10c4430e83c"; //Field offset: 0x0
		public const string BTR_TRADER_ID = "656f0f98d80a697f855d34b1"; //Field offset: 0x0
		public const string MRKERMAN_TRADER_ID = "688246518448b05efd61d461"; //Field offset: 0x0
		public static readonly IReadOnlyDictionary TraderTypeToId; //Field offset: 0x8
		[CompilerGenerated]
		private Action OnStandingChanged; //Field offset: 0x10
		[CompilerGenerated]
		private Action OnSalesSumChanged; //Field offset: 0x18
		[CompilerGenerated]
		private Action OnLoyaltyChanged; //Field offset: 0x20
		[CompilerGenerated]
		private Action OnAvailabilityChanged; //Field offset: 0x28
		[CompilerGenerated]
		private Action OnResupplyTimeChanged; //Field offset: 0x30
		[CompilerGenerated]
		private Action OnTraderServicesUpdated; //Field offset: 0x38
		[CompilerGenerated]
		private Action OnSoldToTrader; //Field offset: 0x40
		[CompilerGenerated]
		private Action OnDialogAvailabilityChanged; //Field offset: 0x48
		[CompilerGenerated]
		private int <LoyaltyLevel>k__BackingField; //Field offset: 0x50
		[CompilerGenerated]
		private long <SalesSum>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private double <Standing>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private int <NextResupply>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		private bool <Unlocked>k__BackingField; //Field offset: 0x6C
		[CompilerGenerated]
		private bool <Disabled>k__BackingField; //Field offset: 0x6D
		[CompilerGenerated]
		private bool <DialogAvailable>k__BackingField; //Field offset: 0x6E
		private readonly ProfileInfo _profileInfo; //Field offset: 0x70
		private readonly Profile _profile; //Field offset: 0x78
		private bool _banned; //Field offset: 0x80
		private readonly HashSet _availableServices; //Field offset: 0x88
		private readonly HashSet _availableForPurchaseServices; //Field offset: 0x90
		private readonly HashSet _alreadyPurchasedServices; //Field offset: 0x98
		public readonly string Id; //Field offset: 0xA0
		[CompilerGenerated]
		private TraderSettings <Settings>k__BackingField; //Field offset: 0xA8
		[CompilerGenerated]
		private TraderLoyaltyLevel <CurrentLoyalty>k__BackingField; //Field offset: 0xB0

		public event Action OnAvailabilityChanged
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public event Action OnDialogAvailabilityChanged
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public event Action OnLoyaltyChanged
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public event Action OnResupplyTimeChanged
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public event Action OnSalesSumChanged
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public event Action OnSoldToTrader
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public event Action OnStandingChanged
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public event Action OnTraderServicesUpdated
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public bool Available
		{
			 get { } //Length: 26
		}

		public private TraderLoyaltyLevel CurrentLoyalty
		{
			[CompilerGenerated]
			 get { } //Length: 47
			[CompilerGenerated]
			private set { } //Length: 44
		}

		public private bool DialogAvailable
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private bool Disabled
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public string GameVersion
		{
			 get { } //Length: 27
		}

		public private int LoyaltyLevel
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public int MaxLoyaltyLevel
		{
			 get { } //Length: 149
		}

		public private int NextResupply
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public override int ProfileLevel
		{
			 get { } //Length: 35
		}

		public private override long SalesSum
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 5
		}

		protected override double SellToTraderPriceModifier
		{
			 get { } //Length: 37
		}

		public private TraderSettings Settings
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private override double Standing
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private bool Unlocked
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		private static TraderInfo() { }

		public TraderInfo(MongoID id, TraderInfoDescriptor descriptor, Profile profile) { }

		[CompilerGenerated]
		private void <.ctor>b__100_0(int _, int __) { }

		[CompilerGenerated]
		private bool <CanBuyItem>b__108_1(Item subItem) { }

		[CompilerGenerated]
		public void add_OnAvailabilityChanged(Action value) { }

		[CompilerGenerated]
		public void add_OnDialogAvailabilityChanged(Action value) { }

		[CompilerGenerated]
		public void add_OnLoyaltyChanged(Action value) { }

		[CompilerGenerated]
		public void add_OnResupplyTimeChanged(Action value) { }

		[CompilerGenerated]
		public void add_OnSalesSumChanged(Action value) { }

		[CompilerGenerated]
		public void add_OnSoldToTrader(Action value) { }

		[CompilerGenerated]
		public void add_OnStandingChanged(Action value) { }

		[CompilerGenerated]
		public void add_OnTraderServicesUpdated(Action value) { }

		public override double ApplyPriceModifier(double basePrice) { }

		private void BanChangedHandler(EBanType banType = 3) { }

		public bool CanBuyItem(Item item) { }

		public bool CanBuyItem(ItemTemplate itemTemplate) { }

		public bool CanBuyRootItem(Item item, out IReadOnlyList unsellableParts) { }

		public bool CanTransferItem(ItemTemplate itemTemplate) { }

		public bool get_Available() { }

		[CompilerGenerated]
		public TraderLoyaltyLevel get_CurrentLoyalty() { }

		[CompilerGenerated]
		public bool get_DialogAvailable() { }

		[CompilerGenerated]
		public bool get_Disabled() { }

		public string get_GameVersion() { }

		[CompilerGenerated]
		public int get_LoyaltyLevel() { }

		public int get_MaxLoyaltyLevel() { }

		[CompilerGenerated]
		public int get_NextResupply() { }

		public override int get_ProfileLevel() { }

		[CompilerGenerated]
		public override long get_SalesSum() { }

		protected override double get_SellToTraderPriceModifier() { }

		[CompilerGenerated]
		public TraderSettings get_Settings() { }

		[CompilerGenerated]
		public override double get_Standing() { }

		[CompilerGenerated]
		public bool get_Unlocked() { }

		public float GetTraderPriceMultiplier(EPerkTradeAction tradeAction) { }

		public bool IsServiceAlreadyPurchased(ETraderServiceType serviceType) { }

		public bool IsServiceAvailable(ETraderServiceType serviceType) { }

		public bool IsServiceAvailableForPurchase(ETraderServiceType serviceType) { }

		[CompilerGenerated]
		public void remove_OnAvailabilityChanged(Action value) { }

		[CompilerGenerated]
		public void remove_OnDialogAvailabilityChanged(Action value) { }

		[CompilerGenerated]
		public void remove_OnLoyaltyChanged(Action value) { }

		[CompilerGenerated]
		public void remove_OnResupplyTimeChanged(Action value) { }

		[CompilerGenerated]
		public void remove_OnSalesSumChanged(Action value) { }

		[CompilerGenerated]
		public void remove_OnSoldToTrader(Action value) { }

		[CompilerGenerated]
		public void remove_OnStandingChanged(Action value) { }

		[CompilerGenerated]
		public void remove_OnTraderServicesUpdated(Action value) { }

		[CompilerGenerated]
		private void set_CurrentLoyalty(TraderLoyaltyLevel value) { }

		[CompilerGenerated]
		private void set_DialogAvailable(bool value) { }

		[CompilerGenerated]
		private void set_Disabled(bool value) { }

		[CompilerGenerated]
		private void set_LoyaltyLevel(int value) { }

		[CompilerGenerated]
		private void set_NextResupply(int value) { }

		[CompilerGenerated]
		private void set_SalesSum(long value) { }

		[CompilerGenerated]
		private void set_Settings(TraderSettings value) { }

		[CompilerGenerated]
		private void set_Standing(double value) { }

		[CompilerGenerated]
		private void set_Unlocked(bool value) { }

		public void SetDialogAvailable(bool available) { }

		public void SetDisabled(bool disabled) { }

		public void SetResupplyTime(int resupplyTime) { }

		public void SetSalesSum(long value) { }

		public void SetServiceAvailability(ETraderServiceType serviceType, bool availabilityState, bool wasPurchasedInRaid) { }

		public void SetSoldToTraderItem(string templateId, int count) { }

		public override void SetStanding(double value) { }

		public void SetUnlocked(bool unlocked) { }

		public bool TryGetNextLoyalty(out TraderLoyaltyLevel nextLoyalty) { }

		protected override void UpdateLevel() { }

	}

	[GenerateBinarySerialization]
	internal sealed class UnlockedInfo
	{
		[JsonProperty("unlockedProductionRecipe")]
		public List unlockedSchemeList; //Field offset: 0x10

		public UnlockedInfo() { }

	}

	public string Id; //Field offset: 0x10
	public readonly string AccountId; //Field offset: 0x18
	public readonly Nullable PetId; //Field offset: 0x20
	public readonly float KarmaValue; //Field offset: 0x40
	public readonly ProfileInfo Info; //Field offset: 0x48
	public BodyCustomization Customization; //Field offset: 0x50
	public readonly HashSet UnlockedLocations; //Field offset: 0x58
	public readonly Encyclopedia Encyclopedia; //Field offset: 0x60
	public HealthInfo Health; //Field offset: 0x68
	public Inventory Inventory; //Field offset: 0x70
	public InsuredProfileItems[] InsuredItems; //Field offset: 0x78
	public SkillManager Skills; //Field offset: 0x80
	public readonly NotesManager Notes; //Field offset: 0x88
	public readonly Dictionary TaskConditionCounters; //Field offset: 0x90
	public List QuestsData; //Field offset: 0x98
	public readonly Dictionary AchievementsData; //Field offset: 0xA0
	public readonly IReadOnlyList PrestigeData; //Field offset: 0xA8
	public readonly SeasonalRewardsContainer SeasonalRewards; //Field offset: 0xB0
	public readonly ProfileVariablesStorage ProfileVariables; //Field offset: 0xB8
	public readonly PerkManager Perks; //Field offset: 0xC0
	public readonly EndingInfo Ending; //Field offset: 0xC8
	[CompilerGenerated]
	private readonly Dictionary <TradersInfo>k__BackingField; //Field offset: 0xD0
	public readonly UnlockedInfo UnlockedRecipeInfo; //Field offset: 0xD8
	public readonly MoneyTransferLimitData TransferLimitData; //Field offset: 0xE0
	public readonly IReadOnlyDictionary BattlePassDocumentLimits; //Field offset: 0xE8
	private readonly HashSet _battlePassDocumentsPickedInRaid; //Field offset: 0xF0
	private readonly Dictionary _completableItems; //Field offset: 0xF8
	public readonly QuestNotesData QuestNotes; //Field offset: 0x100
	private readonly BindableList _readQuestData; //Field offset: 0x108
	public Bonus[] Bonuses; //Field offset: 0x110
	public readonly BattlePassController BattlePass; //Field offset: 0x118
	public readonly HideoutInfo Hideout; //Field offset: 0x120
	public readonly ProfileRagfairInfo RagfairInfo; //Field offset: 0x128
	public readonly WishlistManager WishlistManager; //Field offset: 0x130
	[CompilerGenerated]
	private BonusController <BonusController>k__BackingField; //Field offset: 0x138
	private readonly Dictionary _profileVariables; //Field offset: 0x140
	[CompilerGenerated]
	private FenceTraderInfo <FenceInfo>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private Action OnItemZoneDropped; //Field offset: 0x150
	[CompilerGenerated]
	private Action OnTraderStandingChanged; //Field offset: 0x158
	[CompilerGenerated]
	private Action OnTraderLoyaltyChanged; //Field offset: 0x160
	[CompilerGenerated]
	private Action OnCompletableItemValueChanged; //Field offset: 0x168
	public readonly ProfileStatsSeparator Stats; //Field offset: 0x170
	public readonly Dictionary CheckedMagazines; //Field offset: 0x178
	public readonly List CheckedChambers; //Field offset: 0x180

	public override event Action OnCompletableItemValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnItemZoneDropped
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnTraderLoyaltyChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnTraderStandingChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private BonusController BonusController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override IReadOnlyDictionary CompletableItems
	{
		 get { } //Length: 8
	}

	public string CorrectedNickname
	{
		 get { } //Length: 182
	}

	private override EndingInfo EFT.IPlayerProfileDataContainer.Ending
	{
		private get { } //Length: 8
	}

	private override EGameMode EFT.IPlayerProfileDataContainer.PrestigeGameMode
	{
		private get { } //Length: 26
	}

	private override string EFT.IProfileDataContainer.ProfileId
	{
		private get { } //Length: 5
	}

	public ProfileStats EftStats
	{
		 get { } //Length: 265
		 set { } //Length: 107
	}

	public override int Experience
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public private FenceTraderInfo FenceInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override Inventory InventoryInfo
	{
		 get { } //Length: 5
	}

	public bool IsStreamerModeAvailable
	{
		 get { } //Length: 27
	}

	public override int MagDrillsMastering
	{
		 get { } //Length: 101
	}

	public override string Nickname
	{
		 get { } //Length: 27
	}

	public override int PrestigeLevel
	{
		 get { } //Length: 37
	}

	public override string ProfileId
	{
		 get { } //Length: 5
	}

	public IBindableList ReadQuestData
	{
		 get { } //Length: 8
	}

	public override EPlayerSide Side
	{
		 get { } //Length: 26
	}

	public override IInventoryProfileSkillInfo SkillsInfo
	{
		 get { } //Length: 8
	}

	public ESurvivorClass SurvivorClass
	{
		 get { } //Length: 79
	}

	public override Dictionary TradersInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Profile(ProfileDescriptor descriptor) { }

	[CompilerGenerated]
	private bool <LearnAll>b__138_0(Item item) { }

	[CompilerGenerated]
	public override void add_OnCompletableItemValueChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnItemZoneDropped(Action value) { }

	[CompilerGenerated]
	public void add_OnTraderLoyaltyChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnTraderStandingChanged(Action value) { }

	public void AddSessionCounterLong(int examineExperience, Identifier identifier) { }

	public override void AddToCarriedQuestItems(string id) { }

	public IResult CanPickUpBattlePassDocumentInRaid() { }

	public override void CheckChamber(MongoID weaponId) { }

	public int CheckedMagazineSkillLevel(MongoID id) { }

	public override void CheckMagazines(MongoID magazineId, int value) { }

	public override int CheckMagazinesValue(MongoID magazineId) { }

	public Profile Clone() { }

	public Profile CloneForSaveOfflinePVEWithDonor(Profile donorProfile) { }

	private override EndingInfo EFT.IPlayerProfileDataContainer.get_Ending() { }

	private override EGameMode EFT.IPlayerProfileDataContainer.get_PrestigeGameMode() { }

	private override string EFT.IProfileDataContainer.get_ProfileId() { }

	public override bool Examined(MongoID templateId) { }

	public override bool Examined(Item item) { }

	public override bool ForgetInEncyclopedia(MongoID itemId) { }

	[CompilerGenerated]
	public BonusController get_BonusController() { }

	public override IReadOnlyDictionary get_CompletableItems() { }

	public string get_CorrectedNickname() { }

	public ProfileStats get_EftStats() { }

	public override int get_Experience() { }

	[CompilerGenerated]
	public FenceTraderInfo get_FenceInfo() { }

	public override Inventory get_InventoryInfo() { }

	public bool get_IsStreamerModeAvailable() { }

	public override int get_MagDrillsMastering() { }

	public override string get_Nickname() { }

	public override int get_PrestigeLevel() { }

	public override string get_ProfileId() { }

	public IBindableList get_ReadQuestData() { }

	public override EPlayerSide get_Side() { }

	public override IInventoryProfileSkillInfo get_SkillsInfo() { }

	public ESurvivorClass get_SurvivorClass() { }

	[CompilerGenerated]
	public override Dictionary get_TradersInfo() { }

	[IteratorStateMachine(typeof(<GetAllPrefabPaths>d__140))]
	public IEnumerable GetAllPrefabPaths(bool allCustomization = true) { }

	public int GetBattlePassDocumentLimitRemainingForRaid() { }

	public int GetExfiltrationPrice(int price, MarkOfUnknown markOfUnknown) { }

	public TaskConditionCounter GetTaskConditionCounter(IConditional source, MongoID conditionId) { }

	public int GetTraderLoyalty(string traderId) { }

	public double GetTraderStanding(string traderId) { }

	public PlayerVisualRepresentation GetVisualEquipmentState(bool firstLevelItemsOnly = true) { }

	public override bool IsCheckedChambers(MongoID weaponId) { }

	public override bool IsCheckedMagazines(MongoID magazineId) { }

	public void ItemDroppedAtPlace(string itemId, string zoneId) { }

	public void LearnAll() { }

	public override void LearnInEncyclopedia(MongoID itemId) { }

	public void MarkQuestDataAsRead(MongoID dataId) { }

	public void MarkQuestDataAsUnread(MongoID dataId) { }

	public void MarkQuestNoteAsRead(QuestNote noteId) { }

	private void PerksChangedHandler() { }

	protected override ProfileInfo ProfileInfoFactory(ProfileInfoDescriptor descriptor) { }

	public void RegisterBattlePassDocumentPickedInRaid(BattlePassItem item) { }

	[CompilerGenerated]
	public override void remove_OnCompletableItemValueChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnItemZoneDropped(Action value) { }

	[CompilerGenerated]
	public void remove_OnTraderLoyaltyChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnTraderStandingChanged(Action value) { }

	[CompilerGenerated]
	private void set_BonusController(BonusController value) { }

	public void set_EftStats(ProfileStats value) { }

	public override void set_Experience(int value) { }

	[CompilerGenerated]
	private void set_FenceInfo(FenceTraderInfo value) { }

	public override IResult SetCompletableItemValue(MongoID completableItem, bool completed, bool force = false) { }

	public void SetDefaultFenceInfo() { }

	public void SetSpawnedInSession(bool value) { }

	public void SetUpDogTagSlot(MongoID dogTagId, ItemController itemController = null) { }

	private void SyncPerkBonuses() { }

	public bool TryGetTraderInfo(string traderId, out TraderInfo traderInfo) { }

	public override void UnCheckChamber(MongoID weaponId) { }

	public override void UnCheckMagazines(MongoID magazineId) { }

	private IResult ValidateBattlePassDocumentLimitData(out BattlePassDocumentLimitData limitData) { }

}

