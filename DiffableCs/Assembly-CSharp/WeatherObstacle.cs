//Type is in global namespace

[DisallowMultipleComponent]
[ScriptOrder(-100)]
public sealed class WeatherObstacle : MonoBehaviour
{
	private static WeatherObstacle _instance; //Field offset: 0x0
	[CompilerGenerated]
	private MeshCollider <MeshCollider>k__BackingField; //Field offset: 0x20
	private Mesh mesh; //Field offset: 0x28

	public static WeatherObstacle Instance
	{
		 get { } //Length: 59
		 set { } //Length: 513
	}

	public private MeshCollider MeshCollider
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public WeatherObstacle() { }

	private void Awake() { }

	[ContextMenu("Combine")]
	public void Combine_Debug() { }

	private Mesh CombineMesh() { }

	private void DestroyAllChild() { }

	public static WeatherObstacle get_Instance() { }

	[CompilerGenerated]
	public MeshCollider get_MeshCollider() { }

	public void OnDestroy() { }

	public static void set_Instance(WeatherObstacle value) { }

	[CompilerGenerated]
	private void set_MeshCollider(MeshCollider value) { }

	private void Start() { }

}

