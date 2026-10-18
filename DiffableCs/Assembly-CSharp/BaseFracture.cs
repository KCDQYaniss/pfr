//Type is in global namespace

public abstract class BaseFracture : MonoBehaviour
{
	protected static readonly Vector4[] InitPlanes; //Field offset: 0x0
	[SerializeField]
	private bool _immediate; //Field offset: 0x20
	[SerializeField]
	protected RangedInt Shards; //Field offset: 0x28
	[SerializeField]
	protected int ShardsPerFrame; //Field offset: 0x30
	protected List FinishedShards; //Field offset: 0x38
	protected Vector3 MaxBounds; //Field offset: 0x40
	protected Vector3 MinBounds; //Field offset: 0x4C
	protected Vector3[] NewVertices; //Field offset: 0x58
	protected Vector2[] NewUVs; //Field offset: 0x60
	protected int[] NewTriangles; //Field offset: 0x68
	protected List Vertices; //Field offset: 0x70
	protected List PlaneIndices; //Field offset: 0x78
	protected readonly List Planes; //Field offset: 0x80
	[CompilerGenerated]
	private bool <Complete>k__BackingField; //Field offset: 0x88

	private bool Complete
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	internal List FinalShards
	{
		internal get { } //Length: 5
	}

	private static BaseFracture() { }

	protected BaseFracture() { }

	protected void BeginFracture(Vector3 point, float size = 0.5) { }

	protected void CreateShardMesh(Vector3 point) { }

	public void Destroy(Vector3 point, float force) { }

	protected void FinalizeDestruction() { }

	[CompilerGenerated]
	private bool get_Complete() { }

	internal List get_FinalShards() { }

	protected void GetVerticesInPlane() { }

	protected abstract void ImmediateFracture(Vector3[] points) { }

	protected void InitializeDestruction() { }

	[CompilerGenerated]
	private void set_Complete(bool value) { }

	protected abstract IEnumerator SpreadFracture(Vector3[] points) { }

}

