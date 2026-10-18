namespace EFT;

public class PlayerSpiritBones : MonoBehaviour, IPlatformTransportee
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__38_1; //Field offset: 0x8
		public static Action <>9__38_3; //Field offset: 0x10
		public static Action <>9__38_4; //Field offset: 0x18
		public static Action <>9__38_6; //Field offset: 0x20
		public static Action <>9__38_8; //Field offset: 0x28
		public static Action <>9__38_17; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal void <SetupBone>b__38_1(Vector3 value) { }

		internal void <SetupBone>b__38_17(Vector3 v1, Vector3 v2) { }

		internal void <SetupBone>b__38_3(Quaternion value) { }

		internal void <SetupBone>b__38_4(Vector3 pos, Quaternion rot) { }

		internal void <SetupBone>b__38_6(Vector3 value) { }

		internal void <SetupBone>b__38_8(Quaternion value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public PlayerSpiritBones <>4__this; //Field offset: 0x10
		public PlayerBoneType boneType; //Field offset: 0x18

		public <>c__DisplayClass38_0() { }

		internal Vector3 <SetupBone>b__0() { }

		internal Vector3 <SetupBone>b__10() { }

		internal Vector3 <SetupBone>b__11() { }

		internal Vector3 <SetupBone>b__12() { }

		internal Vector3 <SetupBone>b__13(Vector3 value) { }

		internal Vector3 <SetupBone>b__14(Vector3 value) { }

		internal Vector3 <SetupBone>b__15(Vector3 value) { }

		internal Vector3 <SetupBone>b__16(Vector3 value) { }

		internal Quaternion <SetupBone>b__2() { }

		internal Vector3 <SetupBone>b__5() { }

		internal Quaternion <SetupBone>b__7() { }

		internal Vector3 <SetupBone>b__9() { }

	}

	internal struct BonePosition
	{
		public PlayerBoneType type; //Field offset: 0x0
		public Vector3 position; //Field offset: 0x4

	}

	internal struct PoseSkeleton
	{
		public PoseType type; //Field offset: 0x0
		public BonePosition[] bones; //Field offset: 0x8

	}

	internal enum PoseType
	{
		None = 0,
		Stand = 1,
		Crouch = 2,
		Prone = 3,
		TiltLeft = 4,
		TiltRight = 5,
		SideStepLeft = 6,
		SideStepRight = 7,
		ProneSideStepLeft = 8,
		ProneSideStepRight = 9,
		ProneTiltLeft = 10,
		ProneTiltRight = 11,
		CrouchTiltLeft = 12,
		CrouchTiltRight = 13,
		CrouchSideStepLeft = 14,
		CrouchSideStepRight = 15,
	}

	private ICharacterController _characterController; //Field offset: 0x20
	public List SimpleBones; //Field offset: 0x28
	[SerializeField]
	private PoseType _currentPose; //Field offset: 0x30
	[SerializeField]
	private Transform _vaultingGridRoot; //Field offset: 0x38
	[SerializeField]
	private bool _isAiming; //Field offset: 0x40
	[SerializeField]
	private Vector3 aimingOffsetLocal; //Field offset: 0x44
	[SerializeField]
	private Quaternion aimingRotationLocal; //Field offset: 0x50
	[SerializeField]
	private PoseSkeleton[] _posesConfig; //Field offset: 0x60
	private Dictionary[] _poses; //Field offset: 0x68
	private PlayerSpiritBase _spirit; //Field offset: 0x70
	private Quaternion _cachedFromSurfaceRotation; //Field offset: 0x78
	private int _lastCachedFrameForSurfaceRotation; //Field offset: 0x88
	private readonly Dictionary _bones; //Field offset: 0x90

	public Vector3 Center
	{
		 get { } //Length: 113
	}

	public PoseType CurrentPose
	{
		 get { } //Length: 5
	}

	public float Height
	{
		 get { } //Length: 78
	}

	public PoseType Pose
	{
		 get { } //Length: 5
	}

	public float Radius
	{
		 get { } //Length: 78
	}

	public float SkinWidth
	{
		 get { } //Length: 78
	}

	public float Step
	{
		 get { } //Length: 55
	}

	public float Tilt
	{
		 get { } //Length: 52
	}

	public Transform VaultingGridRoot
	{
		 get { } //Length: 5
	}

	public PlayerSpiritBones() { }

	[ContextMenu("AWAKE")]
	private void Awake() { }

	public override void Board(MovingPlatform platform) { }

	public Vector3 get_Center() { }

	public PoseType get_CurrentPose() { }

	public float get_Height() { }

	public PoseType get_Pose() { }

	public float get_Radius() { }

	public float get_SkinWidth() { }

	public float get_Step() { }

	public float get_Tilt() { }

	public Transform get_VaultingGridRoot() { }

	public BifacialTransform GetBone(PlayerBoneType boneType) { }

	private Vector3 GetImitatorPosition(PlayerBoneType boneType) { }

	public Vector3 GetImitatorPositionLocal(Vector3 relativePoint) { }

	private Quaternion GetImitatorRotation(PlayerBoneType boneType) { }

	public Bounds GetLocalBounds() { }

	public override void GetOff(MovingPlatform platform) { }

	public void Init(PlayerSpiritBase spirit) { }

	private void ModifyPointBySmoothTilt(PlayerBoneType boneType, ref Vector3 relativePoint) { }

	private void ModifyPointBySurfaceAngle(ref Vector3 relativePoint) { }

	private void PreparePoseConfigs() { }

	public void SetAimingState(bool aiming) { }

	public void SetPose(PoseType poseType) { }

	public void SetPoseConfig(PoseSkeleton poseSkeleton) { }

	public void SetupBone(BifacialTransform bone, PlayerBoneType boneType) { }

	public void SetupSimpleBones(Dictionary originalBones) { }

}

