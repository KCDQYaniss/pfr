namespace UnityEngine.ProBuilder;

internal static class Spline
{

	internal static ProBuilderMesh Extrude(IList points, float radius = 0.5, int columns = 32, int rows = 16, bool closeLoop = false, bool smooth = true) { }

	internal static void Extrude(IList bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ref ProBuilderMesh target) { }

	internal static void Extrude(IList points, float radius, int radiusRows, bool closeLoop, bool smooth, ref ProBuilderMesh target, IList pointRotations = null) { }

	internal static List GetControlPoints(IList bezierPoints, int subdivisionsPerSegment, bool closeLoop, List rotations) { }

	private static Quaternion GetRingRotation(IList points, int i, bool closeLoop, out float secant) { }

	private static Vector3[] VertexRing(Quaternion orientation, Vector3 offset, float radius, int segments) { }

}

