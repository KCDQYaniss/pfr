namespace Coffee.UISoftMaskInternal;

[Extension]
internal static class CanvasExtensions
{

	[Extension]
	public static void GetViewProjectionMatrix(Canvas canvas, out Matrix4x4 vpMatrix) { }

	[Extension]
	public static void GetViewProjectionMatrix(Canvas canvas, MonoOrStereoscopicEye eye, out Matrix4x4 vpMatrix) { }

	[Extension]
	public static void GetViewProjectionMatrix(Canvas canvas, out Matrix4x4 vMatrix, out Matrix4x4 pMatrix) { }

	[Extension]
	public static void GetViewProjectionMatrix(Canvas canvas, MonoOrStereoscopicEye eye, out Matrix4x4 vMatrix, out Matrix4x4 pMatrix) { }

	[Extension]
	public static bool IsStereoCanvas(Canvas canvas) { }

	[Extension]
	public static bool ShouldGammaToLinearInMesh(Canvas canvas) { }

	[Extension]
	public static bool ShouldGammaToLinearInShader(Canvas canvas) { }

}

