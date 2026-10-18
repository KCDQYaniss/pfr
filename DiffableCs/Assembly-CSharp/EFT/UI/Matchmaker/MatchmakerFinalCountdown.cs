namespace EFT.UI.Matchmaker;

public sealed class MatchmakerFinalCountdown : EftScreen
{
	internal sealed class FinalCountdownScreenController : EftScreenController
	{
		public readonly Profile ActiveProfile; //Field offset: 0x58
		public readonly DateTime GameStartTime; //Field offset: 0x60

		public virtual bool KeyScreen
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

		public FinalCountdownScreenController(Profile activeProfile, DateTime gameStartTime) { }

		public virtual bool get_KeyScreen() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

	}

	[SerializeField]
	private TextMeshProUGUI _time; //Field offset: 0xA0
	[SerializeField]
	private PlayerNamePanel _namePanel; //Field offset: 0xA8
	private DateTime _gameStartTime; //Field offset: 0xB0

	public MatchmakerFinalCountdown() { }

	public virtual void Show(FinalCountdownScreenController controller) { }

	private void Show(Profile activeProfile, DateTime gameStartTime) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

}

