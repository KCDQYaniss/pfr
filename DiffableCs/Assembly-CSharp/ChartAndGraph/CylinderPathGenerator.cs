namespace ChartAndGraph;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class CylinderPathGenerator : SmoothPathGenerator
{
	public int CircleVertices; //Field offset: 0x50
	[Range(0.01, 10)]
	public float HeightRatio; //Field offset: 0x54
	private Vector3[] mCircleTemp; //Field offset: 0x58
	private Vector3[] mCurrentCircle; //Field offset: 0x60
	private List mTmpTringle; //Field offset: 0x68
	private List mTmpUv; //Field offset: 0x70
	private List mVertices; //Field offset: 0x78

	public CylinderPathGenerator() { }

	private void AddTringles(List tringles, int from, int to) { }

	private void EnsureCirlce() { }

	public virtual void Generator(Vector3[] path, float thickness, bool closed) { }

	private int WriteCircle(float thickness, Quaternion angle, Vector3 center, float u) { }

}

