namespace EFT.WeaponMounting;

public class MountingMovementSettings : IMountingMovementSettings
{
	public const float TILT_POSITION_OFFSET = 0.25; //Field offset: 0x0
	[CompilerGenerated]
	private float <MaxVerticalMountAngle>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Vector2 <PitchLimitVertical>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Vector2 <PitchLimitHorizontal>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private Vector2 <PitchLimitHorizontalBipod>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private float <MaxApproachTime>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private float <MinApproachTime>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private float <ExitTime>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private float <RotationSpeedClamp>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private float <SensitivityMultiplier>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private float <ApproachTimeDeltaAngleModifier>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private float <MaxPitchLimitExcess>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private float <MaxYawLimitExcess>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private float <MountingCameraSpeed>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private float <MountingSwayFactorModifier>k__BackingField; //Field offset: 0x50

	[JsonProperty("ApproachTimeDeltaAngleModifier")]
	public override float ApproachTimeDeltaAngleModifier
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	[JsonProperty("ExitTime")]
	public override float ExitTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	[JsonProperty("MaxApproachTime")]
	public override float MaxApproachTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	[JsonProperty("MaxPitchLimitExcess")]
	public override float MaxPitchLimitExcess
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	[JsonProperty("MaxVerticalMountAngle")]
	public override float MaxVerticalMountAngle
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	[JsonProperty("MaxYawLimitExcess")]
	public override float MaxYawLimitExcess
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	[JsonProperty("MinApproachTime")]
	public override float MinApproachTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	[JsonProperty("MountingCameraSpeed")]
	public override float MountingCameraSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	[JsonProperty("MountingSwayFactorModifier")]
	public override float MountingSwayFactorModifier
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	[JsonProperty("PitchLimitHorizontal")]
	public override Vector2 PitchLimitHorizontal
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonProperty("PitchLimitHorizontalBipod")]
	public override Vector2 PitchLimitHorizontalBipod
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonProperty("PitchLimitVertical")]
	public override Vector2 PitchLimitVertical
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonProperty("RotationSpeedClamp")]
	public override float RotationSpeedClamp
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	[JsonProperty("SensitivityMultiplier")]
	public override float SensitivityMultiplier
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override float TiltPositionOffset
	{
		 get { } //Length: 9
	}

	public MountingMovementSettings() { }

	[CompilerGenerated]
	public override float get_ApproachTimeDeltaAngleModifier() { }

	[CompilerGenerated]
	public override float get_ExitTime() { }

	[CompilerGenerated]
	public override float get_MaxApproachTime() { }

	[CompilerGenerated]
	public override float get_MaxPitchLimitExcess() { }

	[CompilerGenerated]
	public override float get_MaxVerticalMountAngle() { }

	[CompilerGenerated]
	public override float get_MaxYawLimitExcess() { }

	[CompilerGenerated]
	public override float get_MinApproachTime() { }

	[CompilerGenerated]
	public override float get_MountingCameraSpeed() { }

	[CompilerGenerated]
	public override float get_MountingSwayFactorModifier() { }

	[CompilerGenerated]
	public override Vector2 get_PitchLimitHorizontal() { }

	[CompilerGenerated]
	public override Vector2 get_PitchLimitHorizontalBipod() { }

	[CompilerGenerated]
	public override Vector2 get_PitchLimitVertical() { }

	[CompilerGenerated]
	public override float get_RotationSpeedClamp() { }

	[CompilerGenerated]
	public override float get_SensitivityMultiplier() { }

	public override float get_TiltPositionOffset() { }

	[CompilerGenerated]
	public override void set_ApproachTimeDeltaAngleModifier(float value) { }

	[CompilerGenerated]
	public override void set_ExitTime(float value) { }

	[CompilerGenerated]
	public override void set_MaxApproachTime(float value) { }

	[CompilerGenerated]
	public override void set_MaxPitchLimitExcess(float value) { }

	[CompilerGenerated]
	public override void set_MaxVerticalMountAngle(float value) { }

	[CompilerGenerated]
	public override void set_MaxYawLimitExcess(float value) { }

	[CompilerGenerated]
	public override void set_MinApproachTime(float value) { }

	[CompilerGenerated]
	public override void set_MountingCameraSpeed(float value) { }

	[CompilerGenerated]
	public override void set_MountingSwayFactorModifier(float value) { }

	[CompilerGenerated]
	public override void set_PitchLimitHorizontal(Vector2 value) { }

	[CompilerGenerated]
	public override void set_PitchLimitHorizontalBipod(Vector2 value) { }

	[CompilerGenerated]
	public override void set_PitchLimitVertical(Vector2 value) { }

	[CompilerGenerated]
	public override void set_RotationSpeedClamp(float value) { }

	[CompilerGenerated]
	public override void set_SensitivityMultiplier(float value) { }

}

