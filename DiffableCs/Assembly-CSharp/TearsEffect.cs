//Type is in global namespace

public class TearsEffect : MonoBehaviour
{
	private const string SHADER_NAME = "Hidden/TearsEffect"; //Field offset: 0x0
	private static readonly int _strengthId; //Field offset: 0x0
	private static readonly int _distortionTexId; //Field offset: 0x4
	private static readonly int _distortionSpeedId; //Field offset: 0x8
	private static readonly int _distortionPowerId; //Field offset: 0xC
	private static readonly int _centerOfViewId; //Field offset: 0x10
	private static readonly int _enableVignetteId; //Field offset: 0x14
	private static readonly int _vignetteNoiseTexId; //Field offset: 0x18
	private static readonly int _vignetteNoiseTexTillingOffsetId; //Field offset: 0x1C
	private static readonly int _vignetteColorFromId; //Field offset: 0x20
	private static readonly int _vignetteColorToId; //Field offset: 0x24
	private static readonly int _vignetteFalloffId; //Field offset: 0x28
	private static readonly int _vignetteRadiusId; //Field offset: 0x2C
	private static readonly int _vignetteBlinkingId; //Field offset: 0x30
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x20
	private Material _material; //Field offset: 0x28
	private Shader _shader; //Field offset: 0x30
	[Range(0, 1)]
	[SerializeField]
	private float _strength; //Field offset: 0x38
	[Range(0, 10)]
	[SerializeField]
	private float _strengthChangeSpeed; //Field offset: 0x3C
	[SerializeField]
	[Space]
	private Texture2D _distortionTexture; //Field offset: 0x40
	[SerializeField]
	private Vector2 _distortionSpeedR; //Field offset: 0x48
	[SerializeField]
	private Vector2 _distortionSpeedG; //Field offset: 0x50
	[Range(0, 0.3)]
	[SerializeField]
	private float _distortionPowerR; //Field offset: 0x58
	[Range(0, 0.3)]
	[SerializeField]
	private float _distortionPowerG; //Field offset: 0x5C
	[Range(0, 1)]
	[SerializeField]
	private float _centerOfView; //Field offset: 0x60
	[SerializeField]
	[Space]
	private bool _enableVignette; //Field offset: 0x64
	[SerializeField]
	private Texture2D _vignetteNoiseTexture; //Field offset: 0x68
	[SerializeField]
	private Vector2 _vignetteNoiseTextureTilling; //Field offset: 0x70
	[SerializeField]
	private Vector2 _vignetteNoiseTextureOffset; //Field offset: 0x78
	[SerializeField]
	[Space]
	private Color _vignetteColorFrom; //Field offset: 0x80
	[SerializeField]
	private Color _vignetteColorTo; //Field offset: 0x90
	[Range(0, 1)]
	[SerializeField]
	[Space]
	private float _vignetteRadius; //Field offset: 0xA0
	[SerializeField]
	private Vector2 _vignetteFalloff; //Field offset: 0xA4
	[Range(0, 12)]
	[SerializeField]
	[Space]
	private float _vignetteBlinkingSpeed; //Field offset: 0xAC
	[Range(0.2, 12)]
	[SerializeField]
	private float _vignetteBlinkingContrast; //Field offset: 0xB0

	private Material Material
	{
		private get { } //Length: 734
	}

	public float Strength
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public float StrengthChangeSpeed
	{
		 get { } //Length: 6
	}

	private static TearsEffect() { }

	public TearsEffect() { }

	private void Awake() { }

	private Material get_Material() { }

	public float get_Strength() { }

	public float get_StrengthChangeSpeed() { }

	private void OnDestroy() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void set_Strength(float value) { }

}

