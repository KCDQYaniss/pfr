//Type is in global namespace

public class MenuPlayerPoser : MonoBehaviour, IEventsConsumer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__54_0; //Field offset: 0x8
		public static Func <>9__54_1; //Field offset: 0x10
		public static Func <>9__54_3; //Field offset: 0x18
		public static Func <>9__54_4; //Field offset: 0x20
		public static Func <>9__54_5; //Field offset: 0x28
		public static Func <>9__54_6; //Field offset: 0x30
		public static Func <>9__108_0; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__108_0(EInteraction g) { }

		internal bool <UpdatePersonGrip>b__54_0(GripPose x) { }

		internal bool <UpdatePersonGrip>b__54_1(GripPose x) { }

		internal bool <UpdatePersonGrip>b__54_3(GripPose x) { }

		internal bool <UpdatePersonGrip>b__54_4(GripPose x) { }

		internal bool <UpdatePersonGrip>b__54_5(GripPose x) { }

		internal bool <UpdatePersonGrip>b__54_6(GripPose x) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__TriggerLook; //Field offset: 0x0
		public static Action <1>__TriggerCheckChamber; //Field offset: 0x8
		public static Action <2>__TriggerCheckAmmo; //Field offset: 0x10
		public static Action <3>__TriggerReload; //Field offset: 0x18

	}

	private enum EMenuPlayerAnimationType
	{
		Idle = 0,
		RandomAnimation = 1,
		WeaponAnimation = 2,
		GestureAnimation = 3,
	}

	private const int MIN_AMMO_COUNT = 2; //Field offset: 0x0
	private const int MAX_AMMO_COUNT = 10; //Field offset: 0x0
	public LimbIK[] Limbs; //Field offset: 0x20
	public PlayerBones PBones; //Field offset: 0x28
	public TwistRelax[] Twists; //Field offset: 0x30
	public HandPoser LeftHandPoser; //Field offset: 0x38
	public HandPoser RightHandPoser; //Field offset: 0x40
	public GameObject BottomShadow; //Field offset: 0x48
	private bool _initialized; //Field offset: 0x50
	private Transform[] _markers; //Field offset: 0x58
	private readonly Transform[] _gripReferences; //Field offset: 0x60
	private HandPoser[] _handPosers; //Field offset: 0x68
	private Quaternion _ikRotation; //Field offset: 0x70
	private Vector3 _ikPosition; //Field offset: 0x80
	private Transform[] _elbowBends; //Field offset: 0x90
	private IAnimator _weaponAnimator; //Field offset: 0x98
	private int _randomAnimationsCount; //Field offset: 0xA0
	private bool _patrolDelayed; //Field offset: 0xA4
	private bool _canReload; //Field offset: 0xA5
	private bool _canCheckChamber; //Field offset: 0xA6
	private int _ammoToLoad; //Field offset: 0xA8
	private int _weaponAnimationType; //Field offset: 0xAC
	private EInteraction _gestureAnimationType; //Field offset: 0xB0
	private AnimationEventsEmitter _animEventEmitter; //Field offset: 0xB8
	private List _eventConsumers; //Field offset: 0xC0
	private IWeaponGripPose[] _grips; //Field offset: 0xC8
	private GripBlender _blender; //Field offset: 0xD0
	private ValueBlender _crutchBlender; //Field offset: 0xD8
	private List _gestures; //Field offset: 0xE0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Parameter", "AnimateAction"})]
	private List _weaponAnimations; //Field offset: 0xE8
	private bool _animate; //Field offset: 0xF0
	private bool _enableWeaponPatrol; //Field offset: 0xF1
	[CompilerGenerated]
	private Animator <PlayerAnimatorController>k__BackingField; //Field offset: 0xF8

	private bool Patrol
	{
		private set { } //Length: 319
	}

	public private Animator PlayerAnimatorController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static int RandomAmmoCount
	{
		private get { } //Length: 79
	}

	public MenuPlayerPoser() { }

	[CompilerGenerated]
	private int <UpdatePersonGrip>b__54_2(GripPose x) { }

	[CompilerGenerated]
	private int <UpdatePersonGrip>b__54_7(GripPose x) { }

	public override void AimReady() { }

	private void AnimatorEventHandler(int functionNameHash, AnimationEventParameter parameter) { }

	public override void BipodClose() { }

	public override void BipodOpen() { }

	public void ChangeWeapon(AnimationEventsEmitter eventsEmitter, IAnimator animator, TransformLinks links, bool canReload, bool canCheckChamber, bool animate = true) { }

	public override void DropWeapon() { }

	public void ForceWeaponIdleState() { }

	private void Gesture(EInteraction index) { }

	[CompilerGenerated]
	public Animator get_PlayerAnimatorController() { }

	private static int get_RandomAmmoCount() { }

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

	private override void IEventsConsumer.OnThirdAction(int IntParam) { }

	private override void IEventsConsumer.OnUseProp(bool BoolParam) { }

	private override void IEventsConsumer.OnUseSecondMagForReload() { }

	private override void IEventsConsumer.OnWeapIn() { }

	private override void IEventsConsumer.OnWeapOut() { }

	private override void IEventsConsumer.OutUse() { }

	public void Init(Animator playerAnimatorController) { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OneAmmoLoaded() { }

	public void OnRandomizeAnimation() { }

	private void OnWeaponIdleStart() { }

	public void OnWeaponOperationEnd() { }

	public void OnWeaponOperationStart() { }

	public override void ReloadTest() { }

	private void set_Patrol(bool value) { }

	[CompilerGenerated]
	private void set_PlayerAnimatorController(Animator value) { }

	public void SetWeaponPatrol(bool enabled) { }

	private void StartHandsAnimation() { }

	private void TurnOffLights() { }

	private void Unsubscribe() { }

	private void UpdatePersonGrip(TransformLinks transforms = null) { }

}

