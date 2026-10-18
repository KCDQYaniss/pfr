namespace EFT.InventoryLogic;

public class CylinderMagazine : Magazine
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__7_0(Slot x) { }

	}

	[CompilerGenerated]
	private sealed class <get_Containers>d__14 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IContainer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public CylinderMagazine <>4__this; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30
		private Slot[] <>7__wrap2; //Field offset: 0x38
		private int <>7__wrap3; //Field offset: 0x40

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
		public <get_Containers>d__14(int <>1__state) { }

		private void <>m__Finally1() { }

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

	private bool _inDryFireRolling; //Field offset: 0xB0
	protected int _currentCamoraIndex; //Field offset: 0xB4
	protected Slot[] _camoras; //Field offset: 0xB8

	public Slot[] Camoras
	{
		 get { } //Length: 8
	}

	public virtual IEnumerable Containers
	{
		[IteratorStateMachine(typeof(<get_Containers>d__14))]
		 get { } //Length: 175
	}

	public virtual int Count
	{
		 get { } //Length: 326
	}

	public int CurrentCamoraIndex
	{
		 get { } //Length: 7
	}

	public virtual int MaxCount
	{
		 get { } //Length: 29
	}

	public CylinderMagazine(string id, CylinderMagazineTemplate template) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable <>n__0() { }

	public virtual OperationResult Apply(ItemController itemController, Item item, int count, bool simulate) { }

	public virtual OperationResult ApplyWithoutRestrictions(ItemController itemController, Ammo ammo, int count, bool simulate) { }

	protected override int CamoraIndexForDoubleActionFire() { }

	public override bool CanRollCylinderInsteadOfReload() { }

	public virtual bool CheckCompatibility(Ammo ammo) { }

	public virtual bool Compare(Item item) { }

	public override void DryFireIncrementCamoraIndex() { }

	public virtual Item FirstRealAmmo() { }

	public Slot[] get_Camoras() { }

	[IteratorStateMachine(typeof(<get_Containers>d__14))]
	public virtual IEnumerable get_Containers() { }

	public virtual int get_Count() { }

	public int get_CurrentCamoraIndex() { }

	public virtual int get_MaxCount() { }

	public Slot GetActiveCamoraSlot(bool inRaid) { }

	public Ammo GetAmmoByCamoraIndex(int camoraIndex) { }

	public int GetCamoraFireOrLoadStartIndex(bool singleFireMode) { }

	public Slot GetCamoraForFire(bool singleFireMode) { }

	public List GetCamorasIndexesList() { }

	public virtual IContainer GetContainer(string containerId) { }

	private int GetCurrentAmmoCount() { }

	public Ammo GetFirstAmmo(bool singleFireMode) { }

	public override List GetFreeCamorasIndexesFromCurrentActiveIndex(bool quickReload, bool singleAction) { }

	public override void IncrementCamoraIndex(bool rollToZeroCamora = false) { }

	public OperationResult RemoveAmmoInCamora(Item item, ItemController itemController) { }

	public override void ResetCamoraIndex() { }

	public void SetCurrentCamoraIndex(int camoraIndex) { }

	public override void SetNotEmptyCamoraAsActive() { }

	public virtual bool TryFindItem(string itemId, out Item item) { }

}

