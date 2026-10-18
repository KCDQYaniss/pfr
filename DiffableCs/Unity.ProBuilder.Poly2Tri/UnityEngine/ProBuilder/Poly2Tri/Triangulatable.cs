namespace UnityEngine.ProBuilder.Poly2Tri;

internal interface Triangulatable
{

	public IList Points
	{
		 get { } //Length: 0
	}

	public IList Triangles
	{
		 get { } //Length: 0
	}

	public TriangulationMode TriangulationMode
	{
		 get { } //Length: 0
	}

	public void AddTriangle(DelaunayTriangle t) { }

	public void AddTriangles(IEnumerable list) { }

	public void ClearTriangles() { }

	public IList get_Points() { }

	public IList get_Triangles() { }

	public TriangulationMode get_TriangulationMode() { }

	public void Prepare(TriangulationContext tcx) { }

}

