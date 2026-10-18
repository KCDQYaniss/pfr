namespace EFT.InventoryLogic;

public class CompoundItem : ContainerCollection, IApplicable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_1; //Field offset: 0x8
		public static Func <>9__7_0; //Field offset: 0x10
		public static Func <>9__9_0; //Field offset: 0x18
		public static Func <>9__21_0; //Field offset: 0x20
		public static Func <>9__23_0; //Field offset: 0x28
		public static Func <>9__25_0; //Field offset: 0x30
		public static Func <>9__27_2; //Field offset: 0x38
		public static Func <>9__27_5; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__27_2(Grid x) { }

		internal EItemAttributeDisplayType <.ctor>b__27_5() { }

		internal IEnumerable <get_AllSlotsWithoutArrayInside>b__7_0(Slot container) { }

		internal IEnumerable <get_AllSlotsWithoutArrayInside>b__7_1(ContainerCollection x) { }

		internal int <get_IsEmpty>b__9_0(Grid x) { }

		internal bool <get_MissingVitalParts>b__23_0(Slot x) { }

		internal int <get_TotalGridWidth>b__25_0(Grid grid) { }

		internal bool <get_VitalParts>b__21_0(Slot x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public int gridsCapacity; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal float <.ctor>b__3() { }

		internal string <.ctor>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <get_AllSlots>d__5 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Slot <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CompoundItem <>4__this; //Field offset: 0x28
		private Slot[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private Slot <slot>5__4; //Field offset: 0x40
		private IEnumerator <>7__wrap4; //Field offset: 0x48

		private override Slot System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Slot>.Current
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
		public <get_AllSlots>d__5(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Slot>.GetEnumerator() { }

		[DebuggerHidden]
		private override Slot System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Slot>.get_Current() { }

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
	private sealed class <get_Containers>d__11 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IContainer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CompoundItem <>4__this; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x30

		private override IContainer System.Collections.Generic.IEnumerator<EFT.InventoryLogic.IContainer>.Current
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
		public <get_Containers>d__11(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.IContainer>.GetEnumerator() { }

		[DebuggerHidden]
		private override IContainer System.Collections.Generic.IEnumerator<EFT.InventoryLogic.IContainer>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly List _containedItems; //Field offset: 0x0
	public Grid[] Grids; //Field offset: 0x78
	public Slot[] Slots; //Field offset: 0x80
	public bool ForbidMissingVitalParts; //Field offset: 0x88
	public bool ForbidNonEmptyContainers; //Field offset: 0x89

	[NotNull]
	public override IEnumerable AllSlots
	{
		[IteratorStateMachine(typeof(<get_AllSlots>d__5))]
		 get { } //Length: 175
	}

	[NotNull]
	public override IEnumerable AllSlotsWithoutArrayInside
	{
		 get { } //Length: 615
	}

	public virtual bool CanSellOnRagfair
	{
		 get { } //Length: 73
	}

	[NotNull]
	public virtual IEnumerable Containers
	{
		[IteratorStateMachine(typeof(<get_Containers>d__11))]
		 get { } //Length: 175
	}

	public bool IsAllowedToSort
	{
		 get { } //Length: 51
	}

	public bool IsEmpty
	{
		 get { } //Length: 393
	}

	public virtual bool MarkedAsSpawnedInSession
	{
		 get { } //Length: 227
	}

	public IEnumerable MissingVitalParts
	{
		 get { } //Length: 370
	}

	public int TotalGridWidth
	{
		 get { } //Length: 387
	}

	public IEnumerable VitalParts
	{
		 get { } //Length: 386
	}

	private static CompoundItem() { }

	public CompoundItem(string id, CompoundItemTemplate template) { }

	[CompilerGenerated]
	private Slot <.ctor>b__27_0(Slot x) { }

	[CompilerGenerated]
	private Grid <.ctor>b__27_1(Grid x) { }

	public override OperationResult Apply(ItemController itemController, Item item, int count, bool simulate) { }

	public virtual IntVec2 CalculateCellSize() { }

	public ExtraSize CalculateExtraSize(FoldableComponent overrideFoldable = null, bool overrideValue = false, Slot overrideSlot = null, Item overrideSlotContent = null) { }

	[IteratorStateMachine(typeof(<get_AllSlots>d__5))]
	public override IEnumerable get_AllSlots() { }

	public override IEnumerable get_AllSlotsWithoutArrayInside() { }

	public virtual bool get_CanSellOnRagfair() { }

	[IteratorStateMachine(typeof(<get_Containers>d__11))]
	public virtual IEnumerable get_Containers() { }

	public bool get_IsAllowedToSort() { }

	public bool get_IsEmpty() { }

	public virtual bool get_MarkedAsSpawnedInSession() { }

	public IEnumerable get_MissingVitalParts() { }

	public int get_TotalGridWidth() { }

	public IEnumerable get_VitalParts() { }

	[CanBeNull]
	public virtual IContainer GetContainer(string containerId) { }

	protected override int GetContainersHashSum() { }

	public virtual int GetHashSum() { }

	public IntVec2 GetSizeAfterAttachment(ItemAddress location, Item attachedItem) { }

	public IntVec2 GetSizeAfterDetachment(ItemAddress location, Item detachedItem) { }

	public IntVec2 GetSizeAfterFolding(ItemAddress location, FoldableComponent foldedItem, bool folded) { }

	private bool HasForbiddenItems() { }

	public virtual bool TryFindItem(string itemId, out Item item) { }

	public virtual bool TryFindItem(Func predicate, out Item result) { }

	public bool TryGetLastForbiddenItem(out Item item) { }

}

