namespace UnityEngine.ProBuilder.Poly2Tri;

internal class Polygon : Triangulatable
{
	protected List _points; //Field offset: 0x10
	protected List _steinerPoints; //Field offset: 0x18
	protected List _holes; //Field offset: 0x20
	protected List _triangles; //Field offset: 0x28
	protected PolygonPoint _last; //Field offset: 0x30

	public IList Holes
	{
		 get { } //Length: 5
	}

	public override IList Points
	{
		 get { } //Length: 5
	}

	public override IList Triangles
	{
		 get { } //Length: 5
	}

	public override TriangulationMode TriangulationMode
	{
		 get { } //Length: 6
	}

	public Polygon(IList points) { }

	public Polygon(IEnumerable points) { }

	public Polygon(PolygonPoint[] points) { }

	public void AddHole(Polygon poly) { }

	public void AddPoint(PolygonPoint p) { }

	public void AddPoints(IEnumerable list) { }

	public void AddSteinerPoint(TriangulationPoint point) { }

	public void AddSteinerPoints(List points) { }

	public override void AddTriangle(DelaunayTriangle t) { }

	public override void AddTriangles(IEnumerable list) { }

	public void ClearSteinerPoints() { }

	public override void ClearTriangles() { }

	public IList get_Holes() { }

	public override IList get_Points() { }

	public override IList get_Triangles() { }

	public override TriangulationMode get_TriangulationMode() { }

	public void InsertPointAfter(PolygonPoint point, PolygonPoint newPoint) { }

	public override void Prepare(TriangulationContext tcx) { }

	public void RemovePoint(PolygonPoint p) { }

}

