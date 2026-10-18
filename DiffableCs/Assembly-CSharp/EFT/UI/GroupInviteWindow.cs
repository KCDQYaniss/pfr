namespace EFT.UI;

public sealed class GroupInviteWindow : DialogWindow
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ParseInvite>b__6_0(GroupPlayer player, GroupMemberView playerPanel) { }

	}

	private const string ACCEPT_INVITE_MESSAGE = "GroupInviteDescription"; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0xD8
	[SerializeField]
	private Transform _groupListContainer; //Field offset: 0xE0
	[SerializeField]
	private GroupMemberView _groupMemberTemplate; //Field offset: 0xE8
	private ChatSpecialIconSettings _iconsSettings; //Field offset: 0xF0

	public GroupInviteWindow() { }

	private void ParseInvite(GroupInvite invite) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public DialogWindowContext Show(GroupInvite groupInvite) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

