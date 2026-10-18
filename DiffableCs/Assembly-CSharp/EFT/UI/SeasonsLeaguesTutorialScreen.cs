namespace EFT.UI;

public class SeasonsLeaguesTutorialScreen : EftScreen
{
	internal sealed class SeasonsLeaguesTutorialScreenController : EftScreenController
	{

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

		public SeasonsLeaguesTutorialScreenController() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

	}

	private const string TITLE_FORMAT = "Seasons/Leagues/Tutorial/Title{0}"; //Field offset: 0x0
	private const string DESCRIPTION_FORMAT = "Seasons/Leagues/Tutorial/Description{0}"; //Field offset: 0x0
	private const int STEPS_COUNT = 6; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xA0
	[SerializeField]
	private TMP_Text _title; //Field offset: 0xA8
	[SerializeField]
	private TMP_Text _description; //Field offset: 0xB0
	[SerializeField]
	private TMP_Text _counter; //Field offset: 0xB8
	[SerializeField]
	private Button _prevButton; //Field offset: 0xC0
	[SerializeField]
	private Button _nextButton; //Field offset: 0xC8
	[SerializeField]
	private ButtonShortcutInputNode _prevShortcut; //Field offset: 0xD0
	[SerializeField]
	private ButtonShortcutInputNode _nextShortcut; //Field offset: 0xD8
	private int _currentStep; //Field offset: 0xE0

	public SeasonsLeaguesTutorialScreen() { }

	[CompilerGenerated]
	private void <Awake>b__13_0() { }

	private void Awake() { }

	private void NextStep() { }

	private void PrevStep() { }

	private void SetStep(int step) { }

	public virtual void Show(SeasonsLeaguesTutorialScreenController controller) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

