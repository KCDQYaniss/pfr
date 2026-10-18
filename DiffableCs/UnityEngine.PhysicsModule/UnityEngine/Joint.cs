namespace UnityEngine;

[NativeClass("Unity::Joint")]
[NativeHeader("Modules/Physics/Joint.h")]
[RequireComponent(typeof(Rigidbody))]
public class Joint : Component
{

	public Vector3 anchor
	{
		 set { } //Length: 93
	}

	public bool autoConfigureConnectedAnchor
	{
		 set { } //Length: 93
	}

	public Vector3 axis
	{
		 set { } //Length: 93
	}

	public Vector3 connectedAnchor
	{
		 set { } //Length: 93
	}

	public Rigidbody connectedBody
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public float connectedMassScale
	{
		 set { } //Length: 94
	}

	public bool enableCollision
	{
		 set { } //Length: 93
	}

	public bool enablePreprocessing
	{
		 set { } //Length: 93
	}

	public float massScale
	{
		 set { } //Length: 94
	}

	public Rigidbody get_connectedBody() { }

	public void set_anchor(Vector3 value) { }

	private void set_anchor_Injected(ref Vector3 value) { }

	public void set_autoConfigureConnectedAnchor(bool value) { }

	public void set_axis(Vector3 value) { }

	private void set_axis_Injected(ref Vector3 value) { }

	public void set_connectedAnchor(Vector3 value) { }

	private void set_connectedAnchor_Injected(ref Vector3 value) { }

	public void set_connectedBody(Rigidbody value) { }

	public void set_connectedMassScale(float value) { }

	public void set_enableCollision(bool value) { }

	public void set_enablePreprocessing(bool value) { }

	public void set_massScale(float value) { }

}

