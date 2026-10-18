namespace RootMotion.Demos;

[RequireComponent(typeof(Animator))]
public class CharacterAnimationThirdPerson : CharacterAnimationBase
{
	private const string groundedDirectional = "Grounded Directional"; //Field offset: 0x0
	private const string groundedStrafe = "Grounded Strafe"; //Field offset: 0x0
	public CharacterThirdPerson characterController; //Field offset: 0x60
	[SerializeField]
	private float turnSensitivity; //Field offset: 0x68
	[SerializeField]
	private float turnSpeed; //Field offset: 0x6C
	[SerializeField]
	private float runCycleLegOffset; //Field offset: 0x70
	[Range(0.1, 3)]
	[SerializeField]
	private float animSpeedMultiplier; //Field offset: 0x74
	protected Animator animator; //Field offset: 0x78
	private Vector3 lastForward; //Field offset: 0x80

	public virtual bool animationGrounded
	{
		 get { } //Length: 529
	}

	public CharacterAnimationThirdPerson() { }

	public virtual bool get_animationGrounded() { }

	public virtual Vector3 GetPivotPoint() { }

	private void OnAnimatorMove() { }

	protected virtual void Start() { }

	protected override void Update() { }

}

