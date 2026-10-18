namespace EFT.UI.Map;

public class SelectEntryPointPanel : UIElement
{
	[SerializeField]
	private GameObject _randomPointObject; //Field offset: 0x70
	[SerializeField]
	private GameObject _selectedPointObject; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _entryPointIndex; //Field offset: 0x80
	[SerializeField]
	private CustomTextMeshProUGUI _entryPointLabel; //Field offset: 0x88
	[SerializeField]
	private Button _middleButton; //Field offset: 0x90
	[SerializeField]
	private Button _leftButton; //Field offset: 0x98
	[SerializeField]
	private Button _rightButton; //Field offset: 0xA0
	private SelectEntryPointController _selectEntryPointController; //Field offset: 0xA8
	private Action _onSelected; //Field offset: 0xB0

	public EntryPoint SelectedPoint
	{
		 get { } //Length: 32
	}

	public SelectEntryPointPanel() { }

	private void Awake() { }

	public virtual void Close() { }

	public EntryPoint get_SelectedPoint() { }

	private void RefreshView(EntryPoint point) { }

	public void Select(EntryPoint point) { }

	private void SelectNext() { }

	private void SelectPrev() { }

	public void Show(bool allowSelection, EntryPoint[] points, Action onSelected = null) { }

}

