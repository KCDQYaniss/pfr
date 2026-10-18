namespace EFT.UI;

public class ConsoleAutoCompleteItem : MonoBehaviour
{
	[SerializeField]
	private Color _activeColor; //Field offset: 0x20
	[SerializeField]
	private Color _inactiveColor; //Field offset: 0x30
	[SerializeField]
	private TMP_Text _text; //Field offset: 0x40
	[SerializeField]
	private Image _background; //Field offset: 0x48
	private bool _isSelected; //Field offset: 0x50

	public bool IsSelected
	{
		 get { } //Length: 5
		 set { } //Length: 75
	}

	public ConsoleAutoCompleteItem() { }

	public bool get_IsSelected() { }

	public void set_IsSelected(bool value) { }

	public void Setup(AutoCompleteItem item) { }

}

