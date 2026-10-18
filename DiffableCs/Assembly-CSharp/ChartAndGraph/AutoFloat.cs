namespace ChartAndGraph;

public struct AutoFloat
{
	public bool Automatic; //Field offset: 0x0
	public float Value; //Field offset: 0x4

	public AutoFloat(bool automatic, float value) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

