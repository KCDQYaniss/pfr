namespace ChartAndGraph;

[RequireComponent(typeof(LineRenderer))]
public class LineRendererPathGenerator : PathGenerator
{
	private LineRenderer _lineRenderer; //Field offset: 0x20

	public LineRendererPathGenerator() { }

	public virtual void Clear() { }

	public void EnsureRenderer() { }

	public virtual void Generator(Vector3[] path, float thickness, bool closed) { }

}

