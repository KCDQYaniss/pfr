namespace EFT.UI.SessionEnd;

public sealed class SessionResultStatistics : EftScreen
{
	internal sealed class SessionStatisticsScreenController : EftSequenceScreenController
	{
		public readonly Profile Profile; //Field offset: 0x60
		public readonly Location Location; //Field offset: 0x68
		public readonly IEftSession Session; //Field offset: 0x70

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		protected virtual bool MainEnvironment
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public SessionStatisticsScreenController(Profile profile, Location location, IEftSession session) { }

		public virtual bool get_KeyScreen() { }

		protected virtual bool get_MainEnvironment() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

	}

	internal sealed class StatGroup
	{
		public readonly List StatItems; //Field offset: 0x10
		public string Caption; //Field offset: 0x18
		public Sprite Icon; //Field offset: 0x20
		public EStatGroupLayoutType LayoutType; //Field offset: 0x28

		public StatGroup() { }

	}

	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xA8
	[SerializeField]
	private StatisticsSpawn _statsSpawn; //Field offset: 0xB0
	[SerializeField]
	private CustomTextMeshProUGUI _locationName; //Field offset: 0xB8
	[SerializeField]
	private Image _locationImage; //Field offset: 0xC0
	[SerializeField]
	private Sprite _defaultLocationImage; //Field offset: 0xC8

	public SessionResultStatistics() { }

	[CompilerGenerated]
	private void <Awake>b__8_0() { }

	[CompilerGenerated]
	private void <Awake>b__8_1() { }

	private void Awake() { }

	public virtual void Close() { }

	public virtual void Show(SessionStatisticsScreenController controller) { }

	private void Show(Profile profile, Location location, IEftSession session) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

