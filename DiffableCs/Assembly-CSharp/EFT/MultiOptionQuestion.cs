namespace EFT;

public sealed class MultiOptionQuestion : BaseSurveyQuestion
{
	public readonly MultiOptionAnswer answer; //Field offset: 0x20

	public virtual ISurveyAnswer SurveyAnswer
	{
		 get { } //Length: 5
	}

	public MultiOptionQuestion(QuestionTemplate questionTemplate) { }

	public virtual ISurveyAnswer get_SurveyAnswer() { }

	public void SetAnswer(List value) { }

}

