namespace RootMotion.FinalIK;

public class IKMapping
{
	internal class BoneMap
	{
		public Transform transform; //Field offset: 0x10
		public int chainIndex; //Field offset: 0x18
		public int nodeIndex; //Field offset: 0x1C
		public Vector3 defaultLocalPosition; //Field offset: 0x20
		public Quaternion defaultLocalRotation; //Field offset: 0x2C
		public Vector3 localSwingAxis; //Field offset: 0x3C
		public Vector3 localTwistAxis; //Field offset: 0x48
		public Vector3 planePosition; //Field offset: 0x54
		public Vector3 ikPosition; //Field offset: 0x60
		public Quaternion defaultLocalTargetRotation; //Field offset: 0x6C
		private Quaternion maintainRotation; //Field offset: 0x7C
		public float length; //Field offset: 0x8C
		public Quaternion animatedRotation; //Field offset: 0x90
		private Transform planeBone1; //Field offset: 0xA0
		private Transform planeBone2; //Field offset: 0xA8
		private Transform planeBone3; //Field offset: 0xB0
		private int plane1ChainIndex; //Field offset: 0xB8
		private int plane1NodeIndex; //Field offset: 0xBC
		private int plane2ChainIndex; //Field offset: 0xC0
		private int plane2NodeIndex; //Field offset: 0xC4
		private int plane3ChainIndex; //Field offset: 0xC8
		private int plane3NodeIndex; //Field offset: 0xCC

		public bool isNodeBone
		{
			 get { } //Length: 8
		}

		private Quaternion lastAnimatedTargetRotation
		{
			private get { } //Length: 975
		}

		public Vector3 swingDirection
		{
			 get { } //Length: 605
		}

		public BoneMap() { }

		public void FixToNode(IKSolverFullBody solver, float weight, Node fixNode = null) { }

		public void FixTransform(bool position) { }

		public bool get_isNodeBone() { }

		private Quaternion get_lastAnimatedTargetRotation() { }

		public Vector3 get_swingDirection() { }

		public Vector3 GetPlanePosition(IKSolverFullBody solver) { }

		private Quaternion GetTargetRotation(IKSolverFullBody solver) { }

		public void Initiate(Transform transform, IKSolverFullBody solver) { }

		public void MaintainRotation() { }

		public void PositionToPlane(IKSolverFullBody solver) { }

		public void RotateToEffector(IKSolverFullBody solver, float weight) { }

		public void RotateToMaintain(float weight) { }

		public void RotateToPlane(IKSolverFullBody solver, float weight) { }

		public void SetIKPosition() { }

		public void SetLength(BoneMap nextBone) { }

		public void SetLocalSwingAxis(BoneMap swingTarget) { }

		public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2) { }

		public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection) { }

		public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3) { }

		public void SetToIKPosition() { }

		public void StoreDefaultLocalState() { }

		public void Swing(Vector3 swingTarget, float weight) { }

		public void Swing(Vector3 pos1, Vector3 pos2, float weight) { }

		public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight) { }

		public void UpdatePlane(bool rotation, bool position) { }

	}


	public IKMapping() { }

	protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Logger logger = null) { }

	public override void Initiate(IKSolverFullBody solver) { }

	public override bool IsValid(IKSolver solver, ref string message) { }

	protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) { }

}

