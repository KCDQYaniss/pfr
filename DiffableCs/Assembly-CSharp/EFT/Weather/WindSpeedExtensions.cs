namespace EFT.Weather;

[Extension]
public static class WindSpeedExtensions
{
	private const float MAX_VALUE = 4; //Field offset: 0x0
	private const float LIGHT_VALUE = 0.8; //Field offset: 0x0
	private const float MODERATE_VALUE = 1.6; //Field offset: 0x0
	private const float STRONG_VALUE = 2.4; //Field offset: 0x0
	private const float VERY_STRONG_VALUE = 3.2; //Field offset: 0x0
	private const float HURRICANE_VALUE = 4; //Field offset: 0x0

	[Extension]
	public static float ToValue(EWindSpeed currentEnum) { }

}

