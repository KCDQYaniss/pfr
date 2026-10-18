//Type is in global namespace

public class DefaultRepairStrategy : IRepairStrategy
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__15_1; //Field offset: 0x8
		public static Predicate <>9__15_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__15_1(ItemAttribute x) { }

		internal bool <.ctor>b__15_2(ItemAttribute x) { }

	}

	[CompilerGenerated]
	private sealed class <get_Repairers>d__10 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IRepairer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public DefaultRepairStrategy <>4__this; //Field offset: 0x28
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
		public <get_Repairers>d__10(int <>1__state) { }

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
	private struct <RepairItem>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DefaultRepairStrategy <>4__this; //Field offset: 0x20
		public float repairAmount; //Field offset: 0x28
		public RepairKit draggedRepairKit; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private Item _item; //Field offset: 0x10
	private RepairableComponent _repairableItem; //Field offset: 0x18
	private ItemAttribute _durabilityItemAttribute; //Field offset: 0x20
	private ItemAttribute _maxDurabilityItemAttribute; //Field offset: 0x28
	private List _traders; //Field offset: 0x30
	private RepairController _repairController; //Field offset: 0x38
	[CompilerGenerated]
	private readonly List <RepairKitsCollections>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private IRepairer <CurrentRepairer>k__BackingField; //Field offset: 0x48

	public override IRepairer CurrentRepairer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override IEnumerable Repairers
	{
		[IteratorStateMachine(typeof(<get_Repairers>d__10))]
		 get { } //Length: 175
	}

	public override List RepairKitsCollections
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public DefaultRepairStrategy(Item item, RepairController repairController) { }

	[CompilerGenerated]
	private bool <.ctor>b__15_0(Trader trader) { }

	public override void AddRepairKitToRepairers(RepairKit repairKit) { }

	public override bool BrokenItemError() { }

	public override bool CanRepair(IRepairer repairer, MongoID[] excludedCategories) { }

	public override float Durability() { }

	[CompilerGenerated]
	public override IRepairer get_CurrentRepairer() { }

	[IteratorStateMachine(typeof(<get_Repairers>d__10))]
	public override IEnumerable get_Repairers() { }

	[CompilerGenerated]
	public override List get_RepairKitsCollections() { }

	public override ValueTuple GetBuffState() { }

	public override int GetCurrencyPrice(float amount) { }

	public override float GetCurrentDurabilityFraction() { }

	public override Vector2 GetDegradationValues(float repairAmount) { }

	public override float GetMaxDurabilityFraction() { }

	public override double GetPriceRate() { }

	public override double GetRepairPrice(float repairValue, RepairKitsCollection repairKit) { }

	public override float GetRepairQuality() { }

	public override float GetRepairQualityForDisplay() { }

	public override float HowMuchRepairScoresCanAccept() { }

	public override bool IsEligibleForBuff() { }

	public override bool IsNoCorrespondingArea() { }

	public override float MaxDurability() { }

	public override string RepairabilityText(bool isRepairKit) { }

	[AsyncStateMachine(typeof(<RepairItem>d__36))]
	public override Task RepairItem(float repairAmount, RepairKit draggedRepairKit) { }

	[CompilerGenerated]
	public override void set_CurrentRepairer(IRepairer value) { }

	public override int TemplateDurability() { }

	public override bool TryGetEnhancementChance(float repairAmount, out double enhancementChance) { }

}

