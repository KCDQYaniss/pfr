namespace EFT.UI;

public sealed class ReconnectionScreen : EftScreen
{
	internal sealed class ReconnectionScreenController : EftScreenController
	{
		[CompilerGenerated]
		private Action OnReconnectAction; //Field offset: 0x58
		[CompilerGenerated]
		private Action OnLeave; //Field offset: 0x60
		public readonly Profile ActiveProfile; //Field offset: 0x68
		public readonly Location Location; //Field offset: 0x70
		public readonly ESideType Side; //Field offset: 0x78
		public readonly bool ReturnAllowed; //Field offset: 0x7C
		public readonly bool NextScreenAllowed; //Field offset: 0x7D
		public readonly IEftSession Session; //Field offset: 0x80

		public event Action OnLeave
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public event Action OnReconnectAction
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public ReconnectionScreenController(Profile activeProfile, Location location, ESideType side, bool returnAllowed, bool nextScreenAllowed, IEftSession session) { }

		[CompilerGenerated]
		public void add_OnLeave(Action value) { }

		[CompilerGenerated]
		public void add_OnReconnectAction(Action value) { }

		public virtual bool get_KeyScreen() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		public void Leave() { }

		public void Reconnect() { }

		[CompilerGenerated]
		public void remove_OnLeave(Action value) { }

		[CompilerGenerated]
		public void remove_OnReconnectAction(Action value) { }

	}

	[SerializeField]
	private DefaultUIButton _reconnectButton; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xA8
	[SerializeField]
	private DefaultUIButton _exitButton; //Field offset: 0xB0
	[SerializeField]
	private CustomTextMeshProUGUI _locationName; //Field offset: 0xB8
	[SerializeField]
	private PlayerLevelPanel _levelPanel; //Field offset: 0xC0
	[SerializeField]
	private PlayerModelView _playerModelView; //Field offset: 0xC8
	[SerializeField]
	private MatchmakerBannersPanel _bannersPanel; //Field offset: 0xD0

	public ReconnectionScreen() { }

	[CompilerGenerated]
	private void <Awake>b__9_0() { }

	[CompilerGenerated]
	private void <Awake>b__9_1() { }

	[CompilerGenerated]
	private void <Awake>b__9_2() { }

	private void Awake() { }

	public virtual void Close() { }

	private void SetButtonsAvailability(bool available) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public virtual void Show(ReconnectionScreenController controller) { }

	private void Show(Profile activeProfile, Location location, ESideType side, bool returnAllowed, bool nextScreenAllowed, IEftSession session) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

