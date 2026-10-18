namespace EFT.UI.Chat;

public sealed class ChatInvitePlayersPanel : UIElement, IPointerClickHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Callback <>9__8_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__8_1(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public SocialNetwork social; //Field offset: 0x10
		public UpdatableChatDialogue selectedDialogue; //Field offset: 0x18
		public ChatInvitePlayersPanel <>4__this; //Field offset: 0x20

		public <>c__DisplayClass9_0() { }

		internal void <Show>b__0(UpdatableChatMember member, ChatMember view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_1
	{
		public UpdatableChatMember member; //Field offset: 0x10
		public ChatMember view; //Field offset: 0x18
		public <>c__DisplayClass9_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass9_1() { }

		internal void <Show>b__1(Vector2 pos) { }

	}

	[SerializeField]
	private GameObject _captionPanel; //Field offset: 0x70
	[SerializeField]
	private Button _closeButton; //Field offset: 0x78
	[SerializeField]
	private DefaultUIButton _inviteButtonSpawner; //Field offset: 0x80
	[SerializeField]
	private ChatMember _chatMemberTemplate; //Field offset: 0x88
	[SerializeField]
	private RectTransform _membersPlaceholder; //Field offset: 0x90
	private readonly List _chosenMembers; //Field offset: 0x98
	private SocialNetwork _social; //Field offset: 0xA0
	private UpdatableChatDialogue _selectedDialogue; //Field offset: 0xA8

	public ChatInvitePlayersPanel() { }

	[CompilerGenerated]
	private void <Awake>b__8_0() { }

	private void Awake() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	private void SetPriority() { }

	public void Show(SocialNetwork social, UpdatableChatDialogue selectedDialogue) { }

}

