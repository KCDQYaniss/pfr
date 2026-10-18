namespace EFT.UI.BattleTimer;

public class TimerPanel : UIElement
{
	private const float TICK_COOLDOWN = 1; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _timerText; //Field offset: 0x70
	protected TimeSpan TimeSpan; //Field offset: 0x78
	private DateTime _dateTime; //Field offset: 0x80
	private StringBuilder _stringBuilder; //Field offset: 0x88
	private string _stringBuilderString; //Field offset: 0x90
	private double _lastUpdateTime; //Field offset: 0x98
	private bool _localeListenerAdded; //Field offset: 0xA0

	protected override bool DisplayTime
	{
		 get { } //Length: 3
	}

	protected TextMeshProUGUI TimerText
	{
		 get { } //Length: 5
	}

	public TimerPanel() { }

	public virtual void Close() { }

	protected override bool get_DisplayTime() { }

	protected TextMeshProUGUI get_TimerText() { }

	private void HandleLocaleUpdated() { }

	private void OnDestroy() { }

	protected override void OnLocaleUpdated() { }

	protected override void SetTimerText(TimeSpan timeSpan) { }

	public void Show(DateTime dateTime, StringBuilder stringBuilder) { }

	protected override void Update() { }

	protected override void UpdateTimer() { }

}

