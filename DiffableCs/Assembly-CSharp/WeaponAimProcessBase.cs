//Type is in global namespace

public class WeaponAimProcessBase
{
	public ComponentType ComponentType; //Field offset: 0x10
	public float CurveTimeMultiply; //Field offset: 0x14
	public float CurveValueMultiply; //Field offset: 0x18
	public AnimationCurve TransformationCurve; //Field offset: 0x20
	private Vector3 _current; //Field offset: 0x28
	private float _curveTime; //Field offset: 0x34
	private float _aimingTime; //Field offset: 0x38

	private float _normalizedAimingTime
	{
		private get { } //Length: 39
	}

	public WeaponAimProcessBase() { }

	public WeaponAimProcessBase(ComponentType ComponentType, float CurveTimeMultiply, float CurveValueMultiply, AnimationCurve TransformationCurve) { }

	public void Calculate(float deltaTime) { }

	private float get__normalizedAimingTime() { }

	public Vector3 GetCurrent() { }

	private Vector3 GetDirection() { }

	public void Refresh(float aimingTime) { }

}

