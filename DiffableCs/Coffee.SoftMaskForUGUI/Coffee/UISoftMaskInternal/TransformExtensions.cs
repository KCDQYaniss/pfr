namespace Coffee.UISoftMaskInternal;

[Extension]
internal static class TransformExtensions
{
	private const float k_DefaultEpsilon = 0.1; //Field offset: 0x0
	private static readonly Vector3[] s_Corners; //Field offset: 0x0

	private static TransformExtensions() { }

	private static bool Approximately(Matrix4x4 self, Matrix4x4 other, float epsilon = 0.1) { }

	[Extension]
	public static int CompareHierarchyIndex(Transform self, Transform other, Transform stopAt) { }

	[Extension]
	public static Bounds GetRelativeBounds(Transform self, Transform child) { }

	[Extension]
	private static List GetTransforms(Transform self, Transform stopAt, List results) { }

	[Extension]
	public static bool HasChanged(Transform self, ref Matrix4x4 prev, float epsilon = 0.1) { }

	[Extension]
	public static bool HasChanged(Transform self, Transform baseTransform, ref Matrix4x4 prev, float epsilon = 0.1) { }

}

