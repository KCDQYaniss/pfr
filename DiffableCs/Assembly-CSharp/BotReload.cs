//Type is in global namespace

public abstract class BotReload : BotData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__37_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ReloadMagazine>b__37_1(GridItemAddress x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public Magazine magModInWeapon; //Field offset: 0x10
		public BotReload <>4__this; //Field offset: 0x18

		public <>c__DisplayClass37_0() { }

		internal GridItemAddress <ReloadMagazine>b__0(Grid grid) { }

		internal void <ReloadMagazine>b__2(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public BotReload <>4__this; //Field offset: 0x10
		public int stockCount; //Field offset: 0x18
		public MongoID ammoToAdd; //Field offset: 0x20

		public <>c__DisplayClass38_0() { }

		internal void <ReloadAmmo>b__0(IResult s) { }

		internal void <ReloadAmmo>b__1(IResult s) { }

		internal void <ReloadAmmo>b__2(IResult s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public string templateId; //Field offset: 0x10
		public Func <>9__2; //Field offset: 0x18

		public <>c__DisplayClass44_0() { }

		internal bool <AddAmmoToPockets>b__0(Item x) { }

		internal bool <AddAmmoToPockets>b__1(Item x) { }

		internal bool <AddAmmoToPockets>b__2(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public Slot magazineSlot; //Field offset: 0x10

		public <>c__DisplayClass45_0() { }

		internal bool <AddAmmoToMagazines>b__0(Magazine mag) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public Magazine foundMag; //Field offset: 0x10

		public <>c__DisplayClass46_0() { }

		internal void <AddAmmoToMag>g__NetworkTransactionCallback|0(IResult result) { }

	}

	internal enum EReloadType
	{
		MagReload = 0,
		AmmoReload = 1,
	}

	protected const int AMMO_RELOAD_MAX_TIME = 40; //Field offset: 0x0
	protected const int MAG_RELOAD_MAX_TIME = 16; //Field offset: 0x0
	protected const float PAUSE_BETWEEN_TRY_TO_RELOAD = 0.5; //Field offset: 0x0
	protected static readonly EquipmentSlot[] _availableEquipmentSlots; //Field offset: 0x0
	protected static readonly List _preallocatedMagazineList; //Field offset: 0x8
	protected static readonly List _preallocatedAmmoList; //Field offset: 0x10
	protected readonly Player _player; //Field offset: 0x18
	protected float _reloadStartTime; //Field offset: 0x20
	protected bool _reloading; //Field offset: 0x24
	protected float _nextReloadTime; //Field offset: 0x28
	protected bool _reloadFailDebug; //Field offset: 0x2C
	protected EReloadType _reloadType; //Field offset: 0x30
	protected float _nextCanExtraLoadAmmo; //Field offset: 0x34
	protected float _nextPossibleTryStopReload; //Field offset: 0x38
	protected Weapon _weapon; //Field offset: 0x40
	[CompilerGenerated]
	private bool <NoAmmoForReloadCached>k__BackingField; //Field offset: 0x48

	public int BulletCount
	{
		 get { } //Length: 326
	}

	public int MaxBulletCount
	{
		 get { } //Length: 212
	}

	public bool NoAmmoForReloadCached
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool Reloading
	{
		 get { } //Length: 5
		 set { } //Length: 121
	}

	protected IFirearmHandsController ShootController
	{
		 get { } //Length: 39
	}

	private static BotReload() { }

	protected BotReload(BotOwner owner, Weapon weapon) { }

	private bool AcceptableMagInventorySearchDelegate(Ammo ammo) { }

	private void AddAmmoToMag(Weapon weapon, Magazine foundMag) { }

	private void AddAmmoToMagazines() { }

	protected override void AddAmmoToPockets(string templateId, int targetCount) { }

	public bool CanReload(bool withCheckByPeriod) { }

	public abstract bool CanReload(bool withCheckByPeriod, out Magazine foundMag, out List ammoForInternalReload) { }

	protected bool CanReloadPreCheck(bool withCheckByPeriod, out Magazine currentMagazine) { }

	public void CheckReloadLongTime() { }

	public static BotReload Create(BotOwner owner, Weapon weapon, EquipmentSlot slot) { }

	public void Dispose() { }

	public override bool FightShallReload() { }

	private Ammo FindAmmoToReloadMag(Weapon weapon, Magazine foundMag) { }

	public int get_BulletCount() { }

	public int get_MaxBulletCount() { }

	[CompilerGenerated]
	public bool get_NoAmmoForReloadCached() { }

	public bool get_Reloading() { }

	protected IFirearmHandsController get_ShootController() { }

	protected Magazine GetMagazineForReload(Weapon weapon) { }

	public override void ManualUpdate() { }

	private void OnUnderbarrelLauncherReloadStatusChanged(bool status) { }

	public override void Reload() { }

	protected override void ReloadAmmo(List foundAmmo) { }

	protected override void ReloadMagazine(Magazine foundMag) { }

	[CompilerGenerated]
	protected void set_NoAmmoForReloadCached(bool value) { }

	protected void set_Reloading(bool value) { }

	public void TryFillMagazines() { }

	public bool TryReload() { }

	public void TryStopReload() { }

	protected void TryUploadMagazine() { }

}

