//Type is in global namespace

public class DepthPhotograper : MonoBehaviour
{
	private static DepthPhotograper _instance; //Field offset: 0x0
	private const float MaxRaycastDistance = 100; //Field offset: 0x0
	private static readonly int _start; //Field offset: 0x8
	private static readonly int _mapScale; //Field offset: 0xC
	private static readonly int _weatherDepthMap; //Field offset: 0x10
	[SerializeField]
	private PowOfTwoDimensions _depthTextureDimension; //Field offset: 0x20
	[SerializeField]
	private float _yBias; //Field offset: 0x24
	private float _radius; //Field offset: 0x28
	private float _diameter; //Field offset: 0x2C
	private Vector3 _mapStart; //Field offset: 0x30
	private Camera _depthCamera; //Field offset: 0x40
	private Material _blackMaterial; //Field offset: 0x48
	[SerializeField]
	private RenderTexture _depthRT; //Field offset: 0x50
	private RenderTexture _cameraRT; //Field offset: 0x58
	private int _terrainLayer; //Field offset: 0x60
	private CustomSampler _debug; //Field offset: 0x68
	private Bounds _rainBounds; //Field offset: 0x70

	public static DepthPhotograper Instance
	{
		 get { } //Length: 83
	}

	private float MaxBoundSize
	{
		private get { } //Length: 156
	}

	private static DepthPhotograper() { }

	public DepthPhotograper() { }

	public bool CheckIfCameraUnderRain(Transform cameraTransform) { }

	private void CreateDepthRT() { }

	public static DepthPhotograper get_Instance() { }

	private float get_MaxBoundSize() { }

	private void OnDestroy() { }

	[ContextMenu("Render")]
	public void Render() { }

	private void RenderObstacles() { }

	private void SetShaderValues() { }

	private void SetupDepthCamera() { }

	public void Start() { }

}

