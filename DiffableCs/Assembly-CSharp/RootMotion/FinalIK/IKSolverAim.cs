namespace RootMotion.FinalIK;

public class IKSolverAim : IKSolverHeuristic
{
	public Transform transform; //Field offset: 0x88
	public Vector3 axis; //Field offset: 0x90
	public Vector3 poleAxis; //Field offset: 0x9C
	public Vector3 polePosition; //Field offset: 0xA8
	[Range(0, 1)]
	public float poleWeight; //Field offset: 0xB4
	public Transform poleTarget; //Field offset: 0xB8
	[Range(0, 1)]
	public float clampWeight; //Field offset: 0xC0
	[Range(0, 2)]
	public int clampSmoothing; //Field offset: 0xC4
	public IterationDelegate OnPreIteration; //Field offset: 0xC8
	private float step; //Field offset: 0xD0
	private Vector3 clampedIKPosition; //Field offset: 0xD4
	private RotationLimit transformLimit; //Field offset: 0xE0
	private Transform lastTransform; //Field offset: 0xE8

	protected virtual Vector3 localDirection
	{
		 get { } //Length: 261
	}

	protected virtual int minBones
	{
		 get { } //Length: 6
	}

	public Vector3 transformAxis
	{
		 get { } //Length: 614
	}

	public Vector3 transformPoleAxis
	{
		 get { } //Length: 614
	}

	public IKSolverAim() { }

	protected virtual Vector3 get_localDirection() { }

	protected virtual int get_minBones() { }

	public Vector3 get_transformAxis() { }

	public Vector3 get_transformPoleAxis() { }

	public float GetAngle() { }

	private Vector3 GetClampedIKPosition() { }

	protected virtual void OnInitiate() { }

	protected virtual void OnUpdate() { }

	private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight) { }

	private void Solve() { }

}

