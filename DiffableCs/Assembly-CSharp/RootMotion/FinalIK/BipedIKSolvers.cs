namespace RootMotion.FinalIK;

public class BipedIKSolvers
{
	public IKSolverLimb leftFoot; //Field offset: 0x10
	public IKSolverLimb rightFoot; //Field offset: 0x18
	public IKSolverLimb leftHand; //Field offset: 0x20
	public IKSolverLimb rightHand; //Field offset: 0x28
	public IKSolverFABRIK spine; //Field offset: 0x30
	public IKSolverLookAt lookAt; //Field offset: 0x38
	public IKSolverAim aim; //Field offset: 0x40
	public Constraints pelvis; //Field offset: 0x48
	private IKSolverLimb[] _limbs; //Field offset: 0x50
	private IKSolver[] _ikSolvers; //Field offset: 0x58

	public IKSolver[] ikSolvers
	{
		 get { } //Length: 650
	}

	public IKSolverLimb[] limbs
	{
		 get { } //Length: 458
	}

	public BipedIKSolvers() { }

	public void AssignReferences(BipedReferences references) { }

	public IKSolver[] get_ikSolvers() { }

	public IKSolverLimb[] get_limbs() { }

}

