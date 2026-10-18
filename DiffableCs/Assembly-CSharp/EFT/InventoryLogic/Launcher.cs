namespace EFT.InventoryLogic;

public class Launcher : GearMod, IWeapon
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__42_0; //Field offset: 0x8
		public static Func <>9__44_0; //Field offset: 0x10
		public static Func <>9__68_0; //Field offset: 0x18
		public static Func <>9__78_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <get_CenterOfImpactDelta>b__68_0(Mod mod) { }

		internal Item <get_Mods>b__42_0(Slot slot) { }

		internal float <get_RecoilDelta>b__78_0(Mod mod) { }

		internal float <get_VelocityDelta>b__44_0(Mod mod) { }

	}

	[CompilerGenerated]
	private sealed class <get_Containers>d__58 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private IContainer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Launcher <>4__this; //Field offset: 0x28
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
		public <get_Containers>d__58(int <>1__state) { }

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

	private const float DEFAULT_DURABILITY = 100; //Field offset: 0x0
	private const float COI = 0.001; //Field offset: 0x0
	public const int RANGE_UP_SPEED = 400; //Field offset: 0x0
	private const int DEFAULT_RANGE_VALUE = 100; //Field offset: 0x0
	public int[] SightingRange; //Field offset: 0x90
	private int _rangeIndex; //Field offset: 0x98
	private int _rangeValue; //Field offset: 0x9C
	public AmmoTemplate[] _shellsInChambers; //Field offset: 0xA0
	public int SelectedSight; //Field offset: 0xA8
	public int SightModesCount; //Field offset: 0xAC
	[CompilerGenerated]
	private Slot[] <Chambers>k__BackingField; //Field offset: 0xB0
	public LauncherTemplate LauncherTemplate; //Field offset: 0xB8
	public bool UseAmmoWithoutShell; //Field offset: 0xC0
	public int LastRangeValue; //Field offset: 0xC4
	public MalfunctionState LauncherMalfState; //Field offset: 0xC8

	public virtual IEnumerable AllSlots
	{
		 get { } //Length: 225
	}

	public float CenterOfImpact
	{
		 get { } //Length: 46
	}

	public float CenterOfImpactDelta
	{
		 get { } //Length: 423
	}

	public Slot Chamber
	{
		 get { } //Length: 42
	}

	public int ChamberAmmoCount
	{
		 get { } //Length: 280
	}

	public override Slot[] Chambers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public virtual IEnumerable Containers
	{
		[IteratorStateMachine(typeof(<get_Containers>d__58))]
		 get { } //Length: 175
	}

	private float DeviationMax
	{
		private get { } //Length: 214
	}

	public override bool IsUnderbarrelWeapon
	{
		 get { } //Length: 3
	}

	public override Item Item
	{
		 get { } //Length: 4
	}

	public override MalfunctionState MalfState
	{
		 get { } //Length: 8
	}

	public Mod[] Mods
	{
		 get { } //Length: 555
	}

	public int RangeIndex
	{
		 get { } //Length: 7
		 set { } //Length: 60
	}

	public int RangeValue
	{
		 get { } //Length: 7
	}

	public override float RecoilBase
	{
		 get { } //Length: 97
	}

	public override float RecoilDelta
	{
		 get { } //Length: 414
	}

	public override float RecoilForceBack
	{
		 get { } //Length: 46
	}

	public AmmoTemplate[] ShellsInChambers
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public int ShellsInLauncherCount
	{
		 get { } //Length: 91
	}

	public float ShotgunDispersionBase
	{
		 get { } //Length: 190
	}

	public override float SpeedFactor
	{
		 get { } //Length: 24
	}

	public float TotalShotgunDispersion
	{
		 get { } //Length: 222
	}

	public float VelocityDelta
	{
		 get { } //Length: 471
	}

	public override WeaponTemplate WeaponTemplate
	{
		 get { } //Length: 32
	}

	protected virtual float Weight
	{
		 get { } //Length: 43
	}

	public Launcher(string id, LauncherTemplate template) { }

	[CompilerGenerated]
	private Slot <.ctor>b__59_0(Slot x) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerable <>n__0() { }

	public void ForceSetSightRangeIndex(int rangeIndex) { }

	public virtual IEnumerable get_AllSlots() { }

	public float get_CenterOfImpact() { }

	public float get_CenterOfImpactDelta() { }

	public Slot get_Chamber() { }

	public int get_ChamberAmmoCount() { }

	[CompilerGenerated]
	public override Slot[] get_Chambers() { }

	[IteratorStateMachine(typeof(<get_Containers>d__58))]
	public virtual IEnumerable get_Containers() { }

	private float get_DeviationMax() { }

	public override bool get_IsUnderbarrelWeapon() { }

	public override Item get_Item() { }

	public override MalfunctionState get_MalfState() { }

	public Mod[] get_Mods() { }

	public int get_RangeIndex() { }

	public int get_RangeValue() { }

	public override float get_RecoilBase() { }

	public override float get_RecoilDelta() { }

	public override float get_RecoilForceBack() { }

	public AmmoTemplate[] get_ShellsInChambers() { }

	public int get_ShellsInLauncherCount() { }

	public float get_ShotgunDispersionBase() { }

	public override float get_SpeedFactor() { }

	public float get_TotalShotgunDispersion() { }

	public float get_VelocityDelta() { }

	public override WeaponTemplate get_WeaponTemplate() { }

	protected virtual float get_Weight() { }

	private float GetBarrelDeviation(float durability) { }

	public float GetBarrelDeviation() { }

	public float GetCenterOfImpact(bool includeAmmo) { }

	public virtual IContainer GetContainer(string containerId) { }

	public override int GetCurrentMagazineCount() { }

	public void NextMode() { }

	public void ResetRangeValueToDefault() { }

	[CompilerGenerated]
	public void set_Chambers(Slot[] value) { }

	public void set_RangeIndex(int value) { }

	public void set_ShellsInChambers(AmmoTemplate[] value) { }

	public void SightingRangeDown() { }

	public void SightingRangeUp() { }

	public virtual bool TryFindItem(string itemId, out Item item) { }

}

