namespace EFT.UI.Chat;

public sealed class DialogueInviteMessageView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Show>b__13_0(AreaData area) { }

	}

	public const int MRKERMAN_REQUIRED_HIDEOUT_AREA_LEVEL = 1; //Field offset: 0x0
	public const int VOIVODE_REQUIRED_HIDEOUT_AREA_LEVEL = 3; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _startDialogueButton; //Field offset: 0x70
	[SerializeField]
	private DefaultUIButton _dialogueInRaidButton; //Field offset: 0x78
	[SerializeField]
	private DefaultUIButton _dialogueByRadioButton; //Field offset: 0x80
	[SerializeField]
	private TextMeshProUGUI _messageLabel; //Field offset: 0x88
	[SerializeField]
	private GameObject _messageObject; //Field offset: 0x90
	[SerializeField]
	private GameObject _buttonObject; //Field offset: 0x98
	[SerializeField]
	private GameObject _background; //Field offset: 0xA0
	[SerializeField]
	private HoverTooltipArea _dialogByRadioTooltip; //Field offset: 0xA8
	private Action _startDialogueButtonClickAction; //Field offset: 0xB0
	private Nullable _dialogueInvitationMessageData; //Field offset: 0xB8

	public DialogueInviteMessageView() { }

	[CompilerGenerated]
	private void <Awake>b__12_0() { }

	[CompilerGenerated]
	private void <Awake>b__12_1() { }

	private void Awake() { }

	private void DisableRadioButton(string msg) { }

	public void Hide() { }

	private void OnCultureUpdatedHandler() { }

	private void SetMessageText() { }

	public void Show(Nullable dialogueInvitationMessageData, Action startDialogueButtonClickedAction) { }

}

