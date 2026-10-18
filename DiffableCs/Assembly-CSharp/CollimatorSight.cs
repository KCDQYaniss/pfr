//Type is in global namespace

public class CollimatorSight : MonoBehaviour
{
	[CompilerGenerated]
	private static Action OnCollimatorEnabled; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnCollimatorDisabled; //Field offset: 0x8
	[CompilerGenerated]
	private static Action OnCollimatorUpdated; //Field offset: 0x10
	private static readonly Quaternion TransformLocalRotation; //Field offset: 0x18
	public MeshRenderer CollimatorMeshRenderer; //Field offset: 0x20
	public Material CollimatorMaterial; //Field offset: 0x28

	public static event Action OnCollimatorDisabled
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	public static event Action OnCollimatorEnabled
	{
		[CompilerGenerated]
		 add { } //Length: 347
		[CompilerGenerated]
		 remove { } //Length: 347
	}

	public static event Action OnCollimatorUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	private static CollimatorSight() { }

	public CollimatorSight() { }

	[CompilerGenerated]
	public static void add_OnCollimatorDisabled(Action value) { }

	[CompilerGenerated]
	public static void add_OnCollimatorEnabled(Action value) { }

	[CompilerGenerated]
	public static void add_OnCollimatorUpdated(Action value) { }

	private void Awake() { }

	public void LookAt(Vector3 point, Vector3 worldUp) { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public static void remove_OnCollimatorDisabled(Action value) { }

	[CompilerGenerated]
	public static void remove_OnCollimatorEnabled(Action value) { }

	[CompilerGenerated]
	public static void remove_OnCollimatorUpdated(Action value) { }

}

