namespace UnityStandardAssets.CinematicEffects;

[AddComponentMenu("Image Effects/Cinematic/Ambient Occlusion")]
[ExecuteInEditMode]
[ImageEffectAllowedInSceneView]
[RequireComponent(typeof(Camera))]
public class AmbientOcclusion : MonoBehaviour
{
	internal enum OcclusionSource
	{
		DepthTexture = 0,
		DepthNormalsTexture = 1,
		GBuffer = 2,
	}

	private struct PropertyObserver
	{
		private bool _downsampling; //Field offset: 0x0
		private OcclusionSource _occlusionSource; //Field offset: 0x4
		private bool _ambientOnly; //Field offset: 0x8
		private bool _debug; //Field offset: 0x9
		private int _pixelWidth; //Field offset: 0xC
		private int _pixelHeight; //Field offset: 0x10

		public bool CheckNeedsReset(Settings setting, Camera camera) { }

		public void Update(Settings setting, Camera camera) { }

	}

	internal enum SampleCount
	{
		Lowest = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		Variable = 4,
	}

	internal class Settings
	{
		[Range(0, 4)]
		[SerializeField]
		[Tooltip("Degree of darkness produced by the effect.")]
		public float intensity; //Field offset: 0x10
		[SerializeField]
		[Tooltip("Radius of sample points, which affects extent of darkened areas.")]
		public float radius; //Field offset: 0x14
		[SerializeField]
		[Tooltip("CutOff Distance.")]
		public float cutOffDistance; //Field offset: 0x18
		[SerializeField]
		[Tooltip("Number of sample points, which affects quality and performance.")]
		public SampleCount sampleCount; //Field offset: 0x1C
		[SerializeField]
		[Tooltip("Determines the sample count when SampleCount.Variable is used.")]
		public int sampleCountValue; //Field offset: 0x20
		[SerializeField]
		[Tooltip("Halves the resolution of the effect to increase performance.")]
		public bool downsampling; //Field offset: 0x24
		[SerializeField]
		[Tooltip("If checked, the effect only affects ambient lighting.")]
		public bool ambientOnly; //Field offset: 0x25
		[SerializeField]
		[Tooltip("Source buffer on which the occlusion estimator is based.")]
		public OcclusionSource occlusionSource; //Field offset: 0x28
		[SerializeField]
		[Tooltip("Displays occlusion for debug purpose.")]
		public bool debug; //Field offset: 0x2C

		public static Settings defaultSettings
		{
			 get { } //Length: 112
		}

		public Settings() { }

		public static Settings get_defaultSettings() { }

	}

	private static readonly int _blurVector; //Field offset: 0x0
	private static readonly int _occlusionTexture; //Field offset: 0x4
	private static readonly int _intensity; //Field offset: 0x8
	private static readonly int _radius; //Field offset: 0xC
	private static readonly int _cutOffDistance; //Field offset: 0x10
	private static readonly int _targetScale; //Field offset: 0x14
	private static readonly int _sampleCount; //Field offset: 0x18
	[SerializeField]
	public Settings settings; //Field offset: 0x20
	public bool useTriangleBlit; //Field offset: 0x28
	private CommandBuffer _cmdBuf; //Field offset: 0x30
	private MaterialPropertyBlock[] _prop; //Field offset: 0x38
	[SerializeField]
	private Shader _aoShader; //Field offset: 0x40
	private Material _aoMaterial; //Field offset: 0x48
	private CommandBuffer _aoCommands; //Field offset: 0x50
	private PropertyObserver propertyObserver; //Field offset: 0x58
	[SerializeField]
	private Mesh _quadMesh; //Field offset: 0x70

	private bool AmbientOnly
	{
		private get { } //Length: 215
	}

	private CommandBuffer AOCommands
	{
		private get { } //Length: 356
	}

	private Material AOMaterial
	{
		private get { } //Length: 641
	}

	private OcclusionSource AOOcclusionSource
	{
		private get { } //Length: 201
	}

	private SampleCount AOSampleCount
	{
		private get { } //Length: 26
	}

	private Shader AOShader
	{
		private get { } //Length: 320
	}

	private RenderTextureFormat AOTextureFormat
	{
		private get { } //Length: 28
	}

	private float CutOffDistance
	{
		private get { } //Length: 36
	}

	private bool Downsampling
	{
		private get { } //Length: 27
	}

	private float Intensity
	{
		private get { } //Length: 28
	}

	public bool isAmbientOnlySupported
	{
		 get { } //Length: 180
	}

	public bool isGBufferAvailable
	{
		 get { } //Length: 146
	}

	private Mesh QuadMesh
	{
		private get { } //Length: 5
	}

	private float Radius
	{
		private get { } //Length: 36
	}

	private int SampleCountValue
	{
		private get { } //Length: 119
	}

	private Camera TargetCamera
	{
		private get { } //Length: 62
	}

	private static AmbientOcclusion() { }

	public AmbientOcclusion() { }

	private void BuildAOCommands() { }

	private void ExecuteAOPass(RenderTexture source, RenderTexture destination) { }

	private bool get_AmbientOnly() { }

	private CommandBuffer get_AOCommands() { }

	private Material get_AOMaterial() { }

	private OcclusionSource get_AOOcclusionSource() { }

	private SampleCount get_AOSampleCount() { }

	private Shader get_AOShader() { }

	private RenderTextureFormat get_AOTextureFormat() { }

	private float get_CutOffDistance() { }

	private bool get_Downsampling() { }

	private float get_Intensity() { }

	public bool get_isAmbientOnlySupported() { }

	public bool get_isGBufferAvailable() { }

	private Mesh get_QuadMesh() { }

	private float get_Radius() { }

	private int get_SampleCountValue() { }

	private Camera get_TargetCamera() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Update() { }

	private void UpdateMaterialProperties() { }

}

