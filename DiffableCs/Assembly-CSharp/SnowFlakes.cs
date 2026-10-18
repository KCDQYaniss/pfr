//Type is in global namespace

public sealed class SnowFlakes : MonoBehaviour
{
	private struct LightProperties
	{
		public Vector4 pos; //Field offset: 0x0
		public Vector3 dir; //Field offset: 0x10
		public Vector3 color; //Field offset: 0x1C
		public Matrix4x4 worldToLight; //Field offset: 0x28

	}

	private const int MIN_MEMORY_SIZE = 2000; //Field offset: 0x0
	private const float INTENSITY_THRESHOLD = 0.001; //Field offset: 0x0
	private const int MAX_COUNT = 16383; //Field offset: 0x0
	private const int MID_COUNT = 8191; //Field offset: 0x0
	private const int MIN_COUNT = 4095; //Field offset: 0x0
	private static readonly int _fallingVector; //Field offset: 0x0
	private static readonly int _flakesSize; //Field offset: 0x4
	private static readonly int _sideSpeed; //Field offset: 0x8
	[SerializeField]
	private Color DefaultColor; //Field offset: 0x20
	[SerializeField]
	public Vector2 FlakesSizeMin; //Field offset: 0x30
	[SerializeField]
	public Vector2 FlakesSizeMax; //Field offset: 0x38
	[Range(0, 1)]
	public float FlakesFarSizeFactor; //Field offset: 0x40
	[Range(0, 1)]
	public float StormSideSpeed; //Field offset: 0x44
	[MinMaxVec2(0, 1, -1)]
	public Vector2 MinMaxSideSpeed; //Field offset: 0x48
	[Range(0, 1)]
	public float DropsAlphaClose; //Field offset: 0x50
	[Range(0, 1)]
	public float MinAmbient; //Field offset: 0x54
	[Range(0, 1)]
	public float MinAmbientAddition; //Field offset: 0x58
	[Range(0, 1)]
	public float MinAmbientAdditionCoef; //Field offset: 0x5C
	public Material Close; //Field offset: 0x60
	public Material Far; //Field offset: 0x68
	private Material _closeCopy; //Field offset: 0x70
	private Material _farCopy; //Field offset: 0x78
	private Material _closeCopyInStorm; //Field offset: 0x80
	private Material _farCopyInStorm; //Field offset: 0x88
	private MeshRenderer[] _flakes; //Field offset: 0x90
	private MeshRenderer[] _flakesInStorm; //Field offset: 0x98
	private Light _skyLight; //Field offset: 0xA0
	public ComputeBuffer _lightsPropertiesComputeBuffer; //Field offset: 0xA8
	public float Intensity; //Field offset: 0xB0
	[CompilerGenerated]
	private float <StormFactor>k__BackingField; //Field offset: 0xB4
	private List _lightsProperties; //Field offset: 0xB8

	public float StormFactor
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	private static SnowFlakes() { }

	public SnowFlakes() { }

	private MeshRenderer AddObject(int particlesCount, Material material, string caption) { }

	private ComputeBuffer CreateComputeBufferWithData(List data, int tailReserveCount) { }

	[CompilerGenerated]
	public float get_StormFactor() { }

	[CompilerGenerated]
	public void set_StormFactor(float value) { }

	private void SetFlakesSize() { }

	private void SetShaderValues() { }

	private void SetShaderValues(Material material, float sideSpeed, float rainDensity) { }

	private void Start() { }

	private void Update() { }

	private void UpdateLightProperties(ref List props) { }

}

