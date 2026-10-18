namespace RootMotion.Demos;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public abstract class CharacterBase : MonoBehaviour
{
	protected const float half = 0.5; //Field offset: 0x0
	[Header("Base Parameters")]
	[Range(1, 4)]
	[SerializeField]
	protected float gravityMultiplier; //Field offset: 0x20
	[SerializeField]
	protected float airborneThreshold; //Field offset: 0x24
	[SerializeField]
	private float slopeStartAngle; //Field offset: 0x28
	[SerializeField]
	private float slopeEndAngle; //Field offset: 0x2C
	[SerializeField]
	private float spherecastRadius; //Field offset: 0x30
	[SerializeField]
	private LayerMask groundLayers; //Field offset: 0x34
	private PhysicMaterial zeroFrictionMaterial; //Field offset: 0x38
	private PhysicMaterial highFrictionMaterial; //Field offset: 0x40
	protected Rigidbody r; //Field offset: 0x48
	protected float originalHeight; //Field offset: 0x50
	protected Vector3 originalCenter; //Field offset: 0x54
	protected CapsuleCollider capsule; //Field offset: 0x60

	protected CharacterBase() { }

	public float GetAngleFromForward(Vector3 worldDirection) { }

	protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal) { }

	protected override RaycastHit GetSpherecastHit() { }

	protected void HighFriction() { }

	public abstract void Move(Vector3 deltaPosition) { }

	protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle) { }

	protected void ScaleCapsule(float mlp) { }

	protected override void Start() { }

	protected void ZeroFriction() { }

}

