namespace EFT.UI;

public sealed class AnswerRawView : UIElement
{
	[SerializeField]
	private Toggle _toggle; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _text; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x80

	public Toggle Toggle
	{
		 get { } //Length: 5
	}

	public AnswerRawView() { }

	public Toggle get_Toggle() { }

	public void MarkAsChosen(bool chosen) { }

	public void SetInteractable(bool interactable) { }

	public void Show(string text) { }

}

