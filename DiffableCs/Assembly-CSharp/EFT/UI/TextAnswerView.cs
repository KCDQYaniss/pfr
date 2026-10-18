namespace EFT.UI;

public sealed class TextAnswerView : AnswersContainerView
{
	[SerializeField]
	private TMP_Text _charLimitText; //Field offset: 0x88
	[SerializeField]
	private TMP_InputField _inputField; //Field offset: 0x90

	public TextAnswerView() { }

	protected virtual void CollectAnswer() { }

	public void OnInputFieldValueChanged(string value) { }

	public virtual void Show(TextQuestion question) { }

}

