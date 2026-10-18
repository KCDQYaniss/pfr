namespace EFT;

public struct SurveyAnswersData
{
	[JsonProperty("surveyId")]
	private int _surveyId; //Field offset: 0x0
	[JsonProperty("answers")]
	private List _answers; //Field offset: 0x8

	public SurveyAnswersData(int surveyId, List answers) { }

}

