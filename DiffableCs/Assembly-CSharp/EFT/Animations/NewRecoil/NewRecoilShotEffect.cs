namespace EFT.Animations.NewRecoil;

public class NewRecoilShotEffect : IRecoilShotEffect
{
	[Tooltip("Влияние внешних пассивных еффектов смещения, напр Эффект Дыхания")]
	public bool UseOffset; //Field offset: 0x10
	[Tooltip("Задействовать отдачу")]
	public bool RecoilEffectOn; //Field offset: 0x11
	public bool ProgressPowerOn; //Field offset: 0x12
	[Tooltip("С какого выстрела по счету начинаеться прогрессирование силы выстрела до полной")]
	public int ProgressPowerShot; //Field offset: 0x14
	[Tooltip("Мультипликатор  входящих параметров разброса вращения")]
	public float IncomingRotationStrengthMultiplier; //Field offset: 0x18
	[Tooltip("Настройки влияния на оси вращения смещения во время выстрела, здесь можно усилить ослабить кажду ось.")]
	public RecoilShotVal[] ShotRecoilProcessValues; //Field offset: 0x20
	[Tooltip("Настройки групп выстрелов, если один и тот же выстрел попадает в разные группы, то значения из этих групп суммируются при расчетах. Приходит из таксы")]
	public List ShotsGroupsSettings; //Field offset: 0x28
	[Tooltip("Базовый расброс силы вращения, все расчеты ведутся от нее")]
	public Vector2 BasicRecoilRotationStrengthRange; //Field offset: 0x30
	[Tooltip("Базовый расброс силы смещения позиции, все расчеты ведутся от нее")]
	public Vector2 BasicRecoilPositionStrengthRange; //Field offset: 0x38
	[Tooltip("Номер выстрела стабилизации во время автоматического огня")]
	public int RecoilStableShotIndex; //Field offset: 0x40
	public NewRotationRecoilProcess HandRotationRecoil; //Field offset: 0x48
	public RecoilProcessBase HandPositionRecoil; //Field offset: 0x50
	public RecoilProcessBase CameraRotationRecoil; //Field offset: 0x58
	public WeaponRecoil WeaponRecoil; //Field offset: 0x60
	[HideInInspector]
	public Vector2 BasicPlayerRecoilRotationStrength; //Field offset: 0x68
	[HideInInspector]
	public Vector2 BasicPlayerRecoilPositionStrength; //Field offset: 0x70
	[HideInInspector]
	public Vector2 BasicPlayerRecoilDegreeRange; //Field offset: 0x78
	[HideInInspector]
	public Vector3 RecoilDirection; //Field offset: 0x80
	[HideInInspector]
	public Vector2 BasicRecoilRadian; //Field offset: 0x8C
	[HideInInspector]
	public Vector3 IntensitySeparateFactors; //Field offset: 0x94
	[HideInInspector]
	public Vector2 OverheatBarrelMove; //Field offset: 0xA0
	[HideInInspector]
	public float BarrelMoveMult; //Field offset: 0xA8
	private FirearmController _firearmController; //Field offset: 0xB0
	private int _autoFireShotIndex; //Field offset: 0xB8
	private bool _autoFireOn; //Field offset: 0xBC

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
		 get { } //Length: 5
	}

	public override RecoilShotVal[] RecoilProcessValues
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public override Vector2 RecoilRadian
	{
		 get { } //Length: 25
		 set { } //Length: 8
	}

	public override Vector2 RecoilRotationStrength
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public override Vector3 SeparateIntensityFactors
	{
		 get { } //Length: 25
		 set { } //Length: 22
	}

	public override WeaponRecoil WeaponRecoilEffect
	{
		 get { } //Length: 5
	}

	public NewRecoilShotEffect() { }

	public override void AddRecoilForce(float incomingForce) { }

	public override void CalculateBaseRecoilParameters(float recoilSuspensionY, float weaponRecoilAngle, float weaponRecoilDispersion, List shotsGroupSettingsList) { }

	private void CalculateRecoilDirection(Vector2 finalRecoilRadian, float rotationRecoilPower, float positionRecoilPower) { }

	private void CalculateShotRecoilPower(float incomingForce, out float rotationRecoilPower, out float positionRecoilPower) { }

	private void CalculateShotRecoilRadian(out Vector2 recoilRadian) { }

	private void CheckAutoFire() { }

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

	private float GetMultiplierByShotIndex() { }

	public override void RecalculateRecoilParamsOnChangeWeapon(WeaponTemplate template, AimingConfiguration AimingConfig, FirearmController firearmController, float recoilSuppressionX, float recoilSuppressionY, float recoilSuppressionFactor, float modsFactorRecoil) { }

	public override void set_DegreeRecoil(Vector2 value) { }

	public override void set_RecoilProcessValues(RecoilShotVal[] value) { }

	public override void set_RecoilRadian(Vector2 value) { }

	public override void set_RecoilRotationStrength(Vector2 value) { }

	public override void set_SeparateIntensityFactors(Vector3 value) { }

	private void SetUseOffsetToRecoilProcesses() { }

}

