namespace EFT.UI;

[UsedImplicitly]
public sealed class NewsHubScreen : EftScreen
{
	private enum ENewsHubTab
	{
		Questionnaire = 0,
		News = 1,
		Events = 2,
	}

	internal sealed class NewsHubScreenController : EftScreenController
	{
		public readonly IEftSession session; //Field offset: 0x58
		public NewsHub newsHub; //Field offset: 0x60

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

		public NewsHubScreenController(NewsHub newsHub, IEftSession session) { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

	}

	[SerializeField]
	private Tab _surveyTab; //Field offset: 0xA0
	[SerializeField]
	private Tab _newsTab; //Field offset: 0xA8
	[SerializeField]
	private SurveyScreen SurveyScreen; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xB8
	private TabGroup _tabs; //Field offset: 0xC0
	private Dictionary _tabDictionary; //Field offset: 0xC8
	private NewsHub _newsHub; //Field offset: 0xD0
	private IEftSession _session; //Field offset: 0xD8

	public NewsHubScreen() { }

	[CompilerGenerated]
	private void <Awake>g__CloseScreen|10_0() { }

	[CompilerGenerated]
	private void <Show>b__12_0() { }

	[CompilerGenerated]
	private void <Show>b__12_1() { }

	private void Awake() { }

	public virtual void Close() { }

	public virtual void Show(NewsHubScreenController controller) { }

	private void Show(NewsHub newsHub, IEftSession session) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

