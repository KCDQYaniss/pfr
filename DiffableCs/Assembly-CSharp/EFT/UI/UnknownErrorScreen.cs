namespace EFT.UI;

public sealed class UnknownErrorScreen : UIInputNode
{
	private const string DEFAULT_HEADER = "ERROR"; //Field offset: 0x0
	private Action _acceptCallback; //Field offset: 0x80
	[SerializeField]
	private CustomTextMeshProUGUI _errorHeader; //Field offset: 0x88
	[SerializeField]
	private CustomTextMeshProUGUI _errorMessage; //Field offset: 0x90
	[SerializeField]
	private CustomTextMeshProUGUI _errorDescription; //Field offset: 0x98
	[SerializeField]
	private DefaultUIButton _closeButton; //Field offset: 0xA0
	[SerializeField]
	private DefaultUIButton _copyButton; //Field offset: 0xA8

	public UnknownErrorScreen() { }

	private void Awake() { }

	private void CopyToClipboard() { }

	private void Hide() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void Show(string header, string message, string fullDescription, Action acceptCallback = null) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

}

