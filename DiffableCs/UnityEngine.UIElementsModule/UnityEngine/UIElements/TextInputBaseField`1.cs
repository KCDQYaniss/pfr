namespace UnityEngine.UIElements;

public abstract class TextInputBaseField`1 : BaseField
{
	private abstract class TextInputBase : VisualElement
	{
		public static readonly string verticalHorizontalVariantInnerTextElementUssClassName; //Field offset: 0x0
		public static readonly string innerComponentsModifierName; //Field offset: 0x0
		public static readonly string innerTextElementUssClassName; //Field offset: 0x0
		internal static readonly string innerTextElementWithScrollViewUssClassName; //Field offset: 0x0
		public static readonly string horizontalVariantInnerTextElementUssClassName; //Field offset: 0x0
		public static readonly string verticalVariantInnerTextElementUssClassName; //Field offset: 0x0
		public static readonly string innerScrollviewUssClassName; //Field offset: 0x0
		public static readonly string innerViewportUssClassName; //Field offset: 0x0
		public static readonly string innerContentContainerUssClassName; //Field offset: 0x0
		private bool m_ScrollViewWasClamped; //Field offset: 0x0
		internal Vector2 scrollOffset; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private bool <isDragging>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private TextElement <textElement>k__BackingField; //Field offset: 0x0
		internal VisualElement multilineContainer; //Field offset: 0x0
		internal ScrollView scrollView; //Field offset: 0x0
		private Vector2 lastCursorPos; //Field offset: 0x0
		private ScrollerVisibility m_VerticalScrollerVisibility; //Field offset: 0x0

		internal bool isDragging
		{
			[CompilerGenerated]
			internal set { } //Length: 7
		}

		public override bool isPasswordField
		{
			 get { } //Length: 81
			 set { } //Length: 97
		}

		public bool isReadOnly
		{
			 get { } //Length: 81
		}

		public char maskChar
		{
			 set { } //Length: 97
		}

		public int maxLength
		{
			 set { } //Length: 95
		}

		internal string originalText
		{
			internal get { } //Length: 33
		}

		public string text
		{
			 get { } //Length: 45
			 set { } //Length: 147
		}

		public ITextEdition textEdition
		{
			 get { } //Length: 26
		}

		internal TextElement textElement
		{
			[CompilerGenerated]
			internal get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public ITextSelection textSelection
		{
			 get { } //Length: 26
		}

		private static TextInputBase() { }

		internal TextInputBase() { }

		internal override bool AcceptCharacter(char c) { }

		public override bool get_isPasswordField() { }

		public bool get_isReadOnly() { }

		internal string get_originalText() { }

		public string get_text() { }

		public ITextEdition get_textEdition() { }

		[CompilerGenerated]
		internal TextElement get_textElement() { }

		public ITextSelection get_textSelection() { }

		private Vector2 GetScrollOffset(float xOffset, float yOffset, float contentViewportWidth, bool isBackspace, bool widthChanged) { }

		private void MakeSureScrollViewDoesNotLeakEvents(ChangeEvent evt) { }

		internal void MoveFocusToCompositeRoot() { }

		internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e) { }

		private void RemoveMultilineComponents() { }

		private void RemoveSingleLineComponents() { }

		private void ScrollViewOnGeometryChangedEvent(GeometryChangedEvent e) { }

		public void SelectAll() { }

		internal void SelectNone() { }

		[CompilerGenerated]
		internal void set_isDragging(bool value) { }

		public override void set_isPasswordField(bool value) { }

		public void set_maskChar(char value) { }

		public void set_maxLength(int value) { }

		public void set_text(string value) { }

		[CompilerGenerated]
		private void set_textElement(TextElement value) { }

		internal void SetMultiline() { }

		private void SetMultilineContainerStyle() { }

		internal void SetScrollViewMode() { }

		internal void SetSingleLine() { }

		protected override TValueType StringToValue(string str) { }

