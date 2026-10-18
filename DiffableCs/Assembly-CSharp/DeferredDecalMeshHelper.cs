//Type is in global namespace

public class DeferredDecalMeshHelper : MonoBehaviour
{
	public const int VertsInCube = 24; //Field offset: 0x0
	public const int TrigsInCube = 36; //Field offset: 0x0
	public const int CubeSides = 6; //Field offset: 0x0

	public DeferredDecalMeshHelper() { }

	public static Vector4[] GenerateTangents(Vector4[] array, SingleDecal decal) { }

	public static void GenerateTrigs(int[] array) { }

	public static Vector3[] GenerateVerts(Vector3[] a, Vector3 position, Vector3 size, Vector3 right, Vector3 up, Vector3 fwd) { }

}

