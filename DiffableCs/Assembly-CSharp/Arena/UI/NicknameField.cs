namespace Arena.UI;

public class NicknameField : UIElement
{
	[IsReadOnly]
	private struct Pair
	{
		public readonly EValidationType Type; //Field offset: 0x0
		public readonly string Regex; //Field offset: 0x8

		public Pair(EValidationType type, string regex) { }

	}

	private const float SUBMIT_DEBOUNCE = 1; //Field offset: 0x0
	private static readonly Pair[] _regexPairs; //Field offset: 0x0
	[SerializeField]
	private Image[] _statusChangableImages; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _statusLabel; //Field offset: 0x78
	[SerializeField]
	private Color _errorStatusColor; //Field offset: 0x80
	[SerializeField]
	private Color _approvedStatusColor; //Field offset: 0x90
	[SerializeField]
	[Space]
	private TMP_InputField _inputField; //Field offset: 0xA0
	[SerializeField]
	private EValidationType _validationType; //Field offset: 0xA8
	[SerializeField]
	private LocalizedText _usedSymbolsCount; //Field offset: 0xB0
	[SerializeField]
	private int _minCharsCount; //Field offset: 0xB8
	[SerializeField]
	private int _maxDigitsCount; //Field offset: 0xBC
	[SerializeField]
	[Space]
	private string _enterNicknameLocalizationKey; //Field offset: 0xC0
	[SerializeField]
	private string _validNicknameLocalizationKey; //Field offset: 0xC8
	[SerializeField]
	private GameObject _loader; //Field offset: 0xD0
	private Color[] _defaultColors; //Field offset: 0xD8
	private readonly Regex _digits; //Field offset: 0xE0
	private Regex _validator; //Field offset: 0xE8
	private Regex _replacer; //Field offset: 0xF0
	private bool _hasError; //Field offset: 0xF8
	private bool _isLastErrorFromBackend; //Field offset: 0xF9
	private ENicknameError _lastError; //Field offset: 0xFC
	private bool _debouncePending; //Field offset: 0x100
	private float _debounceTicks; //Field offset: 0x104
	private string _submittedNickname; //Field offset: 0x108
	private string _validatedNickname; //Field offset: 0x110
	private bool _awaitingBackend; //Field offset: 0x118
	[CompilerGenerated]
	private Action OnValueChanged; //Field offset: 0x120
	[CompilerGenerated]
	private Action OnNicknameSubmited; //Field offset: 0x128

	public event Action OnNicknameSubmited
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public bool IsLocallyValid
	{
		 get { } //Length: 11
	}

	public string ValidationTooltip
	{
		 get { } //Length: 268
	}

	private static NicknameField() { }

	public NicknameField() { }

	[CompilerGenerated]
	public void add_OnNicknameSubmited(Action value) { }

	[CompilerGenerated]
	public void add_OnValueChanged(Action value) { }

	private void Awake() { }

	public virtual void Close() { }

	public bool get_IsLocallyValid() { }

	public string get_ValidationTooltip() { }

	private static string GetRegexStringFrom(EValidationType validationType) { }

	public void Init(string reservedNickname) { }

	public void InvalidateBackendValidation() { }

	public void NicknameForceSubmit() { }

	private void NicknameSubmitedHandler(string nickname) { }

	private void NicknameValueChangedHandler(string nickname) { }

	[CompilerGenerated]
	public void remove_OnNicknameSubmited(Action value) { }

	[CompilerGenerated]
	public void remove_OnValueChanged(Action value) { }

	private void SetEnteredNicknameLength() { }

	private void SetInfoStatuses(string message, bool isError, bool isFromBackend = false) { }

	private void SetLoaderActive(bool active) { }

	private void ShowEmptyRequiredNickname() { }

	private void ShowNicknameError(ENicknameError error, bool isFromBackend = false) { }

	private void StopDebounce() { }

	public bool TryApplyBackendValidation(ENicknameError error) { }

	private void TrySetDefaultColors() { }

	private void TrySubmitNickname(string nickname) { }

	private void Update() { }

	public void UpdateStatusLabel() { }

	private void ValidateEnteredString(string nickname) { }

	private ENicknameError ValidationError(string textValue) { }

}

