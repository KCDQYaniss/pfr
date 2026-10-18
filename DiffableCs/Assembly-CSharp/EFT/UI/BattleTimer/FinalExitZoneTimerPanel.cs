namespace EFT.UI.BattleTimer;

public sealed class FinalExitZoneTimerPanel : TimerPanel
{
	[SerializeField]
	private TextMeshProUGUI _name; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _condition; //Field offset: 0xB8
	[SerializeField]
	private GameObject _conditionPanel; //Field offset: 0xC0
	[SerializeField]
	private Color _lockedTextColor; //Field offset: 0xC8
	[SerializeField]
	private Color _defaultTextColor; //Field offset: 0xD8

	public FinalExitZoneTimerPanel() { }

	public void InitExitPointInfo(string pointName, string pointDes) { }

	public void InitTimer(string pointName, string pointDes, string condition, DateTime dateTime, StringBuilder stringBuilder) { }

	public void SetConditionState(string condition) { }

	public void SetLockedState(bool locked) { }

	protected virtual void SetTimerText(TimeSpan timeSpan) { }

}

