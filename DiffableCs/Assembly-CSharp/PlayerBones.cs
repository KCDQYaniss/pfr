//Type is in global namespace

public class PlayerBones : MonoBehaviour
{
	internal enum ETransitionType
	{
		In = 0,
		Out = 1,
		None = 2,
	}

	internal struct TransitStruct
	{
		public ETransitionType type; //Field offset: 0x0
		public AnimationCurve c; //Field offset: 0x8
		public bool executed; //Field offset: 0x10

	}

	public static readonly Dictionary BodyPartCollidersStaticMap; //Field offset: 0x0
	public Player Player; //Field offset: 0x20
	public PlayableAnimator PlayableAnimator; //Field offset: 0x28
	public WeaponMountingView weaponMountingView; //Field offset: 0x30
	public bool IsObservedPlayer; //Field offset: 0x38
	public Transform Weapon_Root_Third; //Field offset: 0x40
	public Transform Weapon_Root_Anim; //Field offset: 0x48
	public Transform Neck; //Field offset: 0x50
	public Transform Weapon_reference_point; //Field offset: 0x58
	public Vector3 R_Neck; //Field offset: 0x60
	public Vector3 R_Head; //Field offset: 0x6C
	public Vector3 R_Neck_LeftStance; //Field offset: 0x78
	public Vector3 R_Head_LeftStance; //Field offset: 0x84
	public Transform[] Shoulders; //Field offset: 0x90
	public Transform[] Shoulders_Anim; //Field offset: 0x98
	public Transform[] Upperarms; //Field offset: 0xA0
	public Transform[] Forearms; //Field offset: 0xA8
	public Transform LeftPalm; //Field offset: 0xB0
	public Transform RightPalm; //Field offset: 0xB8
	public Transform LootRaycastOrigin; //Field offset: 0xC0
	public Transform RootJoint; //Field offset: 0xC8
	public Transform VaultingGridRoot; //Field offset: 0xD0
	public Transform WeaponMeleeRoot; //Field offset: 0xD8
	public Transform WeaponPistolRoot; //Field offset: 0xE0
	public Transform WeaponRifleRoot; //Field offset: 0xE8
	public Transform HolsterPrimary; //Field offset: 0xF0
	public Transform HolsterPrimaryAlternative; //Field offset: 0xF8
	public Transform HolsterSecondary; //Field offset: 0x100
	public Transform HolsterSecondaryAlternative; //Field offset: 0x108
	public Transform ScabbardTagillaMelee; //Field offset: 0x110
	public Transform HolsterPistol; //Field offset: 0x118
	public Transform LeftLegHolsterPistol; //Field offset: 0x120
	public Transform[] BendGoals; //Field offset: 0x128
	public Transform KickingFoot; //Field offset: 0x130
	public Transform[] FovSpecialTransforms; //Field offset: 0x138
	public BifacialTransform WeaponRoot; //Field offset: 0x140
	public BifacialTransform Ribcage; //Field offset: 0x148
	public BifacialTransform Head; //Field offset: 0x150
	public BifacialTransform LeftShoulder; //Field offset: 0x158
	public BifacialTransform RightShoulder; //Field offset: 0x160
	public BifacialTransform LeftThigh2; //Field offset: 0x168
	public BifacialTransform RightThigh2; //Field offset: 0x170
	public BifacialTransform BodyTransform; //Field offset: 0x178
	public BifacialTransform AnimatedTransform; //Field offset: 0x180
	public BifacialTransform Pelvis; //Field offset: 0x188
	public BifacialTransform LeftThigh1; //Field offset: 0x190
	public BifacialTransform RightThigh1; //Field offset: 0x198
	public BifacialTransform Spine3; //Field offset: 0x1A0
	public Vector3 Offset; //Field offset: 0x1A8
	public Quaternion DeltaRotation; //Field offset: 0x1B4
	public BodyPartCollider LeftHandCollider; //Field offset: 0x1C8
	[HideInInspector]
	public BifacialTransform Fireport; //Field offset: 0x1D0
	public BifacialTransform LeftMultiBarrelFireport; //Field offset: 0x1D8
	public BifacialTransform RightMultiBarrelFireport; //Field offset: 0x1E0
	public BifacialTransform[] MultiBarrelsFireports; //Field offset: 0x1E8
	public readonly Dictionary BifacialTransforms; //Field offset: 0x1F0
	public readonly Dictionary BodyPartCollidersDictionary; //Field offset: 0x1F8
	public readonly Dictionary ArmorPlateCollidersDict; //Field offset: 0x200
	public Collider[] ArmorColliders; //Field offset: 0x208
	public BodyPartCollider[] BodyPartColliders; //Field offset: 0x210
	public ArmorPlateCollider[] ArmorPlateColliders; //Field offset: 0x218
	public Collider HeadCameraCollider; //Field offset: 0x220
	public readonly HashSet BodyPartCollidersHashSet; //Field offset: 0x228
	private AnimationCurve _transitionCurve; //Field offset: 0x230
	private float _transitionTime; //Field offset: 0x238
	private float _transitionLn; //Field offset: 0x23C
	private ETransitionType _transitionType; //Field offset: 0x240
	public AnimationCurve HeadRotationCurve; //Field offset: 0x248
	public Transform Spine1; //Field offset: 0x250
	private TransitStruct _transition; //Field offset: 0x258
	public float HeadChain; //Field offset: 0x270
	public float NeckChain; //Field offset: 0x274
	private float _offsetForRootAimInLeftStance; //Field offset: 0x278
	private readonly Vector3 _offsterDirrectionForLeftStanceInAim; //Field offset: 0x27C
	public float leftStanceRotationAndPositionChangeSpeed; //Field offset: 0x288
	public float leftStanceReturnBackSpeed; //Field offset: 0x28C
	private Quaternion _lastWeaponRotationInLeftStance; //Field offset: 0x290
	private Vector3 targetLSPosition; //Field offset: 0x2A0
	private bool _gotFullLeftStanceLastFrame; //Field offset: 0x2AC
	private bool _wasMovingInLsAim; //Field offset: 0x2AD
	private Vector3 _targetLSInAimPosition; //Field offset: 0x2B0

	private static PlayerBones() { }

	public PlayerBones() { }

	public void AdjustPistolHolster(Transform holsterTransform, bool isRightLeg) { }

	public void Awake() { }

	public void CreateBifacialTransformsCollection() { }

	public void EnableBoneImitation(bool useImitation) { }

	public void ExecuteTransition(ref TransitStruct trans) { }

	public BifacialTransform FindFireport() { }

	public BifacialTransform[] FindMultiBarrelsFireports(bool isMultiBarrel) { }

	public void IKTransit(ETransitionType eTransitionType, float speed = 4) { }

	public void Kinematics(Transform target, float weight) { }

	public void RotateHead(float blendValue, Vector3 offset, bool leftStance, float leftStanceCurveValue, bool isAiming) { }

	public void SetArmorPlateCollidersState(EArmorPlateCollider activeCollidersMask) { }

	public void SetShoulders(float str, float strRight) { }

	public void ShiftWeaponRoot(float t, EPointOfView pv, float thirdPersonAuthority, bool armsupdated = false, float positionCacheValue = 0, float leftStanceCurveValue = 0, bool inSprint = false, bool inLeftStanceAnimValue = false, bool inLeftStanceCacheValue = false, bool isAiming = false, bool isAnimatedInteraction = false, bool isLeftHandUsing = false) { }

	public void Transit(AnimationCurve c, ETransitionType type) { }

	public void UpdateImportantBones(TransformLinks tLinks) { }

	public void UpdateLauncherRightHand() { }

}

