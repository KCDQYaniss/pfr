namespace EFT;

[Extension]
public static class VectorExtensions
{

	[Extension]
	public static Vector3 WithX(Vector3 source, float x) { }

	[Extension]
	public static Vector2 WithX(Vector2 source, float x) { }

	[Extension]
	public static Vector3 WithY(Vector3 source, float y) { }

	[Extension]
	public static Vector2 WithY(Vector2 source, float y) { }

	[Extension]
	public static Vector3 WithZ(Vector3 source, float z) { }

	[Extension]
	public static Vector3 XZ(Vector3 source) { }

}

