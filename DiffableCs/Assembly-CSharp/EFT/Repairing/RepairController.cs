namespace EFT.Repairing;

public sealed class RepairController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public Item itemToRepair; //Field offset: 0x10

		public <>c__DisplayClass35_0() { }

		internal bool <GetSuitableRepairersCollections>b__0(RepairKit repairKit) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public IEnumerable itemsToRepair; //Field offset: 0x10

		public <>c__DisplayClass36_0() { }

		internal bool <GetSuitableRepairersCollections>b__0(RepairKit repairKit) { }

	}

	[CompilerGenerated]
	private struct <RepairItemsByRepairKit>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RepairController <>4__this; //Field offset: 0x20
		public RepairItem[] repairKitsInfo; //Field offset: 0x28
		public string targetItem; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class RepairParameters
	{
		public readonly EBonusType UnlockBonus; //Field offset: 0x10
		public readonly EBonusType EfficiencyBonus; //Field offset: 0x14
		public readonly ESkillId SkillType; //Field offset: 0x18
		private readonly SkillManager _skillManager; //Field offset: 0x20
		private readonly double _getWearReducePerLevel; //Field offset: 0x28
		[CanBeNull]
		private readonly BuffSettings _buffSettings; //Field offset: 0x30
		private readonly BooleanBuff _noWearEliteRepair; //Field offset: 0x38

		public double GetMaxWearReduce
		{
			 get { } //Length: 14
		}

		public int GetSkillLevel
		{
			 get { } //Length: 90
		}

		public double GetWearReduce
		{
			 get { } //Length: 112
		}

		public bool HasBuffs
		{
			 get { } //Length: 9
		}

		public bool HasEliteNoWearRepair
		{
			 get { } //Length: 15
		}

		public RepairParameters(SkillManager skillManager, EBonusType unlockBonus, EBonusType efficiencyBonus, ESkillId skillType, double getWearReducePerLevel, BuffSettings buffSettings, BooleanBuff noWearEliteRepair) { }

		public double get_GetMaxWearReduce() { }

		public int get_GetSkillLevel() { }

		public double get_GetWearReduce() { }

		public bool get_HasBuffs() { }

		public bool get_HasEliteNoWearRepair() { }

		public double GetEnhancementBonus(float durabilityToRestorePercent) { }

		private double GetHValue(float receiveDurabilityMaxPercent, float receiveDurabilityPercent) { }

	}

	private const string WEAPON_TEMPLATE_ID = "5422acb9af1c889c16000029"; //Field offset: 0x0
	private const string VEST_TEMPLATE_ID = "57bef4c42459772e8d35a53b"; //Field offset: 0x0
	private const string ARMORED_EQUIPMENT_TEMPLATE = "5448e5284bdc2dcb718b4567"; //Field offset: 0x0
	public static readonly GlobalSkillsSettings SkillsSettings; //Field offset: 0x0
	public static readonly float IntellectWearChanceReducePerLevel; //Field offset: 0x8
	public static readonly float WeaponTreatmentWearChanceReducePerLevel; //Field offset: 0xC
	public static readonly float MinimumLevelToApplyBuff; //Field offset: 0x10
	public static readonly float LightVestWearChanceReducePerLevel; //Field offset: 0x14
	public static readonly float HeavyVestWearChanceReducePerLevel; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnSuccessfulRepairChangedEvent; //Field offset: 0x10
	private readonly RepairParameters _weaponRepairParameters; //Field offset: 0x18
	private readonly RepairParameters _lightVestRepairParameters; //Field offset: 0x20
	private readonly RepairParameters _heavyVestRepairParameters; //Field offset: 0x28
	private readonly RepairParameters _intellectRepairParameters; //Field offset: 0x30
	private readonly Profile _profile; //Field offset: 0x38
	private readonly Inventory _profileInventory; //Field offset: 0x40
	private readonly Dictionary _profileEncyclopedia; //Field offset: 0x48
	private readonly IEftSession _backEndSession; //Field offset: 0x50
	private SkillManager _skillManager; //Field offset: 0x58
	private List _preallocatedRepairKits; //Field offset: 0x60
	[CompilerGenerated]
	private readonly IEnumerable <TraderRepairers>k__BackingField; //Field offset: 0x68

	public event Action OnSuccessfulRepairChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public bool HasRepairers
	{
		 get { } //Length: 154
	}

	private HideoutRepresentation Hideout
	{
		private get { } //Length: 46
	}

	public IEnumerable TraderRepairers
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static RepairController() { }

	public RepairController(Profile profile, IEftSession backEndSession) { }

	[CompilerGenerated]
	public void add_OnSuccessfulRepairChangedEvent(Action value) { }

	public RepairKitsCollection CreateRepairKitsCollection(RepairKit repairKit) { }

	private IEnumerable FormRepairKitsCollection(Predicate predicate) { }

	public bool get_HasRepairers() { }

	private HideoutRepresentation get_Hideout() { }

	[CompilerGenerated]
	public IEnumerable get_TraderRepairers() { }

	public double GetBaseRepairPriceCoefficient(Item item) { }

	public double GetBaseRepairQuality(Item item) { }

	public double GetBaseRepairQualityForDisplay(Item item) { }

	public double GetRepairPrice(RepairKitTemplate repairKitTemplate, double repairValue, Item itemToRepair) { }

	public IEnumerable GetSuitableRepairersCollections(IEnumerable itemsToRepair) { }

	public IEnumerable GetSuitableRepairersCollections(Item itemToRepair) { }

	public bool HasEliteNoWearRepair(Item item) { }

	private bool HasRepairBonus(Item item, out RepairParameters repairParameters) { }

	public bool IsEligibleForBuff(Item item) { }

	public bool IsRepairUnlocked(Item item) { }

	[CompilerGenerated]
	public void remove_OnSuccessfulRepairChangedEvent(Action value) { }

	[AsyncStateMachine(typeof(<RepairItemsByRepairKit>d__38))]
	public Task RepairItemsByRepairKit(RepairItem[] repairKitsInfo, string targetItem) { }

	public bool TryGetEnhancementChance(Item item, float durabilityToRestorePercent, out double enhancementChance) { }

}

