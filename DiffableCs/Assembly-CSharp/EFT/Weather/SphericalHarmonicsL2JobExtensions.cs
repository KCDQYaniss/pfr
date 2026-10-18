namespace EFT.Weather;

public static class SphericalHarmonicsL2JobExtensions
{
	private const int kColorChannelCount = 3; //Field offset: 0x0
	private static readonly float sqrtPI; //Field offset: 0x0
	private const float kNormalization = 2.956793; //Field offset: 0x0
	private const float kSqrt15Div4SqrtPI = 0.54627424; //Field offset: 0x0
	private const float k3Sqrt5Div4SqrtPI = 0.9461747; //Field offset: 0x0
	private const float kSqrt15Div2SqrtPI = 1.0925485; //Field offset: 0x0
	private const float kSqrt3Div2SqrtPI = 0.48860252; //Field offset: 0x0
	private const float kOneThird = 0.33333334; //Field offset: 0x0
	private const float kPI = 3.1415927; //Field offset: 0x0
	private const int kCoeffCountSIMD = 3; //Field offset: 0x0
	private const int kVec4Count = 7; //Field offset: 0x0
	private const int kFloatCount = 27; //Field offset: 0x0
	private const int kCoeffCount = 9; //Field offset: 0x0
	private const float kInv2SqrtPI = 0.2820948; //Field offset: 0x0
	private static readonly float fC0; //Field offset: 0x4
	private static readonly float fC1; //Field offset: 0x8
	private static readonly float fC2; //Field offset: 0xC
	private static readonly float fC3; //Field offset: 0x10
	private static readonly float fC4; //Field offset: 0x14
	private static readonly float[] kNormalizationConstants; //Field offset: 0x18
	private static readonly Vector4 EvaluatedConstant04; //Field offset: 0x20
	private static readonly Vector4 EvaluatedConstant48; //Field offset: 0x30
	private static readonly float kNormalizationAmbientLight; //Field offset: 0x40

	private static SphericalHarmonicsL2JobExtensions() { }

	public static void AddAmbientLightMT(ref SphericalHarmonicsL2 sh, Color ambient) { }

	public static void AddDirLightMT(ref SphericalHarmonicsL2 sh, Vector3 direction, Color color, float intensity) { }

	private static void AddToCoefficients(ref SphericalHarmonicsL2 sh, Vector4* evaluatedDirection, float* rgb) { }

	private static void SHEvalDirection9(Vector3 v, Vector4* outsh) { }

}

