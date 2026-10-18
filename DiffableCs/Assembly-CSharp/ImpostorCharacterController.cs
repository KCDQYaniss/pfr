//Type is in global namespace

public class ImpostorCharacterController : ICharacterController
{
	private bool _performMovementValidation; //Field offset: 0x10
	private CapsuleCollider _collider; //Field offset: 0x18
	private IPlayer _player; //Field offset: 0x20
	private Rigidbody _rigidbody; //Field offset: 0x28
	[CompilerGenerated]
	private CollisionFlags <collisionFlags>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <detectCollisions>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private bool <isGrounded>k__BackingField; //Field offset: 0x35
	private float _skinWidth; //Field offset: 0x38
	[CompilerGenerated]
	private float <slopeLimit>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private float <stepOffset>k__BackingField; //Field offset: 0x40
	private Vector3 _velocity; //Field offset: 0x44
	[CompilerGenerated]
	private float <SpeedLimit>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsSpeedLimitWasEnabledAtTheFrame>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private bool <IsMoveIgnored>k__BackingField; //Field offset: 0x55
	[CompilerGenerated]
	private Action OnHeightChanged; //Field offset: 0x58
	private LayerMask _maskToValidateMove; //Field offset: 0x60
	private RaycastJobContainer _raycastContainer; //Field offset: 0x68
	private bool _delayedValidationCheckRequested; //Field offset: 0x70
	private Vector3 _curPointCached; //Field offset: 0x74
	private Vector3 _motionCached; //Field offset: 0x80

	public override event Action OnHeightChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected override float _distanceRaycast
	{
		 get { } //Length: 4
	}

	public private override Rigidbody attachedRigidbody
	{
		 get { } //Length: 5
		private set { } //Length: 82
	}

	public private override Bounds bounds
	{
		 get { } //Length: 144
		private set { } //Length: 3
	}

	public override Vector3 center
	{
		 get { } //Length: 138
		 set { } //Length: 112
	}

	public private override CollisionFlags collisionFlags
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override float contactOffset
	{
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public override bool detectCollisions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override float height
	{
		 get { } //Length: 90
		 set { } //Length: 146
	}

	public override bool isEnabled
	{
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public private override bool isGrounded
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool IsMoveIgnored
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool IsSpeedLimitWasEnabledAtTheFrame
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override float radius
	{
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public override bool ShouldStickToGround
	{
		 get { } //Length: 3
	}

	public override float skinWidth
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public override float slopeLimit
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override float SpeedLimit
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override float stepOffset
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override bool SupportDepenetration
	{
		 get { } //Length: 3
	}

	public override bool UseAsyncMoveValidation
	{
		 get { } //Length: 3
	}

	public private override Vector3 velocity
	{
		 get { } //Length: 19
		private set { } //Length: 62
	}

	public ImpostorCharacterController(bool performMovementValidation, CapsuleCollider collider, Rigidbody rigidbody, IPlayer player, float skinWidth, LayerMask maskToValidateMove) { }

	[CompilerGenerated]
	public override void add_OnHeightChanged(Action value) { }

	private void CalculateVelocity(Vector3 currentPoint, Vector3 destinationPoint, float deltaTime) { }

	private bool CanBeOpenDoor(RaycastHit hitInfo) { }

	public override void CopyFields(CharacterControllerFootprint footprint) { }

	public override void CopyFields(ICharacterController characterController) { }

	public void Dispose() { }

	protected override float get__distanceRaycast() { }

	public override Rigidbody get_attachedRigidbody() { }

	public override Bounds get_bounds() { }

	public override Vector3 get_center() { }

	[CompilerGenerated]
	public override CollisionFlags get_collisionFlags() { }

	public override float get_contactOffset() { }

	[CompilerGenerated]
	public override bool get_detectCollisions() { }

	public override float get_height() { }

	public override bool get_isEnabled() { }

	[CompilerGenerated]
	public override bool get_isGrounded() { }

	[CompilerGenerated]
	public bool get_IsMoveIgnored() { }

	[CompilerGenerated]
	public override bool get_IsSpeedLimitWasEnabledAtTheFrame() { }

	public override float get_radius() { }

	public override bool get_ShouldStickToGround() { }

	public override float get_skinWidth() { }

	[CompilerGenerated]
	public override float get_slopeLimit() { }

	[CompilerGenerated]
	public override float get_SpeedLimit() { }

	[CompilerGenerated]
	public override float get_stepOffset() { }

	public override bool get_SupportDepenetration() { }

	public override bool get_UseAsyncMoveValidation() { }

	public override Vector3 get_velocity() { }

	public override Collider GetCollider() { }

	public override CharacterControllerFootprint GetFootprint() { }

	private bool IsRigidbodySupported() { }

	private bool IsValidMove(Vector3 currentPoint, Vector3 motion) { }

	public override CollisionFlags Move(Vector3 motion, float deltaTime) { }

	public void PerformMovementValidation(bool performMovementValidation) { }

	[CompilerGenerated]
	public override void remove_OnHeightChanged(Action value) { }

	private void RunMoveValidationCheck(Vector3 currentPoint, Vector3 motion) { }

	private void set_attachedRigidbody(Rigidbody value) { }

	private void set_bounds(Bounds value) { }

	public override void set_center(Vector3 value) { }

	[CompilerGenerated]
	private void set_collisionFlags(CollisionFlags value) { }

	public override void set_contactOffset(float value) { }

	[CompilerGenerated]
	public override void set_detectCollisions(bool value) { }

	public override void set_height(float value) { }

	public override void set_isEnabled(bool value) { }

	[CompilerGenerated]
	private void set_isGrounded(bool value) { }

	[CompilerGenerated]
	public void set_IsMoveIgnored(bool value) { }

	[CompilerGenerated]
	public override void set_IsSpeedLimitWasEnabledAtTheFrame(bool value) { }

	public override void set_radius(float value) { }

	public override void set_skinWidth(float value) { }

	[CompilerGenerated]
	public override void set_slopeLimit(float value) { }

	[CompilerGenerated]
	public override void set_SpeedLimit(float value) { }

	[CompilerGenerated]
	public override void set_stepOffset(float value) { }

	private void set_velocity(Vector3 value) { }

	public override void SetEnableVerticalDepenetration(bool enable) { }

	public override void SetSteerDirection(Vector3 steerDirection) { }

	public override bool SimpleMove(Vector3 motion) { }

	public CollisionFlags UpdateDelayedMoveLogic() { }

}

