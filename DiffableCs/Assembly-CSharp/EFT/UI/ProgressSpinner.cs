namespace EFT.UI;

public class ProgressSpinner : UIElement
{
	[SerializeField]
	private Image _fillImage; //Field offset: 0x70
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0x78

	public ProgressSpinner() { }

	public void SetColor(Color color) { }

	public void SetProgress(float progress) { }

	public void Show() { }

}

