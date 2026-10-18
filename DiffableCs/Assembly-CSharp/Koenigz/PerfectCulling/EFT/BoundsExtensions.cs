namespace Koenigz.PerfectCulling.EFT;

[Extension]
public static class BoundsExtensions
{

	[Extension]
	public static Bounds ClampInside(Bounds bounds, Bounds other) { }

	[Extension]
	public static bool Contains(Bounds bounds, Bounds target) { }

	[Extension]
	public static float GetPerimeter(Bounds bounds) { }

	[Extension]
	public static float GetSurfaceArea(Bounds box) { }

	[Extension]
	public static ValueTuple SplitBy8(Bounds original) { }

	[Extension]
	public static float Volume(Bounds bounds) { }

}

