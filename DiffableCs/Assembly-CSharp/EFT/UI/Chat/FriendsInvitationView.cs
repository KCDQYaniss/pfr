namespace EFT.UI.Chat;

public class FriendsInvitationView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	[SerializeField]
	private TextMeshProUGUI _playerNameLabel; //Field offset: 0x70
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0x78
	[SerializeField]
	private Image _friendIcon; //Field offset: 0x80
	[SerializeField]
	private ChatSpecialIcon _icon; //Field offset: 0x88
	[SerializeField]
	private Sprite _inputInvitation; //Field offset: 0x90
	[SerializeField]
	private Sprite _outputInvitation; //Field offset: 0x98
	[SerializeField]
	private Color _defaultImageColor; //Field offset: 0xA0
	[SerializeField]
	private Color _selectedImageColor; //Field offset: 0xB0
	private UpdatableFriendsInvitation _invitation; //Field offset: 0xC0
	private Action _onClick; //Field offset: 0xC8

	public FriendsInvitationView() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Show(UpdatableFriendsInvitation invitation, Action onClick) { }

}

