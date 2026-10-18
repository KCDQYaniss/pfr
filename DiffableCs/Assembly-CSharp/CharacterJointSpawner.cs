//Type is in global namespace

[DisallowMultipleComponent]
public class CharacterJointSpawner : JointSpawner
{
	internal struct SoftJointLimit_
	{
		public float limit; //Field offset: 0x0
		public float bounciness; //Field offset: 0x4
		public float contactDistance; //Field offset: 0x8

		public static SoftJointLimit_ op_Implicit(SoftJointLimit softJointLimit) { }

		public static SoftJointLimit op_Implicit(SoftJointLimit_ softJointLimit) { }

	}

	internal struct SoftJointLimitSpring_
	{
		public float spring; //Field offset: 0x0
		public float damper; //Field offset: 0x4

		public static SoftJointLimitSpring_ op_Implicit(SoftJointLimitSpring softJointLimitSpring) { }

		public static SoftJointLimitSpring op_Implicit(SoftJointLimitSpring_ softJointLimitSpring) { }

	}

	public Vector3 swingAxis; //Field offset: 0x60
	public SoftJointLimitSpring_ twistLimitSpring; //Field offset: 0x6C
	public SoftJointLimit_ lowTwistLimit; //Field offset: 0x74
	public SoftJointLimit_ highTwistLimit; //Field offset: 0x80
	public SoftJointLimitSpring_ swingLimitSpring; //Field offset: 0x8C
	public SoftJointLimit_ swing1Limit; //Field offset: 0x94
	public SoftJointLimit_ swing2Limit; //Field offset: 0xA0
	public bool enableProjection; //Field offset: 0xAC
	public float projectionDistance; //Field offset: 0xB0
	public float projectionAngle; //Field offset: 0xB4

	public CharacterJointSpawner() { }

	[ContextMenu("Create")]
	public virtual Joint Create() { }

	protected virtual Joint CreateComponent() { }

}

