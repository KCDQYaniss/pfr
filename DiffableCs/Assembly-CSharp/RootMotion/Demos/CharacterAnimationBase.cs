namespace RootMotion.Demos;

public abstract class CharacterAnimationBase : MonoBehaviour
{
	public bool smoothFollow; //Field offset: 0x20
	public float smoothFollowSpeed; //Field offset: 0x24
	private Vector3 lastPosition; //Field offset: 0x28
	private Vector3 localPosition; //Field offset: 0x34
	private Quaternion localRotation; //Field offset: 0x40
	private Quaternion lastRotation; //Field offset: 0x50

	public override bool animationGrounded
	{
		 get { } //Length: 3
	}

	protected CharacterAnimationBase() { }

	public override bool get_animationGrounded() { }

	public float GetAngleFromForward(Vector3 worldDirection) { }

	public override Vector3 GetPivotPoint() { }

	protected override void LateUpdate() { }

	protected override void Start() { }

}

