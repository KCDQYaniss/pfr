//Type is in global namespace

public static class InfOrNonChecker
{

	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	public static void Check(float f) { }

	[Conditional("DEBUG")]
	[Conditional("CONSOLE")]
	public static void Check(Vector3 vector3) { }

	[Conditional("CONSOLE")]
	[Conditional("DEBUG")]
	public static void Check(Quaternion quaternion) { }

}

