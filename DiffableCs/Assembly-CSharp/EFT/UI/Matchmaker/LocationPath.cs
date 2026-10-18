namespace EFT.UI.Matchmaker;

public class LocationPath : UIElement
{
	[SerializeField]
	private Image _image; //Field offset: 0x70
	[SerializeField]
	private Color _selectedColor; //Field offset: 0x78
	[SerializeField]
	private Color _idleColor; //Field offset: 0x88

	public LocationPath() { }

	public void Show(Location source, Location destination, bool selected) { }

}

