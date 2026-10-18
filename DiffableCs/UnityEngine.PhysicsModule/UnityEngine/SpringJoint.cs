namespace UnityEngine;

[NativeClass("Unity::SpringJoint")]
[NativeHeader("Modules/Physics/SpringJoint.h")]
public class SpringJoint : Joint
{

	public float damper
	{
		 set { } //Length: 94
	}

	public float spring
	{
		 set { } //Length: 94
	}

	public void set_damper(float value) { }

	public void set_spring(float value) { }

}

