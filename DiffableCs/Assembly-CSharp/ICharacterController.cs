//Type is in global namespace

public interface ICharacterController
{

	public event Action OnHeightChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public Rigidbody attachedRigidbody
	{
		 get { } //Length: 0
	}

	public Bounds bounds
	{
		 get { } //Length: 0
	}

	public Vector3 center
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public CollisionFlags collisionFlags
	{
		 get { } //Length: 0
	}

	public float contactOffset
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool detectCollisions
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float height
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool isEnabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool isGrounded
	{
		 get { } //Length: 0
	}

	public bool IsSpeedLimitWasEnabledAtTheFrame
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float radius
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool ShouldStickToGround
	{
		 get { } //Length: 0
	}

	public float skinWidth
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float slopeLimit
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float SpeedLimit
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float stepOffset
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool SupportDepenetration
	{
		 get { } //Length: 0
	}

	public Vector3 velocity
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnHeightChanged(Action value) { }

	public void CopyFields(CharacterControllerFootprint footprint) { }

	public void CopyFields(ICharacterController characterController) { }

	public Rigidbody get_attachedRigidbody() { }

	public Bounds get_bounds() { }

	public Vector3 get_center() { }

	public CollisionFlags get_collisionFlags() { }

	public float get_contactOffset() { }

	public bool get_detectCollisions() { }

	public float get_height() { }

	public bool get_isEnabled() { }

	public bool get_isGrounded() { }

	public bool get_IsSpeedLimitWasEnabledAtTheFrame() { }

	public float get_radius() { }

	public bool get_ShouldStickToGround() { }

	public float get_skinWidth() { }

	public float get_slopeLimit() { }

	public float get_SpeedLimit() { }

	public float get_stepOffset() { }

	public bool get_SupportDepenetration() { }

	public Vector3 get_velocity() { }

	public Collider GetCollider() { }

	public CharacterControllerFootprint GetFootprint() { }

	public CollisionFlags Move(Vector3 motion, float deltaTime) { }

	[CompilerGenerated]
	public void remove_OnHeightChanged(Action value) { }

	public void set_center(Vector3 value) { }

	public void set_contactOffset(float value) { }

	public void set_detectCollisions(bool value) { }

	public void set_height(float value) { }

	public void set_isEnabled(bool value) { }

	public void set_IsSpeedLimitWasEnabledAtTheFrame(bool value) { }

	public void set_radius(float value) { }

	public void set_skinWidth(float value) { }

	public void set_slopeLimit(float value) { }

	public void set_SpeedLimit(float value) { }

	public void set_stepOffset(float value) { }

	public void SetEnableVerticalDepenetration(bool enable) { }

	public void SetSteerDirection(Vector3 steerDirection) { }

	public bool SimpleMove(Vector3 motion) { }

}

