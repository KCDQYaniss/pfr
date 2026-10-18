//Type is in global namespace

public sealed class ConcaveBorder
{
	private readonly Vector2[] _points; //Field offset: 0x10

	private ConcaveBorder(Vector2[] points) { }

	public bool Contains(float x, float z) { }

	internal static ConcaveBorder Create(Vector2[] points) { }

	public bool Intersects(Bounds bounds) { }

	private static bool LineSegmentIntersects(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4) { }

}

