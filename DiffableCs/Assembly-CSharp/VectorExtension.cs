//Type is in global namespace

[Extension]
public static class VectorExtension
{

	public static Vector2 ScreenCenter
	{
		 get { } //Length: 190
	}

	[Extension]
	public static Vector3[] CreateVectorPartition(Vector3 fromPos, Vector3 toPos, Vector3 upOffset, float step, bool includeOriginAndEnd, bool evenly, bool forceInsert = false) { }

	public static float Distance(float xdiff, float ydiff, float zdif) { }

	public static Vector2 get_ScreenCenter() { }

	public static float Magnitude(Vector3 a) { }

	[Extension]
	public static string ToStringHighResolution(Vector3 vector) { }

	[Extension]
	public static string ToStringVerbose(Vector3 vector) { }

}

