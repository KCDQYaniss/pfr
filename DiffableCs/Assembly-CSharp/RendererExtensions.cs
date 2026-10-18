//Type is in global namespace

[Extension]
public static class RendererExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Bounds bounds; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <IsFullyVisibleByCamera>b__0(Plane plane) { }

	}

	private const int Z_POSITION = -3; //Field offset: 0x0
	private const float STEP = 0.15; //Field offset: 0x0
	private static readonly Dictionary _cachedPositions; //Field offset: 0x0

	private static RendererExtensions() { }

	public static void BlitOrCopy(RenderTexture scr, RenderTexture dst) { }

	public static void BlitOrCopy(CommandBuffer cmdBuf, RenderTexture scr, RenderTexture dst) { }

	[Extension]
	public static void ClearTexture(RenderTexture tex) { }

	[Extension]
	public static bool ContainsPoint(BoxCollider box, Vector3 point) { }

	[Extension]
	public static bool ContainsPointConsiderCenter(BoxCollider box, Vector3 point) { }

	private static IEnumerable GetAllBoundsPoints(Bounds bounds) { }

	[Extension]
	public static bool IsFullyVisibleByCamera(Camera camera, Bounds bounds) { }

	[Extension]
	public static bool IsVisibleFrom(Renderer renderer, Camera camera) { }

	[Extension]
	public static void PlaceInClosestPosition(Camera camera, Bounds bounds, string itemTemplateId, Nullable clampPosition = null) { }

}

