namespace EFT.InventoryLogic;

public class Magazine : GearMod, IAmmoContainer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__26_2; //Field offset: 0x8
		public static Func <>9__26_5; //Field offset: 0x10
		public static Func <>9__26_8; //Field offset: 0x18
		public static Func <>9__26_11; //Field offset: 0x20
		public static Func <>9__26_14; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <SetAttributes>b__26_11() { }

		internal EItemAttributeDisplayType <SetAttributes>b__26_14() { }

		internal EItemAttributeDisplayType <SetAttributes>b__26_2() { }

		internal EItemAttributeDisplayType <SetAttributes>b__26_5() { }

		internal EItemAttributeDisplayType <SetAttributes>b__26_8() { }

	}

	[CompilerGenerated]
	private sealed class <get_Containers>d__46 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IContainer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Magazine <>4__this; //Field offset: 0x28

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
		public <get_Containers>d__46(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <get_ItemInteractionButtons>d__33 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EItemInfoButton <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public Magazine <>4__this; //Field offset: 0x20
		private IEnumerator <>7__wrap1; //Field offset: 0x28
		private Enumerator <>7__wrap2; //Field offset: 0x30

		private override EItemInfoButton System.Collections.Generic.IEnumerator<EFT.InventoryLogic.EItemInfoButton>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 72
		}

		[DebuggerHidden]
		public <get_ItemInteractionButtons>d__33(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.EItemInfoButton>.GetEnumerator() { }

		[DebuggerHidden]
		private override EItemInfoButton System.Collections.Generic.IEnumerator<EFT.InventoryLogic.EItemInfoButton>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class FullMagazineError : InventoryError
	{
		public readonly Magazine Magazine; //Field offset: 0x10
		public readonly Ammo Ammo; //Field offset: 0x18

		public FullMagazineError(Magazine magazine, Ammo ammo) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class ItemFiltersWontAllowError : InventoryError
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__3_0; //Field offset: 0x8
			public static Func <>9__3_1; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal IEnumerable <ToString>b__3_0(ItemFilter x) { }

			internal string <ToString>b__3_1(MongoID x) { }

		}

		public readonly StackSlot CartridgeSlot; //Field offset: 0x10
		public readonly Ammo Ammo; //Field offset: 0x18

		public ItemFiltersWontAllowError(StackSlot cartridgeSlot, Ammo ammo) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class LoadInsertedMagazineError : InventoryError
	{
		public readonly Magazine Magazine; //Field offset: 0x10
		public readonly Ammo Ammo; //Field offset: 0x18

		public LoadInsertedMagazineError(Magazine magazine, Ammo ammo) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	private static readonly string[] MalfChancesKeys; //Field offset: 0x0
	private static List _magInteractions; //Field offset: 0x8
	[Component]
	public readonly TagComponent Tag; //Field offset: 0x90
	private readonly string[] _lvlZero; //Field offset: 0x98
	public int ObservedMagazineCount; //Field offset: 0xA0
	[CompilerGenerated]
	private readonly StackSlot <Cartridges>k__BackingField; //Field offset: 0xA8

	public int BeltMagazineRefreshCount
	{
		 get { } //Length: 79
	}

	public override StackSlot Cartridges
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int CheckOverride
	{
		 get { } //Length: 101
	}

	public float CheckTimeModifier
	{
		 get { } //Length: 81
	}

	public virtual IEnumerable Containers
	{
		[IteratorStateMachine(typeof(<get_Containers>d__46))]
		 get { } //Length: 175
	}

	public override int Count
	{
		 get { } //Length: 32
	}

	public bool IsMagazineForStationaryWeapon
	{
		 get { } //Length: 80
	}

	public bool IsMagazineWithBelt
	{
		 get { } //Length: 80
	}

	public virtual IEnumerable ItemInteractionButtons
	{
		[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__33))]
		 get { } //Length: 175
	}

	public float LoadUnloadModifier
	{
		 get { } //Length: 81
	}

	public int magAnimationIndex
	{
		 get { } //Length: 79
	}

	public float MalfunctionChance
	{
		 get { } //Length: 81
	}

	public override int MaxCount
	{
		 get { } //Length: 29
	}

	public EReloadMode ReloadMagType
	{
		 get { } //Length: 79
	}

	public List VisibleAmmoRanges
	{
		 get { } //Length: 408
	}

	private static Magazine() { }

	public Magazine(string id, MagazineTemplate template) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable <>n__0() { }

	[CompilerGenerated]
	private float <SetAttributes>b__26_0() { }

	[CompilerGenerated]
	private string <SetAttributes>b__26_1() { }

	[CompilerGenerated]
	private string <SetAttributes>b__26_10() { }

	[CompilerGenerated]
	private float <SetAttributes>b__26_12() { }

	[CompilerGenerated]
	private string <SetAttributes>b__26_13() { }

	[CompilerGenerated]
	private float <SetAttributes>b__26_3() { }

	[CompilerGenerated]
	private string <SetAttributes>b__26_4() { }

	[CompilerGenerated]
	private float <SetAttributes>b__26_6() { }

	[CompilerGenerated]
	private string <SetAttributes>b__26_7() { }

	[CompilerGenerated]
	private float <SetAttributes>b__26_9() { }

	public virtual OperationResult Apply(ItemController itemController, Item item, int count, bool simulate) { }

	protected override OperationResult ApplyItem(ItemController itemController, Item item, int count, bool simulate) { }

	protected OperationResult ApplyItemBase(ItemController itemController, Item item, int count, bool simulate) { }

	public override OperationResult ApplyWithoutRestrictions(ItemController itemController, Ammo ammo, int count, bool simulate) { }

	public override bool CheckCompatibility(Ammo ammo) { }

	public virtual bool Compare(Item item) { }

	public override Item FirstRealAmmo() { }

	public int get_BeltMagazineRefreshCount() { }

	[CompilerGenerated]
	public override StackSlot get_Cartridges() { }

	public int get_CheckOverride() { }

	public float get_CheckTimeModifier() { }

	[IteratorStateMachine(typeof(<get_Containers>d__46))]
	public virtual IEnumerable get_Containers() { }

	public override int get_Count() { }

	public bool get_IsMagazineForStationaryWeapon() { }

	public bool get_IsMagazineWithBelt() { }

	[IteratorStateMachine(typeof(<get_ItemInteractionButtons>d__33))]
	public virtual IEnumerable get_ItemInteractionButtons() { }

	public float get_LoadUnloadModifier() { }

	public int get_magAnimationIndex() { }

	public float get_MalfunctionChance() { }

	public override int get_MaxCount() { }

	public EReloadMode get_ReloadMagType() { }

	public List get_VisibleAmmoRanges() { }

	public string GetAmmoCountByLevel(int ammoCount, int maxAmmoCount, int skill, string color, bool checked, bool itemInHands, string valueFormat) { }

	public override Ammo GetBulletAtPosition(int index) { }

	public virtual IContainer GetContainer(string containerId) { }

	[CanBeNull]
	public virtual Magazine GetCurrentMagazine() { }

	public virtual int GetHashSum() { }

	public int GetMaxVisibleAmmo() { }

	public bool IsAmmoCompatible(Slot[] chambers) { }

	private string ModifierStringValue(float value) { }

	protected void SetAttributes() { }

	public virtual bool TryFindItem(string itemId, out Item item) { }

}

