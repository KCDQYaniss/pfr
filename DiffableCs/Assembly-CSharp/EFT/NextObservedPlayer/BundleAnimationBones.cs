namespace EFT.NextObservedPlayer;

public sealed class BundleAnimationBones
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__212_0(ObservedPlayerView observedPlayerView) { }

		internal void <.cctor>b__212_1(ObservedPlayerView observedPlayerView) { }

		internal void <.cctor>b__212_2(ObservedPlayerView observedPlayerView) { }

		internal void <.cctor>b__212_3(ObservedPlayerView observedPlayerView) { }

	}

	[CompilerGenerated]
	private struct <SetStationaryWeaponOnSpawn>d__197 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Weapon weapon; //Field offset: 0x20
		public BundleAnimationBones <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string COMPASS_RESOURCE_PATH = "assets/content/weapons/additional_hands/item_compass.bundle"; //Field offset: 0x0
	private const float RANGEFINDER_AIM_SPEED = 2; //Field offset: 0x0
	private const float WEAPON_POS_SMOOTH_RATE = 14; //Field offset: 0x0
	private static NativeArray _sceneIkMarkerPositions; //Field offset: 0x0
	private const int SCENE_IK_MAX_ENTRIES = 510; //Field offset: 0x0
	private const int SCENE_IK_LIMBS_PER_PLAYER = 2; //Field offset: 0x0
	private const int SCENE_IK_MAX_PLAYERS = 255; //Field offset: 0x0
	private const int CURVE_CACHE_CAPACITY = 24; //Field offset: 0x0
	private static NativeArray _sceneIkMarkerRotations; //Field offset: 0x10
	private static NativeArray _sceneIkGripReferencePositions; //Field offset: 0x20
	private static NativeArray _sceneIkTargetPositions; //Field offset: 0x30
	private static NativeArray _sceneIkTargetRotations; //Field offset: 0x40
	private static NativeArray _sceneIkMarkerValid; //Field offset: 0x50
	private static NativeArray _sceneIkGripReferenceValid; //Field offset: 0x60
	private static NativeArray _sceneIkTargetValid; //Field offset: 0x70
	private static NativeArray _sceneIkLimbActive; //Field offset: 0x80
	private static NativeArray _sceneIkDistanceToCamera; //Field offset: 0x90
	private static NativeArray _sceneIkInteractionValid; //Field offset: 0xA0
	private static NativeArray _sceneIkInteractionTargetPosition; //Field offset: 0xB0
	private static NativeArray _sceneIkInteractionTargetRotation; //Field offset: 0xC0
	private static NativeArray _sceneIkInteractionBlend; //Field offset: 0xD0
	private static NativeArray _sceneIkResultPositions; //Field offset: 0xE0
	private static NativeArray _sceneIkResultRotations; //Field offset: 0xF0
	private static NativeArray _sceneIkResultGripWeights; //Field offset: 0x100
	private static NativeArray _sceneIkShouldSetGripWeight; //Field offset: 0x110
	private static NativeArray _sceneIkResultValid; //Field offset: 0x120
	private static NativeArray _sceneIkUseParallelLimbSolver; //Field offset: 0x130
	private static NativeArray _sceneIkBone1Positions; //Field offset: 0x140
	private static NativeArray _sceneIkBone2Positions; //Field offset: 0x150
	private static NativeArray _sceneIkBone3Positions; //Field offset: 0x160
	private static NativeArray _sceneIkBone1Rotations; //Field offset: 0x170
	private static NativeArray _sceneIkBone2Rotations; //Field offset: 0x180
	private static NativeArray _sceneIkBone3Rotations; //Field offset: 0x190
	private static NativeArray _sceneIkBone1TargetToLocal; //Field offset: 0x1A0
	private static NativeArray _sceneIkBone2TargetToLocal; //Field offset: 0x1B0
	private static NativeArray _sceneIkBone1DefaultLocalBendNormals; //Field offset: 0x1C0
	private static NativeArray _sceneIkBone2DefaultLocalBendNormals; //Field offset: 0x1D0
	private static NativeArray _sceneIkSolverBendNormals; //Field offset: 0x1E0
	private static NativeArray _sceneIkSolverMaintainRotationWeights; //Field offset: 0x1F0
	private static NativeArray _sceneIkSolverMaintainRotationReferences; //Field offset: 0x200
	private static NativeArray _sceneIkSolverIkPositionWeights; //Field offset: 0x210
	private static NativeArray _sceneIkSolverIkRotationWeights; //Field offset: 0x220
	private static NativeArray _sceneIkSolverDirectHierarchy; //Field offset: 0x230
	private static NativeArray _sceneIkBone2ChildOfBone1; //Field offset: 0x240
	private static NativeArray _sceneIkBone3ChildOfBone1; //Field offset: 0x250
	private static NativeArray _sceneIkBone3ChildOfBone2; //Field offset: 0x260
	private static NativeArray _sceneIkSolvedBone1Rotations; //Field offset: 0x270
	private static NativeArray _sceneIkSolvedBone2Rotations; //Field offset: 0x280
	private static NativeArray _sceneIkSolvedBone3Rotations; //Field offset: 0x290
	private static NativeArray _sceneIkSolvedValid; //Field offset: 0x2A0
	private static NativeArray _sceneIkApplyRotations1; //Field offset: 0x2B0
	private static NativeArray _sceneIkApplyRotations2; //Field offset: 0x2C0
	private static NativeArray _sceneIkApplyRotations3; //Field offset: 0x2D0
	private static TransformAccessArray _sceneIkApplyTransforms1; //Field offset: 0x2E0
	private static TransformAccessArray _sceneIkApplyTransforms2; //Field offset: 0x2E8
	private static TransformAccessArray _sceneIkApplyTransforms3; //Field offset: 0x2F0
	private static readonly Transform[] _sceneIkBone1Transforms; //Field offset: 0x2F8
	private static readonly Transform[] _sceneIkBone2Transforms; //Field offset: 0x300
	private static readonly Transform[] _sceneIkBone3Transforms; //Field offset: 0x308
	private static readonly int[] _sceneIkApplyEntryIndices; //Field offset: 0x310
	private static readonly BundleAnimationBones[] _sceneIkBundles; //Field offset: 0x318
	private static int _sceneIkBundleCount; //Field offset: 0x320
	private static int _sceneIkUsers; //Field offset: 0x324
	private static bool _sceneIkInitialized; //Field offset: 0x328
	public static Action DefaultRotationFunction; //Field offset: 0x330
	public static Action UtesRotationFunction; //Field offset: 0x338
	public static Action AGSRotationFunction; //Field offset: 0x340
	public static Action MountingRotationFunction; //Field offset: 0x348
	private Action HandsRotationFunction; //Field offset: 0x10
	private readonly ObservedPlayerView _observedPlayerView; //Field offset: 0x18
	private readonly PlayerBones _bodyBones; //Field offset: 0x20
	private readonly IAnimator _bodyAnimator; //Field offset: 0x28
	private readonly HandPoser[] _handPosers; //Field offset: 0x30
	private readonly LimbIK[] _limbs; //Field offset: 0x38
	private readonly TwistRelax[] _twistBones; //Field offset: 0x40
	private WeaponPrefab _itemObject; //Field offset: 0x48
	private Transform[] _elbowBends; //Field offset: 0x50
	private readonly Transform[] _markers; //Field offset: 0x58
	private readonly Transform[] _gripReferences; //Field offset: 0x60
	private readonly Transform[] _ikTargets; //Field offset: 0x68
	private int _curveCacheFrame; //Field offset: 0x70
	private int _curveCacheCount; //Field offset: 0x74
	private readonly int[] _curveCacheHashes; //Field offset: 0x78
	private readonly float[] _curveCacheValues; //Field offset: 0x80
	private bool _hasAnimatorPropBones; //Field offset: 0x88
	private bool _hasProp; //Field offset: 0x89
	private bool _propActive; //Field offset: 0x8A
	private bool _compassInstantiated; //Field offset: 0x8B
	private CompassArrow _compassArrow; //Field offset: 0x90
	private Transform _propBone; //Field offset: 0x98
	private ContainerCollectionView _containerCollectionView; //Field offset: 0xA0
	private float _utilityLayerWeight; //Field offset: 0xA8
	private float _leftStanceLayerWeight; //Field offset: 0xAC
	private ObservedPlayerLeftStanceController _leftStanceController; //Field offset: 0xB0
	private bool _hasWeaponRotationSample; //Field offset: 0xB8
	private StationaryWeapon _stationaryWeapon; //Field offset: 0xC0
	private bool _canUpdateStationaryWeapon; //Field offset: 0xC8
	private Transform[] _animatorPropTransforms; //Field offset: 0xD0
	private Transform[] _propTransforms; //Field offset: 0xD8
	private TransformLinks _handsHierarchy; //Field offset: 0xE0
	[CompilerGenerated]
	private GameObject <CameraContainer>k__BackingField; //Field offset: 0xE8
	private readonly CameraContainerRotator _btrCameraContainerRotator; //Field offset: 0xF0
	private readonly BtrSideRotator _btrSideRotator; //Field offset: 0xF8
	private readonly InvalidCustomRotator _invalidBtrCameraRotator; //Field offset: 0x100
	private ICustomRotator _btrCameraRotator; //Field offset: 0x108
	private EPlayerBtrState _btrCameraRotatorState; //Field offset: 0x110
	[CompilerGenerated]
	private ProceduralWeaponAnimation <ProceduralWeaponAnimation>k__BackingField; //Field offset: 0x118
	private Transform _vestMarker; //Field offset: 0x120
	private Vector2 UtilityLayerRange; //Field offset: 0x128
	private float UtilityLayerLerpSpeed; //Field offset: 0x130
	private float _lsLayerLerpSpeed; //Field offset: 0x134
	[CompilerGenerated]
	private bool <HaveStationalWeapon>k__BackingField; //Field offset: 0x138
	private IAnimator _underbarrelFastAnimator; //Field offset: 0x140
	private bool _needUseHandBone; //Field offset: 0x148
	private float _firstPersonRightHand; //Field offset: 0x14C
	private float _firstPersonLeftHand; //Field offset: 0x150
	private float _thirdPersonWeaponRootAuthority; //Field offset: 0x154
	private float _manualDistance; //Field offset: 0x158
	private int _sceneIkBatchIndex; //Field offset: 0x15C
	private float _shoulderVel; //Field offset: 0x160
	private float _smoothLW; //Field offset: 0x164
	private GripPose LeftHandInteractionTarget; //Field offset: 0x168
	private readonly BetterValueBlender ThirdIkWeight; //Field offset: 0x170
	private Vector3 _weaponMountingPos; //Field offset: 0x178
	private GameObject _itemInHands; //Field offset: 0x188

	public IAnimator BodyAnimator
	{
		 get { } //Length: 5
	}

	private BifacialTransform BodyTransform
	{
		private get { } //Length: 30
	}

	private GameObject CameraContainer
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Transform[] HandMarkers
	{
		 get { } //Length: 5
	}

	public HandPoser[] HandPosers
	{
		 get { } //Length: 76
	}

	public TransformLinks HandsHierarchy
	{
		 get { } //Length: 8
	}

	public private bool HaveStationalWeapon
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public ObservedPlayerLeftStanceController LeftStanceController
	{
		 get { } //Length: 8
	}

	public private ProceduralWeaponAnimation ProceduralWeaponAnimation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public StationaryWeapon StationaryWeapon
	{
		 get { } //Length: 8
	}

	public IAnimator UnderbarrelWeaponArmsAnimator
	{
		 get { } //Length: 8
	}

	private static BundleAnimationBones() { }

	public BundleAnimationBones(PlayerBones bodyBones, IAnimator bodyAnimator, ObservedPlayerView observedPlayerView) { }

	private void AdjustElbows(float curveWeight) { }

	private void AdjustUtilityLayerWeight() { }

	public void Apply(ObservedPlayerMovementModel model) { }

	public void ApplyBtrExitLook(Vector3 start, Vector3 target) { }

	public void ApplyDeath() { }

	private void ApplySceneIkResult() { }

	private void ApplyTorsoReactionWeaponCounterRotation() { }

	public static void BeginSceneIkBatchFrame() { }

	public void ChangeHandsItem(WeaponPrefab itemObject) { }

	private void ChangeHandsItemWithStationaryWeapon(ValueTuple prevState, ValueTuple newState) { }

	public void ClearIKInteract() { }

	public void CreateCompass() { }

	public void CulledUpdate() { }

	public void Dispose() { }

	private static void DisposeSceneIkData() { }

	private static void EnsureSceneIkData() { }

	public void EnterMountingState() { }

	private void EnterToStationaryWeapon() { }

	public static void ExecuteSceneIkBatchFrame() { }

	public void ExitFromStationaryWeapon() { }

	public void ExitMountingState() { }

	private static Slot FindSlotByFullId(Weapon weapon, string fullId) { }

	private void ForceAnimatorLeftStance(bool value) { }

	public IAnimator get_BodyAnimator() { }

	private BifacialTransform get_BodyTransform() { }

	[CompilerGenerated]
	private GameObject get_CameraContainer() { }

	public Transform[] get_HandMarkers() { }

	public HandPoser[] get_HandPosers() { }

	public TransformLinks get_HandsHierarchy() { }

	[CompilerGenerated]
	public bool get_HaveStationalWeapon() { }

	public ObservedPlayerLeftStanceController get_LeftStanceController() { }

	[CompilerGenerated]
	public ProceduralWeaponAnimation get_ProceduralWeaponAnimation() { }

	public StationaryWeapon get_StationaryWeapon() { }

	public IAnimator get_UnderbarrelWeaponArmsAnimator() { }

	private Quaternion GetCameraContainerRotation() { }

	private float GetCurveValue(int hash) { }

	private void IkApply(float d) { }

	public void InitHandsContainer(bool weaponInHands) { }

	public void InitLeftStanceController() { }

	public void InitPlayerControllerVariables() { }

	private bool IsBtrCameraRotatorState(EPlayerBtrState state) { }

	private void LookHandsRotation() { }

	public void ManualUpdatePostIk() { }

	public void ManualUpdatePreIk() { }

	public void MouseLook() { }

	private void PlayerAnimStateChanged(EPlayerState previousState, EPlayerState nextState) { }

	private static void PrepareSceneIkLimbSolveInput(int entryCount) { }

	private void PrepareSceneIkLimbSolveInput(int entryIndex, int limbIndex) { }

	public void PropUpdate() { }

	private void RegisterSceneIkInput(float distance2Camera) { }

	private void ResetBtrCameraRotator() { }

	[CompilerGenerated]
	private void set_CameraContainer(GameObject value) { }

	[CompilerGenerated]
	private void set_HaveStationalWeapon(bool value) { }

	[CompilerGenerated]
	private void set_ProceduralWeaponAnimation(ProceduralWeaponAnimation value) { }

	public void SetAnimatorLeftStanceToCacheValueInIdleState() { }

	public void SetIKInteract(GripPose grip) { }

	public void SetPropVisibility(bool isVisible) { }

	public void SetStationaryWeapon(SetStationaryWeaponCommandMessage commandMessage) { }

	[AsyncStateMachine(typeof(<SetStationaryWeaponOnSpawn>d__197))]
	public Task SetStationaryWeaponOnSpawn(Weapon weapon) { }

	private void SetVestMarker(TransformLinks links) { }

	public void ShiftWeaponRoot(Transform targetTransform) { }

	public void ShiftWeaponRoot() { }

	public void Shoot(Ammo ammo) { }

	private Vector3 SoftenObservedWeaponPositionalRecoil(Vector3 weaponRootLocalPosition) { }

	public void SpawnInHands(Item item, string parentBone) { }

	public void StationaryWeaponFire() { }

	private void SyncBtrCameraRotator() { }

	public void UnspawnInHands() { }

	public void UpdateBonesOnWeaponChange(TransformLinks links) { }

	private void UpdateCompassController(GameObject obj) { }

	public void UpdateIKInteract(float progress) { }

	public void UpdatePersonGrip() { }

	public void UpdateSpectatingState(bool isSpectateTarget, bool isAlive) { }

	public void UpdateStationaryWeaponPosition() { }

	public void UpdateUnderbarrelBones(bool launcherEnable, WeaponPrefab weaponPrefab) { }

}

