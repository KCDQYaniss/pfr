namespace RootMotion.FinalIK;

public class FingerRig : SolverManager
{
	[Range(0, 1)]
	[Tooltip("The master weight for all fingers.")]
	public float weight; //Field offset: 0x48
	public Finger[] fingers; //Field offset: 0x50
	[CompilerGenerated]
	private bool <initiated>k__BackingField; //Field offset: 0x58

	public private bool initiated
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public FingerRig() { }

	private void AddChildrenRecursive(Transform parent, ref Transform[] array) { }

	public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null) { }

	[ContextMenu("Auto-detect")]
	public void AutoDetect() { }

	public void FixFingerTransforms() { }

	protected virtual void FixTransforms() { }

	[CompilerGenerated]
	public bool get_initiated() { }

	protected virtual void InitiateSolver() { }

	public bool IsValid(ref string errorMessage) { }

	public void RemoveFinger(int index) { }

	[CompilerGenerated]
	private void set_initiated(bool value) { }

	public void UpdateFingerSolvers() { }

	protected virtual void UpdateSolver() { }

}

