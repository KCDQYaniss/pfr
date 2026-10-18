namespace EFT.Animations;

public class ProceduralWeaponAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal int <.cctor>b__384_0(Slot x, Slot y) { }

	}

	[CompilerGenerated]
	private sealed class <ApplyFovAdjustments>d__369 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ProceduralWeaponAnimation <>4__this; //Field offset: 0x20
		public Player player; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ApplyFovAdjustments>d__369(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <ApplyFovAdjustments>d__370 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ProceduralWeaponAnimation <>4__this; //Field offset: 0x20
		public ObservedPlayerView player; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ApplyFovAdjustments>d__370(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <HandShakeCoroutine>d__382 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ProceduralWeaponAnimation <>4__this; //Field offset: 0x20
		public float duration; //Field offset: 0x28
		public float tremorIntensity; //Field offset: 0x2C
		public float curveFrequency; //Field offset: 0x30
		public float curveIntensity; //Field offset: 0x34

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <HandShakeCoroutine>d__382(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class SightNBone
	{
		public SightComponent Mod; //Field offset: 0x10
		public Transform Bone; //Field offset: 0x18
		public ScopePrefabCache ScopePrefabCache; //Field offset: 0x20
		public SightComponent ScopePrefabOwner; //Field offset: 0x28
		public int Depth; //Field offset: 0x30
		public float Rotation; //Field offset: 0x34
		public float LeftStanceRotation; //Field offset: 0x38
		public bool AlignIfAvailable; //Field offset: 0x3C
		public bool BoneRelatesToOptics; //Field offset: 0x3D
		public float EyeGuardShift; //Field offset: 0x40

		public bool IsOptic
		{
			 get { } //Length: 275
		}

		public bool UsesOpticCamera
		{
			 get { } //Length: 291
		}

		public SightNBone() { }

		public bool get_IsOptic() { }

		public bool get_UsesOpticCamera() { }

	}

	internal class TiltCalulator
	{
		private const float x0 = 0.3; //Field offset: 0x0
		private const float y0 = 0.1; //Field offset: 0x0
		private const float y1 = 1; //Field offset: 0x0
		private static Vector3 a; //Field offset: 0x0
		private static Vector3 b; //Field offset: 0xC
		private static Vector3 c; //Field offset: 0x18
		private static Vector3 normal; //Field offset: 0x24
		private static float shift; //Field offset: 0x30

		private static TiltCalulator() { }

		public TiltCalulator() { }

		public static float GetValue(float speed, float height) { }

	}

	private static readonly WaitForEndOfFrame _waitForEndOfFrame; //Field offset: 0x0
	private const float WEAPON_TRANSFORM_OVERRIDE_BLEND_DURATION = 0.25; //Field offset: 0x0
	private const float ScopeDefaultStateAngleRotation = 180; //Field offset: 0x0
	private const float NoButtShift = 0.05; //Field offset: 0x0
	private const float AGS_HEIGHT_STEP = 0.5; //Field offset: 0x0
	private const int SCOPE_ROTATION_RANGE = 55; //Field offset: 0x0
	private const string BIPOD_GROUND_BONE = "bipod_ground"; //Field offset: 0x0
	private const float CameraSmoothTransitionDelay = 0.2; //Field offset: 0x0
	public const string LINE_OF_SIGHT_P1 = "mod_align_front"; //Field offset: 0x0
	private const float PITCH_TOLERANCE = 0.1; //Field offset: 0x0
	public const string MOD_CAMERA_BONE = "mod_aim_camera"; //Field offset: 0x0
	public const string LAUNCHER_CAMERA_BONE = "launcher_0_aim_camera"; //Field offset: 0x0
	public const string CAMERA_BONE = "aim_camera"; //Field offset: 0x0
	public const string LINE_OF_SIGHT_P0 = "mod_align_rear"; //Field offset: 0x0
	private static readonly Comparison _slotNameComparer; //Field offset: 0x8
	[CompilerGenerated]
	private Action OnCurrentOpticUpdate; //Field offset: 0x20
	public Vector3 WeaponLocalPosition; //Field offset: 0x28
	public Vector3 WeaponLocalRotation; //Field offset: 0x34
	public PlayerSpring HandsContainer; //Field offset: 0x40
	public GameObject CameraContainer; //Field offset: 0x48
	[EnumBitMask(typeof(EProceduralAnimationMask))]
	public EProceduralAnimationMask Mask; //Field offset: 0x50
	public BreathEffector Breath; //Field offset: 0x58
	public WalkEffector Walk; //Field offset: 0x60
	public MotionEffector MotionReact; //Field offset: 0x68
	public ForceEffector ForceReact; //Field offset: 0x70
	public ShotEffector Shootingg; //Field offset: 0x78
	public TurnAwayEffector TurnAway; //Field offset: 0x80
	public CustomEffector CustomEffector; //Field offset: 0x88
	public HandShakeEffector HandShakeEffector; //Field offset: 0x90
	public WeaponAiming WeaponAiming; //Field offset: 0x98
	public Vector3 Offset; //Field offset: 0xA0
	public Vector2 AgsDeltaHeightRange; //Field offset: 0xAC
	private float _overweight; //Field offset: 0xB4
	private readonly Quaternion _rotation90deg; //Field offset: 0xB8
	private ContainerCollectionView _ccv; //Field offset: 0xC8
	[CompilerGenerated]
	private bool <IsObservedPlayer>k__BackingField; //Field offset: 0xD0
	private Transform _launcherWeaponRootBone; //Field offset: 0xD8
	private Transform _launcherPropBone; //Field offset: 0xE0
	private Transform _launcherScope; //Field offset: 0xE8
	private float _cachedUnderbarrelSightAngle; //Field offset: 0xF0
	private float _cachedUnderbarrelSightPosition; //Field offset: 0xF4
	private float _lineOfSightDeltaAngle; //Field offset: 0xF8
	private float _currentLineOfSightDeltaAngle; //Field offset: 0xFC
	public Vector2 _cameraShiftToLineOfSight; //Field offset: 0x100
	private Transform _bone0; //Field offset: 0x108
	private Transform _bone1; //Field offset: 0x110
	private bool _hasPairOfIronSightTransforms; //Field offset: 0x118
	public List ScopeAimTransforms; //Field offset: 0x120
	public float WeaponFlipSpeed; //Field offset: 0x128
	public float CameraSmoothTime; //Field offset: 0x12C
	private Vector3 vel; //Field offset: 0x130
	private Quaternion _scopeRotation; //Field offset: 0x13C
	private Quaternion _targetScopeRotation; //Field offset: 0x14C
	private float _targetScopeRotationDeg; //Field offset: 0x15C
	private IFirearmAnimationDataRepresenter _firearmAnimationData; //Field offset: 0x160
	private FirearmController _firearmController; //Field offset: 0x168
	private float _leftStanceCurrentCurveValue; //Field offset: 0x170
	[SerializeField]
	private bool _crankRecoil; //Field offset: 0x174
	private bool _isAiming; //Field offset: 0x175
	private bool _sprinting; //Field offset: 0x176
	public bool _shouldMoveWeaponCloser; //Field offset: 0x177
	private Vector3 _stationaryWeaponRootBaseLocalPosition; //Field offset: 0x178
	private bool _folded; //Field offset: 0x184
	[SerializeField]
	private Vector3 _vCameraTarget; //Field offset: 0x188
	public Vector3 RotationCameraOffset; //Field offset: 0x194
	public EPointOfView _pointOfView; //Field offset: 0x1A0
	private Func _aimingInSpeedMultiplier; //Field offset: 0x1A8
	private Func _aimingOutSpeedMultiplier; //Field offset: 0x1B0
	private float _aimingSpeed; //Field offset: 0x1B8
	private float _overweightAimingMultiplier; //Field offset: 0x1BC
	public AimPlane _currentAimingPlane; //Field offset: 0x1C0
	public AimPlane _farPlane; //Field offset: 0x1C8
	private readonly List _optics; //Field offset: 0x1D0
	private readonly List _sightSlotsBuffer; //Field offset: 0x1D8
	private readonly List _slotProtrudablesBuffer; //Field offset: 0x1E0
	private Vector3 _cameraByFOVOffset; //Field offset: 0x1E8
	public float _fovCompensatoryDistance; //Field offset: 0x1F4
	private float _maxScopeDepthAndAimPlaneDelta; //Field offset: 0x1F8
	private float _previousPitch; //Field offset: 0x1FC
	public float _agsDeltaHeight; //Field offset: 0x200
	private Quaternion _cameraIdenity; //Field offset: 0x204
	private Quaternion _rotationOffset; //Field offset: 0x214
	private float _compensatoryScale; //Field offset: 0x224
	public Vector3 _shotDirection; //Field offset: 0x228
	private float _blindfireStrength; //Field offset: 0x234
	public Vector3 TacticalReloadStiffnes; //Field offset: 0x238
	public float TacticalReloadPosition; //Field offset: 0x244
	private ValueBlenderDelay _tacticalReload; //Field offset: 0x248
	[Tooltip("Диапазон возможной скорости, с которой камера будет доворачиваться до угла задирания оружия, активизируется при автоматическом огне")]
	public Vector2 CameraToWeaponAngleSpeedRange; //Field offset: 0x250
	[Tooltip("Шаг роста скорости, с которой камера будет доворачиваться до угла задирания оружия, активизируется при автоматическом огне")]
	public float CameraToWeaponAngleStep; //Field offset: 0x258
	public float CameraSmoothSteady; //Field offset: 0x25C
	public float CameraSmoothRecoil; //Field offset: 0x260
	public float MountingCameraSmoothRecoilMultiplier; //Field offset: 0x264
	public float BipodCameraSmoothRecoilMultiplier; //Field offset: 0x268
	public float CameraSmoothOut; //Field offset: 0x26C
	public float MountingCameraSpeed; //Field offset: 0x270
	public Action AvailableScopesChanged; //Field offset: 0x278
	private float _cameraRecoilLerpTempSpeed; //Field offset: 0x280
	private Quaternion _previousCameraTargetRotation; //Field offset: 0x284
	private Quaternion _currentRecoilCameraRotate; //Field offset: 0x294
	private Coroutine _resetFovAdjustmentsCorotuine; //Field offset: 0x2A8
	public BetterValueBlender CameraSmoothBlender; //Field offset: 0x2B0
	public Vector3 AimSwayMax; //Field offset: 0x2B8
	public Vector3 AimSwayMin; //Field offset: 0x2C4
	public float SwayFalloff; //Field offset: 0x2D0
	public float AimSwayStartsThreshold; //Field offset: 0x2D4
	public float AimSwayMaxThreshold; //Field offset: 0x2D8
	private float _aimSwayStrength; //Field offset: 0x2DC
	private Vector3 _aimSwayDirection; //Field offset: 0x2E0
	private ValueBlender _aimSwayBlender; //Field offset: 0x2F0
	public Vector3 PlayerBonesThirdRootOffset; //Field offset: 0x2F8
	public Quaternion PlayerBonesThirdRootRotationOffset; //Field offset: 0x304
	private Vector3 _prediction; //Field offset: 0x314
	private Quaternion _local; //Field offset: 0x320
	private Quaternion _temporaryRotation; //Field offset: 0x330
	private Quaternion _aimingRotation; //Field offset: 0x340
	private Vector3 _temporaryPosition; //Field offset: 0x350
	private float _animatorPoseBlend; //Field offset: 0x35C
	private int _pose; //Field offset: 0x360
	private bool _isGrenadeMode; //Field offset: 0x364
	private bool _isLeftStance; //Field offset: 0x365
	private bool _isBipodState; //Field offset: 0x366
	private readonly ValueBlender _grenadeLauncherBlender; //Field offset: 0x368
	public float SmoothedTilt; //Field offset: 0x370
	public float PossibleTilt; //Field offset: 0x374
	public float _launcherZeroZ; //Field offset: 0x378
	public float _launcherRotationZeroX; //Field offset: 0x37C
	public Vector3 RotationZeroSum; //Field offset: 0x380
	public Vector3 PositionZeroSum; //Field offset: 0x38C
	public BetterValueBlender BlindfireBlender; //Field offset: 0x398
	public ValueBlender TiltBlender; //Field offset: 0x3A0
	public Vector3 BlindFireOffset; //Field offset: 0x3A8
	public Vector3 BlindFireRotation; //Field offset: 0x3B4
	public Vector3 BlindFireCamera; //Field offset: 0x3C0
	public Vector3 SideFireOffset; //Field offset: 0x3CC
	public Vector3 SideFireRotation; //Field offset: 0x3D8
	public Vector3 SideFireCamera; //Field offset: 0x3E4
	public float Pitch; //Field offset: 0x3F0
	public float AimingDisplacementStr; //Field offset: 0x3F4
	private float _weight; //Field offset: 0x3F8
	private float _ergonomicWeight; //Field offset: 0x3FC
	private float _swayStrength; //Field offset: 0x400
	private float _displacementStr; //Field offset: 0x404
	private float _aimingWeight; //Field offset: 0x408
	private float _currentScopeWeight; //Field offset: 0x40C
	private Vector3 _currentTargetScopeBonePos; //Field offset: 0x410
	private Vector3 _lastScopePos; //Field offset: 0x41C
	public Vector3 BlindFireEndPosition; //Field offset: 0x428
	private bool _tacticalReloadAvailable; //Field offset: 0x434
	private bool _updateCalibration; //Field offset: 0x435
	[CompilerGenerated]
	private Action OnPreCollision; //Field offset: 0x438
	private Vector3 _headRotationVec; //Field offset: 0x440
	private WeaponBuffsInfo _buffInfo; //Field offset: 0x450
	private Vector3 _localCalibratePoint; //Field offset: 0x458
	private IProceduralAnimationStrategy _strategy; //Field offset: 0x468
	private bool _adjustCollimatorsToTrajectory; //Field offset: 0x470
	private Action _unbindScopeCycle; //Field offset: 0x478
	private Vector3 _localAimShift; //Field offset: 0x480
	private readonly float _aimLeftStanceAdditionalOffset; //Field offset: 0x48C
	private Action _fovEvent; //Field offset: 0x490
	private Coroutine _handShakeCoroutine; //Field offset: 0x498
	public bool BlockOverrideWeaponTransformParameters; //Field offset: 0x4A0
	private float _weaponTransformOverrideWeight; //Field offset: 0x4A4
	[CompilerGenerated]
	private bool <IsMountedState>k__BackingField; //Field offset: 0x4A8
	[CompilerGenerated]
	private bool <IsVerticalMounting>k__BackingField; //Field offset: 0x4A9
	[CompilerGenerated]
	private OpticSight <CurrentOpticSight>k__BackingField; //Field offset: 0x4B0
	[CompilerGenerated]
	private bool <OverlappingAllowsBlindfire>k__BackingField; //Field offset: 0x4B8
	[CompilerGenerated]
	private bool <ShotNeedsFovAdjustments>k__BackingField; //Field offset: 0x4B9
	private float _swayFactor; //Field offset: 0x4BC
	private bool _isT; //Field offset: 0x4C0
	private Vector3 _blindFireRotation; //Field offset: 0x4C4
	private Vector3 _blindFirePosition; //Field offset: 0x4D0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Pose", "Time", "Active"})]
	public List ActiveBlends; //Field offset: 0x4E0
	[SerializeField]
	private Vector3 vector; //Field offset: 0x4E8

	public event Action OnCurrentOpticUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnPreCollision
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public int AimIndex
	{
		 get { } //Length: 128
	}

	public AimingConfiguration Aiming
	{
		 get { } //Length: 64
	}

	public float AimingLerpSpeed
	{
		 get { } //Length: 317
	}

	public float AimingSpeed
	{
		 get { } //Length: 9
	}

	public Transform AimPointParent
	{
		 get { } //Length: 45
	}

	public float AimSwayStrength
	{
		 get { } //Length: 9
	}

	public bool CrankRecoil
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	[CanBeNull]
	public SightComponent CurrentAimingMod
	{
		 get { } //Length: 98
	}

	public private OpticSight CurrentOpticSight
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public SightNBone CurrentScope
	{
		 get { } //Length: 168
	}

	public bool DrawEffectorEnabled
	{
		 set { } //Length: 25
	}

	public float ExternalHeadRotation
	{
		 get { } //Length: 54
	}

	private float FarAimPlane
	{
		private get { } //Length: 37
	}

	private float FieldOfView
	{
		private get { } //Length: 127
	}

	public bool FirstPersonPointOfView
	{
		 get { } //Length: 11
	}

	public bool HandShakeEffectorEnabled
	{
		 set { } //Length: 181
	}

	private float HeadBobbing
	{
		private get { } //Length: 196
	}

	private bool InLeftStance
	{
		private get { } //Length: 18
	}

	public float IntensityByAiming
	{
		 get { } //Length: 157
	}

	public float IntensityByPoseLevel
	{
		 get { } //Length: 89
	}

	public bool IsAiming
	{
		 get { } //Length: 82
		 set { } //Length: 842
	}

	public bool IsBipodUsed
	{
		 get { } //Length: 8
		 set { } //Length: 191
	}

	public bool IsGrenadeLauncher
	{
		 get { } //Length: 8
		 set { } //Length: 109
	}

	public private bool IsMountedState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IsObservedPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IsVerticalMounting
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool LeftStance
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public float LeftStanceCurrentCurveValue
	{
		 get { } //Length: 9
	}

	private float Overlap
	{
		private get { } //Length: 21
	}

	public bool OverlappingAllowsBlindfire
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public float Overweight
	{
		 get { } //Length: 9
		 set { } //Length: 288
	}

	public EPointOfView PointOfView
	{
		 get { } //Length: 7
		 set { } //Length: 314
	}

	public int Pose
	{
		 get { } //Length: 7
		 set { } //Length: 16
	}

	private Vector3 Scale
	{
		private get { } //Length: 26
	}

	public Vector3 ShotDirection
	{
		 get { } //Length: 25
	}

	public bool ShotNeedsFovAdjustments
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool Sprint
	{
		 get { } //Length: 8
		 set { } //Length: 200
	}

	public bool TacticalReload
	{
		 get { } //Length: 8
		 set { } //Length: 13
	}

	public Vector3 VCameraTarget
	{
		 get { } //Length: 25
	}

	public float VisorStepFrequency
	{
		 get { } //Length: 131
	}

	public bool WalkEffectorEnabled
	{
		 set { } //Length: 269
	}

	private static ProceduralWeaponAnimation() { }

	public ProceduralWeaponAnimation() { }

	[CompilerGenerated]
	private float <UpdateWeaponVariables>b__297_0() { }

	[CompilerGenerated]
	public void add_OnCurrentOpticUpdate(Action value) { }

	[CompilerGenerated]
	public void add_OnPreCollision(Action value) { }

	private void AddHandRecoilRotateToCamera(float deltaTime) { }

	public void AdjustOpticsPAG17() { }

	public void AgsCalibrate(bool calibrate) { }

	private float AimTransformDepth(Transform t) { }

	[ContextMenu("align collimator")]
	private void AlignArcTrajectoryToCollimator() { }

	private void AlignIronSight() { }

	public void ApplyAimingAlignment(float dt) { }

	private void ApplyAimingRotation() { }

	public void ApplyComplexRotation(float dt) { }

	[IteratorStateMachine(typeof(<ApplyFovAdjustments>d__370))]
	public IEnumerator ApplyFovAdjustments(ObservedPlayerView player) { }

	[IteratorStateMachine(typeof(<ApplyFovAdjustments>d__369))]
	public IEnumerator ApplyFovAdjustments(Player player) { }

	public void ApplyPosition() { }

	public void ApplySimpleRotation(float dt) { }

	public void ApplyStationaryWeaponPosition() { }

	public void ApplyTacticalReloadTransformations() { }

	public void ApplyWeaponTransformOverride(float dt, bool overrideWeaponTransformParameters) { }

	public void AssignAnimatorPose(AnimatorPose animatorPose) { }

	public void AvoidObstacles() { }

	public void BlendAnimatorPose(float dt) { }

	public void CalculateCameraPosition() { }

	public void CalculateLocalSightTarget() { }

	public void Calibrate() { }

	private void CalibrateSight() { }

	private bool CheckAutoFire() { }

	public void CheckShouldMoveWeaponCloser() { }

	private void CheckUnderbarrelSight() { }

	public void Clear() { }

	public void ClearPreviousWeapon() { }

	private void CollimatorLookAt(Vector3 point) { }

	internal void CycleScopes(int currentScopeIndex) { }

	public void DeferredRotate(Transform t, Vector3 worldPivot, Vector3 rotation) { }

	public void DeferredRotateWithCustomOrder(Transform t, Vector3 worldPivot, Vector3 rotation) { }

	public void FindAimTransforms() { }

	public void FindAimTransformsWithoutSights() { }

	[ContextMenu("Align")]
	private void FindAlignSight() { }

	public void FindBipodMountingPoint() { }

	private void FindCameraDepth() { }

	public void FindMountingPoint(TransformLinks hierarchy) { }

	public void FindUnderbarrelWeaponSight() { }

	public int get_AimIndex() { }

	public AimingConfiguration get_Aiming() { }

	public float get_AimingLerpSpeed() { }

	public float get_AimingSpeed() { }

	public Transform get_AimPointParent() { }

	public float get_AimSwayStrength() { }

	public bool get_CrankRecoil() { }

	public SightComponent get_CurrentAimingMod() { }

	[CompilerGenerated]
	public OpticSight get_CurrentOpticSight() { }

	public SightNBone get_CurrentScope() { }

	public float get_ExternalHeadRotation() { }

	private float get_FarAimPlane() { }

	private float get_FieldOfView() { }

	public bool get_FirstPersonPointOfView() { }

	private float get_HeadBobbing() { }

	private bool get_InLeftStance() { }

	public float get_IntensityByAiming() { }

	public float get_IntensityByPoseLevel() { }

	public bool get_IsAiming() { }

	public bool get_IsBipodUsed() { }

	public bool get_IsGrenadeLauncher() { }

	[CompilerGenerated]
	public bool get_IsMountedState() { }

	[CompilerGenerated]
	public bool get_IsObservedPlayer() { }

	[CompilerGenerated]
	public bool get_IsVerticalMounting() { }

	public bool get_LeftStance() { }

	public float get_LeftStanceCurrentCurveValue() { }

	private float get_Overlap() { }

	[CompilerGenerated]
	public bool get_OverlappingAllowsBlindfire() { }

	public float get_Overweight() { }

	public EPointOfView get_PointOfView() { }

	public int get_Pose() { }

	private Vector3 get_Scale() { }

	public Vector3 get_ShotDirection() { }

	[CompilerGenerated]
	public bool get_ShotNeedsFovAdjustments() { }

	public bool get_Sprint() { }

	public bool get_TacticalReload() { }

	public Vector3 get_VCameraTarget() { }

	public float get_VisorStepFrequency() { }

	public Vector3 GetHeadRotation() { }

	private Vector3 GetWorldCalibrationPoint(Vector3 point) { }

	[IteratorStateMachine(typeof(<HandShakeCoroutine>d__382))]
	private IEnumerator HandShakeCoroutine(float duration, float tremorIntensity, float curveFrequency, float curveIntensity) { }

	private void InitAimingWeaponData(WeaponTemplate weaponTemplate) { }

	internal void InitAimPlanes(WeaponPrefab wp) { }

	public void InitTransforms(TransformLinks hierarchy, ContainerCollectionView ccv = null) { }

	internal void InitWeaponData(IFirearmAnimationDataRepresenter firearms, IWeapon weapon, WeaponPrefab wp, WeaponBuffsInfo buffInfo) { }

	public void LateTransformations(float dt) { }

	public void LerpCamera(float dt) { }

	public void ManualSetVariables(float aimingSpeed, float aimSwayStrength, float overweight, float ergonomicWeight) { }

	public void MountedWeaponCamera(float dt) { }

	public void ObservedCalibration() { }

	private void OnAimOrPoseChanged(bool forced = false) { }

	private void OnDestroy() { }

	private void OnFovChange(int fov) { }

	public void OnScopesModeUpdated() { }

	public void OpticCalibrationSwitch(bool isUp) { }

	public void OpticCalibrationSwitchDown() { }

	public void OpticCalibrationSwitchUp() { }

	private void OpticLookAt(Vector3 point) { }

	private void OpticLookAtGlobal(Vector3 point) { }

	public void PhysicalConditionUpdated(EPhysicalCondition updated, EPhysicalCondition full) { }

	public void PreCalibrate() { }

	public void ProcessEffectors(float deltaTime, int nFixedFrames, Vector3 motion, Vector3 velocity, bool overrideWeaponTransformParameters = true) { }

	[CompilerGenerated]
	public void remove_OnCurrentOpticUpdate(Action value) { }

	[CompilerGenerated]
	public void remove_OnPreCollision(Action value) { }

	public void Reset() { }

	public void ResetCameraRotation() { }

	public void ResetFovAdjustments(ObservedPlayerView player) { }

	public void ResetFovAdjustments(Player player) { }

	public void ResetOptics() { }

	public void ResetScopeRotation() { }

	public void ResetSpring() { }

	private void RestoreIronSightAlignment() { }

	public void RotateAround(Transform t, Vector3 worldPivot, Vector3 rotation) { }

	private void RotateCurrentScopeToCorrectDistanceAngle(float distance) { }

	private bool ScopeRotationWithinLimits(Transform t) { }

	public void set_CrankRecoil(bool value) { }

	[CompilerGenerated]
	private void set_CurrentOpticSight(OpticSight value) { }

	public void set_DrawEffectorEnabled(bool value) { }

	public void set_HandShakeEffectorEnabled(bool value) { }

	public void set_IsAiming(bool value) { }

	public void set_IsBipodUsed(bool value) { }

	public void set_IsGrenadeLauncher(bool value) { }

	[CompilerGenerated]
	private void set_IsMountedState(bool value) { }

	[CompilerGenerated]
	private void set_IsObservedPlayer(bool value) { }

	[CompilerGenerated]
	private void set_IsVerticalMounting(bool value) { }

	public void set_LeftStance(bool value) { }

	[CompilerGenerated]
	public void set_OverlappingAllowsBlindfire(bool value) { }

	public void set_Overweight(float value) { }

	public void set_PointOfView(EPointOfView value) { }

	public void set_Pose(int value) { }

	[CompilerGenerated]
	public void set_ShotNeedsFovAdjustments(bool value) { }

	public void set_Sprint(bool value) { }

	public void set_TacticalReload(bool value) { }

	public void set_WalkEffectorEnabled(bool value) { }

	public void SetAffiliationWithObservedPlayer(bool isObservedPlayer) { }

	public void SetFovParams(float scale) { }

	public void SetHeadRotation(Vector3 headRot) { }

	public void SetLauncherWeaponBone(Transform weaponRoot, Transform propBone) { }

	public void SetLeftStanceCurrentCurveValue(float value) { }

	public void SetMountingData(bool isMounting, bool isVerticalMounting = false) { }

	public void SetStrategy(IProceduralAnimationStrategy strategy) { }

	public void SetStrategy(EPointOfView pointOfView) { }

	public void Shoot(float str = 1) { }

	private void Start() { }

	public void StartBlindFire(int blindfire) { }

	public void StartFovCoroutine(ObservedPlayerView player) { }

	public void StartFovCoroutine(Player player) { }

	public void StartHandShake(float lackOfStamina, float fullStaminaCost) { }

	public void StationaryCamera(float dt) { }

	public void UpdateAimWeight(float deltaTime) { }

	public void UpdateBipodData() { }

	public void UpdateCameraFovForced() { }

	public void UpdateCurrentScopeBoneTarget() { }

	private void UpdateCurrentScopeRotation() { }

	private void UpdateCustomEffector() { }

	private void UpdateFarPlane() { }

	private void UpdateOptics() { }

	public void UpdatePossibleTilt(float smoothedCharacterMovementSpeed, float smoothedPoseLevel) { }

	private void UpdateSightsAfterNewCollection() { }

	public void UpdateSwayFactors() { }

	public void UpdateSwaySettings() { }

	public void UpdateTacticalReload() { }

	public void UpdateWeaponBoneByLauncherWeaponBone() { }

	public void UpdateWeaponVariables() { }

	public void ZeroAdjustments() { }

}

