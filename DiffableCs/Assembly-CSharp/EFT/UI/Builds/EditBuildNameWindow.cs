namespace EFT.UI.Builds;

public sealed class EditBuildNameWindow : Window
{
	[SerializeField]
	private ValidationInputField _inputField; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _saveButtonSpawner; //Field offset: 0xC0
	[SerializeField]
	private TextMeshProUGUI _placeholderText; //Field offset: 0xC8

	protected virtual bool ShowOnTop
	{
		 get { } //Length: 3
	}

	public EditBuildNameWindow() { }

	private void Apply() { }

	protected virtual void Awake() { }

	protected virtual bool get_ShowOnTop() { }

	private void InputFieldValueChanged(bool hasError) { }

	public EditBuildNameWindowContext Show(string savedName, string caption, string placeholderText) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

