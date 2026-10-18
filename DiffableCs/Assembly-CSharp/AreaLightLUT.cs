//Type is in global namespace

public class AreaLightLUT
{
	internal enum LUTType
	{
		TransformInv_DisneyDiffuse = 0,
		TransformInv_GGX = 1,
		AmpDiffAmpSpecFresnel = 2,
	}

	private static double[,] s_LUTTransformInv_DisneyDiffuse; //Field offset: 0x0
	private const int kLUTResolution = 64; //Field offset: 0x0
	private const int kLUTMatrixDim = 3; //Field offset: 0x0
	private static float[] s_LUTAmplitude_DisneyDiffuse; //Field offset: 0x8
	private static double[,] s_LUTTransformInv_GGX; //Field offset: 0x10
	private static float[] s_LUTAmplitude_GGX; //Field offset: 0x18
	private static float[] s_LUTFresnel_GGX; //Field offset: 0x20

	private static AreaLightLUT() { }

	public AreaLightLUT() { }

	private static Texture2D CreateLUT(TextureFormat format, Color[] pixels) { }

	public static Texture2D LoadLUT(LUTType type) { }

	private static Texture2D LoadLUT(double[,] LUTTransformInv) { }

	private static Texture2D LoadLUT(float[] LUTScalar0, float[] LUTScalar1, float[] LUTScalar2) { }

}

