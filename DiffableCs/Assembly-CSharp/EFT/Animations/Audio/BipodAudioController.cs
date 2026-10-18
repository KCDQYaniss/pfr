namespace EFT.Animations.Audio;

public class BipodAudioController : MonoBehaviour, IWeaponModAudioController, IEventsConsumer
{
	private const float CHECK_SURFACE_RAYCAST_LENGTH = 1; //Field offset: 0x0
	[SerializeField]
	private AudioMultipleClipContainer _bipodOpenSounds; //Field offset: 0x20
	[SerializeField]
	private AudioMultipleClipContainer _bipodCloseSounds; //Field offset: 0x28
	[SerializeField]
	private SurfaceSoundContainers _bipodMountSurfaceSounds; //Field offset: 0x30
	private IObserverToPlayerBridge _playerBridge; //Field offset: 0x38
	private FirearmsAnimator _firearmsAnimator; //Field offset: 0x40
	private IEnumerator _timerCoroutine; //Field offset: 0x48

	public BipodAudioController() { }

	public override void Clear() { }

	private void EnterMountedStateHandler(float timeToMount) { }

	private void ExitMountedStateHandler(float timeToUnmount) { }

	private override void IEventsConsumer.AimReady() { }

	private override void IEventsConsumer.BipodClose() { }

	private override void IEventsConsumer.BipodOpen() { }

	private override void IEventsConsumer.DropWeapon() { }

	private override void IEventsConsumer.IdleReady() { }

	private override void IEventsConsumer.OnAddAmmoInChamber() { }

	private override void IEventsConsumer.OnAddAmmoInMag() { }

	private override void IEventsConsumer.OnArm() { }

	private override void IEventsConsumer.OnBackpackDrop() { }

	private override void IEventsConsumer.OnComboPlanning() { }

	private override void IEventsConsumer.OnCook() { }

	private override void IEventsConsumer.OnCurrentAnimStateEnded() { }

	private override void IEventsConsumer.OnDeactivateObject(int objectID) { }

	private override void IEventsConsumer.OnDelAmmoChamber() { }

	private override void IEventsConsumer.OnDelAmmoFromMag() { }

	private override void IEventsConsumer.OnDisarm() { }

	private override void IEventsConsumer.OnFireEnd() { }

	private override void IEventsConsumer.OnFiringBullet() { }

	private override void IEventsConsumer.OnFoldOff() { }

	private override void IEventsConsumer.OnFoldOn() { }

	private override void IEventsConsumer.OnIdleStart() { }

	private override void IEventsConsumer.OnLauncherAppeared() { }

	private override void IEventsConsumer.OnLauncherDisappeared() { }

	private override void IEventsConsumer.OnMagHide() { }

	private override void IEventsConsumer.OnMagIn() { }

	private override void IEventsConsumer.OnMagOut() { }

	private override void IEventsConsumer.OnMagShow() { }

	private override void IEventsConsumer.OnMalfunctionOff() { }

	private override void IEventsConsumer.OnMessageName() { }

	private override void IEventsConsumer.OnModChanged() { }

	private override void IEventsConsumer.OnOffBoltCatch() { }

	private override void IEventsConsumer.OnOnBoltCatch() { }

	private override void IEventsConsumer.OnPutMagToRig() { }

	private override void IEventsConsumer.OnRemoveShell() { }

	private override void IEventsConsumer.OnReplaceSecondMag() { }

	private override void IEventsConsumer.OnSetActiveObject(int objectID) { }

	private override void IEventsConsumer.OnShellEject() { }

	private override void IEventsConsumer.OnShowAmmo(bool BoolParam) { }

	private override void IEventsConsumer.OnShowMag() { }

	private override void IEventsConsumer.OnSound(string StringParam) { }

	private override void IEventsConsumer.OnSoundAtPoint(string StringParam) { }

	private override void IEventsConsumer.OnStartUtilityOperation() { }

	private override void IEventsConsumer.OnThirdAction(int IntParam) { }

	private override void IEventsConsumer.OnUseProp(bool boolParam) { }

	private override void IEventsConsumer.OnUseSecondMagForReload() { }

	private override void IEventsConsumer.OnWeapIn() { }

	private override void IEventsConsumer.OnWeapOut() { }

	private override void IEventsConsumer.OutUse() { }

	private override void IEventsConsumer.ReloadTest() { }

	public override void Init(int playerRaidId, FirearmsAnimator firearmsAnimator) { }

	private void OnBipodClose() { }

	private void OnBipodOpen() { }

	private void OnDestroy() { }

	private void OnInit() { }

	public override void OnSliderOut() { }

	private void PlayAtPoint(IAudioClipContainer clipContainer) { }

	private void PlayMountSound() { }

	private void Subscribe() { }

	private void SubscribeToAnimatorEvents() { }

	private void Unsubscribe() { }

	private void UnsubscribeFromAnimatorEvents() { }

}

