namespace UnityEngine;

[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
public static class Random
{

	public static Vector2 insideUnitCircle
	{
		 get { } //Length: 86
	}

	public static Vector3 insideUnitSphere
	{
		[FreeFunction]
		 get { } //Length: 89
	}

	public static Vector3 onUnitSphere
	{
		[FreeFunction]
		 get { } //Length: 89
	}

	public static Quaternion rotation
	{
		[FreeFunction]
		 get { } //Length: 87
	}

	public static Quaternion rotationUniform
	{
		[FreeFunction]
		 get { } //Length: 87
	}

	public static float value
	{
		[FreeFunction]
		 get { } //Length: 69
	}

	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) { }

	public static Color ColorHSV() { }

	public static Vector2 get_insideUnitCircle() { }

	[FreeFunction]
	public static Vector3 get_insideUnitSphere() { }

	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }

	[FreeFunction]
	public static Vector3 get_onUnitSphere() { }

	private static void get_onUnitSphere_Injected(out Vector3 ret) { }

	[FreeFunction]
	public static Quaternion get_rotation() { }

	private static void get_rotation_Injected(out Quaternion ret) { }

	[FreeFunction]
	public static Quaternion get_rotationUniform() { }

	private static void get_rotationUniform_Injected(out Quaternion ret) { }

	[FreeFunction]
	public static float get_value() { }

	[FreeFunction]
	private static void GetRandomUnitCircle(out Vector2 output) { }

	[NativeMethod("SetSeed")]
	[StaticAccessor("GetScriptingRand()", StaticAccessorType::Dot (0))]
	public static void InitState(int seed) { }

	[FreeFunction]
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	public static int Range(int minInclusive, int maxExclusive) { }

	[FreeFunction]
	public static float Range(float minInclusive, float maxInclusive) { }

}

