namespace EFT;

public sealed class SurveyData
{
	[JsonProperty("locale")]
	public Dictionary localization; //Field offset: 0x10
	[JsonProperty("survey")]
	public SurveyTemplate template; //Field offset: 0x18

	public SurveyData() { }

}

