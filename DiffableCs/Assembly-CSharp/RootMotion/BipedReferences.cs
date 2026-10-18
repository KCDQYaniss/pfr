namespace RootMotion;

public class BipedReferences
{
	internal struct AutoDetectParams
	{
		public bool legsParentInSpine; //Field offset: 0x0
		public bool includeEyes; //Field offset: 0x1

		public static AutoDetectParams Default
		{
			 get { } //Length: 13
		}

		public AutoDetectParams(bool legsParentInSpine, bool includeEyes) { }

		public static AutoDetectParams get_Default() { }

	}

	public Transform root; //Field offset: 0x10
	public Transform pelvis; //Field offset: 0x18
	public Transform leftThigh; //Field offset: 0x20
	public Transform leftCalf; //Field offset: 0x28
	public Transform leftFoot; //Field offset: 0x30
	public Transform rightThigh; //Field offset: 0x38
	public Transform rightCalf; //Field offset: 0x40
	public Transform rightFoot; //Field offset: 0x48
	public Transform leftUpperArm; //Field offset: 0x50
	public Transform leftForearm; //Field offset: 0x58
	public Transform leftHand; //Field offset: 0x60
	public Transform rightUpperArm; //Field offset: 0x68
	public Transform rightForearm; //Field offset: 0x70
	public Transform rightHand; //Field offset: 0x78
	public Transform head; //Field offset: 0x80
	public Transform[] spine; //Field offset: 0x88
	public Transform[] eyes; //Field offset: 0x90

	public bool isEmpty
	{
		 get { } //Length: 22
	}

	public override bool isFilled
	{
		 get { } //Length: 2315
	}

	public BipedReferences() { }

	private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams) { }

	private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform) { }

	private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams) { }

	public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams) { }

	public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams) { }

	public override bool Contains(Transform t, bool ignoreRoot = false) { }

	private static void DetectLimb(BoneType boneType, BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms) { }

	public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams) { }

	private static bool EyesError(BipedReferences references, ref string errorMessage) { }

	private static bool EyesWarning(BipedReferences references, ref string warningMessage) { }

	private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage) { }

	public bool get_isEmpty() { }

	public override bool get_isFilled() { }

	private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation) { }

	public override bool IsEmpty(bool includeRoot) { }

	private static bool IsNeckBone(Transform bone, Transform leftUpperArm) { }

	private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage) { }

	private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage) { }

	private static bool RootHeightWarning(BipedReferences references, ref string warningMessage) { }

	public static bool SetupError(BipedReferences references, ref string errorMessage) { }

	public static bool SetupWarning(BipedReferences references, ref string warningMessage) { }

	private static bool SpineError(BipedReferences references, ref string errorMessage) { }

	private static bool SpineWarning(BipedReferences references, ref string warningMessage) { }

}

