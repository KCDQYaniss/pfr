namespace EFT.UI.BattleTimer;

public sealed class TransitTimerPanel : TimerPanel
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
	[SerializeField]
	private Color _eventTextColor; //Field offset: 0xE8
	private bool _events; //Field offset: 0xF8
	private bool _paused; //Field offset: 0xF9
	private TransitPoint _point; //Field offset: 0x100

	protected virtual bool DisplayTime
	{
		 get { } //Length: 11
	}

	public TransitTimerPanel() { }

	private void FillTimer(TransitPoint point) { }

	protected virtual bool get_DisplayTime() { }

	protected virtual void OnLocaleUpdated() { }

	public void SetLockedTimer(TransitPoint point, StringBuilder stringBuilder, bool events) { }

	public void SetPausedTimer(TimeSpan timeSpan) { }

	public void SetTimer(TransitPoint point, DateTime dateTime, StringBuilder stringBuilder, bool events) { }

	protected virtual void SetTimerText(TimeSpan timeSpan) { }

}