		private void TextElementOnGeometryChangedEvent(GeometryChangedEvent e) { }

		internal void UpdateScrollOffset(bool isBackspace = false) { }

		internal void UpdateScrollOffset(bool isBackspace, bool widthChanged) { }

		internal void UpdateTextFromValue() { }

		internal void UpdateValueFromText() { }

	}

	internal class UxmlTraits : BaseFieldTraits
	{
		private UxmlIntAttributeDescription m_MaxLength; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_Password; //Field offset: 0x0
		private UxmlStringAttributeDescription m_MaskCharacter; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_IsReadOnly; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_IsDelayed; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_HideMobileInput; //Field offset: 0x0
		private UxmlEnumAttributeDescription m_KeyboardType; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_AutoCorrection; //Field offset: 0x0

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private static CustomStyleProperty s_SelectionColorProperty; //Field offset: 0x0
	private static CustomStyleProperty s_CursorColorProperty; //Field offset: 0x0
	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x0
	public static readonly string inputUssClassName; //Field offset: 0x0
	internal static readonly string multilineContainerClassName; //Field offset: 0x0
	public static readonly string singleLineInputUssClassName; //Field offset: 0x0
	public static readonly string multilineInputUssClassName; //Field offset: 0x0
	internal static readonly string multilineInputWithScrollViewUssClassName; //Field offset: 0x0
	public static readonly string textInputUssName; //Field offset: 0x0
	private int m_VisualInputTabIndex; //Field offset: 0x0
	private TextInputBase m_TextInputBase; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action onIsReadOnlyChanged; //Field offset: 0x0

	protected event Action onIsReadOnlyChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public bool autoCorrection
	{
		 set { } //Length: 109
	}

	public bool hideMobileInput
	{
		 set { } //Length: 109
	}

	public bool isDelayed
	{
		 get { } //Length: 93
		 set { } //Length: 109
	}

	public bool isPasswordField
	{
		 set { } //Length: 152
	}

	public bool isReadOnly
	{
		 get { } //Length: 93
		 set { } //Length: 140
	}

	public TouchScreenKeyboardType keyboardType
	{
		 set { } //Length: 107
	}

	public char maskChar
	{
		 set { } //Length: 109
	}

	public int maxLength
	{
		 set { } //Length: 107
	}

	public private string text
	{
		 get { } //Length: 57
		private set { } //Length: 30
	}

	public ITextEdition textEdition
	{
		 get { } //Length: 38
	}

	protected private TextInputBase textInputBase
	{
		private get { } //Length: 8
	}

	private static TextInputBaseField`1() { }

	protected TextInputBaseField`1(string label, int maxLength, char maskChar, TextInputBase textInputBase) { }

	[CompilerGenerated]
	protected void add_onIsReadOnlyChanged(Action value) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(NavigationSubmitEvent), typeof(FocusInEvent), typeof(FocusEvent), typeof(BlurEvent)})]
	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	public bool get_isDelayed() { }

	public bool get_isReadOnly() { }

	public string get_text() { }

	public ITextEdition get_textEdition() { }

	protected private TextInputBase get_textInputBase() { }

	private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e) { }

	[CompilerGenerated]
	protected void remove_onIsReadOnlyChanged(Action value) { }

	public void set_autoCorrection(bool value) { }

	public void set_hideMobileInput(bool value) { }

	public void set_isDelayed(bool value) { }

	public void set_isPasswordField(bool value) { }

	public void set_isReadOnly(bool value) { }

	public void set_keyboardType(TouchScreenKeyboardType value) { }

	public void set_maskChar(char value) { }

	public void set_maxLength(int value) { }

	protected private void set_text(string value) { }

	protected abstract TValueType StringToValue(string str) { }

	protected virtual void UpdateMixedValueContent() { }

	internal override void UpdateTextFromValue() { }

	internal override void UpdateValueFromText() { }

	protected abstract string ValueToString(TValueType value) { }

}

