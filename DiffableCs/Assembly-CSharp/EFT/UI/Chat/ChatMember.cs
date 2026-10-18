namespace EFT.UI.Chat;

public class ChatMember : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	[SerializeField]
	private TextMeshProUGUI _playerNameLabel; //Field offset: 0x70
	[SerializeField]
	private ChatSpecialIcon _specialIcon; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x80
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0x88
	[SerializeField]
	private GameObject _muteIcon; //Field offset: 0x90
	[SerializeField]
	private GameObject _banIcon; //Field offset: 0x98
	[SerializeField]
	private Image _steamIcon; //Field offset: 0xA0
	[SerializeField]
	private Color _defaultImageColor; //Field offset: 0xA8
	[SerializeField]
	private Color _hoveredImageColor; //Field offset: 0xB8
	[SerializeField]
	private Color _chosenHoverImageColor; //Field offset: 0xC8
	[SerializeField]
	private Color _chosenImageColor; //Field offset: 0xD8
	private UpdatableChatMember _member; //Field offset: 0xE8
	private Action _onClick; //Field offset: 0xF0
	private bool _markedAsChosen; //Field offset: 0xF8

	public ChatMember() { }

	public void MarkAsChosen(bool state) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void SetBanStatus(bool value) { }

	public void Show(UpdatableChatMember member, UpdatableChatMember playerMember, bool active, Action onClick) { }

	public void UpdateIgnoreStatus() { }

	private void UpdateSteamIconVisibility() { }

}

