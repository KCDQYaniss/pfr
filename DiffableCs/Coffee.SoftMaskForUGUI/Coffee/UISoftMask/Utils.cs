namespace Coffee.UISoftMask;

internal static class Utils
{

	public static bool AlphaHitTestValid(Graphic src, Vector2 sp, Camera eventCamera, float threshold) { }

	private static bool AlphaHitTestValid(Image src, Vector2 sp, Camera eventCamera, float threshold) { }

	private static bool AlphaHitTestValid(RawImage src, Vector2 sp, Camera eventCamera, float threshold) { }

	public static int GetHighestBit(int i) { }

	public static int GetStencilBits(Transform transform, bool includeSelf, bool useStencil, out Mask nearestMask, out SoftMask nearestSoftMask) { }

	public static void UpdateAntiAlias(Graphic graphic, bool enabled, float threshold) { }

}

