namespace EFT.UI;

public sealed class RestorePasswordScreen : EftScreen
{
	internal sealed class RestorePasswordScreenController : EftScreenController
	{
		[CompilerGenerated]
		private Action OnRestore; //Field offset: 0x58

		public event Action OnRestore
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public RestorePasswordScreenController() { }

		[CompilerGenerated]
		public void add_OnRestore(Action value) { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		[CompilerGenerated]
		public void remove_OnRestore(Action value) { }

		internal void RestorePassword(string login) { }

	}

	[SerializeField]
	private ValidationInputField _login; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _acceptButton; //Field offset: 0xA8
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xB0

	public RestorePasswordScreen() { }

	[CompilerGenerated]
	private void <Awake>b__4_0() { }

	[CompilerGenerated]
	private void <Awake>b__4_1() { }

	private void Awake() { }

	public virtual void Close() { }

	public virtual void Show(RestorePasswordScreenController controller) { }

	private void Show() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

