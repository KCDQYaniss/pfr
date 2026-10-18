namespace EFT.InventoryLogic;

public class ArmorHolderComponent : ItemComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8
		public static Func <>9__10_0; //Field offset: 0x10
		public static Func <>9__26_3; //Field offset: 0x18
		public static Func <>9__26_4; //Field offset: 0x20
		public static Func <>9__26_7; //Field offset: 0x28
		public static Func <>9__26_6; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__26_3(EBodyPartColliderType zone) { }

		internal string <.ctor>b__26_4(EArmorPlateCollider armorCollider) { }

		internal EItemAttributeDisplayType <.ctor>b__26_6() { }

		internal bool <.ctor>b__26_7(EBodyPartColliderType armorCollider) { }

		internal IEnumerable <get_ArmorColliders>b__8_0(CompositeArmorComponent x) { }

		internal IEnumerable <get_ArmorPlateColliders>b__10_0(CompositeArmorComponent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public ArmorHolderComponent <>4__this; //Field offset: 0x10
		public CompoundItem item; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		internal float <.ctor>b__0() { }

		internal string <.ctor>b__1() { }

		internal EItemAttributeDisplayType <.ctor>b__10() { }

		internal EItemAttributeDisplayType <.ctor>b__2() { }

		internal string <.ctor>b__5() { }

		internal string <.ctor>b__8() { }

		internal MultiLineInfo <.ctor>b__9() { }

	}

	[CompilerGenerated]
	private sealed class <GetArmorPlatesInternal>d__24 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ArmorPlate <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ArmorHolderComponent <>4__this; //Field offset: 0x28
		private EArmorPlateFiltering filtering; //Field offset: 0x30
		public EArmorPlateFiltering <>3__filtering; //Field offset: 0x34
		private Slot[] <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private IEnumerator <>7__wrap3; //Field offset: 0x48

		private override ArmorPlate System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ArmorPlate>.Current
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
		public <GetArmorPlatesInternal>d__24(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.ArmorPlate>.GetEnumerator() { }

		[DebuggerHidden]
		private override ArmorPlate System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ArmorPlate>.get_Current() { }

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
	private sealed class <GetArmorSlotsInternal>d__23 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ArmorSlot <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ArmorHolderComponent <>4__this; //Field offset: 0x28
		private EArmorPlateFiltering filtering; //Field offset: 0x30
		public EArmorPlateFiltering <>3__filtering; //Field offset: 0x34
		private Slot[] <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private ArmorSlot <armorSlot>5__4; //Field offset: 0x48

		private override ArmorSlot System.Collections.Generic.IEnumerator<ArmorSlot>.Current
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
		public <GetArmorSlotsInternal>d__23(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<ArmorSlot>.GetEnumerator() { }

		[DebuggerHidden]
		private override ArmorSlot System.Collections.Generic.IEnumerator<ArmorSlot>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private enum EArmorPlateFiltering
	{
		Both = 0,
		Locked = 1,
		MoveAble = 2,
	}

	private readonly IArmorComponentTemplate Template; //Field offset: 0x18
	private CompoundItem Item; //Field offset: 0x20

	private IEnumerable ArmorColliders
	{
		private get { } //Length: 426
	}

	private EArmorMaterial ArmorMaterial
	{
		private get { } //Length: 78
	}

	private IEnumerable ArmorPlateColliders
	{
		private get { } //Length: 1031
	}

	public IEnumerable ArmorPlates
	{
		 get { } //Length: 10
	}

	public IEnumerable ArmorSlots
	{
		 get { } //Length: 10
	}

	private EArmorType ArmorType
	{
		private get { } //Length: 78
	}

	public IEnumerable LockedArmorPlates
	{
		 get { } //Length: 13
	}

	public IEnumerable LockedArmorSlots
	{
		 get { } //Length: 13
	}

	public IEnumerable MoveAbleArmorPlates
	{
		 get { } //Length: 13
	}

	public IEnumerable MoveAbleArmorSlots
	{
		 get { } //Length: 13
	}

	public ArmorHolderComponent(CompoundItem item, IArmorComponentTemplate template) { }

	private IEnumerable get_ArmorColliders() { }

	private EArmorMaterial get_ArmorMaterial() { }

	private IEnumerable get_ArmorPlateColliders() { }

	public IEnumerable get_ArmorPlates() { }

	public IEnumerable get_ArmorSlots() { }

	private EArmorType get_ArmorType() { }

	public IEnumerable get_LockedArmorPlates() { }

	public IEnumerable get_LockedArmorSlots() { }

	public IEnumerable get_MoveAbleArmorPlates() { }

	public IEnumerable get_MoveAbleArmorSlots() { }

	[IteratorStateMachine(typeof(<GetArmorPlatesInternal>d__24))]
	private IEnumerable GetArmorPlatesInternal(EArmorPlateFiltering filtering) { }

	[IteratorStateMachine(typeof(<GetArmorSlotsInternal>d__23))]
	private IEnumerable GetArmorSlotsInternal(EArmorPlateFiltering filtering) { }

	public bool IsModSuitable(Item item) { }

}

