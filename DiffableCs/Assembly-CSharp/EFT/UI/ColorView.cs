namespace EFT.UI;

public class ColorView : MonoBehaviour
{
	[SerializeField]
	private GameObject _selectBorder; //Field offset: 0x20
	[SerializeField]
	private Image _colorImage; //Field offset: 0x28
	[CompilerGenerated]
	private EventHandler OnSelected; //Field offset: 0x30

	public event EventHandler OnSelected
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public Color Color
	{
		 get { } //Length: 62
	}

	public ColorView() { }

	[CompilerGenerated]
	public void add_OnSelected(EventHandler value) { }

	public Color get_Color() { }

	public void OnClick() { }

	[CompilerGenerated]
	public void remove_OnSelected(EventHandler value) { }

	public void SelectionChanged(bool selected) { }

	public void Show(Color color) { }

}

