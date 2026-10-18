namespace UnityEngine;

[NativeHeader("Modules/Physics/CharacterController.h")]
public class CharacterController : Collider
{

	public Vector3 center
	{
		 get { } //Length: 104
		 set { } //Length: 93
	}

	public CollisionFlags collisionFlags
	{
		 get { } //Length: 78
	}

	public bool detectCollisions
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public float height
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public bool isGrounded
	{
		[NativeName("IsGrounded")]
		 get { } //Length: 78
	}

	public float minMoveDistance
	{
		 set { } //Length: 94
	}

	public float radius
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public float skinWidth
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public float slopeLimit
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public float stepOffset
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public Vector3 velocity
	{
		 get { } //Length: 104
	}

	public Vector3 get_center() { }

	private void get_center_Injected(out Vector3 ret) { }

	public CollisionFlags get_collisionFlags() { }

	public bool get_detectCollisions() { }

	public float get_height() { }

	[NativeName("IsGrounded")]
	public bool get_isGrounded() { }

	public float get_radius() { }

	public float get_skinWidth() { }

	public float get_slopeLimit() { }

	public float get_stepOffset() { }

	public Vector3 get_velocity() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	public CollisionFlags Move(Vector3 motion) { }

	private CollisionFlags Move_Injected(ref Vector3 motion) { }

	public void set_center(Vector3 value) { }

	private void set_center_Injected(ref Vector3 value) { }

	public void set_detectCollisions(bool value) { }

	public void set_height(float value) { }

	public void set_minMoveDistance(float value) { }

	public void set_radius(float value) { }

	public void set_skinWidth(float value) { }

	public void set_slopeLimit(float value) { }

	public void set_stepOffset(float value) { }

	public bool SimpleMove(Vector3 speed) { }

	private bool SimpleMove_Injected(ref Vector3 speed) { }

}

