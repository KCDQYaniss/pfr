namespace UnityEngine;

[NativeHeader("Modules/Physics/CapsuleCollider.h")]
[RequiredByNativeCode]
public class CapsuleCollider : Collider
{

	public Vector3 center
	{
		 get { } //Length: 104
		 set { } //Length: 93
	}

	public int direction
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public float height
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public float radius
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public Vector3 get_center() { }

	private void get_center_Injected(out Vector3 ret) { }

	public int get_direction() { }

	public float get_height() { }

	public float get_radius() { }

	public void set_center(Vector3 value) { }

	private void set_center_Injected(ref Vector3 value) { }

	public void set_direction(int value) { }

	public void set_height(float value) { }

	public void set_radius(float value) { }

}

