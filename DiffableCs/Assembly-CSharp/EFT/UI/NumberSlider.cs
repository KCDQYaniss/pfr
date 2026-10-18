namespace EFT.UI;

public sealed class NumberSlider : UIInputNode, IValueUpdatable
{
	private enum EFocusState
	{
		NotInFocus = 0,
		InFocus = 1,
		AfterFocusFrame = 2,
	}

	private const string NUMBERS_AFTER_DOT_REGEX = "(?<=\.)(\d+)"; //Field offset: 0x0
	[SerializeField]
	private Slider _slider; //Field offset: 0x80
	[SerializeField]
	private TMP_InputField _valueInput; //Field offset: 0x88
	private string _format; //Field offset: 0x90
	private float _maxValue; //Field offset: 0x98
	private float _minValue; //Field offset: 0x9C
	private string _cachedOriginalText; //Field offset: 0xA0
	private Action _onValueChanged; //Field offset: 0xA8
	private bool _rollbackRequired; //Field offset: 0xB0
	private EFocusState _focusState; //Field offset: 0xB4

	public NumberSlider() { }

	[CompilerGenerated]
	private void <Awake>b__11_0(string value) { }

	[CompilerGenerated]
	private void <Awake>b__11_1(string value) { }

	private void Awake() { }

	public override void Bind(Action valueChanged) { }

	public override float CurrentValue() { }

	public void DeSelect() { }

	private string FormattedValue(float value) { }

	private void RevertOriginalValue() { }

	private void SetCurrentValue(float value) { }

	private void SetStringValue(string value) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public void Show(float minValue, float maxValue, string format) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

	public override void UpdateValue(float value, bool sendCallback = true, Nullable min = null, Nullable max = null) { }

}

