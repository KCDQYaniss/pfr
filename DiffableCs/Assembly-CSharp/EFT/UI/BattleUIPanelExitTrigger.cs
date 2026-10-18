namespace EFT.UI;

public sealed class BattleUIPanelExitTrigger : BattleUITimerPanel
{
	private const string EXTRACTION_TEXT_KEY = "Extraction in {0:F1}"; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _extractionLabel; //Field offset: 0x88
	[SerializeField]
	private LayoutElement _layoutElement; //Field offset: 0x90
	[SerializeField]
	private Color _countdownColor; //Field offset: 0x98
	[SerializeField]
	private Color _runnerCountdownColor; //Field offset: 0xA8
	[SerializeField]
	private Color _requirementsColor; //Field offset: 0xB8
	[SerializeField]
	private Image _background; //Field offset: 0xC8
	[SerializeField]
	private Image _glow; //Field offset: 0xD0

	protected virtual LayoutElement LayoutElement
	{
		 get { } //Length: 8
	}

	protected virtual TMP_Text TimerLabel
	{
		 get { } //Length: 8
	}

	public BattleUIPanelExitTrigger() { }

	protected virtual LayoutElement get_LayoutElement() { }

	protected virtual TMP_Text get_TimerLabel() { }

	public void SetRunnerVisual(bool isRunner) { }

	public void Show(float duration, bool isRunner) { }

	public void ShowRequirements(string tip) { }

	public static void TryRefreshRunnerVisual(int sessionExp, float pastTime, ExfiltrationPoint point) { }

}

