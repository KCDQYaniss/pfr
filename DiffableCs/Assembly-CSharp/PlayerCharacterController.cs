//Type is in global namespace

public class PlayerCharacterController : ICharacterController
{
	private readonly CharacterController _characterController; //Field offset: 0x10
	[CompilerGenerated]
	private float <SpeedLimit>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsSpeedLimitWasEnabledAtTheFrame>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <IsMoveIgnored>k__BackingField; //Field offset: 0x1D
	[CompilerGenerated]
	private Action OnHeightChanged; //Field offset: 0x20

	public override event Action OnHeightChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override Rigidbody attachedRigidbody
	{
		 get { } //Length: 90
	}

	public override Bounds bounds
	{
		 get { } //Length: 144
	}

	public override Vector3 center
	{
		 get { } //Length: 138
		 set { } //Length: 112
	}

	public override CollisionFlags collisionFlags
	{
		 get { } //Length: 90
	}

	public override float contactOffset
	{
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public override bool detectCollisions
	{
		 get { } //Length: 90
		 set { } //Length: 106
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

	public override bool isGrounded
	{
		 get { } //Length: 90
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
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public override float slopeLimit
	{
		 get { } //Length: 90
		 set { } //Length: 106
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
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public override bool SupportDepenetration
	{
		 get { } //Length: 3
	}

	public override Vector3 velocity
	{
		 get { } //Length: 138
	}

	public PlayerCharacterController(CharacterController cc) { }

	[CompilerGenerated]
	public override void add_OnHeightChanged(Action value) { }

	public override void CopyFields(CharacterControllerFootprint footprint) { }

	public override void CopyFields(ICharacterController characterController) { }

	public override Rigidbody get_attachedRigidbody() { }

	public override Bounds get_bounds() { }

	public override Vector3 get_center() { }

	public override CollisionFlags get_collisionFlags() { }

	public override float get_contactOffset() { }

	public override bool get_detectCollisions() { }

	public override float get_height() { }

	public override bool get_isEnabled() { }

	public override bool get_isGrounded() { }

	[CompilerGenerated]
	public bool get_IsMoveIgnored() { }

	[CompilerGenerated]
	public override bool get_IsSpeedLimitWasEnabledAtTheFrame() { }

	public override float get_radius() { }

	public override bool get_ShouldStickToGround() { }

	public override float get_skinWidth() { }

	public override float get_slopeLimit() { }

	[CompilerGenerated]
	public override float get_SpeedLimit() { }

	public override float get_stepOffset() { }

	public override bool get_SupportDepenetration() { }

	public override Vector3 get_velocity() { }

	public override Collider GetCollider() { }

	public override CharacterControllerFootprint GetFootprint() { }

	public override CollisionFlags Move(Vector3 motion, float deltaTime) { }

	[CompilerGenerated]
	public override void remove_OnHeightChanged(Action value) { }

	public override void set_center(Vector3 value) { }

	public override void set_contactOffset(float value) { }

	public override void set_detectCollisions(bool value) { }

	public override void set_height(float value) { }

	public override void set_isEnabled(bool value) { }

	[CompilerGenerated]
	public void set_IsMoveIgnored(bool value) { }

	[CompilerGenerated]
	public override void set_IsSpeedLimitWasEnabledAtTheFrame(bool value) { }

	public override void set_radius(float value) { }

	public override void set_skinWidth(float value) { }

	public override void set_slopeLimit(float value) { }

	[CompilerGenerated]
	public override void set_SpeedLimit(float value) { }

	public override void set_stepOffset(float value) { }

	public override void SetEnableVerticalDepenetration(bool enable) { }

	public override void SetSteerDirection(Vector3 steerDirection) { }

	public override bool SimpleMove(Vector3 motion) { }

}

