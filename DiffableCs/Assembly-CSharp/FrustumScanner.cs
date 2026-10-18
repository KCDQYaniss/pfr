//Type is in global namespace

public static class FrustumScanner
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetAllRenderersInFrustum>b__1_0(RendererInfo renderer1, RendererInfo renderer2) { }

	}

	private struct RendererInfo
	{
		public Renderer renderer; //Field offset: 0x0
		public float distance; //Field offset: 0x8

	}


	private static List GetAllRenderersInFrustum(Vector3 cameraPosition, float maxDistance) { }

	public static void PrintAllRenderersInFrustum(Vector3 cameraPosition, float maxDistance) { }

	public static void SaveAllRenderersInFrustum(string path, Vector3 cameraPosition, float maxDistance) { }

	public static string StringOfAllRenderersInFrustum(Vector3 cameraPosition, float maxDistance) { }

}

