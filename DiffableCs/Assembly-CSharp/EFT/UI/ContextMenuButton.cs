namespace EFT.UI;

public sealed class ContextMenuButton : SimpleContextMenuButton
{
	[SerializeField]
	private Image _icon; //Field offset: 0xF0
	[SerializeField]
	private GameObject _iconContainer; //Field offset: 0xF8
	[SerializeField]
	private TextMeshProUGUI _text; //Field offset: 0x100
	[SerializeField]
	private TextMeshProUGUI _iconLabel; //Field offset: 0x108
	[SerializeField]
	private GameObject _loader; //Field offset: 0x110

	public ContextMenuButton() { }

	public virtual void Show(string caption, string imageText, Sprite sprite, Action onClicked, Action onHover, bool subMenu = false, bool hideIcon = false) { }

}

