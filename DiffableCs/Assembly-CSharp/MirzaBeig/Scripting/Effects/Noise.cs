namespace MirzaBeig.Scripting.Effects;

public static class Noise
{
	private static float F3; //Field offset: 0x0
	private static float G3; //Field offset: 0x4
	private static byte[] perm; //Field offset: 0x8

	private static Noise() { }

	private static float fade(float t) { }

	private static int floor(float x) { }

	private static float grad(int hash, float x, float y, float z) { }

	private static float lerp(float from, float to, float t) { }

	public static float octavePerlin(float x, float y, float z, float frequency, int octaves, float lacunarity, float persistence) { }

	public static float octaveSimplex(float x, float y, float z, float frequency, int octaves, float lacunarity, float persistence) { }

	public static float perlin(float x, float y, float z) { }

	public static float perlinUnoptimized(float x, float y, float z) { }

	public static float simplex(float x, float y, float z) { }

	public static float simplexUnoptimized(float x, float y, float z) { }

	private static float smooth(float t) { }

}

