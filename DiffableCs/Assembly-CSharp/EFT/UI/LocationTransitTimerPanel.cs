namespace EFT.UI;

public sealed class LocationTransitTimerPanel : BattleUITimerPanel
{
	private const string TRANSITION_TEXT_KEY = "Transition in {0:F1}"; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _extractionLabel; //Field offset: 0x88
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

	public LocationTransitTimerPanel() { }

	protected virtual LayoutElement get_LayoutElement() { }

	protected virtual TMP_Text get_TimerLabel() { }

	public void Show(float time, string overrideLocalizationKey = null) { }

}

