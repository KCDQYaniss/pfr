//Type is in global namespace

public class BoidController : MonoBehaviour
{
	internal static class BoidProperties
	{
		public static readonly int BP_boidsData; //Field offset: 0x0
		public static readonly int BP_bufferSize; //Field offset: 0x4
		public static readonly int BP_controllerTransform; //Field offset: 0x8
		public static readonly int BP_controllerVelocity; //Field offset: 0xC
		public static readonly int BP_controllerVelocityVariation; //Field offset: 0x10
		public static readonly int BP_controllerRotationCoeff; //Field offset: 0x14
		public static readonly int BP_controllerNeighborDist; //Field offset: 0x18
		public static readonly int BP_time; //Field offset: 0x1C
		public static readonly int BP_deltaTime; //Field offset: 0x20
		public static readonly int BP_noiseTexture; //Field offset: 0x24

		private static BoidProperties() { }

	}

	public int spawnCount; //Field offset: 0x20
	public float spawnRadius; //Field offset: 0x24
	[Range(0.1, 20)]
	public float velocity; //Field offset: 0x28
	[Range(0, 0.9)]
	public float velocityVariation; //Field offset: 0x2C
	[Range(0.1, 20)]
	public float rotationCoeff; //Field offset: 0x30
	[Range(0.1, 10)]
	public float neighborDist; //Field offset: 0x34
	private Matrix4x4[] _spawnArray; //Field offset: 0x38
	private Vector4[] _variationArray; //Field offset: 0x40
	public Transform centerTransform; //Field offset: 0x48
	public Texture2D noiseTexture; //Field offset: 0x50
	private GPUInstancerPrefabManager _prefabManager; //Field offset: 0x58
	private ComputeShader _gpuiBoidsCS; //Field offset: 0x60
	private string _variationBufferName; //Field offset: 0x68
	private float[] _centerTransformArray; //Field offset: 0x70
	private ComputeBuffer _transformDataBuffer; //Field offset: 0x78

	public BoidController() { }

	public void Spawn(int index) { }

	private void Start() { }

	private void Update() { }

}

