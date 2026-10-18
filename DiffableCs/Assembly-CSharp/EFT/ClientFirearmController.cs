namespace EFT;

internal sealed class ClientFirearmController : FirearmController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public ItemAddress itemAddress; //Field offset: 0x10
		public ClientFirearmController <>4__this; //Field offset: 0x18
		public Magazine magazine; //Field offset: 0x20

		public <>c__DisplayClass19_0() { }

		internal void <ReloadMag>b__0(IResult error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public ClientFirearmController <>4__this; //Field offset: 0x10
		public bool quickReload; //Field offset: 0x18
		public string[] ammoIds; //Field offset: 0x20
		public List shellsIndexes; //Field offset: 0x28
		public CylinderMagazine cylinderMagazine; //Field offset: 0x30

		public <>c__DisplayClass21_0() { }

		internal void <ReloadCylinderMagazine>b__0(IResult error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public ItemAddress placeToPutContainedAmmoMagazine; //Field offset: 0x10
		public ClientFirearmController <>4__this; //Field offset: 0x18
		public AmmoPack ammoPack; //Field offset: 0x20

		public <>c__DisplayClass22_0() { }

		internal void <ReloadBarrels>b__0(IResult error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public ClientFirearmController <>4__this; //Field offset: 0x10
		public string[] ammoIds; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

		internal void <ReloadWithAmmo>b__0(IResult error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public ClientFirearmController <>4__this; //Field offset: 0x10
		public CylinderMagazine cylinderMagazine; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		internal void <RollCylinder>b__0(IResult finishCallback) { }

	}

	internal class ClientBoltActionFireOperation : BoltActionFireOperation
	{
		private readonly ClientFirearmController _clientFirearmController; //Field offset: 0xA0
		private bool _boltActionReloadSended; //Field offset: 0xA8

		public ClientBoltActionFireOperation(FirearmController controller) { }

		public virtual void QuickReloadMag(Magazine magazine, Callback finishCallback, Callback startCallback) { }

		public virtual void ReloadMag(Magazine magazine, ItemAddress itemAddress, Callback finishCallback, Callback startCallback) { }

		public virtual void ReloadWithAmmo(AmmoPack ammoPack, Callback finishCallback, Callback startCallback) { }

		public virtual void Reset() { }

		private void SendBoltActionReloadInPacket(bool value) { }

		public virtual void SetInventoryOpened(bool opened) { }

		public virtual void SetTriggerPressed(bool pressed) { }

		public virtual void Start() { }

	}

	internal class ClientPlayerReloadCylinderMagOperation : ReloadCylinderMagOperation
	{
		private readonly ClientFirearmController _clientFirearmController; //Field offset: 0xC0

		public ClientPlayerReloadCylinderMagOperation(FirearmController controller) { }

		public virtual void SetTriggerPressed(bool pressed) { }

		protected virtual void SwitchToIdle() { }

	}

	internal class ClientPlayerReloadInternalMagOperation : ReloadInternalMagOperation
	{
		private readonly ClientFirearmController _clientFirearmController; //Field offset: 0xA0

		public ClientPlayerReloadInternalMagOperation(FirearmController controller) { }

		public virtual void SetTriggerPressed(bool pressed) { }

		protected virtual void SwitchToIdle() { }

	}

	internal class ClientPlayerReloadInternalMagWithOpenBoltOperation : ReloadInternalMagWithOpenBoltOperation
	{
		private readonly ClientFirearmController _clientFirearmController; //Field offset: 0xA0

		public ClientPlayerReloadInternalMagWithOpenBoltOperation(FirearmController controller) { }

		public virtual void SetTriggerPressed(bool pressed) { }

		protected virtual void SwitchToIdle() { }

	}

	private const int MAX_SHOTS_FOR_APPROVE = 12; //Field offset: 0x0
	private const int MAX_SPECTATOR_SCOPE_ZOOM_STATUSES = 7; //Field offset: 0x0
	public FirearmPacket FirearmPacket; //Field offset: 0x1F0
	private readonly List _firedShots; //Field offset: 0x430
	private readonly List _shotsWaitingApproval; //Field offset: 0x438
	private readonly Shot[] _shotsFragmentsBuffer; //Field offset: 0x440
	private byte LastShotId; //Field offset: 0x448
	private EShotType LastShotType; //Field offset: 0x44C

	public ClientFirearmController() { }

	[CompilerGenerated]
	private ObjectInHandsOperation <GetOperationFactoryDelegates>b__57_0() { }

	[CompilerGenerated]
	private ObjectInHandsOperation <GetOperationFactoryDelegates>b__57_1() { }

	[CompilerGenerated]
	private ObjectInHandsOperation <GetOperationFactoryDelegates>b__57_2() { }

	private void AbortInternalMagReloadOperation(int ammoToLoadIntoMag) { }

	protected virtual void AimingChanged(bool newValue) { }

	public virtual void BallisticUpdate(float deltaTime) { }

	public virtual bool CanPressTrigger() { }

	public virtual bool CanStartReload(bool checkWeaponMalfunctions = true) { }

	public virtual void ChangeAimingMode(int modeIndex) { }

	public virtual void ChangeAimingMode() { }

	public virtual bool ChangeFireMode(EFireMode fireMode) { }

	public virtual void ChangeLeftStance() { }

	public virtual bool CheckAmmo() { }

	public virtual bool CheckChamber() { }

	public virtual bool CheckFireMode() { }

	protected virtual void CompassStateHandler(bool isActive) { }

	internal static ClientFirearmController Create(ClientPlayer player, Weapon weapon) { }

	internal static Task CreateAsync(ClientPlayer player, string itemId, bool isStationaryWeapon) { }

	protected virtual void CreateFlareShot(Ammo ammo, Vector3 shotPosition, Vector3 shotForward) { }

	protected virtual void CreateRocketShot(Ammo ammo, Vector3 shotPosition, Vector3 shotForward, Transform smokeport = null) { }

	protected private virtual void DryShot(int chamberIndex = 0, bool underbarrelShot = false) { }

	public virtual bool ExamineWeapon() { }

	protected virtual Dictionary GetOperationFactoryDelegates() { }

	protected virtual void InitBallisticCalculator() { }

	protected virtual void LightAndSoundShot(Vector3 point, Vector3 direction, AmmoTemplate ammoTemplate) { }

	public virtual void OpticCalibrationSwitchDown(ScopeState[] scopeStates) { }

	public virtual void OpticCalibrationSwitchUp(ScopeState[] scopeStates) { }

	protected virtual void ProcessShotInPacket(IWeapon weapon, int chamberIndex, float overheat, Vector3 shotPosition, Vector3 shotDirection, Vector3 fireportPosition) { }

	public virtual void QuickReloadMag(Magazine magazine, Callback callback) { }

	private void RefreshSightsStatusInFirearmPacket(ScopeState[] scopeStates) { }

	protected virtual void RegisterShot(Item weapon, Shot shot) { }

	public virtual void ReloadBarrels(AmmoPack ammoPack, ItemAddress placeToPutContainedAmmoMagazine, Callback callback) { }

	public virtual void ReloadCylinderMagazine(AmmoPack ammoPack, Callback callback, bool quickReload = false) { }

	public virtual void ReloadGrenadeLauncher(AmmoPack ammoPack, Callback callback) { }

	private void ReloadInternalMagFinished(int ammoToLoadIntoMag) { }

	public virtual void ReloadMag(Magazine magazine, ItemAddress itemAddress, Callback callback) { }

	public virtual void ReloadWithAmmo(AmmoPack ammoPack, Callback callback) { }

	protected virtual void RemoveBallisticCalculator() { }

	public virtual void RollCylinder(bool rollToZeroCamora) { }

	private void SendCylinderMagPacket(Weapon weapon) { }

	protected virtual void SendStartOneShotFire() { }

	public virtual void SetAim(bool value) { }

	public virtual void SetInventoryOpened(bool opened) { }

	public virtual bool SetLightsState(LightsState[] lightsStates, bool force = false, bool animated = true) { }

	public virtual void SetScopeMode(ScopeState[] scopeStates) { }

	protected virtual void ShotMisfired(Ammo ammo, EMalfunctionState malfunctionState, float overheat) { }

	public virtual void ShowGesture(EInteraction gesture) { }

	protected virtual void SmoothScopeZoomValueChanged(SightComponent sightComponent, float scopeZoomValue) { }

	public virtual bool ToggleBipod() { }

	public virtual bool ToggleLauncher(Action callback) { }

	public virtual void UnderbarrelSightingRangeDown() { }

	public virtual void UnderbarrelSightingRangeUp() { }

	private void UpdateShotsList() { }

}

