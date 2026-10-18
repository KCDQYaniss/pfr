namespace EFT.UI.Matchmaker;

public sealed class RaidReadyPlayerPanel : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler, IPointerDownHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public RaidReadyPlayerPanel <>4__this; //Field offset: 0x10
		public BindableList invites; //Field offset: 0x18
		public RaidPlayer player; //Field offset: 0x20
		public Func <>9__1; //Field offset: 0x28

		public <>c__DisplayClass24_0() { }

		internal void <Show>b__0() { }

		internal bool <Show>b__1(GroupInvite invite) { }

	}

	[CompilerGenerated]
	private Action OnPlayerClick; //Field offset: 0x70
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0x78
	[SerializeField]
	private Color _defaultImageColor; //Field offset: 0x80
	[SerializeField]
	private Color _yourImageColor; //Field offset: 0x90
	[SerializeField]
	private Color _selectedImageColor; //Field offset: 0xA0
	[SerializeField]
	private Image _platformImage; //Field offset: 0xB0
	[SerializeField]
	private ChatSpecialIcon _icon; //Field offset: 0xB8
	[SerializeField]
	private GreenTeamMarkerView _greenTeamMarker; //Field offset: 0xC0
	[SerializeField]
	private GameObject _pinRoot; //Field offset: 0xC8
	[SerializeField]
	private GameObject _unpinnedIcon; //Field offset: 0xD0
	[SerializeField]
	private GameObject _pinnedIcon; //Field offset: 0xD8
	[SerializeField]
	private FriendPinClickHandler _unpinnedClick; //Field offset: 0xE0
	[SerializeField]
	private FriendPinClickHandler _pinnedClick; //Field offset: 0xE8
	[SerializeField]
	private CustomTextMeshProUGUI _sideLabel; //Field offset: 0xF0
	[SerializeField]
	private CustomTextMeshProUGUI _statusLabel; //Field offset: 0xF8
	[SerializeField]
	private GameObject _inviteSentGameObject; //Field offset: 0x100
	[SerializeField]
	private GameObject _lookingForGroupGameObject; //Field offset: 0x108
	private RaidPlayer _player; //Field offset: 0x110
	private UpdatableChatMember _friendMember; //Field offset: 0x118
	private bool _yourPanel; //Field offset: 0x120
	private bool _isFriendPanel; //Field offset: 0x121
	private bool _allowFriendPin; //Field offset: 0x122

	public event Action OnPlayerClick
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public RaidReadyPlayerPanel() { }

	[CompilerGenerated]
	public void add_OnPlayerClick(Action value) { }

	private void BindPinClicks() { }

	private void HandlePinClick(PointerEventData eventData) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnPlayerClick(Action value) { }

	private void SetBackgroundImage() { }

	public void SetInviteSentStatus(bool value) { }

	public void SetLookingForGroupStatus() { }

	public void Show(RaidPlayer player, bool yourPanel, UpdatableChatMember friendMember, BindableList invites, bool allowFriendPin = false) { }

	private void ToggleFriendPin() { }

	private void UpdatePinState() { }

}

