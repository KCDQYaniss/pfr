namespace RootMotion.FinalIK;

public class IKSolverFullBodyBiped : IKSolverFullBody
{
	public Transform rootNode; //Field offset: 0xD8
	[Range(0, 1)]
	public float spineStiffness; //Field offset: 0xE0
	[Range(-1, 1)]
	public float pullBodyVertical; //Field offset: 0xE4
	[Range(-1, 1)]
	public float pullBodyHorizontal; //Field offset: 0xE8
	[CompilerGenerated]
	private Vector3 <pullBodyOffset>k__BackingField; //Field offset: 0xEC
	private Vector3 offset; //Field offset: 0xF8

	public IKEffector bodyEffector
	{
		 get { } //Length: 39
	}

	public IKMappingBone headMapping
	{
		 get { } //Length: 39
	}

	public FBIKChain leftArmChain
	{
		 get { } //Length: 39
	}

	public IKMappingLimb leftArmMapping
	{
		 get { } //Length: 42
	}

	public IKEffector leftFootEffector
	{
		 get { } //Length: 39
	}

	public IKEffector leftHandEffector
	{
		 get { } //Length: 39
	}

	public FBIKChain leftLegChain
	{
		 get { } //Length: 39
	}

	public IKMappingLimb leftLegMapping
	{
		 get { } //Length: 42
	}

	public IKEffector leftShoulderEffector
	{
		 get { } //Length: 39
	}

	public IKEffector leftThighEffector
	{
		 get { } //Length: 39
	}

	public private Vector3 pullBodyOffset
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public FBIKChain rightArmChain
	{
		 get { } //Length: 39
	}

	public IKMappingLimb rightArmMapping
	{
		 get { } //Length: 42
	}

	public IKEffector rightFootEffector
	{
		 get { } //Length: 39
	}

	public IKEffector rightHandEffector
	{
		 get { } //Length: 39
	}

	public FBIKChain rightLegChain
	{
		 get { } //Length: 39
	}

	public IKMappingLimb rightLegMapping
	{
		 get { } //Length: 42
	}

	public IKEffector rightShoulderEffector
	{
		 get { } //Length: 39
	}

	public IKEffector rightThighEffector
	{
		 get { } //Length: 39
	}

	public IKSolverFullBodyBiped() { }

	protected virtual void ApplyBendConstraints() { }

	private static bool Contains(Transform[] array, Transform transform) { }

	public static Transform DetectRootNodeBone(BipedReferences references) { }

	public IKEffector get_bodyEffector() { }

	public IKMappingBone get_headMapping() { }

	public FBIKChain get_leftArmChain() { }

	public IKMappingLimb get_leftArmMapping() { }

	public IKEffector get_leftFootEffector() { }

	public IKEffector get_leftHandEffector() { }

	public FBIKChain get_leftLegChain() { }

	public IKMappingLimb get_leftLegMapping() { }

	public IKEffector get_leftShoulderEffector() { }

	public IKEffector get_leftThighEffector() { }

	[CompilerGenerated]
	public Vector3 get_pullBodyOffset() { }

	public FBIKChain get_rightArmChain() { }

	public IKMappingLimb get_rightArmMapping() { }

	public IKEffector get_rightFootEffector() { }

	public IKEffector get_rightHandEffector() { }

	public FBIKChain get_rightLegChain() { }

	public IKMappingLimb get_rightLegMapping() { }

	public IKEffector get_rightShoulderEffector() { }

	public IKEffector get_rightThighEffector() { }

	public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb) { }

	private Vector3 GetBodyOffset() { }

	public FBIKChain GetChain(FullBodyBipedChain c) { }

	public FBIKChain GetChain(FullBodyBipedEffector effector) { }

	public IKEffector GetEffector(FullBodyBipedEffector effector) { }

	public IKEffector GetEndEffector(FullBodyBipedChain c) { }

	private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset) { }

	public IKMappingBone GetHeadMapping() { }

	private static Transform GetLeftClavicle(BipedReferences references) { }

	public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector) { }

	public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain) { }

	private static Transform GetRightClavicle(BipedReferences references) { }

	public IKMappingSpine GetSpineMapping() { }

	public virtual bool IsValid(ref string message) { }

	private void PullBody() { }

	protected virtual void ReadPose() { }

	[CompilerGenerated]
	private void set_pullBodyOffset(Vector3 value) { }

	public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0) { }

	public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight) { }

	private void SetLimbOrientation(FullBodyBipedChain chain, LimbOrientation limbOrientation) { }

	public void SetLimbOrientations(BipedLimbOrientations o) { }

	public void SetToReferences(BipedReferences references, Transform rootNode = null) { }

	protected virtual void WritePose() { }

}

