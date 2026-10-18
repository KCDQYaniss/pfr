//Type is in global namespace

public class SimpleCharacterControllerTest : MonoBehaviour
{
	private SimpleCharacterController _characterController; //Field offset: 0x20
	[SerializeField]
	private CapsuleCollider _mainCollider; //Field offset: 0x28
	private Vector3 _lastPosition; //Field offset: 0x30
	public bool IsGrounded; //Field offset: 0x3C

	public SimpleCharacterControllerTest() { }

	private void Awake() { }

	private void Update() { }

}

