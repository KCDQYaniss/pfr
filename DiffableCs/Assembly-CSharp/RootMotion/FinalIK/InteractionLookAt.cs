namespace RootMotion.FinalIK;

public class InteractionLookAt
{
	[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
	public LookAtIK ik; //Field offset: 0x10
	[Tooltip("Interpolation speed of the LookAtIK target.")]
	public float lerpSpeed; //Field offset: 0x18
	[Tooltip("Interpolation speed of the LookAtIK weight.")]
	public float weightSpeed; //Field offset: 0x1C
	[HideInInspector]
	public bool isPaused; //Field offset: 0x20
	private Transform lookAtTarget; //Field offset: 0x28
	private float stopLookTime; //Field offset: 0x30
	private float weight; //Field offset: 0x34
	private bool firstFBBIKSolve; //Field offset: 0x38

	public InteractionLookAt() { }

	public void Look(Transform target, float time) { }

	public void SolveHead() { }

	public void SolveSpine() { }

	public void Update() { }

}

