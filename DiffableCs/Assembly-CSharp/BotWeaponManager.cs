//Type is in global namespace

public class BotWeaponManager : BotData
{
	private const float BLOCK_AUTO_FIRE_PERIOD = 60; //Field offset: 0x0
	[CompilerGenerated]
	private Action WeaponHandsChangedEvent; //Field offset: 0x18
	private readonly BotWeaponPresetCollection _presetCollection; //Field offset: 0x20
	private Dictionary info; //Field offset: 0x28
	private BotWeaponInfo _currentWeaponInfo; //Field offset: 0x30
	private AIPeriodAction _periodCheckAutoFire; //Field offset: 0x38
	[CompilerGenerated]
	private BotWeaponSelector <Selector>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private BotMeleeWeaponData <Melee>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private BotStationaryWeaponData <Stationary>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private BotGrenadeController <Grenades>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly BotUnderbarrelLauncherController <UnderbarrelLauncherController>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private BotMalfunctionData <Malfunctions>k__BackingField; //Field offset: 0x68
	private bool _canBeAutomatic; //Field offset: 0x70
	private bool _isScatteringFixed; //Field offset: 0x71
	[CompilerGenerated]
	private IFirearmHandsController <ShootController>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private bool <IsReady>k__BackingField; //Field offset: 0x80
	public float CriticalBulletCount; //Field offset: 0x84
	private float _blockAutoFireUntil; //Field offset: 0x88
	private bool _disposed; //Field offset: 0x8C
	[CompilerGenerated]
	private float <AmbushDistance>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private bool <IsCloseWeapon>k__BackingField; //Field offset: 0x94

	public event Action WeaponHandsChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private float AmbushDistance
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public Weapon CurrentWeapon
	{
		 get { } //Length: 119
	}

	private float distanceToOffAutomaticFire
	{
		private get { } //Length: 58
	}

	private float distanceToOnAutomaticFire
	{
		private get { } //Length: 58
	}

	public private BotGrenadeController Grenades
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool HandsControllerCanRemove
	{
		 get { } //Length: 81
	}

	public bool HaveBullets
	{
		 get { } //Length: 62
	}

	public bool IsChangingWeapon
	{
		 get { } //Length: 68
	}

	public private bool IsCloseWeapon
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsHandsNull
	{
		 get { } //Length: 254
	}

	public bool IsInInteractionStrictCheck
	{
		 get { } //Length: 81
	}

	public bool IsMelee
	{
		 get { } //Length: 27
	}

	public bool IsNowAutomatic
	{
		 get { } //Length: 56
	}

	public private bool IsReady
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsWeaponReady
	{
		 get { } //Length: 27
	}

	public BotWeaponInfo MainWeaponInfo
	{
		 get { } //Length: 111
	}

	public private BotMalfunctionData Malfunctions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotMeleeWeaponData Melee
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotWeaponInfo MeleeWeaponInfo
	{
		 get { } //Length: 114
	}

	public BotWeaponInfo PistolWeaponInfo
	{
		 get { } //Length: 114
	}

	public BotReload Reload
	{
		 get { } //Length: 27
	}

	public BotWeaponInfo SecondWeaponInfo
	{
		 get { } //Length: 114
	}

	public private BotWeaponSelector Selector
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private IFirearmHandsController ShootController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool StateIsSuitableForHandInput
	{
		 get { } //Length: 41
	}

	public private BotStationaryWeaponData Stationary
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotUnderbarrelLauncherController UnderbarrelLauncherController
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public WeaponAIPreset WeaponAIPreset
	{
		 get { } //Length: 27
	}

	public BotWeaponManager(BotOwner owner) { }

	public override void Activate() { }

	[CompilerGenerated]
	public void add_WeaponHandsChangedEvent(Action value) { }

	private void CacheActiveEquipmentSlot(EquipmentSlot slot) { }

	public bool CanChangeHands() { }

	private bool ChangeToMode(EFireMode obj) { }

	private void CheckAutomaticFire() { }

	public void CheckCurMainWeapon() { }

	private void CheckOnAutomaticFire(Weapon weapon) { }

	public void CheckWeaponReady() { }

	private void ChecnBlockAuto(Vector3 from) { }

	public void Dispose() { }

	[CompilerGenerated]
	public float get_AmbushDistance() { }

	public Weapon get_CurrentWeapon() { }

	private float get_distanceToOffAutomaticFire() { }

	private float get_distanceToOnAutomaticFire() { }

	[CompilerGenerated]
	public BotGrenadeController get_Grenades() { }

	public bool get_HandsControllerCanRemove() { }

	public bool get_HaveBullets() { }

	public bool get_IsChangingWeapon() { }

	[CompilerGenerated]
	public bool get_IsCloseWeapon() { }

	public bool get_IsHandsNull() { }

	public bool get_IsInInteractionStrictCheck() { }

	public bool get_IsMelee() { }

	public bool get_IsNowAutomatic() { }

	[CompilerGenerated]
	public bool get_IsReady() { }

	public bool get_IsWeaponReady() { }

	public BotWeaponInfo get_MainWeaponInfo() { }

	[CompilerGenerated]
	public BotMalfunctionData get_Malfunctions() { }

	[CompilerGenerated]
	public BotMeleeWeaponData get_Melee() { }

	public BotWeaponInfo get_MeleeWeaponInfo() { }

	public BotWeaponInfo get_PistolWeaponInfo() { }

	public BotReload get_Reload() { }

	public BotWeaponInfo get_SecondWeaponInfo() { }

	[CompilerGenerated]
	public BotWeaponSelector get_Selector() { }

	[CompilerGenerated]
	public IFirearmHandsController get_ShootController() { }

	public bool get_StateIsSuitableForHandInput() { }

	[CompilerGenerated]
	public BotStationaryWeaponData get_Stationary() { }

	[CompilerGenerated]
	public BotUnderbarrelLauncherController get_UnderbarrelLauncherController() { }

	public WeaponAIPreset get_WeaponAIPreset() { }

	public string GetCurrentHandsControllerState() { }

	public string GetCurrentHandsItemTemplateId() { }

	public bool InIdleState() { }

	public override void ManualUpdate() { }

	private void OnBulletNear(BotOwner arg1, IPlayer source) { }

	private void OnGetHit(DamageInfo arg1, EBodyPart arg2, float arg3) { }

	public void PreActivate() { }

	[CompilerGenerated]
	public void remove_WeaponHandsChangedEvent(Action value) { }

	[CompilerGenerated]
	private void set_AmbushDistance(float value) { }

	[CompilerGenerated]
	private void set_Grenades(BotGrenadeController value) { }

	[CompilerGenerated]
	private void set_IsCloseWeapon(bool value) { }

	[CompilerGenerated]
	private void set_IsReady(bool value) { }

	[CompilerGenerated]
	private void set_Malfunctions(BotMalfunctionData value) { }

	[CompilerGenerated]
	private void set_Melee(BotMeleeWeaponData value) { }

	[CompilerGenerated]
	private void set_Selector(BotWeaponSelector value) { }

	[CompilerGenerated]
	private void set_ShootController(IFirearmHandsController value) { }

	[CompilerGenerated]
	private void set_Stationary(BotStationaryWeaponData value) { }

	public void StationaryTaken(IFirearmHandsController fireArms, StationaryWeapon stationaryWeapon) { }

	public void TryReloadWeaponOrUnderbarrelLauncher() { }

	private void UpdateFirearmsController(IFirearmHandsController firearmHandsController, StationaryWeapon stationaryWeapon) { }

	public void UpdateHandsController(IHandsController handsController, out bool allFine) { }

	public void UpdateWeaponsList() { }

}

