namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
[RequireComponent(typeof(Transform))]
public sealed class Rigidbody2D : Component
{

	public RigidbodyType2D bodyType
	{
		 get { } //Length: 78
		[NativeMethod("SetBodyType_Binding")]
		 set { } //Length: 91
	}

	public float mass
	{
		 get { } //Length: 78
	}

	public Vector2 position
	{
		 get { } //Length: 95
		 set { } //Length: 88
	}

	public float rotation
	{
		 get { } //Length: 78
	}

	public Vector2 velocity
	{
		 get { } //Length: 95
	}

	public Rigidbody2D() { }

	public RigidbodyType2D get_bodyType() { }

	public float get_mass() { }

	public Vector2 get_position() { }

	private void get_position_Injected(out Vector2 ret) { }

	public float get_rotation() { }

	public Vector2 get_velocity() { }

	private void get_velocity_Injected(out Vector2 ret) { }

	public void MovePosition(Vector2 position) { }

	private void MovePosition_Injected(ref Vector2 position) { }

	public void MoveRotation(float angle) { }

	[NativeMethod("MoveRotation")]
	private void MoveRotation_Angle(float angle) { }

	[NativeMethod("SetBodyType_Binding")]
	public void set_bodyType(RigidbodyType2D value) { }

	public void set_position(Vector2 value) { }

	private void set_position_Injected(ref Vector2 value) { }

}

