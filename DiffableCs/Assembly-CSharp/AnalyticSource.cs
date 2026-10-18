//Type is in global namespace

[ExecuteInEditMode]
public class AnalyticSource : MonoBehaviour
{
	private static readonly int _cubeScale; //Field offset: 0x0
	private static readonly int _cubeShift; //Field offset: 0x4
	private static readonly int _doorSize; //Field offset: 0x8
	private static readonly int _fadeOut; //Field offset: 0xC
	private static readonly int _fadeNormals; //Field offset: 0x10
	private static readonly int _lightIntensity; //Field offset: 0x14
	private static readonly int _lightIntensityMultiplicator; //Field offset: 0x18
	private static readonly int _addAmbient; //Field offset: 0x1C
	private static readonly int _cubeLightMinZ; //Field offset: 0x20
	public static bool EnableAutoculling; //Field offset: 0x24
	public static bool EnableDraw; //Field offset: 0x25
	[Help("If you want to update settings or transform wile plaing, you should call UpdateSettins manually")]
	public bool IsAdditional; //Field offset: 0x20
	public float LightIntensity; //Field offset: 0x24
	[Range(0, 8)]
	public float LightIntensityMultiplicator; //Field offset: 0x28
	public float FadeNormals; //Field offset: 0x2C
	public float AddAmbient; //Field offset: 0x30
	public Vector2 DoorSize; //Field offset: 0x34
	public Vector3 CubeScale; //Field offset: 0x3C
	public Vector3 CubeShift; //Field offset: 0x48
	public Vector3 FadeOut; //Field offset: 0x54
	public Transform CubeControlHelper; //Field offset: 0x60
	public CullingSettings Culling; //Field offset: 0x68
	public StencilShadow LinkedStencilShadow; //Field offset: 0x70
	[HideInInspector]
	public Bounds Bounds; //Field offset: 0x78
	[HideInInspector]
	public MaterialPropertyBlock MaterialPropertyBlock; //Field offset: 0x90
	[HideInInspector]
	public Matrix4x4 LocalToWorldMatrix; //Field offset: 0x98
	[HideInInspector]
	public int ShaderPath; //Field offset: 0xD8
	public int DesiredDrawPriority; //Field offset: 0xDC
	[HideInInspector]
	[SerializeField]
	private int _drawPriority; //Field offset: 0xE0
	public bool IsAutocullVisible; //Field offset: 0xE4

	public int ActualDrawPriority
	{
		 get { } //Length: 7
	}

	private static AnalyticSource() { }

	public AnalyticSource() { }

	private void Awake() { }

	public int get_ActualDrawPriority() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void Start() { }

	public void UpdateSettings() { }

}

