namespace ChartAndGraph;

public class ChartOrientedSize
{
	public float Breadth; //Field offset: 0x10
	public float Depth; //Field offset: 0x14

	public ChartOrientedSize() { }

	public ChartOrientedSize(float breadth) { }

	public ChartOrientedSize(float breadth, float depth) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

