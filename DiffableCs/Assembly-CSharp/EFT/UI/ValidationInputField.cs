namespace EFT.UI;

[UsedImplicitly]
public sealed class ValidationInputField : TMP_InputField
{
	[IsReadOnly]
	private struct Pair
	{
		public readonly EValidationType Type; //Field offset: 0x0
		public readonly string Regex; //Field offset: 0x8

		public Pair(EValidationType type, string regex) { }

	}

	private const float CHANGE_COLOR_DURATION = 0.2; //Field offset: 0x0
	private const string NO_START_WITH_SPACE_PATTERN = "^\s"; //Field offset: 0x0
	private const string NO_END_WITH_SPACE_PATTERN = "\s$"; //Field offset: 0x0
	private static readonly Pair[] _regexPairs; //Field offset: 0x0
	private BindableEvent _onValidatedTextChanged; //Field offset: 0x2F8
	[SerializeField]
	private TextMeshProUGUI _errorLabel; //Field offset: 0x300
	[SerializeField]
	private LocalizedText _usedSymbolsCount; //Field offset: 0x308
	[SerializeField]
	private Color _usedSymbolsColor; //Field offset: 0x310
	[SerializeField]
	private Color _outOfRangeColor; //Field offset: 0x320
	[SerializeField]
	private Color _defaultColor; //Field offset: 0x330
	[SerializeField]
	private EValidationType _validationType; //Field offset: 0x340
	[SerializeField]
	private int _minCharsCount; //Field offset: 0x344
	[SerializeField]
	private int _maxDigitsCount; //Field offset: 0x348
	private readonly Regex _digits; //Field offset: 0x350
	private Regex _validator; //Field offset: 0x358
	private Regex _replacer; //Field offset: 0x360
	public readonly BindableState HasError; //Field offset: 0x368
	public readonly BindableState CurrentErrorType; //Field offset: 0x370

	public IBindableEvent OnValidatedTextChanged
	{
		 get { } //Length: 8
	}

	private static ValidationInputField() { }

	public ValidationInputField() { }

	[CompilerGenerated]
	private void <ShowMessage>b__31_0() { }

	[CompilerGenerated]
	private void <ShowMessage>b__31_1() { }

	protected virtual void Awake() { }

	public void DeSelect() { }

	public IBindableEvent get_OnValidatedTextChanged() { }

	private static string GetRegexStringFrom(EValidationType validationType) { }

	public void HideSymbolCountLabel(bool needHide) { }

	private void Init() { }

	protected virtual void OnEnable() { }

	private void SetEnteredNicknameLength() { }

	public void ShowError(ENicknameError error) { }

	public void ShowErrorFromCode(int errorCode) { }

	public void ShowMessage(string message, bool isError, ENicknameError errorType) { }

	public void ValidateCurrentInput() { }

	private void ValidateEnteredString(string nickname) { }

	private ENicknameError ValidationError(string textValue) { }

}

