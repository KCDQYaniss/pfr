namespace EFT.UI;

public sealed class BattleUIPanelExtraction : BattleUITimerPanel
{
	[SerializeField]
	private CustomTextMeshProUGUI _extractionLabel; //Field offset: 0x88
	[SerializeField]
	private LayoutElement _layoutElement; //Field offset: 0x90

	protected virtual LayoutElement LayoutElement
	{
		 get { } //Length: 8
	}

	protected virtual TMP_Text TimerLabel
	{
		 get { } //Length: 8
	}

	public BattleUIPanelExtraction() { }

	protected virtual LayoutElement get_LayoutElement() { }

	protected virtual TMP_Text get_TimerLabel() { }

	public void Show(string textKey) { }

	public void Show(string textKey, float duration) { }

}

