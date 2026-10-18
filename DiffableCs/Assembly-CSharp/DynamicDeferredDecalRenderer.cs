//Type is in global namespace

public class DynamicDeferredDecalRenderer : MonoBehaviour
{
	private static readonly int _uvStartEnd; //Field offset: 0x0
	[CompilerGenerated]
	private Material <DecalMaterial>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Transform <TransformHelper>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GameObject <GameObjectHelper>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <CullingGroupSphereIndex>k__BackingField; //Field offset: 0x38
	private Action _onColliderDestroy; //Field offset: 0x40

	public private int CullingGroupSphereIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Material DecalMaterial
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public GameObject GameObjectHelper
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Matrix4x4 ModelMatrix
	{
		 get { } //Length: 238
	}

	public Vector3 Position
	{
		 get { } //Length: 204
	}

	public Transform TransformHelper
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private static DynamicDeferredDecalRenderer() { }

	public DynamicDeferredDecalRenderer() { }

	[CompilerGenerated]
	public int get_CullingGroupSphereIndex() { }

	[CompilerGenerated]
	public Material get_DecalMaterial() { }

	[CompilerGenerated]
	public GameObject get_GameObjectHelper() { }

	public Matrix4x4 get_ModelMatrix() { }

	public Vector3 get_Position() { }

	[CompilerGenerated]
	public Transform get_TransformHelper() { }

	public void Init(Material mat, Mesh mesh, Vector3 projectionDirection, Vector4 uvStartEnd, bool tiled, int cullingGroupIndex) { }

	public bool ManualUpdate() { }

	[CompilerGenerated]
	private void set_CullingGroupSphereIndex(int value) { }

	[CompilerGenerated]
	private void set_DecalMaterial(Material value) { }

	[CompilerGenerated]
	public void set_GameObjectHelper(GameObject value) { }

	[CompilerGenerated]
	public void set_TransformHelper(Transform value) { }

}

