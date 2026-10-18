//Type is in global namespace

public class PlayerMotor : MonoBehaviour
{
	internal static class Constants
	{
		public const float PRONE_POSE = 0; //Field offset: 0x0
		public const float CROUCH_POSE = 0.5; //Field offset: 0x0
		public const float STAND_POSE = 1; //Field offset: 0x0
		public const float SPEED_MIN = 0; //Field offset: 0x0
		public const float SPEED_MAX = 1; //Field offset: 0x0
		public const string POSE_LEVEL_PARAM_NAME = "Level"; //Field offset: 0x0
		public const string DIRECTION_X_PARAM_NAME = "Direct_X"; //Field offset: 0x0
		public const string DIRECTION_Y_PARAM_NAME = "Direct_Y"; //Field offset: 0x0
		public const string SPEED_PARAM_NAME = "Speed"; //Field offset: 0x0

	}

	public Vector3 LocalVelocity; //Field offset: 0x20
	private RaycastHit _groundHit; //Field offset: 0x2C
	[SerializeField]
	private float _checkGroundedRayDistance; //Field offset: 0x58
	private Animator _animator; //Field offset: 0x60
	private Vector2 _movementDirection; //Field offset: 0x68
	private float _speed; //Field offset: 0x70
	private float _poseLevel; //Field offset: 0x74
	private Rigidbody _rigidbody; //Field offset: 0x78
	private float _rotationSpeed; //Field offset: 0x80

	public bool IsGrounded
	{
		 get { } //Length: 213
	}

	public Vector2 MovementDirection
	{
		 get { } //Length: 19
		 set { } //Length: 185
	}

	public float PoseLevel
	{
		 get { } //Length: 6
		 set { } //Length: 126
	}

	public float Speed
	{
		 get { } //Length: 6
		 set { } //Length: 126
	}

	public PlayerMotor() { }

	protected override void Awake() { }

	public void CheckGrounded() { }

	protected Vector3 ConvertToWorldXZCoordintaes(Vector3 vector) { }

	private void FixedUpdate() { }

	public bool get_IsGrounded() { }

	public Vector2 get_MovementDirection() { }

	public float get_PoseLevel() { }

	public float get_Speed() { }

	public override void Move(Vector2 direction, float speed) { }

	private void OnDrawGizmos() { }

	private void OnGUI() { }

	public void set_MovementDirection(Vector2 value) { }

	public void set_PoseLevel(float value) { }

	public void set_Speed(float value) { }

	public void SetYaw(float yaw) { }

}

