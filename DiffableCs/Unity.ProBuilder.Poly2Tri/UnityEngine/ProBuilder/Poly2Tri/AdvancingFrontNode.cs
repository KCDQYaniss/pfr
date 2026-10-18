namespace UnityEngine.ProBuilder.Poly2Tri;

internal class AdvancingFrontNode
{
	public AdvancingFrontNode Next; //Field offset: 0x10
	public AdvancingFrontNode Prev; //Field offset: 0x18
	public double Value; //Field offset: 0x20
	public TriangulationPoint Point; //Field offset: 0x28
	public DelaunayTriangle Triangle; //Field offset: 0x30

	public bool HasNext
	{
		 get { } //Length: 9
	}

	public bool HasPrev
	{
		 get { } //Length: 9
	}

	public AdvancingFrontNode(TriangulationPoint point) { }

	public bool get_HasNext() { }

	public bool get_HasPrev() { }

}

