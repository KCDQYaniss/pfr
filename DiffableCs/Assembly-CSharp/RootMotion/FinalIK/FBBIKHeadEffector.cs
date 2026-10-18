namespace RootMotion.FinalIK;

public class FBBIKHeadEffector : MonoBehaviour
{
	internal class BendBone
	{
		[Tooltip("Assign spine and/or neck bones.")]
		public Transform transform; //Field offset: 0x10
		[Range(0, 1)]
		[Tooltip("The weight of rotating this bone.")]
		public float weight; //Field offset: 0x18
		private Quaternion defaultLocalRotation; //Field offset: 0x1C

		public BendBone() { }

		public BendBone(Transform transform, float weight) { }

		public void FixTransforms() { }

		public void StoreDefaultLocalState() { }

	}

	[Tooltip("Reference to the FBBIK component.")]
	public FullBodyBipedIK ik; //Field offset: 0x20
	[LargeHeader("Position")]
	[Range(0, 1)]
	[Tooltip("Master weight for positioning the head.")]
	public float positionWeight; //Field offset: 0x28
	[Range(0, 1)]
	[Tooltip("The weight of moving the body along with the head")]
	public float bodyWeight; //Field offset: 0x2C
	[Range(0, 1)]
	[Tooltip("The weight of moving the thighs along with the head")]
	public float thighWeight; //Field offset: 0x30
	[LargeHeader("Rotation")]
	[Range(0, 1)]
	[Tooltip("The weight of rotating the head bone after solving")]
	public float rotationWeight; //Field offset: 0x34
	[Range(0, 1)]
	[Tooltip("Clamping the rotation of the body")]
	public float bodyClampWeight; //Field offset: 0x38
	[Range(0, 1)]
	[Tooltip("Clamping the rotation of the head")]
	public float headClampWeight; //Field offset: 0x3C
	[Range(0, 1)]
	[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
	public float bendWeight; //Field offset: 0x40
	[Tooltip("The bones to use for bending.")]
	public BendBone[] bendBones; //Field offset: 0x48
	[LargeHeader("CCD")]
	[Range(0, 1)]
	[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
	public float CCDWeight; //Field offset: 0x50
	[Range(0, 1)]
	[Tooltip("The weight of rolling the bones in towards the target")]
	public float roll; //Field offset: 0x54
	[Range(0, 1000)]
	[Tooltip("Smoothing the CCD effect.")]
	public float damper; //Field offset: 0x58
	[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
	public Transform[] CCDBones; //Field offset: 0x60
	[LargeHeader("Stretching")]
	[Range(0, 1)]
	[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
	public float postStretchWeight; //Field offset: 0x68
	[Tooltip("Stretch magnitude limit.")]
	public float maxStretch; //Field offset: 0x6C
	[Tooltip("If > 0, dampers the stretching effect.")]
	public float stretchDamper; //Field offset: 0x70
	[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
	public bool fixHead; //Field offset: 0x74
	[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
	public Transform[] stretchBones; //Field offset: 0x78
	[LargeHeader("Chest Direction")]
	public Vector3 chestDirection; //Field offset: 0x80
	[Range(0, 1)]
	public float chestDirectionWeight; //Field offset: 0x8C
	public Transform[] chestBones; //Field offset: 0x90
	public UpdateDelegate OnPostHeadEffectorFK; //Field offset: 0x98
	private Vector3 offset; //Field offset: 0xA0
	private Vector3 headToBody; //Field offset: 0xAC
	private Vector3 shoulderCenterToHead; //Field offset: 0xB8
	private Vector3 headToLeftThigh; //Field offset: 0xC4
	private Vector3 headToRightThigh; //Field offset: 0xD0
	private Vector3 leftShoulderPos; //Field offset: 0xDC
	private Vector3 rightShoulderPos; //Field offset: 0xE8
	private float shoulderDist; //Field offset: 0xF4
	private float leftShoulderDist; //Field offset: 0xF8
	private float rightShoulderDist; //Field offset: 0xFC
	private Quaternion chestRotation; //Field offset: 0x100
	private Quaternion headRotationRelativeToRoot; //Field offset: 0x110
	private Quaternion[] ccdDefaultLocalRotations; //Field offset: 0x120
	private Vector3 headLocalPosition; //Field offset: 0x128
	private Quaternion headLocalRotation; //Field offset: 0x134
	private Vector3[] stretchLocalPositions; //Field offset: 0x148
	private Quaternion[] stretchLocalRotations; //Field offset: 0x150
	private Vector3[] chestLocalPositions; //Field offset: 0x158
	private Quaternion[] chestLocalRotations; //Field offset: 0x160
	private int bendBonesCount; //Field offset: 0x168
	private int ccdBonesCount; //Field offset: 0x16C
	private int stretchBonesCount; //Field offset: 0x170
	private int chestBonesCount; //Field offset: 0x174

	public FBBIKHeadEffector() { }

	private void Awake() { }

	private void CCDPass() { }

	private void ChestDirection() { }

	private void Iterate(int iteration) { }

	private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset) { }

	private void OnDestroy() { }

	private void OnFixTransforms() { }

	private void OnPostUpdate() { }

	private void OnPreRead() { }

	private void OnStoreDefaultLocalState() { }

	private void PostStretching() { }

	private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance) { }

	private void SpineBend() { }

}

