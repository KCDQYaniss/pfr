namespace EFT.NextObservedPlayer;

public abstract class BaseAnimationHandsController : MonoBehaviour, IEventsConsumer
{
	protected EHandsControllerType _handsControllerType; //Field offset: 0x20
	private IAnimator _bodyAnimator; //Field offset: 0x28
	private FirearmsAnimator _handsAnimator; //Field offset: 0x30
	private AnimationEventsEmitter _handsAnimationEventsEmitter; //Field offset: 0x38
	private Func _needFastForward; //Field offset: 0x40
	private Func _isPlayerCulled; //Field offset: 0x48
	private Action _unsubscribeFromEvent; //Field offset: 0x50
	private BundleAnimationBones _bundleAnimationBones; //Field offset: 0x58
	private HandsOperationAnimatorCallbacks _emptyCallbacks; //Field offset: 0x60
	private readonly CompositeDisposable _compositeDisposable; //Field offset: 0x68
	protected IHandOperation _currentHandsOperation; //Field offset: 0x70
	public bool IsCompleted; //Field offset: 0x78

	public AnimationEventsEmitter AnimationEventsEmitter
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public IAnimator BodyAnimator
	{
		 get { } //Length: 5
	}

	protected HandsOperationAnimatorCallbacks CurrentHandsOperationCallbacks
	{
		 get { } //Length: 73
	}

	public FirearmsAnimator HandsAnimator
	{
		 get { } //Length: 76
	}

	protected abstract Dictionary HandsOperationFactories
	{
		 get { } //Length: 0
	}

	protected BaseAnimationHandsController() { }

	[CompilerGenerated]
	private void <Setup>b__22_0() { }

	[CompilerGenerated]
	private void <Setup>b__22_1(ObservedPlayerCullingChangedEvent raisedEvent) { }

	public override void AimReady() { }

	public override void BipodClose() { }

	public override void BipodOpen() { }

	public void CheckAbortCurrentOperation(CommandMessageType messageType) { }

	public void Complete() { }

	public override void Destroy() { }

	public override void DropWeapon() { }

	public void FastForwardCurrentOperation(bool ignoreAllAndForce = false) { }

	public AnimationEventsEmitter get_AnimationEventsEmitter() { }

	public IAnimator get_BodyAnimator() { }

	protected HandsOperationAnimatorCallbacks get_CurrentHandsOperationCallbacks() { }

	public FirearmsAnimator get_HandsAnimator() { }

	protected abstract Dictionary get_HandsOperationFactories() { }

	public override void IdleReady() { }

	private override void IEventsConsumer.OutUse() { }

	public TO InitiateOperation(TI input) { }

	public override void OnAddAmmoInChamber() { }

	public override void OnAddAmmoInMag() { }

	protected override void OnAnimatorOutUse() { }

	public override void OnArm() { }

	public override void OnBackpackDrop() { }

	public override void OnComboPlanning() { }

	public override void OnCook() { }

	public override void OnCurrentAnimStateEnded() { }

	public override void OnDeactivateObject(int objectID) { }

	public override void OnDelAmmoChamber() { }

	public override void OnDelAmmoFromMag() { }

	public override void OnDisarm() { }

	public override void OnFireEnd() { }

	public override void OnFiringBullet() { }

	public override void OnFoldOff() { }

	public override void OnFoldOn() { }

	public override void OnIdleStart() { }

	public override void OnLauncherAppeared() { }

	public override void OnLauncherDisappeared() { }

	public override void OnMagHide() { }

	public override void OnMagIn() { }

	public override void OnMagOut() { }

	public override void OnMagShow() { }

	public override void OnMalfunctionOff() { }

	public override void OnMessageName() { }

	public override void OnModChanged() { }

	public override void OnOffBoltCatch() { }

	public override void OnOnBoltCatch() { }

	public override void OnPutMagToRig() { }

	public override void OnRemoveShell() { }

	public override void OnReplaceSecondMag() { }

	public override void OnSetActiveObject(int objectID) { }

	public override void OnShellEject() { }

	public override void OnShowAmmo(bool BoolParam) { }

	public override void OnShowMag() { }

	public override void OnSliderOut() { }

	private void OnSomePlayerCullingChanged() { }

	public override void OnSound(string StringParam) { }

	public override void OnSoundAtPoint(string StringParam) { }

	public override void OnStartUtilityOperation() { }

	public override void OnThirdAction(int IntParam) { }

	public override void OnUseProp(bool BoolParam) { }

	public override void OnUseSecondMagForReload() { }

	public override void OnWeapIn() { }

	public override void OnWeapOut() { }

	public override void ReloadTest() { }

	public void ResetAimingAnimationsFlags() { }

	public void set_AnimationEventsEmitter(AnimationEventsEmitter value) { }

	public void SetAimingInAnimator(bool isAiming) { }

	public void SetHandsAnimator(FirearmsAnimator firearmsAnimator) { }

	public void Setup(IAnimator bodyAnimator, FirearmsAnimator handsAnimator, AnimationEventsEmitter animationEventsEmitter, EHandsControllerType controllerType, BundleAnimationBones bundleAnimationBones, Func NeedFastForward, Func isPlayerCulled) { }

	public Task Spawn(float animationSpeed) { }

	public Task Unspawn(Input input) { }

	public void Update() { }

}

