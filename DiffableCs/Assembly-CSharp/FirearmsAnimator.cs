//Type is in global namespace

[Obfuscation(Exclude = True)]
public class FirearmsAnimator : ObjectInHandsAnimator
{
	internal enum EGrenadeFire
	{
		Idle = 0,
		Hold = 1,
		Throw = 2,
	}

	public const int UTILITY_LAYER_INDEX = 2; //Field offset: 0x0
	public const string MALFUNCTION_LAYER = "Malfunction"; //Field offset: 0x0
	public const string STOCK_LAYER = "Stock"; //Field offset: 0x0
	public const string ADDITIONAL_HANDS_LAYER_NAME = "Additional_Hands"; //Field offset: 0x0
	public const string HAMMER_LAYER_NAME = "Hammer"; //Field offset: 0x0
	public const string BOLT_CATCH_LAYER_NAME = "Catch"; //Field offset: 0x0
	public const string HANDS_LAYER_NAME = "Hands"; //Field offset: 0x0
	public const int HANDS_LAYER_INDEX = 0; //Field offset: 0x0
	public const string OPEN_INVENTORY_STATE_NAME = "OPEN INVENTORY"; //Field offset: 0x0
	public const string DRY_FIRE_DISARMED_STATE_NAME = "Hands.DRY FIRE DISARMED"; //Field offset: 0x0
	public const string DRY_FIRE_STATE_NAME = "DRY FIRE"; //Field offset: 0x0
	public const string PATROL_STATE_NAME = "PATROL"; //Field offset: 0x0
	public const string IN_INVENTORY_STATE_NAME = "IN INVENTORY"; //Field offset: 0x0
	public const string IDLE_UNDERBARREL_NAME = "IDLE WEAPON"; //Field offset: 0x0
	public const string JAM_STATE_NAME = "JAM"; //Field offset: 0x0
	public const string SPAWN_STATE_NAME = "SPAWN"; //Field offset: 0x0
	public const string SEMIFIRE_STATE_NAME = "SA FIRE"; //Field offset: 0x0
	public const string DOUBLE_ACTION_FIRE_STATE_NAME = "DOUBLE_ACTION_FIRE"; //Field offset: 0x0
	public const string MISFIRE_STATE_NAME = "MISFIRE"; //Field offset: 0x0
	public const string FIRE_STATE_NAME = "FIRE"; //Field offset: 0x0
	public const string HARD_SLIDE_STATE_NAME = "HARD_SLIDE"; //Field offset: 0x0
	public const string FEED_STATE_NAME = "FEED"; //Field offset: 0x0
	public const string IDLE_STATE_NAME = "IDLE"; //Field offset: 0x0
	public const string IDLE_PLANT_STATE_NAME = "IDLE PLANT"; //Field offset: 0x0
	public const string SOFT_SLIDE_STATE_NAME = "SOFT_SLIDE"; //Field offset: 0x0
	public int ADDITIONAL_HANDS_LAYER_INDEX; //Field offset: 0x38
	public int BOLT_CATCH_LAYER_INDEX; //Field offset: 0x3C
	public int HAMMER_LAYER_INDEX; //Field offset: 0x40
	public int STOCK_LAYER_INDEX; //Field offset: 0x44
	public int MALFUNCTION_LAYER_INDEX; //Field offset: 0x48
	[CompilerGenerated]
	private string <FullFireStateName>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private string <FullSemiFireStateName>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private string <FullDoubleActionFireStateName>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private string <FullIdleStateName>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Action SetPatronInWeaponVisibleEvent; //Field offset: 0x70

	public event Action SetPatronInWeaponVisibleEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private string FullDoubleActionFireStateName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private string FullFireStateName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private string FullIdleStateName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private string FullSemiFireStateName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public FirearmsAnimator() { }

	[CompilerGenerated]
	public void add_SetPatronInWeaponVisibleEvent(Action value) { }

	public void CheckAmmo() { }

	public void CheckChamber() { }

	public void Discharge(bool discharge) { }

	public void Fold(bool folded) { }

	[CompilerGenerated]
	public string get_FullDoubleActionFireStateName() { }

	[CompilerGenerated]
	public string get_FullFireStateName() { }

	[CompilerGenerated]
	public string get_FullIdleStateName() { }

	[CompilerGenerated]
	public string get_FullSemiFireStateName() { }

	public bool GetBoltCatch() { }

	public int GetSightingRange() { }

	public void HammerArmed() { }

	public bool HasNextLimb() { }

	internal void Idle() { }

	public void InsertMagInInventoryMode() { }

	public bool IsHandsProcessing() { }

	public bool IsIdling() { }

