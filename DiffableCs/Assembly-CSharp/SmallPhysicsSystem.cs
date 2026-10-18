//Type is in global namespace

public class SmallPhysicsSystem : MonoBehaviour
{
	private const float UPDATE_DELTA_TIMES = 0.2; //Field offset: 0x0
	private const float MIN_DISTANCE_TO_PLAYER = 5; //Field offset: 0x0
	private static SmallPhysicsSystem _instance; //Field offset: 0x0
	private static bool _onApplicationQuiting; //Field offset: 0x8
	private static object _lock; //Field offset: 0x10
	private List _smallPhysicsObjects; //Field offset: 0x20
	private float _lastTime; //Field offset: 0x28
	private int _frames; //Field offset: 0x2C
	private float _fps; //Field offset: 0x30
	private float _maxUpdateObjects; //Field offset: 0x34
	private float _minSqrDistance; //Field offset: 0x38
	private int _index; //Field offset: 0x3C

	public static SmallPhysicsSystem Instance
	{
		 get { } //Length: 880
	}

	private static SmallPhysicsSystem() { }

	public SmallPhysicsSystem() { }

	public void AddObject(SmallPhysicsObject smallPhysicsObject) { }

	private void Awake() { }

	public static SmallPhysicsSystem get_Instance() { }

	public void OnApplicationQuit() { }

	public void RemoveObject(SmallPhysicsObject smallPhysicsObject) { }

	private void Update() { }

}

