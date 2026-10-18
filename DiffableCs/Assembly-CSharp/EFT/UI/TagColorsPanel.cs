namespace EFT.UI;

public class TagColorsPanel : MonoBehaviour
{
	[SerializeField]
	private GameObject _cellTemplate; //Field offset: 0x20
	private ColorView[] _cells; //Field offset: 0x28
	private Action _onSelected; //Field offset: 0x30

	public TagColorsPanel() { }

	private void CellSelectedHandler(object sender, EventArgs args) { }

	public void Hide() { }

	public void Show(Color[] colors, int selectedIndex, Action OnSelected) { }

}

