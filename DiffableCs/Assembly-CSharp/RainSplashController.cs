//Type is in global namespace

public class RainSplashController : MonoBehaviour
{
	[SerializeField]
	private DepthPhotograper _depthPhoto; //Field offset: 0x20
	[SerializeField]
	private ParticleSystem _splashes; //Field offset: 0x28
	[SerializeField]
	private float _splashLifetime; //Field offset: 0x30
	[SerializeField]
	private Vector2 _particleSizeRange; //Field offset: 0x34
	[SerializeField]
	private float _splashesOffset; //Field offset: 0x3C
	[SerializeField]
	private float _minDistance; //Field offset: 0x40
	[SerializeField]
	private float _maxDistance; //Field offset: 0x44
	[SerializeField]
	private float _maxGeneratedParticlesInFrame; //Field offset: 0x48
	[SerializeField]
	private AnimationCurve _falloffCurve; //Field offset: 0x50
	[SerializeField]
	private AnimationCurve _dispersionCurve; //Field offset: 0x58
	private Transform _target; //Field offset: 0x60
	private float _intensity; //Field offset: 0x68
	private PrecalculatedFloatRandoms _floatRandoms; //Field offset: 0x70

	public float Intensity
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public RainSplashController() { }

	private void Awake() { }

	public float get_Intensity() { }

	public void Init(Camera targetCamera) { }

	public void set_Intensity(float value) { }

	private void Update() { }

}

