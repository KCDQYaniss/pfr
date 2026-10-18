namespace RootMotion.FinalIK;

public class IKMappingBone : IKMapping
{
	public Transform bone; //Field offset: 0x10
	[Range(0, 1)]
	public float maintainRotationWeight; //Field offset: 0x18
	private BoneMap boneMap; //Field offset: 0x20

	public IKMappingBone() { }

	public IKMappingBone(Transform bone) { }

	public void FixTransforms() { }

	public virtual void Initiate(IKSolverFullBody solver) { }

	public virtual bool IsValid(IKSolver solver, ref string message) { }

	public void ReadPose() { }

	public void StoreDefaultLocalState() { }

	public void WritePose(float solverWeight) { }

}

