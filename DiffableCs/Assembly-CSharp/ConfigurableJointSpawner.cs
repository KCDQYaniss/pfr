//Type is in global namespace

[DisallowMultipleComponent]
public class ConfigurableJointSpawner : JointSpawner
{
	internal struct JointDrive_
	{
		public float positionSpring; //Field offset: 0x0
		public float positionDamper; //Field offset: 0x4
		public float maximumForce; //Field offset: 0x8

		public static JointDrive_ op_Implicit(JointDrive jointDrive) { }

		public static JointDrive op_Implicit(JointDrive_ jointDrive) { }

	}

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

	public float projectionAngle; //Field offset: 0x60
	public float projectionDistance; //Field offset: 0x64
	[EnumBitMask(typeof(JointProjectionMode))]
	public JointProjectionMode projectionMode; //Field offset: 0x68
	public JointDrive_ slerpDrive; //Field offset: 0x6C
	public JointDrive_ angularYZDrive; //Field offset: 0x78
	public JointDrive_ angularXDrive; //Field offset: 0x84
	[EnumBitMask(typeof(RotationDriveMode))]
	public RotationDriveMode rotationDriveMode; //Field offset: 0x90
	public Vector3 targetAngularVelocity; //Field offset: 0x94
	public Quaternion targetRotation; //Field offset: 0xA0
	public JointDrive_ zDrive; //Field offset: 0xB0
	public JointDrive_ yDrive; //Field offset: 0xBC
	public JointDrive_ xDrive; //Field offset: 0xC8
	public Vector3 targetVelocity; //Field offset: 0xD4
	public Vector3 targetPosition; //Field offset: 0xE0
	public SoftJointLimit_ angularZLimit; //Field offset: 0xEC
	public SoftJointLimit_ angularYLimit; //Field offset: 0xF8
	public SoftJointLimit_ highAngularXLimit; //Field offset: 0x104
	public SoftJointLimit_ lowAngularXLimit; //Field offset: 0x110
	public SoftJointLimit_ linearLimit; //Field offset: 0x11C
	public SoftJointLimitSpring_ angularYZLimitSpring; //Field offset: 0x128
	public SoftJointLimitSpring_ angularXLimitSpring; //Field offset: 0x130
	public SoftJointLimitSpring_ linearLimitSpring; //Field offset: 0x138
	[EnumBitMask(typeof(ConfigurableJointMotion))]
	public ConfigurableJointMotion angularZMotion; //Field offset: 0x140
	[EnumBitMask(typeof(ConfigurableJointMotion))]
	public ConfigurableJointMotion angularYMotion; //Field offset: 0x144
	[EnumBitMask(typeof(ConfigurableJointMotion))]
	public ConfigurableJointMotion angularXMotion; //Field offset: 0x148
	[EnumBitMask(typeof(ConfigurableJointMotion))]
	public ConfigurableJointMotion zMotion; //Field offset: 0x14C
	[EnumBitMask(typeof(ConfigurableJointMotion))]
	public ConfigurableJointMotion yMotion; //Field offset: 0x150
	[EnumBitMask(typeof(ConfigurableJointMotion))]
	public ConfigurableJointMotion xMotion; //Field offset: 0x154
	public Vector3 secondaryAxis; //Field offset: 0x158
	public bool configuredInWorldSpace; //Field offset: 0x164
	public bool swapBodies; //Field offset: 0x165

	public ConfigurableJointSpawner() { }

	public virtual Joint Create() { }

	protected virtual Joint CreateComponent() { }

}

