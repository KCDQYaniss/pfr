//Type is in global namespace

public interface IEventsConsumer
{

	public void AimReady() { }

	public void BipodClose() { }

	public void BipodOpen() { }

	public void DropWeapon() { }

	public void IdleReady() { }

	public void OnAddAmmoInChamber() { }

	public void OnAddAmmoInMag() { }

	public void OnArm() { }

	public void OnBackpackDrop() { }

	public void OnComboPlanning() { }

	public void OnCook() { }

	public void OnCurrentAnimStateEnded() { }

	public void OnDeactivateObject(int objectID) { }

	public void OnDelAmmoChamber() { }

	public void OnDelAmmoFromMag() { }

	public void OnDisarm() { }

	public void OnFireEnd() { }

	public void OnFiringBullet() { }

	public void OnFoldOff() { }

	public void OnFoldOn() { }

	public void OnIdleStart() { }

	public void OnLauncherAppeared() { }

	public void OnLauncherDisappeared() { }

	public void OnMagHide() { }

	public void OnMagIn() { }

	public void OnMagOut() { }

	public void OnMagShow() { }

	public void OnMalfunctionOff() { }

	public void OnMessageName() { }

	public void OnModChanged() { }

	public void OnOffBoltCatch() { }

	public void OnOnBoltCatch() { }

	public void OnPutMagToRig() { }

	public void OnRemoveShell() { }

	public void OnReplaceSecondMag() { }

	public void OnSetActiveObject(int objectID) { }

	public void OnShellEject() { }

	public void OnShowAmmo(bool BoolParam) { }

	public void OnShowMag() { }

	public void OnSliderOut() { }

	public void OnSound(string StringParam) { }

	public void OnSoundAtPoint(string StringParam) { }

	public void OnStartUtilityOperation() { }

	public void OnThirdAction(int IntParam) { }

	public void OnUseProp(bool BoolParam) { }

	public void OnUseSecondMagForReload() { }

	public void OnWeapIn() { }

	public void OnWeapOut() { }

	public void OutUse() { }

	public void ReloadTest() { }

}

