namespace EFT.UI.Matchmaker;

public sealed class GroupPlayersList : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public IList friends; //Field offset: 0x10
		public string profileAid; //Field offset: 0x18
		public BindableState group; //Field offset: 0x20
		public GroupPlayersList <>4__this; //Field offset: 0x28

		public <>c__DisplayClass6_0() { }

		internal void <Show>b__0(RaidPlayer player, AbstractGroupPlayerPanel playerPanel) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_1
	{
		public RaidPlayer player; //Field offset: 0x10
		public AbstractGroupPlayerPanel playerPanel; //Field offset: 0x18
		public <>c__DisplayClass6_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass6_1() { }

		internal bool <Show>b__1(UpdatableChatMember foundFriend) { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private Action OnPlayerClick; //Field offset: 0x70
	[SerializeField]
	private RectTransform _groupPlayersContainer; //Field offset: 0x78
	[SerializeField]
	private AbstractGroupPlayerPanel _groupPlayerPanelTemplate; //Field offset: 0x80
	private BindableViewList _views; //Field offset: 0x88

	public event Action OnPlayerClick
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public GroupPlayersList() { }

	[CompilerGenerated]
	public void add_OnPlayerClick(Action value) { }

	private void PlayerPanelOnPlayerClick(RaidPlayer player, Vector2 position) { }

	[CompilerGenerated]
	public void remove_OnPlayerClick(Action value) { }

	public void Show(BindableList playersList, BindableState group, IList friends, string profileAid) { }

	private void UpdateLeader(RaidPlayer leader) { }

}

