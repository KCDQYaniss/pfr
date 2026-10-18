//Type is in global namespace

public class BotWeaponSelector : BotData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__60_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <SetSlotItem>b__60_0(string current, Slot slot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public BotWeaponSelector <>4__this; //Field offset: 0x10
		public EquipmentSlot slot; //Field offset: 0x18
		public Action callback; //Field offset: 0x20

		public <>c__DisplayClass58_0() { }

		internal void <TryChangeToSlot>b__0(Result x) { }

	}

	private const int MAX_ERRORS = 20; //Field offset: 0x0
	private const float CHANGE_WEAPON_PERIOD = 25; //Field offset: 0x0
	protected Item _firstPrimaryWeaponItem; //Field offset: 0x18
	protected Item _secondPrimaryWeaponItem; //Field offset: 0x20
	protected EquipmentSlot _lastEquipmentSlot; //Field offset: 0x28
	protected bool _canChangeToSecondWeapons; //Field offset: 0x2C
	private Item _holsterItem; //Field offset: 0x30
	protected Item _melee; //Field offset: 0x38
	protected EquipmentSlot _mainWeapon; //Field offset: 0x40
	private EquipmentSlot _secondWeapon; //Field offset: 0x44
	private readonly EquipmentSlot _meleeWeapon; //Field offset: 0x48
	private EquipmentSlot _supportWeapon; //Field offset: 0x4C
	[CompilerGenerated]
	private bool <CanChangeToMeleeWeapons>k__BackingField; //Field offset: 0x50
	private bool _errorStuckLog; //Field offset: 0x51
	private bool _isFound; //Field offset: 0x52
	protected bool _canChangeToSupportWeapons; //Field offset: 0x53
	private float _nextChangeTime; //Field offset: 0x54
	private int _errorCounter; //Field offset: 0x58
	private float _prevChangeWeaponTime; //Field offset: 0x5C
	private float _startChangeTime; //Field offset: 0x60
	[CompilerGenerated]
	private bool <IsWeaponReady>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private bool <IsChanging>k__BackingField; //Field offset: 0x65
	public Action OnActiveEquipmentSlotChanged; //Field offset: 0x68

	public bool CanChangeToMeleeWeapons
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool CanChangeToSecondWeapons
	{
		 get { } //Length: 5
	}

	private float ChangeWeaponPeriod
	{
		private get { } //Length: 58
	}

	public EquipmentSlot EquipmentSlot
	{
		 get { } //Length: 4
	}

	public Item FirstPrimaryWeaponItem
	{
		 get { } //Length: 5
	}

	public bool IsChanging
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsWeaponReady
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public EquipmentSlot LastEquipmentSlot
	{
		 get { } //Length: 4
	}

	public Item SecondPrimaryWeaponItem
	{
		 get { } //Length: 5
	}

	public override bool ShouldChnageFromMeleeOnHold
	{
		 get { } //Length: 3
	}

	public BotWeaponSelector(BotOwner owner) { }

	public override void Activate() { }

	public bool CanChangeWeaponCauseEnemyDistance() { }

	public bool ChangeToMain() { }

	public void ChangeToMelee() { }

	public bool ChangeToSecond(Action callback = null) { }

	private bool ChangeToSupport() { }

	public void Dispose() { }

	protected override void FindItemsInSlots(bool anyway) { }

	[CompilerGenerated]
	public bool get_CanChangeToMeleeWeapons() { }

	public bool get_CanChangeToSecondWeapons() { }

	private float get_ChangeWeaponPeriod() { }

	public EquipmentSlot get_EquipmentSlot() { }

	public Item get_FirstPrimaryWeaponItem() { }

	[CompilerGenerated]
	public bool get_IsChanging() { }

	[CompilerGenerated]
	public bool get_IsWeaponReady() { }

	public EquipmentSlot get_LastEquipmentSlot() { }

	public Item get_SecondPrimaryWeaponItem() { }

	public override bool get_ShouldChnageFromMeleeOnHold() { }

	public override void ManualUpdate() { }

	protected override void OnWeaponTaken(Result x) { }

	[CompilerGenerated]
	protected void set_CanChangeToMeleeWeapons(bool value) { }

	[CompilerGenerated]
	protected void set_IsChanging(bool value) { }

	[CompilerGenerated]
	public void set_IsWeaponReady(bool value) { }

	protected override void SetSlotItem(Callback onSpawn, bool order) { }

	public bool ShallChangeIfNoAmmo(EnemyInfo goalEnemy) { }

	public void TakeMainWeapon() { }

	public bool TakePrevWeapon() { }

	public bool TryChangeToMain() { }

	protected override bool TryChangeToSlot(EquipmentSlot slot, bool changeToMain, Action callback = null) { }

	public bool TryChangeWeapon(bool ignoreDistance = false) { }

	public void TryChangeWeaponCauseNoAmmo() { }

	public void TrySwitchToLauncherOrChangeWeapon() { }

	public void UpdateWeaponsList() { }

}

