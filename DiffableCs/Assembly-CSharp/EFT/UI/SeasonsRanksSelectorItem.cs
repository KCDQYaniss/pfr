namespace EFT.UI;

public sealed class SeasonsRanksSelectorItem : UIElement, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField]
	private GameObject _playerLabel; //Field offset: 0x70
	[SerializeField]
	private Image _icon; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _title; //Field offset: 0x80
	[SerializeField]
	private Color _iconHoverColor; //Field offset: 0x88
	[SerializeField]
	private Color _textHoverColor; //Field offset: 0x98
	[SerializeField]
	private Color _iconFadeColor; //Field offset: 0xA8
	[SerializeField]
	private Color _textFadeColor; //Field offset: 0xB8
	private int _rank; //Field offset: 0xC8
	private Action _clickAction; //Field offset: 0xD0

	public SeasonsRanksSelectorItem() { }

	public void Init(Action clickAction) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void SetHoverState(bool hover) { }

	public void Show(bool activePlayer, int rank) { }

}

