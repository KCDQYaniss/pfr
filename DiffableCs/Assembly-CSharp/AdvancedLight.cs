//Type is in global namespace

[ExecuteInEditMode]
public class AdvancedLight : MonoBehaviour, IRenderer
{
	internal enum LightTypeEnum
	{
		Point = 0,
		Directional = 1,
	}

	internal enum ShadingTypeEnum
	{
		Diffuse = 0,
		Specular = 1,
		DiffuseAndSpecular = 2,
	}

	private static readonly Vector3 VectorOne; //Field offset: 0x0
	private static readonly Vector3 VectorZero; //Field offset: 0xC
	private static readonly int _color; //Field offset: 0x18
	private static readonly int _invSqRadius; //Field offset: 0x1C
	private static readonly int _fullScreen; //Field offset: 0x20
	private static readonly int _cubeHelperScale; //Field offset: 0x24
	private static readonly int _cubeHelperShift; //Field offset: 0x28
	public Shader Shader; //Field offset: 0x20
	public LightTypeEnum LightType; //Field offset: 0x28
	public Mesh Mesh; //Field offset: 0x30
	public int SubMesh; //Field offset: 0x38
	public Transform LightPosition; //Field offset: 0x40
	[ColorUsage(False, True)]
	public Color Color; //Field offset: 0x48
	public float Radius; //Field offset: 0x58
	public ShadingTypeEnum ShadingType; //Field offset: 0x5C
	public bool ShowDebugShapes; //Field offset: 0x60
	public Transform CubeControlHelper; //Field offset: 0x68
	public bool FullScreen; //Field offset: 0x70
	[HideInInspector]
	public Vector3 CubeScale; //Field offset: 0x74
	[HideInInspector]
	public Vector3 CubeShift; //Field offset: 0x80
	private Material _material; //Field offset: 0x90
	private Transform _transform; //Field offset: 0x98
	private Transform _targetTransform; //Field offset: 0xA0
	private int _lightPositionPropertyID; //Field offset: 0xA8
	private int _lightDirectionPropertyID; //Field offset: 0xAC
	private int _srcBlendID; //Field offset: 0xB0
	private int _dstBlendID; //Field offset: 0xB4
	private int _colorID; //Field offset: 0xB8
	private int _invSqRadiusID; //Field offset: 0xBC
	private float _lastRadius; //Field offset: 0xC0

	private static AdvancedLight() { }

	public AdvancedLight() { }

	public override void Draw(CommandBuffer buffer, Plane[] frustrumPlanes, Camera cam) { }

	private void Initialize() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	private void OnEnable() { }

	private void OnValidate() { }

	private void SetHelperParamsToShader() { }

	private void Start() { }

	private void Update() { }

	public static void UpdateKeywords(Material material, Enum enumValue) { }

}

