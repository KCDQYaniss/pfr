//Type is in global namespace

[ExecuteInEditMode]
public sealed class WetRenderer : OnRenderObjectConnector
{
	[CompilerGenerated]
	private static bool <WetOffMaskUsed>k__BackingField; //Field offset: 0x0
	private static readonly int _wetOffMask; //Field offset: 0x4
	private static readonly int _intensityId; //Field offset: 0x8
	private static readonly int _diffuseColorId; //Field offset: 0xC
	private static readonly int _specColorId; //Field offset: 0x10
	private static readonly int _biasId; //Field offset: 0x14
	public Shader WetShader; //Field offset: 0x20
	[Range(0, 1)]
	public float Intensity; //Field offset: 0x28
	public Color DiffuseColor; //Field offset: 0x2C
	public Color SpecColor; //Field offset: 0x3C
	public float WetBias; //Field offset: 0x4C
	private Material _wetMaterial; //Field offset: 0x50
	private Mesh _wetMesh; //Field offset: 0x58
	private bool _cachedWetOffMaskUsed; //Field offset: 0x60
	private readonly RenderTargetIdentifier[] _mrt; //Field offset: 0x68
	private readonly CommandBufferManager _cbManager; //Field offset: 0x70

	public static bool WetOffMaskUsed
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		 set { } //Length: 88
	}

	private static WetRenderer() { }

	public WetRenderer() { }

	private static Mesh CreateQuad() { }

	[CompilerGenerated]
	public static bool get_WetOffMaskUsed() { }

	private Material GetMaterial() { }

	private void Init() { }

	public virtual void ManualOnRenderObject(Camera currentCamera) { }

	protected virtual void OnDestroy() { }

	private void OnValidate() { }

	[CompilerGenerated]
	public static void set_WetOffMaskUsed(bool value) { }

	public void SetDebugRain(bool debug) { }

	protected virtual void Start() { }

	private void Update() { }

	private void UpdateMaterial() { }

}

