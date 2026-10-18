//Type is in global namespace

public class WeaponAiming
{
	private const float _epsilon = 0.999; //Field offset: 0x0
	public bool Enable; //Field offset: 0x10
	public float InSpeedMultiplier; //Field offset: 0x14
	public float OutSpeedMultiplier; //Field offset: 0x18
	public WeaponAimValue[] ValuesIn; //Field offset: 0x20
	public WeaponAimValue[] ValuesOut; //Field offset: 0x28
	private bool _prevAiming; //Field offset: 0x30
	private bool _isAiming; //Field offset: 0x31
	private Func _aimingLerpSpeed; //Field offset: 0x38

	public Func InSpeed
	{
		 get { } //Length: 110
	}

	public Func OutSpeed
	{
		 get { } //Length: 110
	}

	public WeaponAiming() { }

	public WeaponAiming(bool enable, float inSpeedMult, float outSpeedMult) { }

	[CompilerGenerated]
	private float <get_InSpeed>b__8_0() { }

	[CompilerGenerated]
	private float <get_OutSpeed>b__10_0() { }

	public void CalculateAim(float deltaTime) { }

	private float CalculateAimingTime(float speed) { }

	public Func get_InSpeed() { }

	public Func get_OutSpeed() { }

	public Vector3 GetCameraRotation() { }

	public Vector3 GetPosition() { }

	public Vector3 GetRotation() { }

	public void Initialize(WeaponAimValue[] valuesIn, WeaponAimValue[] valuesOut) { }

	public void OnAim(bool isAiming) { }

	public void SetAimingLerpSpeed(Func aimingLerpSpeed) { }

}

