namespace ChartAndGraph;

public struct MaterialTiling
{
	public bool EnableTiling; //Field offset: 0x0
	public float TileFactor; //Field offset: 0x4

	public MaterialTiling(bool enable, float value) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

