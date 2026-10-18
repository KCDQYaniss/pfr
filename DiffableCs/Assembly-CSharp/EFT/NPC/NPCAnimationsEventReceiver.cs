namespace EFT.NPC;

public class NPCAnimationsEventReceiver : MonoBehaviour, IEventsConsumer
{
	[CompilerGenerated]
	private Action OnCurrentAnimationEnded; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnNeedChangeObjectVisibility; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnNeedToPlaySomeSound; //Field offset: 0x30
	private AnimationEventsEmitter _animEventEmitter; //Field offset: 0x38
	private IAnimator _animator; //Field offset: 0x40
	private List _eventsConsumers; //Field offset: 0x48

	public event Action OnCurrentAnimationEnded
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnNeedChangeObjectVisibility
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnNeedToPlaySomeSound
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public NPCAnimationsEventReceiver() { }

	[CompilerGenerated]
	public void add_OnCurrentAnimationEnded(Action value) { }

	[CompilerGenerated]
	public void add_OnNeedChangeObjectVisibility(Action value) { }

	[CompilerGenerated]
	public void add_OnNeedToPlaySomeSound(Action value) { }

	public override void AimReady() { }

	private void Awake() { }

	public override void BipodClose() { }

	public override void BipodOpen() { }

	public override void DropWeapon() { }

	public override void IdleReady() { }

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

	private override void IEventsConsumer.OnSliderOut() { }

	private override void IEventsConsumer.OnSound(string StringParam) { }

	private override void IEventsConsumer.OnSoundAtPoint(string StringParam) { }

	private override void IEventsConsumer.OnStartUtilityOperation() { }

	private override void IEventsConsumer.OnThirdAction(int objectID) { }

	private override void IEventsConsumer.OnUseProp(bool BoolParam) { }

	private override void IEventsConsumer.OnUseSecondMagForReload() { }

	private override void IEventsConsumer.OnWeapIn() { }

	private override void IEventsConsumer.OnWeapOut() { }

	private override void IEventsConsumer.OutUse() { }

	public void Initialize(Animator npcAnimator) { }

	private void OnEventAction(int functionHashName, AnimationEventParameter parameters) { }

	public override void ReloadTest() { }

	[CompilerGenerated]
	public void remove_OnCurrentAnimationEnded(Action value) { }

	[CompilerGenerated]
	public void remove_OnNeedChangeObjectVisibility(Action value) { }

	[CompilerGenerated]
	public void remove_OnNeedToPlaySomeSound(Action value) { }

}

