//Type is in global namespace

public class Shard : MonoBehaviour
{
	private MeshFilter meshFilter; //Field offset: 0x20
	private MeshCollider meshCollider; //Field offset: 0x28

	public Mesh Mesh
	{
		 get { } //Length: 90
	}

	public Shard() { }

	private void Awake() { }

	internal static Shard CreateShard(GameObject parent, Vector3[] newVertices, int[] newTriangles, Vector2[] newUVs) { }

	internal void FinalizeShard() { }

	private void FixMesh(Vector3[] verts, int[] tris, Vector2[] uvs) { }

	public Mesh get_Mesh() { }

}

