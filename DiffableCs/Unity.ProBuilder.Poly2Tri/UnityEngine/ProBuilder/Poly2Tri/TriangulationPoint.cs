namespace UnityEngine.ProBuilder.Poly2Tri;

internal class TriangulationPoint
{
	public const int INSERTED_INDEX = -1; //Field offset: 0x0
	public const int INVALID_INDEX = -2; //Field offset: 0x0
	[CompilerGenerated]
	private List <Edges>k__BackingField; //Field offset: 0x10
	public double X; //Field offset: 0x18
	public double Y; //Field offset: 0x20
	public int Index; //Field offset: 0x28

	public private List Edges
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool HasEdges
	{
		 get { } //Length: 9
	}

	public float Xf
	{
		 get { } //Length: 10
		 set { } //Length: 13
	}

	public float Yf
	{
		 get { } //Length: 10
		 set { } //Length: 13
	}

	public TriangulationPoint(double x, double y, int index = -1) { }

	public void AddEdge(DTSweepConstraint e) { }

	[CompilerGenerated]
	public List get_Edges() { }

	public bool get_HasEdges() { }

	public float get_Xf() { }

	public float get_Yf() { }

	[CompilerGenerated]
	private void set_Edges(List value) { }

	public void set_Xf(float value) { }

	public void set_Yf(float value) { }

	public virtual string ToString() { }

}

