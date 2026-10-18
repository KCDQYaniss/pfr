namespace CW2;

public static class AdditiveMeshBakeManager
{
	private class MeshData
	{
		public Vector3[] Vertices; //Field offset: 0x10
		public Vector2[] Uv; //Field offset: 0x18
		public Vector4[] Tangents; //Field offset: 0x20
		public Vector3[] Normals; //Field offset: 0x28
		public int[] Triangles; //Field offset: 0x30

		public MeshData() { }

	}

	private static Dictionary _meshDict; //Field offset: 0x0
	private static Dictionary _cachedMeshData; //Field offset: 0x8

	private static AdditiveMeshBakeManager() { }

	public static void Add(GameObject obj, bool saveCollider, bool dontDesttroyComponents = true) { }

	private static Mesh CreateGameObject(Renderer renderer) { }

	private static void DestroyComponents(GameObject obj, bool saveCollider) { }

	private static void DisableGameObject(GameObject obj, bool saveCollider) { }

	private static void GenerateMesh(Mesh commonMesh, Mesh meshToBake, Matrix4x4 modelMatrix, MeshData meshData) { }

	public static void Reset() { }

}

