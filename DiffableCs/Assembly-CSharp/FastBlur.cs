//Type is in global namespace

[RequireComponent(typeof(Camera))]
public class FastBlur : MonoBehaviour
{
	internal enum Dimensions
	{
		_128 = 128,
		_256 = 256,
		_512 = 512,
		_1024 = 1024,
		_2048 = 2048,
	}

	private static readonly int _blurTex; //Field offset: 0x0
	private static readonly int _value1; //Field offset: 0x4
	[Header("Blur Setup")]
	[Range(0, 1)]
	[SerializeField]
	private float _value; //Field offset: 0x20
	[SerializeField]
	private Material _material; //Field offset: 0x28
	[SerializeField]
	private Dimensions _upsampleTexDimension; //Field offset: 0x30
	[SerializeField]
	private Dimensions _downsampleTexDimension; //Field offset: 0x34
	[Range(1, 8)]
	[SerializeField]
	private int _blurCount; //Field offset: 0x38
	[Header("Hit")]
	[SerializeField]
	private float _hitTime; //Field offset: 0x3C
	[SerializeField]
	private AnimationCurve _hitCurve; //Field offset: 0x40
	[Header("Death")]
	[SerializeField]
	private float _deathTime; //Field offset: 0x48
	[SerializeField]
	private AnimationCurve _deathCurve; //Field offset: 0x50
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x58
	private float _currentTime; //Field offset: 0x60
	private float _timer; //Field offset: 0x64
	private AnimationCurve _currentCurve; //Field offset: 0x68
	private bool _isDead; //Field offset: 0x70
	private float _power; //Field offset: 0x74

	private static FastBlur() { }

	public FastBlur() { }

	private void Awake() { }

	public void Die() { }

	public void Hit(float power) { }

	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected void OnRenderImageImpl(RenderTexture source, RenderTexture destanation) { }

	public void Reset() { }

	private void Start() { }

	public void Update() { }

}

