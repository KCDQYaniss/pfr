namespace EFT;

public class RequiredItem : UIElement
{
	private const string GROUP_SEPARATOR = " "; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _text; //Field offset: 0x70
	[SerializeField]
	private Image _image; //Field offset: 0x78
	private NumberFormatInfo _formatInfo; //Field offset: 0x80
	private ItemRequirements _requirement; //Field offset: 0x88
	private Func _available; //Field offset: 0x90
	private Sprite _sprite; //Field offset: 0x98
	private Color _badColor; //Field offset: 0xA0
	private Color _goodColor; //Field offset: 0xB0

	public RequiredItem() { }

	public void Show(ItemRequirements requirement, Color goodColor, Color badColor, Func available, Sprite sprite) { }

	public void UpdateView() { }

}

