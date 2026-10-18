//Type is in global namespace

[DisallowMultipleComponent]
public class HitCameraShaker : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _positionCurve; //Field offset: 0x20
	[SerializeField]
	private AnimationCurve _hitBackCurve; //Field offset: 0x28
	[SerializeField]
	private float _maxOffset; //Field offset: 0x30
	[SerializeField]
	private float _goForwardTime; //Field offset: 0x34
	[SerializeField]
	private float _goBackTime; //Field offset: 0x38
	[SerializeField]
	private float _eulersNoiseXYMaxValue; //Field offset: 0x3C
	[SerializeField]
	private float _eulersNoiseZMaxValue; //Field offset: 0x40
	[SerializeField]
	private float _positionXYNoise; //Field offset: 0x44
	[SerializeField]
	private float _positionZNoise; //Field offset: 0x48
	private float _lerpVal; //Field offset: 0x4C
	private Vector3 _initialLocalCoords; //Field offset: 0x50
	private Vector3 _initialEulers; //Field offset: 0x5C
	[SerializeField]
	private Transform _transform; //Field offset: 0x68
	private bool _hit; //Field offset: 0x70
	private Vector3 _targetPosition; //Field offset: 0x74
	private Vector3 _fromPosition; //Field offset: 0x80
	private AnimationCurve _curve; //Field offset: 0x90
	private float _hitPower; //Field offset: 0x98

	public HitCameraShaker() { }

	public void Hit(Vector3 hitDirection, float hitPower) { }

	public void LateUpdate() { }

	private void Start() { }

}

