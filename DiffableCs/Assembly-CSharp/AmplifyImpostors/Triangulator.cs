namespace AmplifyImpostors;

public class Triangulator
{
	private List m_points; //Field offset: 0x10

	public List Points
	{
		 get { } //Length: 5
	}

	public Triangulator(Vector2[] points) { }

	public Triangulator(Vector2[] points, bool invertY = true) { }

	private float Area() { }

	public List get_Points() { }

	private bool InsideTriangle(Vector2 pt, Vector2 v1, Vector2 v2, Vector2 v3) { }

	private bool Snip(int u, int v, int w, int n, int[] V) { }

	public int[] Triangulate() { }

}

