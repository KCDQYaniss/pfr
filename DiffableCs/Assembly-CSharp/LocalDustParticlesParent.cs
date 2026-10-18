//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class LocalDustParticlesParent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GenerateMesh>b__13_0(LocalDustParticles ldp) { }

	}

	private static Vector2 _size; //Field offset: 0x0
	private static readonly int _selfTime; //Field offset: 0x8
	public LocalDustParticles[] Childs; //Field offset: 0x20
	public float TimeSpeed; //Field offset: 0x28
	public float Size; //Field offset: 0x2C
	public int QuadTileSetSide; //Field offset: 0x30
	public float UvTilePadding; //Field offset: 0x34
	private Material _material; //Field offset: 0x38
	private Vector3 _time; //Field offset: 0x40
	public bool Regenerate; //Field offset: 0x4C
	private Mesh _mesh; //Field offset: 0x50
	private float _editorLastTime; //Field offset: 0x58

	private static LocalDustParticlesParent() { }

	public LocalDustParticlesParent() { }

	private void Awake() { }

	private static Texture3D Built(Texture2D[] textures) { }

	private void ClampValues() { }

	public void GenerateMesh() { }

	private static void GetPlane(int i, int[] triangles, Vector3[] positions, Vector2[] uv0, Vector2[] uv1, Vector4[] tangents, Color32[] colors, Matrix4x4 matrix, float sideSpeed, Vector2[][] uvs, Vector2[][] shifts, Color32[] rndColors) { }

	private static Color32[] GetRandomColors(Color color, int count, float randomnessAlpha) { }

	private static Vector2[][] GetRotatedShifts(Vector2 size, int steps, float randomnessSize) { }

	private static Texture2D[] GetTextures(Texture3D tex) { }

	private static Vector2[][] GetTileUv(int width, int heigth, float padding = 0) { }

	private void OnDestroy() { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	private void OnValidate() { }

	private static void Qweqwe(Texture2D[] textures, int width, int height) { }

	private static T[] Remove(T[] array, Func needToRemove) { }

	private static Texture2D ResizeTex(Texture2D tex, int width, int height, float xScale, float yScale, float xOffset, float yOffset) { }

	private void Update() { }

}

