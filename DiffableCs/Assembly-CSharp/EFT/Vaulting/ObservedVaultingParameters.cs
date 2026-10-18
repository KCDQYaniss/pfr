namespace EFT.Vaulting;

public class ObservedVaultingParameters : IVaultingParameters
{
	[CompilerGenerated]
	private float <VaultingSpeed>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private float <VaultingLength>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private float <VaultingHeight>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <BehindObstacleRatio>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private float <AbsoluteForwardVelocity>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Vector3 <MaxWeightPointPosition>k__BackingField; //Field offset: 0x24

	public override float AbsoluteForwardVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override float BehindObstacleRatio
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override Vector3 MaxWeightPointPosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public override float VaultingHeight
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override float VaultingLength
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public float VaultingSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public ObservedVaultingParameters() { }

	[CompilerGenerated]
	public override float get_AbsoluteForwardVelocity() { }

	[CompilerGenerated]
	public override float get_BehindObstacleRatio() { }

	[CompilerGenerated]
	public override Vector3 get_MaxWeightPointPosition() { }

	[CompilerGenerated]
	public override float get_VaultingHeight() { }

	[CompilerGenerated]
	public override float get_VaultingLength() { }

	[CompilerGenerated]
	public float get_VaultingSpeed() { }

	public override EVaultingStrategy GetAutoVaultingStrategy() { }

	public override EVaultingStrategy GetVaultingStrategy() { }

	[CompilerGenerated]
	public void set_AbsoluteForwardVelocity(float value) { }

	[CompilerGenerated]
	public void set_BehindObstacleRatio(float value) { }

	[CompilerGenerated]
	public void set_MaxWeightPointPosition(Vector3 value) { }

	[CompilerGenerated]
	public void set_VaultingHeight(float value) { }

	[CompilerGenerated]
	public void set_VaultingLength(float value) { }

	[CompilerGenerated]
	public void set_VaultingSpeed(float value) { }

}

