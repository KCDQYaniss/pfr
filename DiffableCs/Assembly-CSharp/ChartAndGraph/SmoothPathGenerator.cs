namespace ChartAndGraph;

public abstract class SmoothPathGenerator : PathGenerator
{
	public int JointSmoothing; //Field offset: 0x20
	public float JointSize; //Field offset: 0x24
	protected List SkipJoints; //Field offset: 0x28
	private readonly List _innerTmpCenters; //Field offset: 0x30
	protected List TmpCenters; //Field offset: 0x38
	private MeshFilter _meshFilter; //Field offset: 0x40
	private Mesh _cleanMesh; //Field offset: 0x48

	protected override float JointSizeLink
	{
		 get { } //Length: 6
	}

	protected override int JointSmoothingLink
	{
		 get { } //Length: 4
	}

	protected SmoothPathGenerator() { }

	private void AddJointSegments(Vector3 from, Vector3 curr, Vector3 to) { }

	public virtual void Clear() { }

	protected bool EnsureMeshFilter() { }

	protected override float get_JointSizeLink() { }

	protected override int get_JointSmoothingLink() { }

	protected Quaternion LookRotation(Vector3 diff) { }

	protected void ModifyPath(Vector3[] path, bool closed, List res) { }

	protected void ModifyPath(Vector3[] path, bool closed) { }

	public void OnDestroy() { }

	public void SetMesh(Mesh mesh) { }

}

