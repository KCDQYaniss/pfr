namespace EFT.UI;

public sealed class SeasonsIntroScreen : EftScreen
{
	internal sealed class SeasonsIntroScreenController : EftScreenController
	{
		[CompilerGenerated]
		private readonly IReadOnlyList <Pages>k__BackingField; //Field offset: 0x58

		protected virtual bool MainEnvironment
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public IReadOnlyList Pages
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public SeasonsIntroScreenController(IReadOnlyList pages) { }

		protected virtual bool get_MainEnvironment() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		[CompilerGenerated]
		public IReadOnlyList get_Pages() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

	}

	private SeasonsIntroScreenController _controller; //Field offset: 0xA0
	[SerializeField]
	private CarouselView _carousel; //Field offset: 0xA8
	[SerializeField]
	private SeasonCarouselData _carouselData; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _closeButton; //Field offset: 0xB8
	[SerializeField]
	private EUISoundType _showSound; //Field offset: 0xC0

	public SeasonsIntroScreen() { }

	public virtual void Close() { }

	private void CloseScreen() { }

	private void PlayShowSound() { }

	public virtual void Show(SeasonsIntroScreenController controller) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

