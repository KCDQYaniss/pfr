//Type is in global namespace

public class ArmorRepairStrategy : IRepairStrategy
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8
		public static Func <>9__14_1; //Field offset: 0x10
		public static Func <>9__14_2; //Field offset: 0x18
		public static Func <>9__24_0; //Field offset: 0x20
		public static Func <>9__25_0; //Field offset: 0x28
		public static Func <>9__26_0; //Field offset: 0x30
		public static Func <>9__27_0; //Field offset: 0x38
		public static Func <>9__30_0; //Field offset: 0x40
		public static Func <>9__31_0; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal Item <.ctor>b__14_0(RepairableComponent repairable) { }

		internal ItemRepairInfo <.ctor>b__14_1(Item subItem) { }

		internal bool <.ctor>b__14_2(ItemRepairInfo info) { }

		internal bool <BrokenItemError>b__24_0(ItemRepairInfo repairable) { }

		internal float <Durability>b__26_0(ItemRepairInfo repairable) { }

		internal float <GetCurrentDurabilityFraction>b__30_0(ItemRepairInfo subItem) { }

		internal float <GetMaxDurabilityFraction>b__31_0(ItemRepairInfo subItem) { }

		internal float <MaxDurability>b__27_0(ItemRepairInfo subItem) { }

		internal int <TemplateDurability>b__25_0(ItemRepairInfo repairableItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public ArmorRepairStrategy <>4__this; //Field offset: 0x10
		public float repairAmount; //Field offset: 0x18
		public bool any; //Field offset: 0x1C

		public <>c__DisplayClass17_0() { }

		internal double <TryGetEnhancementChance>b__0(ItemRepairInfo itemInfo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public ArmorRepairStrategy <>4__this; //Field offset: 0x10
		public IRepairer repairer; //Field offset: 0x18
		public MongoID[] excludedCategories; //Field offset: 0x20

		public <>c__DisplayClass34_0() { }

		internal bool <CanRepair>b__0(ItemRepairInfo subItem) { }

	}

	[CompilerGenerated]
	private sealed class <get_Repairers>d__9 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IRepairer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ArmorRepairStrategy <>4__this; //Field offset: 0x28
		private Enumerator <>7__wrap1; //Field offset: 0x30
		private Enumerator <>7__wrap2; //Field offset: 0x48

		private override IRepairer System.Collections.Generic.IEnumerator<EFT.Repairing.IRepairer>.Current
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
		public <get_Repairers>d__9(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Repairing.IRepairer>.GetEnumerator() { }

		[DebuggerHidden]
		private override IRepairer System.Collections.Generic.IEnumerator<EFT.Repairing.IRepairer>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <RepairItem>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public float repairAmount; //Field offset: 0x20
		public ArmorRepairStrategy <>4__this; //Field offset: 0x28
		public RepairKit draggedRepairKit; //Field offset: 0x30
		private float <repairAmountLeft>5__2; //Field offset: 0x38
		private ItemRepairInfo[] <>7__wrap2; //Field offset: 0x40
		private int <>7__wrap3; //Field offset: 0x48
		private ItemRepairInfo <item>5__5; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class ItemRepairInfo
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Predicate <>9__4_0; //Field offset: 0x8
			public static Predicate <>9__4_1; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal bool <.ctor>b__4_0(ItemAttribute attribute) { }

			internal bool <.ctor>b__4_1(ItemAttribute attribute) { }

		}

		public Item Item; //Field offset: 0x10
		public ItemAttribute Durability; //Field offset: 0x18
		public ItemAttribute MaxDurability; //Field offset: 0x20
		public RepairableComponent Repairable; //Field offset: 0x28

		public ItemRepairInfo(Item item) { }

		public bool NotNull() { }

	}

	[CompilerGenerated]
	private readonly List <RepairKitsCollections>k__BackingField; //Field offset: 0x10
	private Item _rootItem; //Field offset: 0x18
	private ItemRepairInfo[] _repairableItems; //Field offset: 0x20
	private RepairController _repairController; //Field offset: 0x28
	private List _traders; //Field offset: 0x30
	[CompilerGenerated]
	private IRepairer <CurrentRepairer>k__BackingField; //Field offset: 0x38

	public override IRepairer CurrentRepairer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override IEnumerable Repairers
	{
		[IteratorStateMachine(typeof(<get_Repairers>d__9))]
		 get { } //Length: 175
	}

	public override List RepairKitsCollections
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ArmorRepairStrategy(Item item, RepairController repairController) { }

	[CompilerGenerated]
	private bool <.ctor>b__14_3(Trader trader) { }

	[CompilerGenerated]
	private double <GetPriceRate>b__33_0(ItemRepairInfo subItem) { }

	[CompilerGenerated]
	private float <GetRepairQuality>b__20_0(ItemRepairInfo item) { }

	[CompilerGenerated]
	private float <GetRepairQualityForDisplay>b__19_0(ItemRepairInfo item) { }

	[CompilerGenerated]
	private bool <IsEligibleForBuff>b__23_0(ItemRepairInfo item) { }

	[CompilerGenerated]
	private bool <IsNoCorrespondingArea>b__22_0(ItemRepairInfo item) { }

	public override void AddRepairKitToRepairers(RepairKit repairKit) { }

	public override bool BrokenItemError() { }

	private bool CanRepair(IRepairer repairer, Item item, MongoID[] excludedCategories) { }

	public override bool CanRepair(IRepairer repairer, MongoID[] excludedCategories) { }

	public override float Durability() { }

	[CompilerGenerated]
	public override IRepairer get_CurrentRepairer() { }

	[IteratorStateMachine(typeof(<get_Repairers>d__9))]
	public override IEnumerable get_Repairers() { }

	[CompilerGenerated]
	public override List get_RepairKitsCollections() { }

	public override ValueTuple GetBuffState() { }

	public override int GetCurrencyPrice(float repairAmountLeft) { }

	private int GetCurrencyPrice(Item item, float amount) { }

	public override float GetCurrentDurabilityFraction() { }

	public override Vector2 GetDegradationValues(float repairAmountLeft) { }

	public override float GetMaxDurabilityFraction() { }

	public override double GetPriceRate() { }

	public override double GetRepairPrice(float repairAmountLeft, RepairKitsCollection repairKit) { }

	public override float GetRepairQuality() { }

	public override float GetRepairQualityForDisplay() { }

	public override float HowMuchRepairScoresCanAccept() { }

	public override bool IsEligibleForBuff() { }

	public override bool IsNoCorrespondingArea() { }

	public override float MaxDurability() { }

	private int OrderRepair(Item item) { }

	public override string RepairabilityText(bool isRepairKit) { }

	[AsyncStateMachine(typeof(<RepairItem>d__38))]
	public override Task RepairItem(float repairAmount, RepairKit draggedRepairKit) { }

	[CompilerGenerated]
	public override void set_CurrentRepairer(IRepairer value) { }

	public override int TemplateDurability() { }

	public override bool TryGetEnhancementChance(float repairAmount, out double enhancementChance) { }

}

