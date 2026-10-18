namespace RootMotion;

public class SolverManager : MonoBehaviour
{
	[Tooltip("If zero, will update the solver in every LateUpdate(). Use this for chains that are animated. If > 0, will be used as updating frequency so that the solver will reach its target in the same time on all machines.")]
	public float timeStep; //Field offset: 0x20
	[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
	public bool fixTransforms; //Field offset: 0x24
	private float lastTime; //Field offset: 0x28
	private Animator animator; //Field offset: 0x30
	private Animation legacy; //Field offset: 0x38
	private bool updateFrame; //Field offset: 0x40
	private bool componentInitiated; //Field offset: 0x41
	private bool skipSolverUpdate; //Field offset: 0x42

	private bool animatePhysics
	{
		private get { } //Length: 536
	}

	private bool isAnimated
	{
		private get { } //Length: 375
	}

	public SolverManager() { }

	public void Disable() { }

	private void FindAnimatorRecursive(Transform t, bool findInChildren) { }

	private void FixedUpdate() { }

	protected override void FixTransforms() { }

	private bool get_animatePhysics() { }

	private bool get_isAnimated() { }

	private void Initiate() { }

	protected override void InitiateSolver() { }

	private void LateUpdate() { }

	private void OnDisable() { }

	private void Start() { }

	private void Update() { }

	protected override void UpdateSolver() { }

	public void UpdateSolverExternal() { }

}

