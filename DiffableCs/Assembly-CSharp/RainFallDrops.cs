//Type is in global namespace

public sealed class RainFallDrops : MonoBehaviour
{
	private static readonly int _alphaMult; //Field offset: 0x0
	private const int MaxCount = 16383; //Field offset: 0x0
	private static readonly int _fallingVector; //Field offset: 0x4
	private static readonly int _intensity1; //Field offset: 0x8
	private static readonly int _sideSpeed; //Field offset: 0xC
	private static readonly int _rainDensity; //Field offset: 0x10
	private static readonly int _size; //Field offset: 0x14
	private static readonly int _minAmbient; //Field offset: 0x18
	[Range(0, 1)]
	[SerializeField]
	private float _intensity; //Field offset: 0x20
	[Range(0, 1)]
	[SerializeField]
	private float _intensityThreshold; //Field offset: 0x24
	[Range(128, 16383)]
	public int Count; //Field offset: 0x28
	public Vector2 MinSize; //Field offset: 0x2C
	public Vector2 MaxSize; //Field offset: 0x34
	[MinMaxVec2(0, 1, -1)]
	public Vector2 MinMaxSideSpeed; //Field offset: 0x3C
	[MinMaxVec2(0, 2, -1)]
	public Vector2 MinMaxDensity; //Field offset: 0x44
	[SerializeField]
	private Material _close; //Field offset: 0x50
	[Range(0, 1)]
	[SerializeField]
	public float DropsAlphaClose; //Field offset: 0x58
	[Range(0, 1)]
	[SerializeField]
	public float MinAmbient; //Field offset: 0x5C
	[Range(0, 1)]
	[SerializeField]
	public float MinAmbientAddition; //Field offset: 0x60
	[Range(0, 1)]
	[SerializeField]
	public float MinAmbientAdditionCoef; //Field offset: 0x64
	public float SideSpeed; //Field offset: 0x68
	private MeshRenderer _rainRenderer; //Field offset: 0x70
	private GameObject _rainfallObject; //Field offset: 0x78
	private Material _closeCopy; //Field offset: 0x80

	public float Intensity
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public GameObject RainfallObject
	{
		 get { } //Length: 5
	}

	private static RainFallDrops() { }

	public RainFallDrops() { }

	private MeshRenderer AddObject(int particlesCount, Material material) { }

	public float get_Intensity() { }

	public GameObject get_RainfallObject() { }

	private static Mesh GetMesh(int count) { }

	public void Init() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnScreenChange() { }

	public void set_Intensity(float value) { }

	private void SetShaderValues() { }

	private void Update() { }

}

