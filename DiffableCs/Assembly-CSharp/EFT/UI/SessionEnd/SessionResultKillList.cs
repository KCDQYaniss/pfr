namespace EFT.UI.SessionEnd;

public sealed class SessionResultKillList : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Show>b__8_1(DogtagComponent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public DogtagComponent[] tags; //Field offset: 0x10
		public int index; //Field offset: 0x18
		public IEftSession session; //Field offset: 0x20

		public <>c__DisplayClass8_0() { }

		internal void <Show>b__0(VictimStats victim, KillListVictim view) { }

	}

	internal sealed class KillListScreenController : EftSequenceScreenController
	{
		public readonly UpdatableBindableList Victims; //Field offset: 0x60
		public readonly DogtagComponent[] Tags; //Field offset: 0x68
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

		public KillListScreenController(UpdatableBindableList victims, DogtagComponent[] tags, IEftSession session) { }

		public virtual bool get_KeyScreen() { }

		protected virtual bool get_MainEnvironment() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

	}

	[SerializeField]
	private KillListVictim _victimTemplate; //Field offset: 0xA0
	[SerializeField]
	private RectTransform _container; //Field offset: 0xA8
	[SerializeField]
	private GameObject _noKillsObject; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xC0

	public SessionResultKillList() { }

	[CompilerGenerated]
	private void <Awake>b__6_0() { }

	[CompilerGenerated]
	private void <Awake>b__6_1() { }

	private void Awake() { }

	public virtual void Show(KillListScreenController controller) { }

	private void Show(UpdatableBindableList victims, DogtagComponent[] tags, IEftSession session) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

