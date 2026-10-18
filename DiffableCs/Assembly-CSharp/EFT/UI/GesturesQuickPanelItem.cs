namespace EFT.UI;

public class GesturesQuickPanelItem : UIElement
{
	[SerializeField]
	private CustomTextMeshProUGUI _label; //Field offset: 0x70
	[SerializeField]
	private Image _background; //Field offset: 0x78
	[SerializeField]
	private GameObject _yObject; //Field offset: 0x80
	[SerializeField]
	private Color _defaultBackground; //Field offset: 0x88
	[SerializeField]
	private Color _selectedBackground; //Field offset: 0x98
	[SerializeField]
	private Color _defaultText; //Field offset: 0xA8
	[SerializeField]
	private Color _selectedText; //Field offset: 0xB8

	public GesturesQuickPanelItem() { }

	public virtual void Close() { }

	public void Deselect() { }

	public void Select() { }

	public void Show(EPhraseTrigger trigger) { }

}

