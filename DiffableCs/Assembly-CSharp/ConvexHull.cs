//Type is in global namespace

public class ConvexHull : MonoBehaviour
{
	private static List _validFaces; //Field offset: 0x0
	private static List _visibleFaces; //Field offset: 0x8
	private static List _tmpFaces; //Field offset: 0x10

	public ConvexHull() { }

	private static Vector3 Centroid(Vector3[] points, int index, Face face) { }

	public static int[] ComputeIncremental(Vector3[] points) { }

}

