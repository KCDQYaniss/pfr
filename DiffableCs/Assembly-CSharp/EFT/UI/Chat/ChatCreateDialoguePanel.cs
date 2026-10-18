namespace EFT.UI.Chat;

public sealed class ChatCreateDialoguePanel : UIElement, IPointerClickHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__9_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Awake>b__9_2(UpdatableChatMember x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public SocialNetwork social; //Field offset: 0x10
		public ChatCreateDialoguePanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <Show>b__0(UpdatableChatMember member, ChatMember view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_1
	{
		public UpdatableChatMember member; //Field offset: 0x10
		public ChatMember view; //Field offset: 0x18
		public <>c__DisplayClass10_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass10_1() { }

		internal void <Show>b__1(Vector2 pos) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public string dialogName; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal void <Awake>b__3(IResult _) { }

	}

	[SerializeField]
	private GameObject _captionPanel; //Field offset: 0x70
	[SerializeField]
	private Button _closeButton; //Field offset: 0x78
	[SerializeField]
	private ValidationInputField _dialogNameInputField; //Field offset: 0x80
	[SerializeField]
	private DefaultUIButton _createButton; //Field offset: 0x88
	[SerializeField]
	private DefaultUIButton _cancelButton; //Field offset: 0x90
	[SerializeField]
	private ChatMember _chatMemberTemplate; //Field offset: 0x98
	[SerializeField]
	private RectTransform _membersPlaceholder; //Field offset: 0xA0
	private readonly List _chosenMembers; //Field offset: 0xA8
	private SocialNetwork _social; //Field offset: 0xB0

	public ChatCreateDialoguePanel() { }

	[CompilerGenerated]
	private void <Awake>b__9_0() { }

	[CompilerGenerated]
	private void <Awake>b__9_1(string arg) { }

	private void Awake() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	private void SetCreateButtonInteractable() { }

	private void SetPriority() { }

	public void Show(SocialNetwork social) { }

}

