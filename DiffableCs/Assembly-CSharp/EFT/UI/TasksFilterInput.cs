namespace EFT.UI;

public sealed class TasksFilterInput : UIElement
{
	private static bool _isPinned; //Field offset: 0x0
	private static string _pinValue; //Field offset: 0x8
	private static string _profileForPin; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnValueChanged; //Field offset: 0x70
	[SerializeField]
	private ValidationInputField _inputField; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _textCanvasGroup; //Field offset: 0x80
	[SerializeField]
	private Button _pinButton; //Field offset: 0x88
	[SerializeField]
	private Image _pinIcon; //Field offset: 0x90
	[SerializeField]
	private Button _clearButton; //Field offset: 0x98
	[SerializeField]
	private GameObject _searchIcon; //Field offset: 0xA0
	[SerializeField]
	private Sprite _pinOn; //Field offset: 0xA8
	[SerializeField]
	private Sprite _pinOff; //Field offset: 0xB0

	public event Action OnValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public string CurrentValue
	{
		 get { } //Length: 30
	}

	public bool Interactable
	{
		 get { } //Length: 30
	}

	public TasksFilterInput() { }

	[CompilerGenerated]
	public void add_OnValueChanged(Action value) { }

	private void Awake() { }

	private void Clear() { }

	public string get_CurrentValue() { }

	public bool get_Interactable() { }

	private void InputHandler(string value) { }

	[CompilerGenerated]
	public void remove_OnValueChanged(Action value) { }

	public void SetInteractable(bool interactable, bool select) { }

	private void TogglePin() { }

	public void ValidateOnShow(string profileId) { }

}

