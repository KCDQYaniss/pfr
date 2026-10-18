namespace Coffee.UISoftMaskInternal;

[Extension]
internal static class TransformExtensionsForTransformSensitivity
{
	private const float k_DefaultEpsilon = 0.1; //Field offset: 0x0

	private static bool Approximately(Matrix4x4 self, Matrix4x4 other, float epsilon = 0.1) { }

	private static float Convert(TransformSensitivity self) { }

	[Extension]
	public static bool HasChanged(Transform self, ref Matrix4x4 prev, TransformSensitivity sensitivity) { }

	[Extension]
	public static bool HasChanged(Transform self, Transform baseTransform, ref Matrix4x4 prev, TransformSensitivity sensitivity) { }

	[Extension]
	private static bool HasChanged_Internal(Transform self, Transform baseTransform, ref Matrix4x4 prev, float epsilon) { }

}

