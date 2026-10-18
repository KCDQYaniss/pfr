namespace Koenigz.PerfectCulling;

public static class PerfectCullingMath
{

	public static Vector3 CalculateCellCount(Vector3 scale, Vector3 cellSize) { }

	public static int CalculateNumberOfCells(Vector3 scale, Vector3 cellSize) { }

	public static int FlattenXYZ(int x, int y, int z, Vector3 cellCount) { }

	public static int FlattenXYZDouble(int x, int y, int z, Vector3 cellCount) { }

	public static int GetIndexForWorldPos(Vector3 worldPos, Vector3 gridOrigin, Quaternion gridCurrentOrientation, Vector3 gridScale, Quaternion gridBakeOrientation, Vector3 cellCount, Vector3 cellSize, out bool isOutOfBounds) { }

	public static int GetIndexForWorldPosNoOrientation(Vector3 worldPos, Vector3 gridOrigin, Vector3 gridScale, Vector3 cellCount, Vector3 cellSize, out bool isOutOfBounds) { }

	public static bool IsXYZInBounds(int x, int y, int z, Vector3 cellCount) { }

	public static void UnflattenToXYZ(int index, out int x, out int y, out int z, Vector3 cellCount) { }

}

