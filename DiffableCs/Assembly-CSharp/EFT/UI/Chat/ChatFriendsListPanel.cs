namespace EFT.UI.Chat;

public sealed class ChatFriendsListPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public ChatFriendsListPanel <>4__this; //Field offset: 0x10
		public SocialNetwork social; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal ChatMember <Show>b__0(UpdatableChatMember _) { }

		internal void <Show>b__1(UpdatableChatMember member, ChatMember view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_1
	{
		public UpdatableChatMember member; //Field offset: 0x10
		public <>c__DisplayClass6_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass6_1() { }

		internal void <Show>b__2(Vector2 pos) { }

	}

	[SerializeField]
	private SimpleContextMenu _contextMenu; //Field offset: 0x70
	[SerializeField]
	private ChatMember _chatMember; //Field offset: 0x78
	[SerializeField]
	private LightScroller _lightScroller; //Field offset: 0x80
	[SerializeField]
	private TextMeshProUGUI _friendsLabel; //Field offset: 0x88
	private SocialNetwork _social; //Field offset: 0x90
	private int _friendsListCount; //Field offset: 0x98

	public ChatFriendsListPanel() { }

	private void SetFriendsLabelText() { }

	public void Show(SocialNetwork social) { }

}

