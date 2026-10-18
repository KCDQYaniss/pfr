namespace RootMotion.FinalIK;

public class IKMappingLimb : IKMapping
{
	internal enum BoneMapType
	{
		Parent = 0,
		Bone1 = 1,
		Bone2 = 2,
		Bone3 = 3,
	}

	public Transform parentBone; //Field offset: 0x10
	public Transform bone1; //Field offset: 0x18
	public Transform bone2; //Field offset: 0x20
	public Transform bone3; //Field offset: 0x28
	[Range(0, 1)]
	public float maintainRotationWeight; //Field offset: 0x30
	[Range(0, 1)]
	public float weight; //Field offset: 0x34
	private BoneMap boneMapParent; //Field offset: 0x38
	private BoneMap boneMap1; //Field offset: 0x40
	private BoneMap boneMap2; //Field offset: 0x48
	private BoneMap boneMap3; //Field offset: 0x50

	public IKMappingLimb() { }

	public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null) { }

	public void FixTransforms() { }

	public BoneMap GetBoneMap(BoneMapType boneMap) { }

	public virtual void Initiate(IKSolverFullBody solver) { }

	public virtual bool IsValid(IKSolver solver, ref string message) { }

	public void ReadPose() { }

	public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null) { }

	public void SetLimbOrientation(Vector3 upper, Vector3 lower) { }

	public void StoreDefaultLocalState() { }

	public void WritePose(IKSolverFullBody solver, bool fullBody) { }

}

