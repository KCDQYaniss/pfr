namespace EFT.UI.Ragfair;

[UsedImplicitly]
public sealed class RagfairFilterWindow : Window
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__24_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Show>b__24_0(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public TMP_InputField currentField; //Field offset: 0x10
		public TMP_InputField dependField; //Field offset: 0x18
		public EManageInputFieldType type; //Field offset: 0x20

		public <>c__DisplayClass27_0() { }

		internal void <ManageInputField>b__0(string arg) { }

	}

	private enum EManageInputFieldType
	{
		InfinityOverflow = 0,
		HundredOverflow = 1,
		DependencyClamp = 2,
	}

	private const string INFINITY_CHAR = "∞"; //Field offset: 0x0
	[SerializeField]
	private DropDownBox _currencyDropdown; //Field offset: 0xB8
	[SerializeField]
	private TMP_InputField _estimatedPriceFrom; //Field offset: 0xC0
	[SerializeField]
	private TMP_InputField _estimatedPriceTo; //Field offset: 0xC8
	[SerializeField]
	private CanvasGroup _priceFromGroup; //Field offset: 0xD0
	[SerializeField]
	private CanvasGroup _priceToGroup; //Field offset: 0xD8
	[SerializeField]
	private TMP_InputField _quantityFrom; //Field offset: 0xE0
	[SerializeField]
	private TMP_InputField _quantityTo; //Field offset: 0xE8
	[SerializeField]
	private TMP_InputField _conditionFrom; //Field offset: 0xF0
	[SerializeField]
	private TMP_InputField _conditionTo; //Field offset: 0xF8
	[SerializeField]
	private Image _currencyImage; //Field offset: 0x100
	[SerializeField]
	private UpdatableToggle _hourExpiration; //Field offset: 0x108
	[SerializeField]
	private UpdatableToggle _removeBartering; //Field offset: 0x110
	[SerializeField]
	private DropDownBox _displayOwnerDropdown; //Field offset: 0x118
	[SerializeField]
	private UpdatableToggle _onlyFunctional; //Field offset: 0x120
	[SerializeField]
	private UpdatableToggle _rememberSelected; //Field offset: 0x128
	[SerializeField]
	private DefaultUIButton _applyButton; //Field offset: 0x130
	[SerializeField]
	private DefaultUIButton _resetButton; //Field offset: 0x138
	private RagFair _ragfair; //Field offset: 0x140

	protected virtual RectTransform RectTransform
	{
		 get { } //Length: 68
	}

	public RagfairFilterWindow() { }

	[CompilerGenerated]
	private void <Awake>b__22_0() { }

	[CompilerGenerated]
	private void <Awake>b__22_1() { }

	[CompilerGenerated]
	private void <Show>b__24_1(int index) { }

	[UsedImplicitly]
	protected virtual void Awake() { }

	protected virtual RectTransform get_RectTransform() { }

	private static int GetClampedValue(int inputValue, TMP_InputField dependField, EManageInputFieldType type) { }

	private static void HandleInputFieldEndEdit(TMP_InputField currentField, TMP_InputField dependField, EManageInputFieldType type, string arg) { }

	private static void ManageInputField(TMP_InputField currentField, TMP_InputField dependField, EManageInputFieldType type) { }

	private void PositionUnderAnchor(RectTransform anchorTransform) { }

	private void SetPriceFilterActive(bool status) { }

	public WindowContext Show(RagFair ragfair, RectTransform anchorTransform) { }

	private WindowContext Show(RagFair ragfair) { }

}

