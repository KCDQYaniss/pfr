namespace EFT.InventoryLogic;

public class ArmorComponent : ItemComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__28_5; //Field offset: 0x8
		public static Func <>9__28_7; //Field offset: 0x10
		public static Func <>9__28_9; //Field offset: 0x18
		public static Func <>9__29_0; //Field offset: 0x20
		public static Func <>9__29_1; //Field offset: 0x28
		public static Func <>9__29_2; //Field offset: 0x30
		public static Func <>9__41_0; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__28_5(CompositeArmorComponent x) { }

		internal EItemAttributeDisplayType <.ctor>b__28_7() { }

		internal EItemAttributeDisplayType <.ctor>b__28_9() { }

		internal string <ToString>b__41_0(EBodyPartColliderType x) { }

		internal string <UniqueLocalizedZones>b__29_0(EArmorPlateCollider apc) { }

		internal string <UniqueLocalizedZones>b__29_1(EBodyPartColliderType ac) { }

		internal string <UniqueLocalizedZones>b__29_2(string zone) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public ArmorComponent <>4__this; //Field offset: 0x10
		public Item item; //Field offset: 0x18

		public <>c__DisplayClass28_0() { }

		internal float <.ctor>b__0() { }

		internal string <.ctor>b__1() { }

		internal EItemAttributeDisplayType <.ctor>b__2() { }

		internal string <.ctor>b__3() { }

		internal EItemAttributeDisplayType <.ctor>b__4() { }

		internal string <.ctor>b__6() { }

		internal string <.ctor>b__8() { }

	}

	[CompilerGenerated]
	private sealed class <GetArmorPlateColliders>d__27 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EArmorPlateCollider <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public ArmorComponent <>4__this; //Field offset: 0x20
		private EArmorPlateCollider <mask>5__2; //Field offset: 0x28
		private IEnumerator <>7__wrap2; //Field offset: 0x30

		private override EArmorPlateCollider System.Collections.Generic.IEnumerator<EArmorPlateCollider>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 74
		}

		[DebuggerHidden]
		public <GetArmorPlateColliders>d__27(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EArmorPlateCollider>.GetEnumerator() { }

		[DebuggerHidden]
		private override EArmorPlateCollider System.Collections.Generic.IEnumerator<EArmorPlateCollider>.get_Current() { }

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
	private sealed class <GetBothColliders>d__25 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EBodyPartColliderType <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		private ArmorSlot armorSlot; //Field offset: 0x20
		public ArmorSlot <>3__armorSlot; //Field offset: 0x28
		public ArmorComponent <>4__this; //Field offset: 0x30
		private EBodyPartColliderType[] <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40

		private override EBodyPartColliderType System.Collections.Generic.IEnumerator<EBodyPartColliderType>.Current
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
		public <GetBothColliders>d__25(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EBodyPartColliderType>.GetEnumerator() { }

		[DebuggerHidden]
		private override EBodyPartColliderType System.Collections.Generic.IEnumerator<EBodyPartColliderType>.get_Current() { }

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
	private static Action OnDurabilityChanged; //Field offset: 0x0
	public readonly IArmorComponentTemplate Template; //Field offset: 0x18
	public readonly RepairableComponent Repairable; //Field offset: 0x20
	public readonly BuffComponent Buff; //Field offset: 0x28

	public static event Action OnDurabilityChanged
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	public int ArmorClass
	{
		 get { } //Length: 78
	}

	public IEnumerable ArmorColliders
	{
		 get { } //Length: 505
	}

	public EArmorPlateCollider ArmorPlateCollidersMask
	{
		 get { } //Length: 323
	}

	public EArmorType ArmorType
	{
		 get { } //Length: 78
	}

	public float BluntThroughput
	{
		 get { } //Length: 78
	}

	public EDeafStrength Deaf
	{
		 get { } //Length: 78
	}

	public bool IsDestroyed
	{
		 get { } //Length: 38
	}

	public MaterialType Material
	{
		 get { } //Length: 78
	}

	public float MousePenalty
	{
		 get { } //Length: 78
	}

	public float SpeedPenalty
	{
		 get { } //Length: 75
	}

	public float WeaponErgonomicPenalty
	{
		 get { } //Length: 78
	}

	public ArmorComponent(Item item, IArmorComponentTemplate template, RepairableComponent repairable, BuffComponent buffComponent) { }

	[CompilerGenerated]
	public static void add_OnDurabilityChanged(Action value) { }

	public float ApplyDamage(ref DamageInfo damageInfo, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, bool damageInfoIsLocal, List armorComponents, FloatBuff lightVestsDamageReduction, FloatBuff heavyVestsDamageReduction) { }

	public void ApplyDurabilityDamage(float armorDamage, List armorComponents) { }

	public float ApplyExplosionDurabilityDamage(float armorDamage, DamageInfo damageInfo, List armorComponents) { }

	public bool Deflects(Vector3 shotDirection, Vector3 hitNormal, Shot shot) { }

	public int get_ArmorClass() { }

	public IEnumerable get_ArmorColliders() { }

	public EArmorPlateCollider get_ArmorPlateCollidersMask() { }

	public EArmorType get_ArmorType() { }

	public float get_BluntThroughput() { }

	public EDeafStrength get_Deaf() { }

	public bool get_IsDestroyed() { }

	public MaterialType get_Material() { }

	public float get_MousePenalty() { }

	public float get_SpeedPenalty() { }

	public float get_WeaponErgonomicPenalty() { }

	[IteratorStateMachine(typeof(<GetArmorPlateColliders>d__27))]
	public IEnumerable GetArmorPlateColliders() { }

	private EArmorPlateCollider GetBothArmorPlates(ArmorSlot armorSlot) { }

	[IteratorStateMachine(typeof(<GetBothColliders>d__25))]
	private IEnumerable GetBothColliders(ArmorSlot armorSlot) { }

	[CompilerGenerated]
	public static void remove_OnDurabilityChanged(Action value) { }

	public void SetPenetrationStatus(Shot shot) { }

	public override bool ShotMatches(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider) { }

	public virtual string ToString() { }

	public void TryShatter(Player damageSource, bool damageInfoIsLocal = true) { }

	private void TryShatterIfNeeded(DamageInfo damageInfo, float modifiedArmorDamage) { }

	public IEnumerable UniqueLocalizedZones() { }

}

