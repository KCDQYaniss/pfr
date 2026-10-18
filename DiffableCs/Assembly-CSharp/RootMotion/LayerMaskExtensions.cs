namespace RootMotion;

[Extension]
public static class LayerMaskExtensions
{

	[Extension]
	public static LayerMask AddToMask(LayerMask original, string[] layerNames) { }

	public static bool Contains(LayerMask mask, int layer) { }

	public static LayerMask Create(string[] layerNames) { }

	public static LayerMask Create(int[] layerNumbers) { }

	public static LayerMask GetAllCollisionsLayerMask(string layerCollision) { }

	public static LayerMask GetAllCollisionsLayerMask(int layerCollision) { }

	public static void IgnoreLayerCollision(int someLayer, LayerMask layersMask, bool ignore = true) { }

	[Extension]
	public static LayerMask Inverse(LayerMask original) { }

	public static LayerMask LayerNumbersToMask(int[] layerNumbers) { }

	[Extension]
	public static string[] MaskToNames(LayerMask original) { }

	[Extension]
	public static int[] MaskToNumbers(LayerMask original) { }

	[Extension]
	public static string MaskToString(LayerMask original) { }

	[Extension]
	public static string MaskToString(LayerMask original, string delimiter) { }

	public static LayerMask NamesToMask(string[] layerNames) { }

	[Extension]
	public static LayerMask RemoveFromMask(LayerMask original, string[] layerNames) { }

}

