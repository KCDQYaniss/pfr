namespace EFT.Animations.Recoil;

public interface IRecoilShotEffect
{

	public RecoilProcessBase CameraRotationRecoilEffect
	{
		 get { } //Length: 0
	}

	public Vector2 DegreeRecoil
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public RecoilProcessBase HandPositionRecoilEffect
	{
		 get { } //Length: 0
	}

	public RotationRecoilProcessBase HandRotationRecoilEffect
	{
		 get { } //Length: 0
	}

	public RecoilShotVal[] RecoilProcessValues
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector2 RecoilRadian
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector2 RecoilRotationStrength
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector3 SeparateIntensityFactors
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public WeaponRecoil WeaponRecoilEffect
	{
		 get { } //Length: 0
	}

	public void AddRecoilForce(float incomingForce) { }

	public void CalculateBaseRecoilParameters(float recoilSuspensionY, float weaponRecoilAngle, float weaponRecoilDispersion, List shotsGroupSettingsList) { }

	public void FixedUpdate(float deltaTime) { }

	public RecoilProcessBase get_CameraRotationRecoilEffect() { }

	public Vector2 get_DegreeRecoil() { }

	public RecoilProcessBase get_HandPositionRecoilEffect() { }

	public RotationRecoilProcessBase get_HandRotationRecoilEffect() { }

	public RecoilShotVal[] get_RecoilProcessValues() { }

	public Vector2 get_RecoilRadian() { }

	public Vector2 get_RecoilRotationStrength() { }

	public Vector3 get_SeparateIntensityFactors() { }

	public WeaponRecoil get_WeaponRecoilEffect() { }

	public Vector3 GetCameraRotationRecoil() { }

	public Vector3 GetHandPositionRecoil() { }

	public Vector3 GetHandRotationRecoil() { }

	public void RecalculateRecoilParamsOnChangeWeapon(WeaponTemplate template, AimingConfiguration AimingConfig, FirearmController firearmController, float recoilSuppressionX, float recoilSuppressionY, float recoilSuppressionFactor, float modsFactorRecoil) { }

	public void set_DegreeRecoil(Vector2 value) { }

	public void set_RecoilProcessValues(RecoilShotVal[] value) { }

	public void set_RecoilRadian(Vector2 value) { }

	public void set_RecoilRotationStrength(Vector2 value) { }

	public void set_SeparateIntensityFactors(Vector3 value) { }

}

