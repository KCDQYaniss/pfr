namespace EFT.UI.Matchmaker;

public sealed class LocationConditionsPanelFactory : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _currentPhaseTime; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _nextPhaseTime; //Field offset: 0x78
	[SerializeField]
	private Image _weatherIcon; //Field offset: 0x80
	[SerializeField]
	private Toggle _amTimeToggle; //Field offset: 0x88
	[SerializeField]
	private Toggle _pmTimeToggle; //Field offset: 0x90
	private Coroutine _updateCoroutine; //Field offset: 0x98
	private Action _onDateTimeSelected; //Field offset: 0xA0
	[CompilerGenerated]
	private EDateTime <SelectedDateTime>k__BackingField; //Field offset: 0xA8

	private static DateTime DayTime
	{
		private get { } //Length: 117
	}

	private static DateTime NightTime
	{
		private get { } //Length: 117
	}

	private EDateTime SelectedDateTime
	{
		[CompilerGenerated]
		private get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public LocationConditionsPanelFactory() { }

	[CompilerGenerated]
	private void <Awake>b__15_0(bool arg) { }

	[CompilerGenerated]
	private void <Awake>b__15_1(bool arg) { }

	private void Awake() { }

	private static DateTime get_DayTime() { }

	private static DateTime get_NightTime() { }

	[CompilerGenerated]
	private EDateTime get_SelectedDateTime() { }

	public void Set(EDateTime selectedTime, Action onDateTimeSelected) { }

	[CompilerGenerated]
	private void set_SelectedDateTime(EDateTime value) { }

}

