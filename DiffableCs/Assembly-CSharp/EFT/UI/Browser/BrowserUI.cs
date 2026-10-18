namespace EFT.UI.Browser;

public class BrowserUI
{
	[Header("Top bar")]
	[SerializeField]
	private GameObject _rootControlsGroup; //Field offset: 0x10
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0x18
	[SerializeField]
	private DefaultUIButton _forwardButton; //Field offset: 0x20
	[SerializeField]
	private DefaultUIButton _reloadButton; //Field offset: 0x28
	[SerializeField]
	private DefaultUIButton _closeButton; //Field offset: 0x30
	[SerializeField]
	private ValidationInputField _addressField; //Field offset: 0x38
	[SerializeField]
	private TextMeshProUGUI _statusLabel; //Field offset: 0x40
	[SerializeField]
	private PreloaderPanelBase _defaultPlaceholder; //Field offset: 0x48
	[SerializeField]
	private PreloaderPanelBase _shopPlaceholder; //Field offset: 0x50
	private bool _suppressAddressSubmit; //Field offset: 0x58
	private bool _navigationEnabled; //Field offset: 0x59
	private EBrowserType _browserType; //Field offset: 0x5C
	private PreloaderPanelBase _selectedPlaceholder; //Field offset: 0x60

	public bool IsAddressSubmitSuppressed
	{
		 get { } //Length: 5
	}

	public BrowserUI() { }

	public bool get_IsAddressSubmitSuppressed() { }

	public void Initialize(EBrowserType browserType, UnityAction onBack, UnityAction onForward, UnityAction onReload, UnityAction onClose, UnityAction onAddressSubmit) { }

	private void SelectPlaceholder() { }

	public void SetAddress(string url) { }

	public void SetNavigationEnabled(bool enabled) { }

	public void SetPlaceholderVisible(bool visible, bool soft) { }

	public void SetStatus(string status) { }

	public void UpdateNavigationButtons(bool canGoBack, bool canGoForward, bool canReload) { }

}

