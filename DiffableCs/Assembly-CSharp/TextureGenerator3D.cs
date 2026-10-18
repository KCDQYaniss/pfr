//Type is in global namespace

public static class TextureGenerator3D
{

	private static void FixCoord(ref int value, int size) { }

	private static void FixCoords(ref int x, ref int y, ref int z, int size) { }

	private static float GetNoise(float x, float y, float z, int size) { }

	private static float[,,] GetNoise(int bSize, float roughness) { }

	private static float GetNoiseSimple(int x, int y, int z) { }

	public static Texture3D GetNoiseTexture3D(int bSize, float roughness) { }

	private static Texture3D GetTexture3D(float[,,] map, int size) { }

	private static float Smooth(float x) { }

}

