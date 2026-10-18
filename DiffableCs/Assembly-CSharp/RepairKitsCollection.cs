//Type is in global namespace

public class RepairKitsCollection : IRepairer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__27_0; //Field offset: 0x8
		public static Func <>9__29_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <GetRepairPoints>b__27_0(RepairKit repairKit) { }

		internal float <RepairItems>b__29_0(RepairKit repairKit) { }

	}

	[CompilerGenerated]
	private struct <GetAndAssignAvatar>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RepairKitsCollection <>4__this; //Field offset: 0x20
		public Image image; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly MongoID _fakeId; //Field offset: 0x0
	private RepairController _repairController; //Field offset: 0x10
	private RepairKitTemplate _repairKitTemplate; //Field offset: 0x18
	private HashSet _repairKits; //Field offset: 0x20
	private Sprite _icon; //Field offset: 0x28

	public override float CurrencyCoefficient
	{
		 get { } //Length: 9
	}

	public override string LocalizedName
	{
		 get { } //Length: 132
	}

	public override int LoyaltyLevel
	{
		 get { } //Length: 3
	}

	public override int MaxLoyaltyLevel
	{
		 get { } //Length: 3
	}

	public override string RepairerId
	{
		 get { } //Length: 215
	}

	public override double Standing
	{
		 get { } //Length: 4
	}

	public override MongoID[] Targets
	{
		 get { } //Length: 30
	}

	private static RepairKitsCollection() { }

	public RepairKitsCollection(RepairKitTemplate template, RepairController repairController) { }

	public bool AddRepairKit(RepairKit repairKit) { }

	public override float get_CurrencyCoefficient() { }

	public override string get_LocalizedName() { }

	public override int get_LoyaltyLevel() { }

	public override int get_MaxLoyaltyLevel() { }

	public override string get_RepairerId() { }

	public override double get_Standing() { }

	public override MongoID[] get_Targets() { }

	[AsyncStateMachine(typeof(<GetAndAssignAvatar>d__23))]
	public override Task GetAndAssignAvatar(Image image, CancellationToken cancellationToken) { }

	public override Vector2 GetDegradationValues(RepairableComponent repairable, Item item) { }

	public float GetRepairPoints() { }

	public double GetRepairPrice(double repairValue, Item itemToRepair) { }

	public override double GetRepairPriceCoefficient(Item item) { }

	public override float GetRepairQuality(Item item) { }

	public float GetRepairQualityForDisplay(Item item) { }

	public bool RemoveRepairKit(RepairKit repairKit) { }

	public override Task RepairItems(RepairItem repairItem, RepairKit draggedRepairKit) { }

	public RepairKit SelectMinRepairKit(RepairKit draggedRepairKit) { }

	public override bool TryGetEnhancementChance(Item item, float receiveDurabilityPercent, out double enhancementChance) { }

}

