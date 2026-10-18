//Type is in global namespace

[Extension]
public static class VectorChecksExtensions
{

	[Extension]
	public static bool AllAbsComponentsLessThen(Vector3 vector3, float value) { }

	[Extension]
	public static bool AllAbsComponentsLessThen(Vector2 vector2, float value) { }

	public static bool Equals(Vector2 a, Vector2 b, float epsilon) { }

	[Extension]
	public static bool IsAnyComponentInfinity(Vector3 vector3) { }

	[Extension]
	public static bool IsAnyComponentInfinity(Vector2 vector2) { }

	[Extension]
	public static bool IsAnyComponentInfinity(Quaternion quaternion) { }

	[Extension]
	public static bool IsAnyComponentNaN(Vector3 vector3) { }

	[Extension]
	public static bool IsAnyComponentNaN(Vector2 vector2) { }

	[Extension]
	public static bool IsAnyComponentNaN(Quaternion quaternion) { }

}

