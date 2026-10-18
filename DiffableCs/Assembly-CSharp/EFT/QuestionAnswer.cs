namespace EFT;

public struct QuestionAnswer
{
	[JsonProperty("questionId")]
	private int _questionId; //Field offset: 0x0
	[JsonProperty("answerType")]
	private EAnswerType _answerType; //Field offset: 0x4
	[JsonProperty("answers")]
	private ISurveyAnswer _answer; //Field offset: 0x8

	public QuestionAnswer(int questionId, EAnswerType answerType, ISurveyAnswer answer) { }

}

