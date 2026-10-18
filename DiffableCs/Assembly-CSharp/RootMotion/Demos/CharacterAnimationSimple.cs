namespace RootMotion.Demos;

[RequireComponent(typeof(Animator))]
public class CharacterAnimationSimple : CharacterAnimationBase
{
	[SerializeField]
	private CharacterThirdPerson characterController; //Field offset: 0x60
	[SerializeField]
	private float pivotOffset; //Field offset: 0x68
	[SerializeField]
	private AnimationCurve moveSpeed; //Field offset: 0x70
	private Animator animator; //Field offset: 0x78

	public CharacterAnimationSimple() { }

	public virtual Vector3 GetPivotPoint() { }

	protected virtual void Start() { }

	private void Update() { }

}

