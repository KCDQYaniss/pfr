namespace EFT.UI;

public sealed class QuestionView : UIElement
{
	[SerializeField]
	private TMP_Text _label; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _subLabel; //Field offset: 0x78
	[SerializeField]
	private GameObject _hintGameObject; //Field offset: 0x80
	[SerializeField]
	private SingleOptionAnswersContainerView SingleOptionAnswerView; //Field offset: 0x88
	[SerializeField]
	private MultiOptionAnswersContainerView MultiOptionAnswerView; //Field offset: 0x90
	[SerializeField]
	private TextAnswerView TextAnswerView; //Field offset: 0x98

	public QuestionView() { }

	public virtual void Close() { }

	public void Show(BaseSurveyQuestion baseSurveyQuestion) { }

}

