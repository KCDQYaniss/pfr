namespace GPUInstancer;

public class SpaceshipCameraRig : MonoBehaviour
{
	public Transform m_Target; //Field offset: 0x20
	public float m_MoveSpeed; //Field offset: 0x28
	public float m_TurnSpeed; //Field offset: 0x2C
	public float m_RollSpeed; //Field offset: 0x30
	public bool m_FollowVelocity; //Field offset: 0x34
	public bool m_FollowTilt; //Field offset: 0x35
	public float m_SpinTurnLimit; //Field offset: 0x38
	public float m_TargetVelocityLowerLimit; //Field offset: 0x3C
	public float m_SmoothTurnTime; //Field offset: 0x40
	private Vector3 m_LastTargetPosition; //Field offset: 0x44
	private Rigidbody targetRigidbody; //Field offset: 0x50
	private float m_LastFlatAngle; //Field offset: 0x58
	private float m_CurrentTurnAmount; //Field offset: 0x5C
	private float m_TurnSpeedVelocityChange; //Field offset: 0x60
	private Vector3 m_RollUp; //Field offset: 0x64

	public SpaceshipCameraRig() { }

	private void FixedUpdate() { }

	private void FollowTarget(float deltaTime) { }

	private void Start() { }

}

