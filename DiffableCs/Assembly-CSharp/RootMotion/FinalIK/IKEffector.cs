namespace RootMotion.FinalIK;

public class IKEffector
{
	public Transform bone; //Field offset: 0x10
	public Transform target; //Field offset: 0x18
	[Range(0, 1)]
	public float positionWeight; //Field offset: 0x20
	[Range(0, 1)]
	public float rotationWeight; //Field offset: 0x24
	public Vector3 position; //Field offset: 0x28
	public Quaternion rotation; //Field offset: 0x34
	public Vector3 positionOffset; //Field offset: 0x44
	[CompilerGenerated]
	private bool <isEndEffector>k__BackingField; //Field offset: 0x50
	public bool effectChildNodes; //Field offset: 0x51
	[Range(0, 1)]
	public float maintainRelativePositionWeight; //Field offset: 0x54
	public Transform[] childBones; //Field offset: 0x58
	public Transform planeBone1; //Field offset: 0x60
	public Transform planeBone2; //Field offset: 0x68
	public Transform planeBone3; //Field offset: 0x70
	public Quaternion planeRotationOffset; //Field offset: 0x78
	private float posW; //Field offset: 0x88
	private float rotW; //Field offset: 0x8C
	private Vector3[] localPositions; //Field offset: 0x90
	private bool usePlaneNodes; //Field offset: 0x98
	private Quaternion animatedPlaneRotation; //Field offset: 0x9C
	private Vector3 animatedPosition; //Field offset: 0xAC
	private bool firstUpdate; //Field offset: 0xB8
	private int chainIndex; //Field offset: 0xBC
	private int nodeIndex; //Field offset: 0xC0
	private int plane1ChainIndex; //Field offset: 0xC4
	private int plane1NodeIndex; //Field offset: 0xC8
	private int plane2ChainIndex; //Field offset: 0xCC
	private int plane2NodeIndex; //Field offset: 0xD0
	private int plane3ChainIndex; //Field offset: 0xD4
	private int plane3NodeIndex; //Field offset: 0xD8
	private int[] childChainIndexes; //Field offset: 0xE0
	private int[] childNodeIndexes; //Field offset: 0xE8

	public private bool isEndEffector
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public IKEffector() { }

	public IKEffector(Transform bone, Transform[] childBones) { }

	[CompilerGenerated]
	public bool get_isEndEffector() { }

	public Node GetNode(IKSolverFullBody solver) { }

	private Quaternion GetPlaneRotation(IKSolverFullBody solver) { }

	private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset) { }

	public void Initiate(IKSolverFullBody solver) { }

	public bool IsValid(IKSolver solver, ref string message) { }

	public void OnPostWrite() { }

	public void OnPreSolve(IKSolverFullBody solver) { }

	public void PinToBone(float positionWeight, float rotationWeight) { }

	public void ResetOffset(IKSolverFullBody solver) { }

	[CompilerGenerated]
	private void set_isEndEffector(bool value) { }

	public void SetToTarget() { }

	public void Update(IKSolverFullBody solver) { }

}

