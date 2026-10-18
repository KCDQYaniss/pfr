namespace Coffee.UISoftMaskInternal;

internal static class RenderTextureRepository
{
	private static readonly ObjectRepository s_Repository; //Field offset: 0x0
	private static readonly GraphicsFormat s_StencilFormat; //Field offset: 0x8

	public static int count
	{
		 get { } //Length: 125
	}

	private static RenderTextureRepository() { }

	public static void Get(Hash128 hash, ref RenderTexture rt, Func onCreate, T source) { }

	public static int get_count() { }

	public static RenderTextureDescriptor GetDescriptor(Vector2Int size, bool useStencil, RenderTextureFormat format = 0) { }

	public static Vector2Int GetPreferSize(Vector2Int size, int downSamplingRate) { }

	public static Vector2Int GetScreenSize(int downSamplingRate) { }

	public static Vector2Int GetScreenSize() { }

	public static void Release(ref RenderTexture rt) { }

	public static bool Valid(Hash128 hash, RenderTexture rt) { }

}

