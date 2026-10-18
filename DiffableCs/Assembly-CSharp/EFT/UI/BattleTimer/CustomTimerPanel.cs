namespace EFT.UI.BattleTimer;

public sealed class CustomTimerPanel : TimerPanel
{
	[SerializeField]
	private TextMeshProUGUI _timerCaption; //Field offset: 0xA8

	public CustomTimerPanel() { }

	public void SetTimerCaption(string text) { }

}

