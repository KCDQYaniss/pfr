namespace EFT.UI;

public sealed class CardSelectionPanel : UIElement
{
	[SerializeField]
	private Image _selectedItemIcon; //Field offset: 0x70
	[SerializeField]
	private Sprite _emptyIcon; //Field offset: 0x78
	[SerializeField]
	private GameObject _noCardTooltip; //Field offset: 0x80
	[SerializeField]
	private Button _dropdownButton; //Field offset: 0x88
	[SerializeField]
	private Sprite _closeButtonIcon; //Field offset: 0x90
	[SerializeField]
	private Sprite _openButtonIcon; //Field offset: 0x98
	[SerializeField]
	private RectTransform _container; //Field offset: 0xA0
	[SerializeField]
	private KeyCardItem _cardItemPrefab; //Field offset: 0xA8
	private Item _currentCard; //Field offset: 0xB0
	private Action _cardSelected; //Field offset: 0xB8
	private bool _menuOpen; //Field offset: 0xC0
	private ItemIcon _realItemIcon; //Field offset: 0xC8

	public CardSelectionPanel() { }

	[CompilerGenerated]
	private void <Show>b__13_0(Item item, KeyCardItem view) { }

	private void Awake() { }

	private void DropdownButtonClickHandler() { }

	public void Hide() { }

	private void IconChangedHandler() { }

	private void OnCardSelected(Item item) { }

	private void ScaleImage(Vector2 size) { }

	private void SetDropdownOpenStatus(bool isOpen) { }

	private void SetItemIcon(Item item) { }

	public void Show(Item currentSelectedCard, Item[] availableCards, Action cardSelected) { }

}

