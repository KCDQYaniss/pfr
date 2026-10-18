//Type is in global namespace

[AddComponentMenu("Time of Day/Camera MBOIT Scattering")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class MBOIT_Scattering : TOD_ImageEffect
{
	private struct MboitScatterParameters
	{
		public float ColorMultiplierRed; //Field offset: 0x0
		public float ColorMultiplierGreen; //Field offset: 0x4
		public float ColorMultiplierBlue; //Field offset: 0x8
		public float ScatterDensityMultiplier; //Field offset: 0xC
		public float ScatterDensityPower; //Field offset: 0x10
		public float ScatterDensityBias; //Field offset: 0x14
		public float ScatterGreyscale; //Field offset: 0x18
		public float HeightFalloffFactor; //Field offset: 0x1C

	}

	public const int SLICES_COUNT = 10; //Field offset: 0x0
	private static readonly int _frustumCornersWs; //Field offset: 0x0
	private static readonly int _ditheringTexture; //Field offset: 0x4
	private static readonly int _density; //Field offset: 0x8
	private static readonly int _sunrizeGlow; //Field offset: 0xC
	private static int _cameraParametersID; //Field offset: 0x10
	public bool Lighten; //Field offset: 0x38
	public bool FromLevelSettings; //Field offset: 0x39
	public ComputeShader ScatteringSlicesComputeShader; //Field offset: 0x40
	public ComputeShader ScatteringMBOITComputeShader; //Field offset: 0x48
	public ComputeShader ScatteringMBOITRCPComputeShader; //Field offset: 0x50
	public ComputeShader ScatteringMBOITFinalPassComputeShader; //Field offset: 0x58
	public Color ScatterColorMultiplier; //Field offset: 0x60
	public float ScatterGreyscale; //Field offset: 0x70
	public float ScatterDensityMultiplier; //Field offset: 0x74
	public float ScatterDensityPower; //Field offset: 0x78
	public float ScatterDensityBias; //Field offset: 0x7C
	public float HeightFalloffFactor; //Field offset: 0x80
	public float SOFT_SCALE; //Field offset: 0x84
	public float SOFT_CONTRAST_POWER; //Field offset: 0x88
	public Texture2D DitheringTexture; //Field offset: 0x90
	[Range(0, 0.2)]
	public float GlobalDensity; //Field offset: 0x98
	[Range(0, 1)]
	public float HeightFalloff; //Field offset: 0x9C
	[Range(0.95, 1)]
	public float SunrizeGlow; //Field offset: 0xA0
	public bool ThermalVisionIsEnabled; //Field offset: 0xA4
	public float MBOITDitherScale; //Field offset: 0xA8
	private float _slicesFarDistance; //Field offset: 0xAC
	private float _slicesDistributionExponent; //Field offset: 0xB0
	private bool _isDataUpdated; //Field offset: 0xB4
	private bool _areSlicesDepthDurty; //Field offset: 0xB5
	public float ZeroLevel; //Field offset: 0xB8
	private ComputeBuffer _slicesBuffer; //Field offset: 0xC0
	private RenderTexture _slicesColor2DArray; //Field offset: 0xC8
	private RenderTexture _slicesAlpha2DArray; //Field offset: 0xD0
	private RenderTexture _depthBuffer; //Field offset: 0xD8
	private Mesh _mesh; //Field offset: 0xE0
	private CommandBuffer _cmdBufEvaluate; //Field offset: 0xE8
	private SSAA _ssaa; //Field offset: 0xF0
	private Camera _camera; //Field offset: 0xF8
	private bool _isInitialized; //Field offset: 0x100
	private ComputeBuffer _mboitScatterParameters; //Field offset: 0x108
	private MboitScatterParameters[] _mboitScatterParametersArray; //Field offset: 0x110

	public bool IsDataUpdated
	{
		 get { } //Length: 8
	}

	public float SlicesDistributionExponent
	{
		 get { } //Length: 9
		 set { } //Length: 27
	}

	public float SlicesFarDistance
	{
		 get { } //Length: 9
	}

	private static MBOIT_Scattering() { }

	public MBOIT_Scattering() { }

	private void ClearSlicesRT() { }

	public bool get_IsDataUpdated() { }

	public float get_SlicesDistributionExponent() { }

	public float get_SlicesFarDistance() { }

	private void Init() { }

	private void InitRTSlices(int width, int height) { }

	protected void OnDestroy() { }

	protected void OnPreCull() { }

	protected void OnRenderImageMBOITMode(ComputeBuffer scatteringParameters) { }

	public void RenderMoments(CommandBuffer cmd, RenderTexture depthBuffer, RenderTexture moments0UAV, RenderTexture moments1UAV, RenderTexture fogAlpha) { }

	public void RenderNormalizationFactor(CommandBuffer cmd, RenderTexture moments0UAV, RenderTexture moments1UAV, RenderTexture momentsRcp) { }

	public void RenderWithMBOIT(CommandBuffer cmd, RenderTexture moments0UAV, RenderTexture moments1UAV, RenderTexture momentsRcp, RenderTexture resultTexture) { }

	public void set_SlicesDistributionExponent(float value) { }

	protected void Start() { }

	private void UpdateSlicesDepth() { }

}

