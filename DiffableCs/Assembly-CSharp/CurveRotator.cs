//Type is in global namespace

public class CurveRotator : MonoBehaviour
{
	public Transform RotatedTransform; //Field offset: 0x20
	public float RotationSpeed; //Field offset: 0x28
	public Quaternion OffRotation; //Field offset: 0x2C
	public Quaternion OnRotation; //Field offset: 0x3C
	public AnimationCurve AnimationCurve; //Field offset: 0x50
	private float _t; //Field offset: 0x58
	private bool _rotating; //Field offset: 0x5C
	private float _targetT; //Field offset: 0x60

	public CurveRotator() { }

	public void Set(bool isOn, bool initial) { }

	private bool ShouldRotate() { }

	private void Update() { }

}

