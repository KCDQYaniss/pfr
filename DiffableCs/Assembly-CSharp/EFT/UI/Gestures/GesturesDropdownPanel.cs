namespace EFT.UI.Gestures;

public class GesturesDropdownPanel : UIInputNode
{
	[SerializeField]
	private GesturesQuickPanelItem _quickTemplate; //Field offset: 0x80
	[SerializeField]
	private RectTransform _container; //Field offset: 0x88
	[SerializeField]
	private GameObject _dropdownObject; //Field offset: 0x90
	private readonly SortedDictionary _views; //Field offset: 0x98
	private readonly SortedDictionary _cache; //Field offset: 0xA0
	internal EPhraseTrigger SelectedPhrase; //Field offset: 0xA8
	private int _scrollIndex; //Field offset: 0xAC

	public bool DropdownPanelActive
	{
		 get { } //Length: 93
	}

	public GesturesDropdownPanel() { }

	public void AddCommand(EPhraseTrigger trigger) { }

	public void CloseDropdown() { }

	public bool get_DropdownPanelActive() { }

	private GesturesQuickPanelItem MakeView(EPhraseTrigger trigger) { }

	private void RearrangeViews() { }

	public void RemoveCommand(EPhraseTrigger trigger) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void ShowDropdown() { }

	private void Start() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void WarmUpCache() { }

}

