namespace UnityEngine;

[NativeClass("Unity::CharacterJoint")]
[NativeHeader("Modules/Physics/CharacterJoint.h")]
public class CharacterJoint : Joint
{
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("TargetRotation not in use for Unity 5 and assumed disabled.", True)]
	public Quaternion targetRotation; //Field offset: 0x18
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("TargetAngularVelocity not in use for Unity 5 and assumed disabled.", True)]
	public Vector3 targetAngularVelocity; //Field offset: 0x28
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("RotationDrive not in use for Unity 5 and assumed disabled.", True)]
	public JointDrive rotationDrive; //Field offset: 0x34

	public bool enableProjection
	{
		 set { } //Length: 93
	}

	public SoftJointLimit highTwistLimit
	{
		 set { } //Length: 93
	}

	public SoftJointLimit lowTwistLimit
	{
		 set { } //Length: 93
	}

	public float projectionAngle
	{
		 set { } //Length: 94
	}

	public float projectionDistance
	{
		 set { } //Length: 94
	}

	public SoftJointLimit swing1Limit
	{
		 set { } //Length: 93
	}

	public SoftJointLimit swing2Limit
	{
		 set { } //Length: 93
	}

	public Vector3 swingAxis
	{
		 set { } //Length: 93
	}

	public SoftJointLimitSpring swingLimitSpring
	{
		 set { } //Length: 88
	}

	public SoftJointLimitSpring twistLimitSpring
	{
		 set { } //Length: 88
	}

	public void set_enableProjection(bool value) { }

	public void set_highTwistLimit(SoftJointLimit value) { }

	private void set_highTwistLimit_Injected(ref SoftJointLimit value) { }

	public void set_lowTwistLimit(SoftJointLimit value) { }

	private void set_lowTwistLimit_Injected(ref SoftJointLimit value) { }

	public void set_projectionAngle(float value) { }

	public void set_projectionDistance(float value) { }

	public void set_swing1Limit(SoftJointLimit value) { }

	private void set_swing1Limit_Injected(ref SoftJointLimit value) { }

	public void set_swing2Limit(SoftJointLimit value) { }

	private void set_swing2Limit_Injected(ref SoftJointLimit value) { }

	public void set_swingAxis(Vector3 value) { }

	private void set_swingAxis_Injected(ref Vector3 value) { }

	public void set_swingLimitSpring(SoftJointLimitSpring value) { }

	private void set_swingLimitSpring_Injected(ref SoftJointLimitSpring value) { }

	public void set_twistLimitSpring(SoftJointLimitSpring value) { }

	private void set_twistLimitSpring_Injected(ref SoftJointLimitSpring value) { }

}

