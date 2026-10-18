namespace Coffee.UISoftMaskInternal;

[Extension]
internal static class GraphicExtensions
{
	private static readonly Vector3[] s_WorldCorners; //Field offset: 0x0
	private static readonly Bounds s_ScreenBounds; //Field offset: 0x8

	private static GraphicExtensions() { }

	[Extension]
	public static Texture GetActualMainTexture(Graphic self) { }

	[Extension]
	public static Material GetMaterialForRendering(Graphic self) { }

	[Extension]
	public static void GetMaterialsForRendering(Graphic self, List result) { }

	[Extension]
	public static float GetParentGroupAlpha(Graphic self) { }

	private static Vector2Int GetScreenSize() { }

	[Extension]
	public static bool IsInScreen(Graphic self) { }

}

