namespace EFT.UI.SessionEnd;

public sealed class SessionResultExperienceCount : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__20_0(ExperienceSection section, ExperienceSectionView view) { }

	}

	internal sealed class SessionExperienceScreenController : EftSequenceScreenController
	{
		public readonly Profile Profile; //Field offset: 0x60
		public readonly bool IsOnline; //Field offset: 0x68
		public readonly ExitStatus ExitStatus; //Field offset: 0x6C

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

		public SessionExperienceScreenController(Profile profile, bool isOnline, ExitStatus exitStatus) { }

		public virtual bool get_KeyScreen() { }

		protected virtual bool get_MainEnvironment() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

	}

	private static readonly IReadOnlyDictionary _bonusColors; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xA8
	[SerializeField]
	private SessionExperiencePanel _experiencePanel; //Field offset: 0xB0
	[SerializeField]
	private CustomTextMeshProUGUI _resultExperience; //Field offset: 0xB8
	[SerializeField]
	private GameObject _sectionsScroller; //Field offset: 0xC0
	[SerializeField]
	private Transform _sectionsContainer; //Field offset: 0xC8
	[SerializeField]
	private ExperienceSectionView _sectionTemplate; //Field offset: 0xD0
	[SerializeField]
	private SpriteMap _bonusGlow; //Field offset: 0xD8
	[SerializeField]
	private SpriteMap _bonusIcons; //Field offset: 0xE0
	[SerializeField]
	private CustomTextMeshProUGUI _bonusTitle; //Field offset: 0xE8
	[SerializeField]
	private CustomTextMeshProUGUI _bonusValue; //Field offset: 0xF0
	[SerializeField]
	private PlayerExperienceIcon _expIcon; //Field offset: 0xF8
	[SerializeField]
	private Image _bonusBack; //Field offset: 0x100
	[SerializeField]
	private Image _bonusIcon; //Field offset: 0x108
	[SerializeField]
	private Image _bonusHalo; //Field offset: 0x110
	private ViewList _list; //Field offset: 0x118

	private static SessionResultExperienceCount() { }

	public SessionResultExperienceCount() { }

	[CompilerGenerated]
	private void <Awake>b__18_0() { }

	[CompilerGenerated]
	private void <Awake>b__18_1() { }

	private void Awake() { }

	private static string BuildExperienceFormula(float exitStatusMultiplier, float bonusMultiplier, float perkMultiplier, float gameEditionMultiplier, float referralMultiplier, int totalExperience) { }

	private static SessionExperience FormatSessionExperience(Profile profile) { }

	public virtual void Show(SessionExperienceScreenController controller) { }

	private void Show(Profile profile, bool isOnline, ExitStatus exitStatus) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

