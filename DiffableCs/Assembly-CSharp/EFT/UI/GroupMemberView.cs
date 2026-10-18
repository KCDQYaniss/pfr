namespace EFT.UI;

public sealed class GroupMemberView : ButtonFeedback
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public GroupMemberView <>4__this; //Field offset: 0x10
		public GroupPlayer player; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <Show>b__0(RaidPlayer owner) { }

	}

	[CompilerGenerated]
	private Action OnGroupMemberClick; //Field offset: 0xA8
	[SerializeField]
	private Image _bgImage; //Field offset: 0xB0
	[SerializeField]
	private Image _border; //Field offset: 0xB8
	[SerializeField]
	private Image _borderLeader; //Field offset: 0xC0
	[SerializeField]
	private Sprite _bgIdle; //Field offset: 0xC8
	[SerializeField]
	private Sprite _bgHover; //Field offset: 0xD0
	[SerializeField]
	private Sprite _borderIdle; //Field offset: 0xD8
	[SerializeField]
	private Sprite _borderHover; //Field offset: 0xE0
	[SerializeField]
	private Sprite _borderLeaderIdle; //Field offset: 0xE8
	[SerializeField]
	private Sprite _borderLeaderHover; //Field offset: 0xF0
	[SerializeField]
	private TextMeshProUGUI _nicknameLetter; //Field offset: 0xF8
	[SerializeField]
	private ChatSpecialIcon _playerNickname; //Field offset: 0x100
	private SimpleTooltip _tooltip; //Field offset: 0x108
	private GroupPlayer _player; //Field offset: 0x110
	private bool _isLeader; //Field offset: 0x118

	public event Action OnGroupMemberClick
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public GroupMemberView() { }

	[CompilerGenerated]
	public void add_OnGroupMemberClick(Action value) { }

	private void HoverHandler(bool hover) { }

	private void Init(GroupPlayer player) { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	[CompilerGenerated]
	public void remove_OnGroupMemberClick(Action value) { }

	public void Show(GroupPlayer player, BindableState groupOwner) { }

	public void Show(GroupPlayer player) { }

}

