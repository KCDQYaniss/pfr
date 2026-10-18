//Type is in global namespace

[DisallowMultipleComponent]
public class RainScreenDrops : MonoBehaviour
{
	private static readonly int _inputMin; //Field offset: 0x0
	private static readonly int _inputMax; //Field offset: 0x4
	private static readonly int _inputGamma; //Field offset: 0x8
	private static readonly int _outputMin; //Field offset: 0xC
	private static readonly int _outputMax; //Field offset: 0x10
	private static readonly int _blured; //Field offset: 0x14
	private static readonly int _dudvMap; //Field offset: 0x18
	private static readonly int _refraction1; //Field offset: 0x1C
	private static readonly int _intensity1; //Field offset: 0x20
	[Header("Appearance settings")]
	[SerializeField]
	private Shader _blitShader; //Field offset: 0x20
	[Range(0, 1)]
	[SerializeField]
	private float _intensity; //Field offset: 0x28
	[SerializeField]
	private float _refraction; //Field offset: 0x2C
	[SerializeField]
	private float _refractionWithoutGlass; //Field offset: 0x30
	[SerializeField]
	private int _downsamplingCount; //Field offset: 0x34
	[Header("Drops settings")]
	[SerializeField]
	private AnimationCurve _dropScaleCurve; //Field offset: 0x38
	[SerializeField]
	private int _dropsAmount; //Field offset: 0x40
	[SerializeField]
	private float _rainDropsDelay; //Field offset: 0x44
	[SerializeField]
	private Vector2 _dropScale; //Field offset: 0x48
	[SerializeField]
	private float _dropLifetime; //Field offset: 0x50
	[SerializeField]
	private float _dropLifetimeWithoutGlass; //Field offset: 0x54
	[SerializeField]
	private bool _isDropsShouldMove; //Field offset: 0x58
	[SerializeField]
	private int _maxDropsAtOnce; //Field offset: 0x5C
	[SerializeField]
	private Material _dropMaterial; //Field offset: 0x60
	[SerializeField]
	private float _scaleMultiplierWithoutGlass; //Field offset: 0x68
	private Material _blitMaterial; //Field offset: 0x70
	public RenderTexture DuDvMap; //Field offset: 0x78
	[Space(10)]
	private RenderTexture _duDvMap; //Field offset: 0x80
	private GameObject _rainCameraObject; //Field offset: 0x88
	private RainScreenDropsPlacer _dropsPlacer; //Field offset: 0x90
	private float _lastDropFadeTime; //Field offset: 0x98
	private float _zeroIntensityTimer; //Field offset: 0x9C
	private SSAAPropagator _ssaaPropagator; //Field offset: 0xA0
	private bool _hasGlasses; //Field offset: 0xA8
	[HideInInspector]
	public int Mode; //Field offset: 0xAC
	[HideInInspector]
	[SerializeField]
	public float InputMinL; //Field offset: 0xB0
	[HideInInspector]
	[SerializeField]
	public float InputMaxL; //Field offset: 0xB4
	[HideInInspector]
	[SerializeField]
	public float InputGammaL; //Field offset: 0xB8
	[HideInInspector]
	[SerializeField]
	public float InputMinR; //Field offset: 0xBC
	[HideInInspector]
	[SerializeField]
	public float InputMaxR; //Field offset: 0xC0
	[HideInInspector]
	[SerializeField]
	public float InputGammaR; //Field offset: 0xC4
	[HideInInspector]
	[SerializeField]
	public float InputMinG; //Field offset: 0xC8
	[HideInInspector]
	[SerializeField]
	public float InputMaxG; //Field offset: 0xCC
	[HideInInspector]
	[SerializeField]
	public float InputGammaG; //Field offset: 0xD0
	[HideInInspector]
	[SerializeField]
	public float InputMinB; //Field offset: 0xD4
	[HideInInspector]
	[SerializeField]
	public float InputMaxB; //Field offset: 0xD8
	[HideInInspector]
	[SerializeField]
	public float InputGammaB; //Field offset: 0xDC
	[HideInInspector]
	[SerializeField]
	public float OutputMinL; //Field offset: 0xE0
	[HideInInspector]
	[SerializeField]
	public float OutputMaxL; //Field offset: 0xE4
	[HideInInspector]
	[SerializeField]
	public float OutputMinR; //Field offset: 0xE8
	[HideInInspector]
	[SerializeField]
	public float OutputMaxR; //Field offset: 0xEC
	[HideInInspector]
	[SerializeField]
	public float OutputMinG; //Field offset: 0xF0
	[HideInInspector]
	[SerializeField]
	public float OutputMaxG; //Field offset: 0xF4
	[HideInInspector]
	[SerializeField]
	public float OutputMinB; //Field offset: 0xF8
	[HideInInspector]
	[SerializeField]
	public float OutputMaxB; //Field offset: 0xFC

	public float Intensity
	{
		 get { } //Length: 6
		 set { } //Length: 57
	}

	private static RainScreenDrops() { }

	public RainScreenDrops() { }

	public void Awake() { }

	public void ChangeGlassesState(bool hasGlasses) { }

	public float get_Intensity() { }

	public void Init() { }

	private void OnDestroy() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void OnRenderImageInternal(RenderTexture source, RenderTexture destanation) { }

	private void OnValidate() { }

	public void set_Intensity(float value) { }

	public void SetIntensity(float intensity) { }

	private void Update() { }

}

