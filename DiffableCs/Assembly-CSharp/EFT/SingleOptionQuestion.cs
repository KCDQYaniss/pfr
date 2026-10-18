namespace EFT;

public sealed class SingleOptionQuestion : BaseSurveyQuestion
{
	public readonly SingleOptionAnswer answer; //Field offset: 0x20

	public virtual ISurveyAnswer SurveyAnswer
	{
		 get { } //Length: 5
	}

	public SingleOptionQuestion(QuestionTemplate questionTemplate) { }

	public virtual ISurveyAnswer get_SurveyAnswer() { }

	public void SetAnswer(int value) { }

}

