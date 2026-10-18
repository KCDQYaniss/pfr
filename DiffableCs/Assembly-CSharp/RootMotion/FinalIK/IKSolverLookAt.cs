namespace RootMotion.FinalIK;

public class IKSolverLookAt : IKSolver
{
	internal class LookAtBone : Bone
	{

		public Vector3 forward
		{
			 get { } //Length: 605
		}

		public LookAtBone() { }

		public LookAtBone(Transform transform) { }

		public Vector3 get_forward() { }

		public void Initiate(Transform root) { }

		public void LookAt(Vector3 direction, float weight) { }

	}

	public Transform target; //Field offset: 0x58
	public LookAtBone[] spine; //Field offset: 0x60
	public LookAtBone head; //Field offset: 0x68
	public LookAtBone[] eyes; //Field offset: 0x70
	[Range(0, 1)]
	public float bodyWeight; //Field offset: 0x78
	[Range(0, 1)]
	public float headWeight; //Field offset: 0x7C
	[Range(0, 1)]
	public float eyesWeight; //Field offset: 0x80
	[Range(0, 1)]
	public float clampWeight; //Field offset: 0x84
	[Range(0, 1)]
	public float clampWeightHead; //Field offset: 0x88
	[Range(0, 1)]
	public float clampWeightEyes; //Field offset: 0x8C
	[Range(0, 2)]
	public int clampSmoothing; //Field offset: 0x90
	public AnimationCurve spineWeightCurve; //Field offset: 0x98
	private Vector3[] spineForwards; //Field offset: 0xA0
	private Vector3[] headForwards; //Field offset: 0xA8
	private Vector3[] eyeForward; //Field offset: 0xB0

	private bool eyesIsEmpty
	{
		private get { } //Length: 30
	}

	private bool eyesIsValid
	{
		private get { } //Length: 347
	}

	private bool headIsEmpty
	{
		private get { } //Length: 220
	}

	private bool headIsValid
	{
		private get { } //Length: 9
	}

	private bool spineIsEmpty
	{
		private get { } //Length: 30
	}

	private bool spineIsValid
	{
		private get { } //Length: 347
	}

	public IKSolverLookAt() { }

	public virtual void FixTransforms() { }

	private bool get_eyesIsEmpty() { }

	private bool get_eyesIsValid() { }

	private bool get_headIsEmpty() { }

	private bool get_headIsValid() { }

	private bool get_spineIsEmpty() { }

	private bool get_spineIsValid() { }

	private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp) { }

	public virtual Point GetPoint(Transform transform) { }

	public virtual Point[] GetPoints() { }

	public virtual bool IsValid(ref string message) { }

	protected virtual void OnInitiate() { }

	protected virtual void OnUpdate() { }

	private void SetBones(Transform[] array, ref LookAtBone[] bones) { }

	public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root) { }

	public void SetLookAtWeight(float weight, float bodyWeight = 0, float headWeight = 1, float eyesWeight = 0.5, float clampWeight = 0.5, float clampWeightHead = 0.5, float clampWeightEyes = 0.3) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	public void SetLookAtWeight(float weight, float bodyWeight) { }

	public void SetLookAtWeight(float weight) { }

	private void SolveEyes() { }

	private void SolveHead() { }

	private void SolveSpine() { }

	public virtual void StoreDefaultLocalState() { }

}

