namespace ChartAndGraph;

public class DoubleVector4
{
	public double x; //Field offset: 0x10
	public double y; //Field offset: 0x18
	public double z; //Field offset: 0x20
	public double w; //Field offset: 0x28

	public DoubleVector4(double _x, double _y, double _z, double _w) { }

	public DoubleVector3 ToDoubleVector3() { }

	public Vector3 ToVector3() { }

	public Vector4 ToVector4() { }

}

