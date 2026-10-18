//Type is in global namespace

[Extension]
public static class NavMeshPathExtension
{

	[Extension]
	public static float CalculatePathLength(NavMeshPath path) { }

	[Extension]
	public static float CalculatePathLength(Vector3[] corners) { }

	public static void DrawPathDebug(Vector3[] path, Color color, float time, float offsetUp = 0.1) { }

	[Extension]
	public static void DrawPathGizmo(NavMeshPath path, Color color) { }

}

