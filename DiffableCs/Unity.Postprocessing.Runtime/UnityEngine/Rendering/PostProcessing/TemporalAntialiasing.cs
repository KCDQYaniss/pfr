namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
public sealed class TemporalAntialiasing
{
	private enum Pass
	{
		SolverDilate = 0,
		SolverNoDilate = 1,
	}

	private const int k_NumHistoryTextures = 2; //Field offset: 0x0
	private const int k_NumEyes = 2; //Field offset: 0x0
	[CompilerGenerated]
	private static Vector2 <jitterPixelSpace>k__BackingField; //Field offset: 0x0
	public static int k_SampleCount; //Field offset: 0x8
	private static int jitterSamplesGeneratorRepeatCount; //Field offset: 0xC
	private static int repeatIdx; //Field offset: 0x10
	private static Vector2 lastOffset; //Field offset: 0x14
	[Range(0, 10)]
	[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable, but blurrier, output.")]
	public float jitterSpread; //Field offset: 0x10
	[Range(0, 3)]
	[Tooltip("Controls the amount of sharpening applied to the color buffer. High values may introduce dark-border artifacts.")]
	public float sharpness; //Field offset: 0x14
	public float moveSpeed; //Field offset: 0x18
	[Range(0, 0.99)]
	[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
	public float stationaryBlending; //Field offset: 0x1C
	[Range(0, 0.99)]
	[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
	public float motionBlending; //Field offset: 0x20
	public Func jitteredMatrixFunc; //Field offset: 0x28
	[CompilerGenerated]
	private Vector2 <jitter>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Vector2 <lastJitterPixelSpace>k__BackingField; //Field offset: 0x38
	private readonly RenderTargetIdentifier[] m_Mrt; //Field offset: 0x40
	private bool m_ResetHistory; //Field offset: 0x48
	[CompilerGenerated]
	private int <sampleIndex>k__BackingField; //Field offset: 0x4C
	private readonly RenderTexture[][] m_HistoryTextures; //Field offset: 0x50
	private readonly int[] m_HistoryPingPong; //Field offset: 0x58

	public private Vector2 jitter
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private static Vector2 jitterPixelSpace
	{
		[CompilerGenerated]
		 get { } //Length: 97
		[CompilerGenerated]
		private set { } //Length: 106
	}

	public static int JitterSamplesGeneratorRepeatCount
	{
		 get { } //Length: 83
		 set { } //Length: 139
	}

	public private Vector2 lastJitterPixelSpace
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private int sampleIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static TemporalAntialiasing() { }

	public TemporalAntialiasing() { }

	private RenderTexture CheckHistory(int id, PostProcessRenderContext context) { }

	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context) { }

	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context) { }

	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context) { }

	private Vector2 GenerateRandomOffset() { }

	[CompilerGenerated]
	public Vector2 get_jitter() { }

	[CompilerGenerated]
	public static Vector2 get_jitterPixelSpace() { }

	public static int get_JitterSamplesGeneratorRepeatCount() { }

	[CompilerGenerated]
	public Vector2 get_lastJitterPixelSpace() { }

	[CompilerGenerated]
	public int get_sampleIndex() { }

	internal DepthTextureMode GetCameraFlags() { }

	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera) { }

	private static Vector2 GetUnityHaltonSequence(int sampleIndex) { }

	public bool IsSupported() { }

	internal void Release() { }

	internal void Render(PostProcessRenderContext context) { }

	internal void ResetHistory() { }

	[CompilerGenerated]
	private void set_jitter(Vector2 value) { }

	[CompilerGenerated]
	private static void set_jitterPixelSpace(Vector2 value) { }

	public static void set_JitterSamplesGeneratorRepeatCount(int value) { }

	[CompilerGenerated]
	private void set_lastJitterPixelSpace(Vector2 value) { }

	[CompilerGenerated]
	private void set_sampleIndex(int value) { }

}

