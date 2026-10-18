namespace EFT.UI.Matchmaker;

public sealed class MatchMakerPlayerPreview : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public MatchmakerPlayersController matchmaker; //Field offset: 0x10
		public MatchMakerPlayerPreview <>4__this; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private struct <Show>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerPlayersController matchmaker; //Field offset: 0x20
		public MatchMakerPlayerPreview <>4__this; //Field offset: 0x28
		public RaidPlayer player; //Field offset: 0x30
		public RaidSettings raidSettings; //Field offset: 0x38
		public RaidGroupContextInteractions contextInteractions; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int NICKNAME_SIZE = 20; //Field offset: 0x0
	private const int NICKNAME_SIZE_WITH_SCAV = 19; //Field offset: 0x0
	[SerializeField]
	private PlayerModelView _playerModelView; //Field offset: 0x70
	[SerializeField]
	private Image _noVisualImage; //Field offset: 0x78
	[SerializeField]
	private RawImage _playerVisualImage; //Field offset: 0x80
	[SerializeField]
	private PlayerNamePanel _namePanel; //Field offset: 0x88
	[SerializeField]
	private ChatSpecialIcon _scavName; //Field offset: 0x90
	[SerializeField]
	private TextMeshProUGUI _groupStatusField; //Field offset: 0x98
	[SerializeField]
	private InteractionButtonsContainer _interactionButtons; //Field offset: 0xA0
	[SerializeField]
	private PlayerLevelPanel _levelPanel; //Field offset: 0xA8
	[SerializeField]
	private bool _isMainCharacter; //Field offset: 0xB0
	private PlayerInfo _mainProfileInfo; //Field offset: 0xB8
	private MatchmakerPlayersController _matchmaker; //Field offset: 0xC0
	private RaidPlayer _player; //Field offset: 0xC8
	private RaidGroupContextInteractions _contextInteractions; //Field offset: 0xD0
	[CompilerGenerated]
	private string <PlayerAid>k__BackingField; //Field offset: 0xD8

	public private string PlayerAid
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public MatchMakerPlayerPreview() { }

	[CompilerGenerated]
	public string get_PlayerAid() { }

	private void MatchingTypeUpdateHandler(EMatchingType _) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	[CompilerGenerated]
	private void set_PlayerAid(string value) { }

	private void SetInteractionsActive(bool active) { }

	[AsyncStateMachine(typeof(<Show>d__19))]
	public Task Show(MatchmakerPlayersController matchmaker, RaidSettings raidSettings, RaidPlayer player, RaidGroupContextInteractions contextInteractions) { }

	private void UpdateGroupStatus() { }

	private void UpdateVisual() { }

}

