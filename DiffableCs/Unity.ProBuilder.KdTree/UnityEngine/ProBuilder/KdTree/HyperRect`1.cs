namespace UnityEngine.ProBuilder.KdTree;

internal struct HyperRect`1
{
	private T[] minPoint; //Field offset: 0x0
	private T[] maxPoint; //Field offset: 0x0

	public T[] MaxPoint
	{
		 get { } //Length: 5
		 set { } //Length: 210
	}

	public T[] MinPoint
	{
		 get { } //Length: 4
		 set { } //Length: 209
	}

	public HyperRect Clone() { }

	public T[] get_MaxPoint() { }

	public T[] get_MinPoint() { }

	public T[] GetClosestPoint(T[] toPoint, ITypeMath math) { }

	public static HyperRect Infinite(int dimensions, ITypeMath math) { }

	public void set_MaxPoint(T[] value) { }

	public void set_MinPoint(T[] value) { }

}

