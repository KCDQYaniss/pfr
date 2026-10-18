namespace EFT;

public interface IFirearmHandsController : IWeaponController, IHandsController, ICompassController
{

	public BindableState CompassState
	{
		 get { } //Length: 0
	}

	public bool IsOverlap
	{
		 get { } //Length: 0
	}

	public Weapon Item
	{
		 get { } //Length: 0
	}

	public bool CanPressTrigger() { }

	public bool CanStartReload(bool checkWeaponMalfunctions = true) { }

	public void ChangeAimingMode() { }

	public bool ChangeFireMode(EFireMode fireMode) { }

	public void ChangeLeftStance() { }

	public bool CheckAmmo() { }

	public bool CheckChamber() { }

	public bool CheckFireMode() { }

	public void ClickAim() { }

	public bool ExamineWeapon() { }

	public BindableState get_CompassState() { }

	public bool get_IsOverlap() { }

	public Weapon get_Item() { }

	public bool HasScopeAimBone(SightComponent sightComp) { }

	public bool IsInLauncherMode() { }

	public void OpticCalibrationSwitchDown(ScopeState[] scopeStates) { }

	public void OpticCalibrationSwitchUp(ScopeState[] scopeStates) { }

	public void PressingAim() { }

	public void QuickReloadMag(Magazine foundItem, Callback callback) { }

	public void ReloadBarrels(AmmoPack ammoPack, ItemAddress placeToPutContainedAmmoMagazine, Callback callback) { }

	public void ReloadCylinderMagazine(AmmoPack ammoPack, Callback callback, bool quickReload) { }

	public void ReloadGrenadeLauncher(AmmoPack foundItem, Callback callback) { }

	public void ReloadMag(Magazine foundItem, ItemAddress itemAddress, Callback callback) { }

	public void ReloadMagNotFound() { }

	public void ReloadWithAmmo(AmmoPack foundItem, Callback callback) { }

	public void RollCylinder(bool rollToZeroCamora) { }

	public void SetAim(bool value) { }

	public bool SetLightsState(LightsState[] lightsStates, bool force = false, bool animated = true) { }

	public void SetScopeMode(ScopeState[] scopeStates) { }

	public void SetTriggerPressed(bool pressed) { }

	public bool ShouldForceQuickReload() { }

	public void ToggleAim() { }

	public bool ToggleBipod() { }

	public bool ToggleLauncher(Action callback = null) { }

	public void UnderbarrelSightingRangeDown() { }

	public void UnderbarrelSightingRangeUp() { }

	public void UnpressingAim() { }

}

