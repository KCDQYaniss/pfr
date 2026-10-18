namespace EFT.UI.Matchmaker;

public abstract class AbstractGroupPlayerPanel : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler, IPointerDownHandler
{
	protected const float HOVER_VALUE = 0.76; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnPlayerClick; //Field offset: 0x70
	[SerializeField]
	protected Image _backgroundImage; //Field offset: 0x78
	[SerializeField]
	protected Image _platformImage; //Field offset: 0x80
	[SerializeField]
	protected ChatSpecialIcon _icon; //Field offset: 0x88
	[SerializeField]
	protected GreenTeamMarkerView _greenTeamMarker; //Field offset: 0x90
	[SerializeField]
	protected CustomTextMeshProUGUI _sideLabel; //Field offset: 0x98
	[SerializeField]
	protected CustomTextMeshProUGUI _statusLabel; //Field offset: 0xA0
	protected RaidPlayer _player; //Field offset: 0xA8
	protected bool _yourPanel; //Field offset: 0xB0
	protected bool _isFriendPanel; //Field offset: 0xB1
	protected bool _isHovered; //Field offset: 0xB2
	protected RaidPlayer _owner; //Field offset: 0xB8

	public event Action OnPlayerClick
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected AbstractGroupPlayerPanel() { }

	[CompilerGenerated]
	public void add_OnPlayerClick(Action value) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	[CompilerGenerated]
	public void remove_OnPlayerClick(Action value) { }

	protected abstract void SetBackgroundImage(bool hover) { }

	public abstract void Show(RaidPlayer player, UpdatableChatMember friendMember, string profileAid, BindableState groupOwner) { }

}

