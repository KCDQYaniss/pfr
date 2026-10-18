namespace AbsolutDecals;

public class DecalSystemUtils
{
	public static readonly Dictionary ProjcectionDirectionsDict; //Field offset: 0x0
	private const float DistanceTresholdSqr = 0.0001; //Field offset: 0x0

	private static DecalSystemUtils() { }

	public DecalSystemUtils() { }

	public static Vector3 CrossWithNormalization(Vector3 lhs1, Vector3 lhs2, Vector3 rhs1, Vector3 rhs2) { }

	private static List RemoveClosePointsBruteforce(List vertices) { }

	public static Mesh RemoveFromMesh(Vector2 startEndVerticies, Vector2 startEndTrigs, Mesh mesh) { }

	public static Vector3 ScaledVectorToWorld(Transform localSpace, Vector3 normal) { }

}

