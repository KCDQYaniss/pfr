//Type is in global namespace

public static class ZigZagWayBuilder
{
	private const float SDIST_TOO_CLOSE = 0.001; //Field offset: 0x0
	private static readonly NavMeshPath _cachePath; //Field offset: 0x0

	private static ZigZagWayBuilder() { }

	private static bool CheckOnHaveWayFrom(List allModifWay, Vector3 c1) { }

	private static List GetDefinedPath(Vector3[] corners, float stepLength) { }

	public static bool ModifyZigZagAllSteps(Vector3[] corners, float offsetLength, float sideOffset, out List modifedWay) { }

	public static bool ModifyZigZagPercentOffset(Vector3[] corners, float offsetLength, float chance, float maxStepDistToOffset, float percentToSideOffset, out List modifedWay) { }

	private static bool TestSidePoint(Vector3 p1, Vector3 p3, List collectedPath, ref int debugIndex, Vector3 possibleTestPoint) { }

	private static bool TestWayOnSamePoints(Vector3[] path1, Vector3[] path2) { }

	private static bool TryPath(Vector3 from, Vector3 to, out Vector3[] path) { }

	private static bool TryStep(float sideOffset, Vector3 p1, Vector3 p2, Vector3 p3, SideTurn turnSide, List collectedPath, ref int debugIndex) { }

	private static bool TryStep2(float maxDist, Vector3 p1, Vector3 p2, Vector3 p3, float chance100, float percentToSideOffset, SideTurn turnSide, List collectedPath, ref int debugIndex) { }

}

