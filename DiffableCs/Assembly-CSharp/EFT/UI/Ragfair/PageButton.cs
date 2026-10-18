namespace EFT.UI.Ragfair;

public class PageButton : UIElement
{
	[SerializeField]
	private Image _buttonImage; //Field offset: 0x70
	[SerializeField]
	private Color _selectedColor; //Field offset: 0x78
	[SerializeField]
	private Color _nonSelectedColor; //Field offset: 0x88
	[SerializeField]
	private Button _button; //Field offset: 0x98
	[SerializeField]
	private TextMeshProUGUI _label; //Field offset: 0xA0
	private bool _pageSelected; //Field offset: 0xA8
	private int _page; //Field offset: 0xAC
	private Action _onClick; //Field offset: 0xB0

	public PageButton() { }

	[CompilerGenerated]
	private void <Awake>b__8_0() { }

	private void Awake() { }

	public void Show(bool pageSelected, int page, Action onClick) { }

}

