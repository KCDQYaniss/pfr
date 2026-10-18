namespace UnityEngine;

[NativeHeader("PhysicsScriptingClasses.h")]
[NativeHeader("Modules/Vehicles/WheelCollider.h")]
public class WheelCollider : Collider
{

	public float brakeTorque
	{
		 set { } //Length: 94
	}

	public float forceAppPointDistance
	{
		 set { } //Length: 94
	}

	public float motorTorque
	{
		 set { } //Length: 94
	}

	public float radius
	{
		 get { } //Length: 78
	}

	public float sprungMass
	{
		 get { } //Length: 78
	}

	public float steerAngle
	{
		 set { } //Length: 94
	}

	public float suspensionDistance
	{
		 set { } //Length: 94
	}

	public JointSpring suspensionSpring
	{
		 get { } //Length: 104
		 set { } //Length: 93
	}

	public void ConfigureVehicleSubsteps(float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold) { }

	public float get_radius() { }

	public float get_sprungMass() { }

	public JointSpring get_suspensionSpring() { }

	private void get_suspensionSpring_Injected(out JointSpring ret) { }

	public void GetWorldPose(out Vector3 pos, out Quaternion quat) { }

	public void set_brakeTorque(float value) { }

	public void set_forceAppPointDistance(float value) { }

	public void set_motorTorque(float value) { }

	public void set_steerAngle(float value) { }

	public void set_suspensionDistance(float value) { }

	public void set_suspensionSpring(JointSpring value) { }

	private void set_suspensionSpring_Injected(ref JointSpring value) { }

}

