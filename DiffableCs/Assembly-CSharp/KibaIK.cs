//Type is in global namespace

[RequireComponent(typeof(LimbIK))]
[RequireComponent(typeof(Animator))]
public class KibaIK : MonoBehaviour
{
	private float _animatorLayerWeight; //Field offset: 0x20
	private Animator _animator; //Field offset: 0x28
	private LimbIK _limb; //Field offset: 0x30
	private AnimationCurve _c; //Field offset: 0x38
	[Header("Curves")]
	public AnimationCurve OnCurve; //Field offset: 0x40
	public AnimationCurve OffCurve; //Field offset: 0x48
	private float _speed; //Field offset: 0x50
	[Header("Debug")]
	public float TimeScale; //Field offset: 0x54
	public int GripType; //Field offset: 0x58
	private float _time; //Field offset: 0x5C

	public KibaIK() { }

	public void GripOff(float t) { }

	public void GripOn(float t) { }

	private void Start() { }

	private void Update() { }

}

