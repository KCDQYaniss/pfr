namespace EFT.Animations;

public class OldRecoilShotEffect : IRecoilShotEffect
{
	[Tooltip("Влияние внешних пассивных еффектов смещения, напр Эффект Дыхания")]
	public bool UseOffset; //Field offset: 0x10
	[Tooltip("Задействовать отдачу")]
	public bool RecoilEffectOn; //Field offset: 0x11
	[Tooltip("Настройки влияния на оси вращения смещения во время выстрела, здесь можно усилить ослабить кажду ось.")]
	public RecoilShotVal[] ShotRecoilProcessValues; //Field offset: 0x18
	[Tooltip("Базовый расброс силы вращения, все расчеты ведутся от нее")]
	public Vector2 BasicRecoilRotationStrength; //Field offset: 0x20
	[Tooltip("Базовый расброс силы смещения позиции, все расчеты ведутся от нее")]
	public Vector2 BasicRecoilPositionStrength; //Field offset: 0x28
	public OldRotationRecoilProcess HandRotationRecoil; //Field offset: 0x30
	public RecoilProcessBase HandPositionRecoil; //Field offset: 0x38
	public RecoilProcessBase CameraRotationRecoil; //Field offset: 0x40
	public WeaponRecoil WeaponRecoil; //Field offset: 0x48
	[HideInInspector]
	public Vector2 BasicPlayerRecoilRotationStrength; //Field offset: 0x50
	[HideInInspector]
	public Vector2 BasicPlayerRecoilPositionStrength; //Field offset: 0x58
	[HideInInspector]
	public Vector2 BasicPlayerRecoilDegreeRange; //Field offset: 0x60
	[HideInInspector]
	public Vector3 RecoilDirection; //Field offset: 0x68
	[HideInInspector]
	public Vector2 BasicRecoilRadian; //Field offset: 0x74
	[HideInInspector]
	public Vector3 IntensitySeparateFactors; //Field offset: 0x7C
	[HideInInspector]
	public Vector2 OverheatBarrelMove; //Field offset: 0x88
	[HideInInspector]
	public float BarrelMoveMult; //Field offset: 0x90
	private FirearmController _firearmController; //Field offset: 0x98

	public override RecoilProcessBase CameraRotationRecoilEffect
	{
		 get { } //Length: 5
	}

	public override Vector2 DegreeRecoil
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public override RecoilProcessBase HandPositionRecoilEffect
	{
		 get { } //Length: 5
	}

	public override RotationRecoilProcessBase HandRotationRecoilEffect
	{
		 get { } //Length: 76
	}

	public override RecoilShotVal[] RecoilProcessValues
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public override Vector2 RecoilRadian
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public override Vector2 RecoilRotationStrength
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public override Vector3 SeparateIntensityFactors
	{
		 get { } //Length: 22
		 set { } //Length: 19
	}

	public override WeaponRecoil WeaponRecoilEffect
	{
		 get { } //Length: 5
	}

	public OldRecoilShotEffect() { }

	public override void AddRecoilForce(float incomingForce) { }

	public override void CalculateBaseRecoilParameters(float recoilSuspensionY, float weaponRecoilAngle, float weaponRecoilDispersion, List shotsGroupSettingsList) { }

	public float ConvertFromTaxanomy(float f) { }

	public override void FixedUpdate(float deltaTime) { }

	public override RecoilProcessBase get_CameraRotationRecoilEffect() { }

	public override Vector2 get_DegreeRecoil() { }

	public override RecoilProcessBase get_HandPositionRecoilEffect() { }

	public override RotationRecoilProcessBase get_HandRotationRecoilEffect() { }

	public override RecoilShotVal[] get_RecoilProcessValues() { }

	public override Vector2 get_RecoilRadian() { }

	public override Vector2 get_RecoilRotationStrength() { }

	public override Vector3 get_SeparateIntensityFactors() { }

	public override WeaponRecoil get_WeaponRecoilEffect() { }

	public override Vector3 GetCameraRotationRecoil() { }

	public override Vector3 GetHandPositionRecoil() { }

	public override Vector3 GetHandRotationRecoil() { }

	public Vector3 GetWeaponPositionRecoil() { }

	public Vector3 GetWeaponRotationRecoil() { }

	public override void RecalculateRecoilParamsOnChangeWeapon(WeaponTemplate template, AimingConfiguration AimingConfig, FirearmController firearmController, float recoilSuppressionX, float recoilSuppressionY, float recoilSuppressionFactor, float modsFactorRecoil) { }

	public override void set_DegreeRecoil(Vector2 value) { }

	public override void set_RecoilProcessValues(RecoilShotVal[] value) { }

	public override void set_RecoilRadian(Vector2 value) { }

	public override void set_RecoilRotationStrength(Vector2 value) { }

	public override void set_SeparateIntensityFactors(Vector3 value) { }

}

