//Type is in global namespace

public class WeaponRecoilProcessBase
{
	public ComponentType ComponentType; //Field offset: 0x10
	public float CurveTimeMultiply; //Field offset: 0x14
	public float CurveValueMultiply; //Field offset: 0x18
	public float CurveAimingValueMultiply; //Field offset: 0x1C
	public AnimationCurve TransformationCurve; //Field offset: 0x20
	private Vector3 _current; //Field offset: 0x28
	private float _curveTime; //Field offset: 0x34

	public WeaponRecoilProcessBase() { }

	public WeaponRecoilProcessBase(ComponentType ComponentType, float CurveTimeMultiply, float CurveValueMultiply, float CurveAimingValueMultiply, AnimationCurve TransformationCurve) { }

	public void CalculateRecoil(float deltaTime, bool isAiming) { }

	private Vector3 GetDirection() { }

	public Vector3 GetRecoil() { }

	public void OnShoot() { }

}

