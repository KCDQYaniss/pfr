namespace EFT.UI;

public sealed class GroupPanel : BaseGroupPanel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public GroupPanel <>4__this; //Field offset: 0x10
		public MatchmakerPlayersController matchmakerPlayersController; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

	}

	private const float PRE_OFFSET_X = -4; //Field offset: 0x0
	private const float PRE_OFFSET_Y = 25; //Field offset: 0x0
	private const double UPDATE_INTERVAL = 1; //Field offset: 0x0
	[SerializeField]
	private Button _backToMatchingButton; //Field offset: 0x100
	[SerializeField]
	private TextMeshProUGUI _matchingStatusLabel; //Field offset: 0x108
	[SerializeField]
	private TextMeshProUGUI _matchingTimeLabel; //Field offset: 0x110
	private bool _isOnMatchingScreen; //Field offset: 0x118
	private DateTime _startTime; //Field offset: 0x120
	private DateTime _lastUpdateTime; //Field offset: 0x128
	private TimeSpan _timePassed; //Field offset: 0x130
	private MatchmakerPlayersController _matchmakerPlayersController; //Field offset: 0x138

	private bool CanShowBackToMatchingButton
	{
		private get { } //Length: 131
	}

	public GroupPanel() { }

	protected virtual void Awake() { }

	private void ChangeStatus() { }

	private bool get_CanShowBackToMatchingButton() { }

	private void OnBackToMatchingButtonClick() { }

	protected virtual void OnEmptyViewClickHandler(PointerEventData eventData) { }

	private void ScreenChangedHandler(EEftScreenType eftScreen) { }

	public void Show(MatchmakerPlayersController matchmakerPlayersController, SocialNetwork socialNetwork) { }

	private void ShowBackToMatchingButton() { }

	public virtual void ShowContextMenu(GroupPlayer player, PointerEventData eventData) { }

	private void ShowPLayersInviteWindow(PointerEventData eventData, string profileId, IMatchmakerController matchmakerPlayersController) { }

	private void Update() { }

}

