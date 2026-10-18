//Type is in global namespace

public class CharacterControllerSpawner : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__48_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <Spawn>b__48_0(Collider x) { }

	}

	internal enum ControllerType
	{
		Unity = 0,
		Impostor = 1,
		Simple = 2,
		SteeringImpostor = 3,
		BotAISteeringImpostorWithDoors = 4,
	}

	internal class Mode
	{
		public ControllerType Type; //Field offset: 0x10
		public bool WithRigidbody; //Field offset: 0x14
		public bool WithMovementValidation; //Field offset: 0x15
		public bool WithTriggerCollider; //Field offset: 0x16
		public bool WithKinematicOption; //Field offset: 0x17

		public Mode() { }

	}

	[SerializeField]
	private float _slopeLimit; //Field offset: 0x20
	[SerializeField]
	private float _stepOffset; //Field offset: 0x24
	[SerializeField]
	private float _skinWidth; //Field offset: 0x28
	[SerializeField]
	private float _minMoveDistance; //Field offset: 0x2C
	[SerializeField]
	private Vector3 _center; //Field offset: 0x30
	[SerializeField]
	private float _radius; //Field offset: 0x3C
	[SerializeField]
	private float _height; //Field offset: 0x40
	[Range(-5, 5)]
	[SerializeField]
	private float _tilt; //Field offset: 0x44
	[Range(-1, 1)]
	[SerializeField]
	private float _step; //Field offset: 0x48
	[SerializeField]
	private PoseType _pose; //Field offset: 0x4C
	private CharacterController _characterController; //Field offset: 0x50
	private CapsuleCollider _capsuleCollider; //Field offset: 0x58
	private Rigidbody _rigidbody; //Field offset: 0x60
	private TriggerColliderSearcher _triggerColliderSearcher; //Field offset: 0x68
	private Mode _settings; //Field offset: 0x70

	public CapsuleCollider CapsuleCollider
	{
		 get { } //Length: 5
	}

	public Vector3 center
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public CharacterController CharacterController
	{
		 get { } //Length: 5
	}

	public float height
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public PoseType pose
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float radius
	{
		 get { } //Length: 6
	}

	public Rigidbody Rigidbody
	{
		 get { } //Length: 5
	}

	public float skinWidth
	{
		 get { } //Length: 6
	}

	public float slopeLimit
	{
		 get { } //Length: 6
	}

	public float step
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float stepOffset
	{
		 get { } //Length: 6
	}

	public float tilt
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public TriggerColliderSearcher TriggerColliderSearcher
	{
		 get { } //Length: 5
	}

	public CharacterControllerSpawner() { }

	private void CreateCapsuleCollider() { }

	public void CreateRigidbody() { }

	private void CreateTriggerColliderSearcher(Collider collider, bool thirdPerson) { }

	public CapsuleCollider get_CapsuleCollider() { }

	public Vector3 get_center() { }

	public CharacterController get_CharacterController() { }

	public float get_height() { }

	public PoseType get_pose() { }

	public float get_radius() { }

	public Rigidbody get_Rigidbody() { }

	public float get_skinWidth() { }

	public float get_slopeLimit() { }

	public float get_step() { }

	public float get_stepOffset() { }

	public float get_tilt() { }

	public TriggerColliderSearcher get_TriggerColliderSearcher() { }

	public ICharacterController ReplaceSpawn(Mode settings, Player player, GameObject gameObject, bool isSpirit, bool isThirdPerson) { }

	public void set_center(Vector3 value) { }

	public void set_height(float value) { }

	public void set_pose(PoseType value) { }

	public void set_step(float value) { }

	public void set_tilt(float value) { }

	public ICharacterController Spawn(Mode settings, IPlayer player, GameObject gameObject, bool isSpirit, bool isThirdPerson) { }

}

