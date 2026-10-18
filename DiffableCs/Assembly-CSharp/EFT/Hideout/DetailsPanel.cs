namespace EFT.Hideout;

public class DetailsPanel : UIElement
{
	[SerializeField]
	private Image _colorPanel; //Field offset: 0x70
	[SerializeField]
	private Image _detailsIcon; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _detailsStatus; //Field offset: 0x80

	public DetailsPanel() { }

	public void SetBackgroundColor(Color color) { }

	public void SetIcon(Sprite icon) { }

	public void SetText(string text) { }

}

