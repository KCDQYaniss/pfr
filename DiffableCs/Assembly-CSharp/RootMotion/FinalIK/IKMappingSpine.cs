namespace RootMotion.FinalIK;

public class IKMappingSpine : IKMapping
{
	public Transform[] spineBones; //Field offset: 0x10
	public Transform leftUpperArmBone; //Field offset: 0x18
	public Transform rightUpperArmBone; //Field offset: 0x20
	public Transform leftThighBone; //Field offset: 0x28
	public Transform rightThighBone; //Field offset: 0x30
	[Range(1, 3)]
	public int iterations; //Field offset: 0x38
	[Range(0, 1)]
	public float twistWeight; //Field offset: 0x3C
	private int rootNodeIndex; //Field offset: 0x40
	private BoneMap[] spine; //Field offset: 0x48
	private BoneMap leftUpperArm; //Field offset: 0x50
	private BoneMap rightUpperArm; //Field offset: 0x58
	private BoneMap leftThigh; //Field offset: 0x60
	private BoneMap rightThigh; //Field offset: 0x68
	private bool useFABRIK; //Field offset: 0x70

	public IKMappingSpine() { }

	public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	private void BackwardReach(Vector3 position) { }

	public void FixTransforms() { }

	public void ForwardReach(Vector3 position) { }

	public virtual void Initiate(IKSolverFullBody solver) { }

	public virtual bool IsValid(IKSolver solver, ref string message) { }

	private void MapToSolverPositions(IKSolverFullBody solver) { }

	public void ReadPose() { }

	public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	public void StoreDefaultLocalState() { }

	private bool UseFABRIK() { }

	public void WritePose(IKSolverFullBody solver) { }

}