	public void LoadOneTrigger(bool loadOne) { }

	public void LookTrigger() { }

	public void Malfunction(int val) { }

	public void MalfunctionRepair(bool val) { }

	public void MisfireSlideUnknown(bool val) { }

	public void ModToggleTrigger() { }

	public void PullOutMagInInventoryMode() { }

	public void Rechamber(bool val) { }

	public void Reload(bool b) { }

	internal void Reload(int currentMagType, int nextMagType, bool isFast) { }

	public void ReloadFast(bool b) { }

	[CompilerGenerated]
	public void remove_SetPatronInWeaponVisibleEvent(Action value) { }

	public void ResetCheckChamberTrigger() { }

	public void ResetGestureTrigger() { }

	public void ResetHandReadyTrigger() { }

	public void ResetInsertMagInInventoryMode() { }

	public void ResetReload() { }

	public void RollToZeroCamora(bool roll) { }

	[CompilerGenerated]
	private void set_FullDoubleActionFireStateName(string value) { }

	[CompilerGenerated]
	private void set_FullFireStateName(string value) { }

	[CompilerGenerated]
	private void set_FullIdleStateName(string value) { }

	[CompilerGenerated]
	private void set_FullSemiFireStateName(string value) { }

	public void SetAimAngle(float playerPitch) { }

	public void SetAiming(bool isAiming) { }

	public void SetAimingFloat(float aiming) { }

	public void SetAimingIn(bool aimingIn) { }

	public void SetAimingOut(bool aimingOut) { }

	public void SetAlternativeFire(bool fire) { }

	public void SetAmmoCompatible(bool compatible) { }

	public void SetAmmoCountForRemove(int count) { }

	public void SetAmmoInChamber(float count) { }

	public void SetAmmoOnMag(int count) { }

	public void SetAnimationVariant(int animationVariant) { }

	public virtual void SetAnimatorGetter(Func getter) { }

	public void SetBipod(bool open) { }

	public void SetBoltActionReload(bool boltActionReload) { }

	public void SetBoltCatch(bool active) { }

	public void SetButterFingers() { }

	public void SetCamoraFireIndex(int camoraFireIndex) { }

	public void SetCamoraIndex(int camoraIndex) { }

	public void SetCamoraIndexForLoadAmmo(int camoraIndex) { }

	public void SetCamoraIndexForUnloadAmmo(int camoraIndex) { }

	public void SetCamoraIndexWithShellForRemove(int camoraIdnex) { }

	public void SetCanReload(bool canReload) { }

	public void SetChamberIndexForLoadUnloadAmmo(float chamberIndex) { }

	public void SetChamberIndexWithShell(float chamberIndex) { }

	public void SetDoubleAction(float doubleAction) { }

	public void SetFire(bool fire) { }

	public void SetFireMode(EFireMode fireMode, bool skipAnimation = false) { }

	public void SetGrenadeAltFire(EGrenadeFire fire) { }

	public void SetGrenadeFire(EGrenadeFire fire) { }

	public void SetHammerArmed(bool isTriggerArmed) { }

	public void SetInteract(bool p, int actionIndex) { }

	public void SetIsExternalMag(bool isExternalMag) { }

	public void SetLauncher(bool isLauncherEnabled) { }

	public void SetLauncherId(int launcherId) { }

	public void SetLooting(bool b) { }

	internal void SetMagFull(bool b) { }

	public void SetMagInWeapon(bool ok) { }

	public void SetMagOutWeapon(bool ok) { }

	public void SetMagTypeCurrent(int magType) { }

	public void SetMagTypeNew(int magType) { }

	internal void SetMalfRepairSpeed(float fix = 1) { }

	public void SetMasteringReloadAborted(bool value) { }

	public void SetMounted(bool mounted) { }

	public void SetNextLimb(bool value) { }

	public void SetPatronInWeaponVisible(bool visible) { }

	public void SetPickup(bool p) { }

	public void SetPrevAimingFloat(bool isAiming) { }

	public void SetRollCylinder(bool roll) { }

	public void SetShellsInWeapon(int count) { }

	internal void SetSpeedParameters(float reload = 1, float draw = 1) { }

	public void SetSprint(bool sprint) { }

	public void SetUnderbarrelSightingRange(float value) { }

	public void SetUniqueAnimationModId(int id) { }

	public void SetupMod(bool modSet) { }

	public void SetUseTimeMultiplier(float speed) { }

	public void SetWeaponLevel(float weaponLevel) { }

	public void TriggerFiremodeCheck() { }

	public void TriggerFold() { }

	internal void WatchClock(EPlayerSide playerSide) { }

}

