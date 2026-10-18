//Type is in global namespace

public class MgBelt : MonoBehaviour
{
	internal class WaveInfo
	{
		public const float Cap = 3; //Field offset: 0x0
		public float Shift; //Field offset: 0x10
		public float Decay; //Field offset: 0x14

		public WaveInfo() { }

	}

	[SerializeField]
	private BezierCurve Curve1; //Field offset: 0x20
	[SerializeField]
	private float _sleepCooldown; //Field offset: 0x28
	public Rigidbody[] KeyElemetns; //Field offset: 0x30
	public Collider[] KeyElementsColliders; //Field offset: 0x38
	public List Links; //Field offset: 0x40
	public float WaveAmplitude; //Field offset: 0x48
	public AnimationCurve AmplitudeCurve; //Field offset: 0x50
	public AnimationCurve WeightCurve; //Field offset: 0x58
	private readonly List _waves; //Field offset: 0x60
	private float _terminateTimer; //Field offset: 0x68
	private bool _termination; //Field offset: 0x6C
	private bool _on; //Field offset: 0x6D
	private Transform _beltPivot; //Field offset: 0x70
	private int _lastDisplayedElement; //Field offset: 0x78
	private bool _isVisible; //Field offset: 0x7C
	private bool _physicsAlreadyRegistered; //Field offset: 0x7D

	public bool On
	{
		 get { } //Length: 5
		 set { } //Length: 122
	}

	public MgBelt() { }

	public void AddWave() { }

	public void DisplayAll(int displayElements) { }

	public void DisplayDelta(int displayElements) { }

	public bool get_On() { }

	public void Init() { }

	private void LateUpdate() { }

	public void set_On(bool value) { }

	private void SetPhysicsPartsEnabled(bool isPhysicsEnabled) { }

	public void SetPivotPoint(Transform t) { }

	public void SetVisible(bool isVisible) { }

}

