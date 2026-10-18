namespace EFT.UI;

public class LocationLabel : UIElement
{
	[SerializeField]
	private CustomTextMeshProUGUI _headerLabel; //Field offset: 0x70
	[SerializeField]
	private GameObject _availableIcon; //Field offset: 0x78
	[SerializeField]
	private GameObject _lockedIcon; //Field offset: 0x80
	[SerializeField]
	private Image _iconImage; //Field offset: 0x88
	[SerializeField]
	private Color _selectedColor; //Field offset: 0x90
	[SerializeField]
	private Color _idleColor; //Field offset: 0xA0

	public LocationLabel() { }

	public void Show(Location location, bool selected) { }

}

