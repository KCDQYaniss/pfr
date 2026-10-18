namespace ChartAndGraph;

public class PathMultiplier
{
	public int JointSmoothing; //Field offset: 0x10
	public float JointSize; //Field offset: 0x14
	private readonly List _innerTmpCenters; //Field offset: 0x18
	protected List TmpCenters; //Field offset: 0x20
	protected List MultipliedPath; //Field offset: 0x28

	public PathMultiplier() { }

	private void AddCenters(Vector3 translation, float scale) { }

	private void AddJointSegments(Vector3 from, Vector3 curr, Vector3 to) { }

	public void ApplyToMesh(WorldSpaceChartMesh mesh) { }

	protected Quaternion LookRotation(Vector3 diff) { }

	public void ModifyPath(Vector3[] path, bool closed) { }

	public void MultiplyPath(Vector3[] paths) { }

}

