//Type is in global namespace

[ExecuteInEditMode]
public class VoxelAmbientTest : MonoBehaviour
{
	private class Image
	{
		private int _pixelsX; //Field offset: 0x10
		private int _pixelsY; //Field offset: 0x14
		private int _pixelsZ; //Field offset: 0x18
		private int _heightWidthLayer; //Field offset: 0x1C

		public Image(int pixelsX, int pixelsY, int pixelsZ) { }

		public Color[] BlurImage(Color[] pixels, int size) { }

		public Color[] Downsample(Color[] pixels, int samples, out Image im) { }

		private void GetComp(int id, out int x, out int y, out int z) { }

		public Color[] GetDirected(float[] array, int[][] axes, Vector3[] vectors, float NormalContrast) { }

		private int GetID(int x, int y, int z) { }

		public float[] GetLight(bool[] obstacles, LinkedList lights, int[][] axes, float[] intensities) { }

		public bool[] GetObstacles(Transform gridPosition) { }

		public LinkedList GetSunLight(bool[] obstacles) { }

		public Texture3D GetTex(Color[] pixels) { }

	}

	private static readonly int _mainTex; //Field offset: 0x0
	public int PixelsX; //Field offset: 0x20
	public int PixelsY; //Field offset: 0x24
	public int PixelsZ; //Field offset: 0x28
	[Space]
	public int Upsample; //Field offset: 0x2C
	[Space]
	public float LightRange; //Field offset: 0x30
	public float NormalsContrast; //Field offset: 0x34
	public float WallLightness; //Field offset: 0x38
	[Space]
	public Transform GridPosition; //Field offset: 0x40
	public Material Material; //Field offset: 0x48
	public Texture3D Tex; //Field offset: 0x50
	public Vector4 DebugVec; //Field offset: 0x58
	public bool DebugDrawGrid; //Field offset: 0x68

	private static VoxelAmbientTest() { }

	public VoxelAmbientTest() { }

	private void GetArrays(float lightRange, out int[][] axes, out float[] intensities, out Vector3[] vectors) { }

	private bool[] GetGrid() { }

	private void OnDrawGizmosSelected() { }

	private void OnEnable() { }

	private void OnValidate() { }

}

