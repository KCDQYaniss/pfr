//Type is in global namespace

public class WeaponRecoil
{
	public bool Enable; //Field offset: 0x10
	public WeaponRecoilValue[] Values; //Field offset: 0x18
	private bool _isAiming; //Field offset: 0x20

	public WeaponRecoil() { }

	public WeaponRecoil(bool enable) { }

	public void CalculateRecoil(float deltaTime) { }

	public Vector3 GetCameraRotationRecoil() { }

	public Vector3 GetPositionRecoil() { }

	public Vector3 GetRotationRecoil() { }

	public void Initialize(WeaponRecoilValue[] values) { }

	public void OnShoot() { }

	public void SetAiming(bool value) { }

}

