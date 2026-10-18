namespace EFT.Weather;

[Extension]
public static class CloudinessTypeExtensions
{
	private const float CLEAR_VALUE = -1; //Field offset: 0x0
	private const float PARTLY_CLOUDY_VALUE = -0.5; //Field offset: 0x0
	private const float CLOUDY_VALUE = -0.3; //Field offset: 0x0
	private const float CLOUDY_WITH_GAPS_VALUE = 0; //Field offset: 0x0
	private const float HEAVY_CLOUD_COVER_VALUE = 0.2; //Field offset: 0x0
	private const float THUNDERCLOUD_VALUE = 1; //Field offset: 0x0

	[Extension]
	public static float ToValue(ECloudinessType currentEnum) { }

}

