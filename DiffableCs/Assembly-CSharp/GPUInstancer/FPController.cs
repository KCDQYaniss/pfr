namespace GPUInstancer;

[RequireComponent(typeof(CharacterController))]
public class FPController : MonoBehaviour
{
	[SerializeField]
	public float m_WalkSpeed; //Field offset: 0x20
	[SerializeField]
	public float m_RunSpeed; //Field offset: 0x24
	[SerializeField]
	public float m_JumpSpeed; //Field offset: 0x28
	private bool m_IsWalking; //Field offset: 0x2C
	private MouseLook m_MouseLook; //Field offset: 0x30
	private Camera m_Camera; //Field offset: 0x38
	private bool m_Jump; //Field offset: 0x40
	private float m_YRotation; //Field offset: 0x44
	private Vector2 m_Input; //Field offset: 0x48
	private Vector3 m_MoveDir; //Field offset: 0x50
	private CharacterController m_CharacterController; //Field offset: 0x60
	private CollisionFlags m_CollisionFlags; //Field offset: 0x68
	private bool m_PreviouslyGrounded; //Field offset: 0x6C
	private bool m_Jumping; //Field offset: 0x6D
	private float m_StickToGroundForce; //Field offset: 0x70
	private float m_GravityMultiplier; //Field offset: 0x74

	public FPController() { }

	private void FixedUpdate() { }

	private void GetInput(out float speed) { }

	private void OnControllerColliderHit(ControllerColliderHit hit) { }

	private void RotateView() { }

	private void Start() { }

	private void Update() { }

}

