namespace UnityEngine.ProBuilder.Poly2Tri;

internal class PolygonSet
{
	protected List _polygons; //Field offset: 0x10

	public IEnumerable Polygons
	{
		 get { } //Length: 5
	}

	public PolygonSet() { }

	public PolygonSet(Polygon poly) { }

	public void Add(Polygon p) { }

	public IEnumerable get_Polygons() { }

}

