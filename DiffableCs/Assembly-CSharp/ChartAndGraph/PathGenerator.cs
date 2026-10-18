namespace ChartAndGraph;

public abstract class PathGenerator : MonoBehaviour
{

	protected PathGenerator() { }

	public abstract void Clear() { }

	public abstract void Generator(Vector3[] path, float thickness, bool closed) { }

}

