namespace EFT;

public abstract class BaseSurveyQuestion
{
	[CompilerGenerated]
	private Action answerChanged; //Field offset: 0x10
	public readonly QuestionTemplate template; //Field offset: 0x18

	public event Action answerChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public abstract ISurveyAnswer SurveyAnswer
	{
		 get { } //Length: 0
	}

	protected BaseSurveyQuestion(QuestionTemplate questionTemplate) { }

	[CompilerGenerated]
	public void add_answerChanged(Action value) { }

	protected void CallAnswerChangedEvent() { }

	public abstract ISurveyAnswer get_SurveyAnswer() { }

	public bool HasAnswer() { }

	[CompilerGenerated]
	public void remove_answerChanged(Action value) { }

}

