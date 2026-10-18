namespace ChartAndGraph;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class BoxPathGenerator : SmoothPathGenerator
{
	[Range(0, 10)]
	public float HeightRatio; //Field offset: 0x50
	private List mTmpTringle; //Field offset: 0x58
	private List mTmpUv; //Field offset: 0x60
	private List mVertices; //Field offset: 0x68

	public BoxPathGenerator() { }

	private void AddTringles(List tringles, int from, int to) { }

	public virtual void Generator(Vector3[] path, float thickness, bool closed) { }

	private int WriteBox(float thickness, Quaternion rotation, Vector3 center, float u) { }

}

