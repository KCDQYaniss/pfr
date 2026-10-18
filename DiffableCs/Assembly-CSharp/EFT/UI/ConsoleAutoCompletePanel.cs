namespace EFT.UI;

public class ConsoleAutoCompletePanel : MonoBehaviour
{
	private const int MAX_ITEMS_HARD_LIMIT = 30; //Field offset: 0x0
	[SerializeField]
	private GameObject _container; //Field offset: 0x20
	[SerializeField]
	private ConsoleAutoCompleteItem _prefabItem; //Field offset: 0x28
	[SerializeField]
	private GameObject _documentationContainer; //Field offset: 0x30
	[SerializeField]
	private TMP_Text _documentation; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnSelect; //Field offset: 0x40
	private int _selectedIndex; //Field offset: 0x48
	private List _items; //Field offset: 0x50

	public event Action OnSelect
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public ConsoleAutoCompletePanel() { }

	[CompilerGenerated]
	public void add_OnSelect(Action value) { }

	private void Awake() { }

	private void LateUpdate() { }

	[CompilerGenerated]
	public void remove_OnSelect(Action value) { }

	public void UpdateList(AutoCompleteItem[] items) { }

	private void UpdateSelectedIndicator() { }

}

