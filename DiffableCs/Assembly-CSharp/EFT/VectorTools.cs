namespace EFT;

[Extension]
public static class VectorTools
{

	[Extension]
	public static bool AllVectorAbsComponentsGreater(Vector3 vector3, float value) { }

	[Extension]
	public static bool AllVectorAbsComponentsGreater(Vector2 vector2, float value) { }

	[Extension]
	public static bool AllVectorAbsComponentsLess(Vector3 vector3, float value) { }

	[Extension]
	public static bool AllVectorAbsComponentsLess(Vector2 vector2, float value) { }

	[Extension]
	public static bool AnyVectorAbsComponentsGreater(Vector3 vector3, float value) { }

	[Extension]
	public static bool AnyVectorAbsComponentsGreater(Vector2 vector2, float value) { }

	[Extension]
	public static float Evaluate(Vector2 v, float t) { }

	[Extension]
	public static float Evaluate(Vector3 v, float t) { }

	[Extension]
	public static float InverseLerp(Vector2 v, float t) { }

	[Extension]
	public static float InverseLerp(Vector3 v, float t) { }

	public static Vector2 LerpAngle(Vector2 a, Vector2 b, float t) { }

	public static Vector2 LerpAngleUnclamped(Vector2 a, Vector2 b, float t) { }

	public static float LerpAngleUnclamped(float a, float b, float t) { }

	[Extension]
	public static float[] ToArray(Vector3 v) { }

}

