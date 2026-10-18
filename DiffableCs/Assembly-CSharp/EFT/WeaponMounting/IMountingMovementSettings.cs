namespace EFT.WeaponMounting;

public interface IMountingMovementSettings
{

	public float ApproachTimeDeltaAngleModifier
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float ExitTime
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float MaxApproachTime
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float MaxPitchLimitExcess
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float MaxVerticalMountAngle
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float MaxYawLimitExcess
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float MinApproachTime
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float MountingCameraSpeed
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float MountingSwayFactorModifier
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector2 PitchLimitHorizontal
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector2 PitchLimitHorizontalBipod
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector2 PitchLimitVertical
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float RotationSpeedClamp
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float SensitivityMultiplier
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float TiltPositionOffset
	{
		 get { } //Length: 0
	}

	public float get_ApproachTimeDeltaAngleModifier() { }

	public float get_ExitTime() { }

	public float get_MaxApproachTime() { }

	public float get_MaxPitchLimitExcess() { }

	public float get_MaxVerticalMountAngle() { }

	public float get_MaxYawLimitExcess() { }

	public float get_MinApproachTime() { }

	public float get_MountingCameraSpeed() { }

	public float get_MountingSwayFactorModifier() { }

	public Vector2 get_PitchLimitHorizontal() { }

	public Vector2 get_PitchLimitHorizontalBipod() { }

	public Vector2 get_PitchLimitVertical() { }

	public float get_RotationSpeedClamp() { }

	public float get_SensitivityMultiplier() { }

	public float get_TiltPositionOffset() { }

	public void set_ApproachTimeDeltaAngleModifier(float value) { }

	public void set_ExitTime(float value) { }

	public void set_MaxApproachTime(float value) { }

	public void set_MaxPitchLimitExcess(float value) { }

	public void set_MaxVerticalMountAngle(float value) { }

	public void set_MaxYawLimitExcess(float value) { }

	public void set_MinApproachTime(float value) { }

	public void set_MountingCameraSpeed(float value) { }

	public void set_MountingSwayFactorModifier(float value) { }

	public void set_PitchLimitHorizontal(Vector2 value) { }

	public void set_PitchLimitHorizontalBipod(Vector2 value) { }

	public void set_PitchLimitVertical(Vector2 value) { }

	public void set_RotationSpeedClamp(float value) { }

	public void set_SensitivityMultiplier(float value) { }

}

