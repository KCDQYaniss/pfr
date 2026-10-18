namespace EFT;

public sealed class TextQuestion : BaseSurveyQuestion
{
	public readonly TextAnswer answer; //Field offset: 0x20

	public virtual ISurveyAnswer SurveyAnswer
	{
		 get { } //Length: 5
	}

	public TextQuestion(QuestionTemplate questionTemplate) { }

	public virtual ISurveyAnswer get_SurveyAnswer() { }

	public void SetAnswer(string value) { }

}

