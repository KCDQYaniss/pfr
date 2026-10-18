namespace Systems.Effects;

public class LightPool
{
	private class LightStruct
	{
		public Light LightScript; //Field offset: 0x10
		public GameObject LightObject; //Field offset: 0x18
		public Transform LightTransform; //Field offset: 0x20
		public float DeathTime; //Field offset: 0x28
		public float RangeFallof; //Field offset: 0x2C
		public float IntensityFallof; //Field offset: 0x30

		public LightStruct() { }

		public void Start(float time, float range, float intensity, Vector3 position, Color color, bool shadows = false) { }

		public void Update(float deltaTime) { }

	}

	private const int MAX_FREE_LIGHTS = 100; //Field offset: 0x0
	private const float DEFAULT_RANGE = 1.5; //Field offset: 0x0
	private const float DEFAULT_LIFE_TIME = 0.1; //Field offset: 0x0
	private const float DEFAULT_INTENSITY = 5; //Field offset: 0x0
	private GameObject _lightParent; //Field offset: 0x10
	private LinkedList _free; //Field offset: 0x18
	private LinkedList _used; //Field offset: 0x20

	public LightPool() { }

	public void Add(Vector3 position, Color color, float range = 1.5, float intensity = 5, float time = 0.1, bool shadows = false) { }

	private LightStruct CreateLightStruct() { }

	private GameObject CreateOrGetLightParent() { }

	public void Destroy() { }

	private void FillFreeLights() { }

	public void Init() { }

	public void Update() { }

}

