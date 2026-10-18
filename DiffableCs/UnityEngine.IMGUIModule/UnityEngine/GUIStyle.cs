namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[NativeHeader("IMGUIScriptingClasses.h")]
[RequiredByNativeCode]
public sealed class GUIStyle
{
	internal static bool showKeyboardFocus; //Field offset: 0x0
	private static GUIStyle s_None; //Field offset: 0x8
	internal IntPtr m_Ptr; //Field offset: 0x10
	private GUIStyleState m_Normal; //Field offset: 0x18
	private GUIStyleState m_Hover; //Field offset: 0x20
	private GUIStyleState m_Active; //Field offset: 0x28
	private GUIStyleState m_Focused; //Field offset: 0x30
	private GUIStyleState m_OnNormal; //Field offset: 0x38
	private GUIStyleState m_OnHover; //Field offset: 0x40
	private GUIStyleState m_OnActive; //Field offset: 0x48
	private GUIStyleState m_OnFocused; //Field offset: 0x50
	private RectOffset m_Border; //Field offset: 0x58
	private RectOffset m_Padding; //Field offset: 0x60
	private RectOffset m_Margin; //Field offset: 0x68
	private RectOffset m_Overflow; //Field offset: 0x70
	private string m_Name; //Field offset: 0x78

	[NativeProperty("m_Alignment", False, TargetType::Field (1))]
	public TextAnchor alignment
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public RectOffset border
	{
		 get { } //Length: 344
		 set { } //Length: 108
	}

	[NativeProperty("m_Clipping", False, TargetType::Field (1))]
	public TextClipping clipping
	{
		 set { } //Length: 91
	}

	[NativeProperty("m_ContentOffset", False, TargetType::Field (1))]
	public Vector2 contentOffset
	{
		 get { } //Length: 95
		 set { } //Length: 88
	}

	[NativeProperty("m_FixedHeight", False, TargetType::Field (1))]
	public float fixedHeight
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	[NativeProperty("m_FixedWidth", False, TargetType::Field (1))]
	public float fixedWidth
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	[NativeProperty("Font", False, TargetType::Function (0))]
	public Font font
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	[NativeProperty("m_FontSize", False, TargetType::Field (1))]
	public int fontSize
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	[NativeProperty("m_FontStyle", False, TargetType::Field (1))]
	public FontStyle fontStyle
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	[NativeProperty("m_ImagePosition", False, TargetType::Field (1))]
	public ImagePosition imagePosition
	{
		 get { } //Length: 78
	}

	[NativeProperty("m_ClipOffset", False, TargetType::Field (1))]
	internal Vector2 Internal_clipOffset
	{
		internal set { } //Length: 88
	}

	public bool isHeightDependantOnWidth
	{
		 get { } //Length: 244
	}

	public float lineHeight
	{
		 get { } //Length: 140
	}

	public RectOffset margin
	{
		 get { } //Length: 344
		 set { } //Length: 111
	}

	public string name
	{
		 get { } //Length: 176
		 set { } //Length: 174
	}

	public static GUIStyle none
	{
		 get { } //Length: 254
	}

	public GUIStyleState normal
	{
		 get { } //Length: 344
		 set { } //Length: 108
	}

	public RectOffset padding
	{
		 get { } //Length: 344
		 set { } //Length: 111
	}

	[NativeProperty("Name", False, TargetType::Function (0))]
	internal string rawName
	{
		internal get { } //Length: 78
		internal set { } //Length: 93
	}

	[NativeProperty("m_RichText", False, TargetType::Field (1))]
	public bool richText
	{
		 set { } //Length: 93
	}

	[NativeProperty("m_StretchHeight", False, TargetType::Field (1))]
	public bool stretchHeight
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	[NativeProperty("m_StretchWidth", False, TargetType::Field (1))]
	public bool stretchWidth
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	[NativeProperty("m_WordWrap", False, TargetType::Field (1))]
	public bool wordWrap
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	private static GUIStyle() { }

	public GUIStyle() { }

	public GUIStyle(GUIStyle other) { }

	[FreeFunction(Name = "GUIStyle_Bindings::AssignRectOffset", HasExplicitThis = True)]
	private void AssignRectOffset(int idx, IntPtr srcRectOffset) { }

	[FreeFunction(Name = "GUIStyle_Bindings::AssignStyleState", HasExplicitThis = True)]
	private void AssignStyleState(int idx, IntPtr srcStyleState) { }

	public float CalcHeight(GUIContent content, float width) { }

	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	public Vector2 CalcSize(GUIContent content) { }

	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	public void Draw(Rect position, GUIContent content, int controlID) { }

	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	protected virtual void Finalize() { }

	public TextAnchor get_alignment() { }

	public RectOffset get_border() { }

	public Vector2 get_contentOffset() { }

	private void get_contentOffset_Injected(out Vector2 ret) { }

	public float get_fixedHeight() { }

	public float get_fixedWidth() { }

	public Font get_font() { }

	public int get_fontSize() { }

	public FontStyle get_fontStyle() { }

	public ImagePosition get_imagePosition() { }

	public bool get_isHeightDependantOnWidth() { }

	public float get_lineHeight() { }

	public RectOffset get_margin() { }

	public string get_name() { }

	public static GUIStyle get_none() { }

	public GUIStyleState get_normal() { }

	public RectOffset get_padding() { }

	internal string get_rawName() { }

	public bool get_stretchHeight() { }

	public bool get_stretchWidth() { }

	public bool get_wordWrap() { }

	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = True)]
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = True)]
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSize", HasExplicitThis = True)]
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = True)]
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Copy", IsThreadSafe = True)]
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = True)]
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = True)]
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawCursor", HasExplicitThis = True)]
	private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor) { }

	private void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawWithTextSelection", HasExplicitThis = True)]
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor) { }

	private void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorFlashOffset")]
	private static float Internal_GetCursorFlashOffset() { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorPixelPosition", HasExplicitThis = True)]
	internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	private void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorStringIndex", HasExplicitThis = True)]
	internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { }

	private int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetLineHeight")]
	private static float Internal_GetLineHeight(IntPtr target) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetSelectedRenderedText", HasExplicitThis = True)]
	internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	private string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex) { }

	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	internal static bool IsTooltipActive(string tooltip) { }

	public static GUIStyle op_Implicit(string str) { }

	public void set_alignment(TextAnchor value) { }

	public void set_border(RectOffset value) { }

	public void set_clipping(TextClipping value) { }

	public void set_contentOffset(Vector2 value) { }

	private void set_contentOffset_Injected(ref Vector2 value) { }

	public void set_fixedHeight(float value) { }

	public void set_fixedWidth(float value) { }

	public void set_font(Font value) { }

	public void set_fontSize(int value) { }

	public void set_fontStyle(FontStyle value) { }

	internal void set_Internal_clipOffset(Vector2 value) { }

	private void set_Internal_clipOffset_Injected(ref Vector2 value) { }

	public void set_margin(RectOffset value) { }

	public void set_name(string value) { }

	public void set_normal(GUIStyleState value) { }

	public void set_padding(RectOffset value) { }

	internal void set_rawName(string value) { }

	public void set_richText(bool value) { }

	public void set_stretchHeight(bool value) { }

	public void set_stretchWidth(bool value) { }

	public void set_wordWrap(bool value) { }

	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	internal static void SetDefaultFont(Font font) { }

	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }

	public virtual string ToString() { }

}

