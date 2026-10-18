namespace EFT.Weather;

[Extension]
public static class FogTypeExtensions
{
	private const float NO_FOG_VALUE = 0.004; //Field offset: 0x0
	private const float FAINT_VALUE = 0.015; //Field offset: 0x0
	private const float FOG_VALUE = 0.035; //Field offset: 0x0
	private const float HEAVY_VALUE = 0.075; //Field offset: 0x0
	private const float CONTINUOUS_VALUE = 0.01; //Field offset: 0x0

	public static float CalcFogNormalizedIntensity(float currentHeight, float distance, float fogDensityRaw) { }

	public static float NormalizeFogValueToActualMinMax(float curveParameterFog) { }

	[Extension]
	public static float ToValue(EFogType currentEnum) { }

}

