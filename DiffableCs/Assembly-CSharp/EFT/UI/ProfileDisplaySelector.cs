namespace EFT.UI;

public sealed class ProfileDisplaySelector : MonoBehaviour
{
	[SerializeField]
	private SlotViewHeader _slotHeader; //Field offset: 0x20
	[SerializeField]
	private Image _currentIcon; //Field offset: 0x28
	[SerializeField]
	private GameObject _optionsRoot; //Field offset: 0x30
	[SerializeField]
	private Transform _optionsContainer; //Field offset: 0x38
	[SerializeField]
	private ProfileDisplayOptionView _optionTemplate; //Field offset: 0x40
	private readonly List _views; //Field offset: 0x48
	private string _selectedId; //Field offset: 0x50
	private bool _canOpen; //Field offset: 0x58
	[CompilerGenerated]
	private Action Opened; //Field offset: 0x60
	[CompilerGenerated]
	private Action Selected; //Field offset: 0x68

	public event Action Opened
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action Selected
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public ProfileDisplaySelector() { }

	[CompilerGenerated]
	public void add_Opened(Action value) { }

	[CompilerGenerated]
	public void add_Selected(Action value) { }

	private void ApplyCurrentIcon(ProfileDisplayOption option) { }

	private void Awake() { }

	public void Close() { }

	private void CloseOptions() { }

	private void ClosePanel() { }

	public void Collapse() { }

	private void CreateOptions(IReadOnlyList options) { }

	private static ProfileDisplayOption FindOption(IReadOnlyList options, string id) { }

	private static bool HasAvailable(IReadOnlyList options) { }

	private void OnHeaderSelected(bool selected) { }

	private void OnOptionClicked(ProfileDisplayOptionView view) { }

	private void PlaceWindow() { }

	[CompilerGenerated]
	public void remove_Opened(Action value) { }

	[CompilerGenerated]
	public void remove_Selected(Action value) { }

	public void Select(string id) { }

	private void SetOpen(bool isOpen) { }

	public void Show(string header, IReadOnlyList options, string selectedId, bool canSelect) { }

}

