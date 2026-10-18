namespace EFT.Game.Spawning;

[Extension]
public static class GroundHelper
{
	private const float Tolerance = 0.0001; //Field offset: 0x0

	[Extension]
	public static void Ground(Transform transform, bool useNavMesh = true, float maxDistance = 10) { }

	public static bool Ground(ref Vector3 position, ref Vector3 rotation) { }

	public static bool Ground(ref Vector3 position) { }

	private static bool Round(ref float v) { }

}

