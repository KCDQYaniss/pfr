namespace EFT.UI.Chat;

public sealed class ChatMembersPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public SocialNetwork social; //Field offset: 0x10
		public ChatMembersPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <Show>b__0(UpdatableChatMember member, ChatMember view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_1
	{
		public UpdatableChatMember member; //Field offset: 0x10
		public <>c__DisplayClass7_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass7_1() { }

		internal void <Show>b__1(Vector2 pos) { }

	}

	private sealed class ChatMemberComparer : IComparer
	{
		public static readonly ChatMemberComparer Instance; //Field offset: 0x0

		private static ChatMemberComparer() { }

		public ChatMemberComparer() { }

		public override int Compare(UpdatableChatMember x, UpdatableChatMember y) { }

	}

	[SerializeField]
	private SimpleContextMenu _contextMenu; //Field offset: 0x70
	[SerializeField]
	private BanTimeWindow _banTimeWindow; //Field offset: 0x78
	[SerializeField]
	private ChatMember _chatMemberTemplate; //Field offset: 0x80
	[SerializeField]
	private RectTransform _membersPlaceholder; //Field offset: 0x88
	private SocialNetwork _social; //Field offset: 0x90
	private UpdatableBindableList _chatMembers; //Field offset: 0x98

	public ChatMembersPanel() { }

	public virtual void Close() { }

	public void Show(SocialNetwork social, UpdatableBindableList chatMembers) { }

}

