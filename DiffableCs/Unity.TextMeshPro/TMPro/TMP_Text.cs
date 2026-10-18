namespace TMPro;

public abstract class TMP_Text : MaskableGraphic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__622_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__622_0(TMP_TextInfo <p0>) { }

	}

	internal struct CharacterSubstitution
	{
		public int index; //Field offset: 0x0
		public uint unicode; //Field offset: 0x4

		public CharacterSubstitution(int index, uint unicode) { }

	}

	internal struct SpecialCharacter
	{
		public TMP_Character character; //Field offset: 0x0
		public TMP_FontAsset fontAsset; //Field offset: 0x8
		public Material material; //Field offset: 0x10
		public int materialIndex; //Field offset: 0x18

		public SpecialCharacter(TMP_Character character, int materialIndex) { }

	}

	[DefaultMember("Item")]
	private struct TextBackingContainer
	{
		private uint[] m_Array; //Field offset: 0x0
		private int m_Count; //Field offset: 0x8

		public int Capacity
		{
			 get { } //Length: 25
		}

		public int Count
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public uint Item
		{
			 get { } //Length: 42
			 set { } //Length: 91
		}

		public TextBackingContainer(int size) { }

		public int get_Capacity() { }

		public int get_Count() { }

		public uint get_Item(int index) { }

		public void Resize(int size) { }

		public void set_Count(int value) { }

		public void set_Item(int index, uint value) { }

	}

	public enum TextInputSources
	{
		TextInputBox = 0,
		SetText = 1,
		SetTextArray = 2,
		TextString = 3,
	}

	[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
	public struct UnicodeChar
	{
		public int unicode; //Field offset: 0x0
		public int stringIndex; //Field offset: 0x4
		public int length; //Field offset: 0x8

	}

	protected static MaterialReference[] m_materialReferences; //Field offset: 0x0
	protected static Dictionary m_materialReferenceIndexLookup; //Field offset: 0x8
	protected static TMP_TextProcessingStack m_materialReferenceStack; //Field offset: 0x10
	protected static Color32 s_colorWhite; //Field offset: 0x68
	[CompilerGenerated]
	private static Func OnFontAssetRequest; //Field offset: 0x70
	[CompilerGenerated]
	private static Func OnSpriteAssetRequest; //Field offset: 0x78
	private static char[] m_htmlTag; //Field offset: 0x80
	private static RichTextTagAttribute[] m_xmlAttribute; //Field offset: 0x88
	private static float[] m_attributeParameterValues; //Field offset: 0x90
	protected static WordWrapState m_SavedWordWrapState; //Field offset: 0x98
	protected static WordWrapState m_SavedLineState; //Field offset: 0x410
	protected static WordWrapState m_SavedEllipsisState; //Field offset: 0x788
	protected static WordWrapState m_SavedLastValidState; //Field offset: 0xB00
	protected static WordWrapState m_SavedSoftLineBreakState; //Field offset: 0xE78
	[SerializeField]
	[TextArea(5, 10)]
	protected string m_text; //Field offset: 0xE0
	private bool m_IsTextBackingStringDirty; //Field offset: 0xE8
	[SerializeField]
	protected ITextPreprocessor m_TextPreprocessor; //Field offset: 0xF0
	[SerializeField]
	protected bool m_isRightToLeft; //Field offset: 0xF8
	[SerializeField]
	protected TMP_FontAsset m_fontAsset; //Field offset: 0x100
	protected TMP_FontAsset m_currentFontAsset; //Field offset: 0x108
	protected bool m_isSDFShader; //Field offset: 0x110
	[SerializeField]
	protected Material m_sharedMaterial; //Field offset: 0x118
	protected Material m_currentMaterial; //Field offset: 0x120
	protected int m_currentMaterialIndex; //Field offset: 0x128
	[SerializeField]
	protected Material[] m_fontSharedMaterials; //Field offset: 0x130
	[SerializeField]
	protected Material m_fontMaterial; //Field offset: 0x138
	[SerializeField]
	protected Material[] m_fontMaterials; //Field offset: 0x140
	protected bool m_isMaterialDirty; //Field offset: 0x148
	[SerializeField]
	protected Color32 m_fontColor32; //Field offset: 0x14C
	[SerializeField]
	protected Color m_fontColor; //Field offset: 0x150
	protected Color32 m_underlineColor; //Field offset: 0x160
	protected Color32 m_strikethroughColor; //Field offset: 0x164
	[SerializeField]
	protected bool m_enableVertexGradient; //Field offset: 0x168
	[SerializeField]
	protected ColorMode m_colorMode; //Field offset: 0x16C
	[SerializeField]
	protected VertexGradient m_fontColorGradient; //Field offset: 0x170
	[SerializeField]
	protected TMP_ColorGradient m_fontColorGradientPreset; //Field offset: 0x1B0
	[SerializeField]
	protected TMP_SpriteAsset m_spriteAsset; //Field offset: 0x1B8
	[SerializeField]
	protected bool m_tintAllSprites; //Field offset: 0x1C0
	protected bool m_tintSprite; //Field offset: 0x1C1
	protected Color32 m_spriteColor; //Field offset: 0x1C4
	[SerializeField]
	protected TMP_StyleSheet m_StyleSheet; //Field offset: 0x1C8
	internal TMP_Style m_TextStyle; //Field offset: 0x1D0
	[SerializeField]
	protected int m_TextStyleHashCode; //Field offset: 0x1D8
	[SerializeField]
	protected bool m_overrideHtmlColors; //Field offset: 0x1DC
	[SerializeField]
	protected Color32 m_faceColor; //Field offset: 0x1E0
	protected Color32 m_outlineColor; //Field offset: 0x1E4
	protected float m_outlineWidth; //Field offset: 0x1E8
	[SerializeField]
	protected float m_fontSize; //Field offset: 0x1EC
	internal static TMP_TextProcessingStack m_EllipsisInsertionCandidateStack; //Field offset: 0x11F0
	protected float m_currentFontSize; //Field offset: 0x1F0
	[SerializeField]
	protected float m_fontSizeBase; //Field offset: 0x1F4
	protected TMP_TextProcessingStack m_sizeStack; //Field offset: 0x1F8
	[SerializeField]
	protected FontWeight m_fontWeight; //Field offset: 0x218
	protected FontWeight m_FontWeightInternal; //Field offset: 0x21C
	protected TMP_TextProcessingStack m_FontWeightStack; //Field offset: 0x220
	[SerializeField]
	protected bool m_enableAutoSizing; //Field offset: 0x240
	protected float m_maxFontSize; //Field offset: 0x244
	protected float m_minFontSize; //Field offset: 0x248
	protected int m_AutoSizeIterationCount; //Field offset: 0x24C
	protected int m_AutoSizeMaxIterationCount; //Field offset: 0x250
	protected bool m_IsAutoSizePointSizeSet; //Field offset: 0x254
	[SerializeField]
	protected float m_fontSizeMin; //Field offset: 0x258
	[SerializeField]
	protected float m_fontSizeMax; //Field offset: 0x25C
	[SerializeField]
	protected FontStyles m_fontStyle; //Field offset: 0x260
	protected FontStyles m_FontStyleInternal; //Field offset: 0x264
	protected TMP_FontStyleStack m_fontStyleStack; //Field offset: 0x268
	protected bool m_isUsingBold; //Field offset: 0x272
	[SerializeField]
	protected HorizontalAlignmentOptions m_HorizontalAlignment; //Field offset: 0x274
	[SerializeField]
	protected VerticalAlignmentOptions m_VerticalAlignment; //Field offset: 0x278
	[FormerlySerializedAs("m_lineJustification")]
	[SerializeField]
	protected TextAlignmentOptions m_textAlignment; //Field offset: 0x27C
	protected HorizontalAlignmentOptions m_lineJustification; //Field offset: 0x280
	protected TMP_TextProcessingStack m_lineJustificationStack; //Field offset: 0x288
	protected Vector3[] m_textContainerLocalCorners; //Field offset: 0x2A8
	[SerializeField]
	protected float m_characterSpacing; //Field offset: 0x2B0
	protected float m_cSpacing; //Field offset: 0x2B4
	protected float m_monoSpacing; //Field offset: 0x2B8
	[SerializeField]
	protected float m_wordSpacing; //Field offset: 0x2BC
	[SerializeField]
	protected float m_lineSpacing; //Field offset: 0x2C0
	protected float m_lineSpacingDelta; //Field offset: 0x2C4
	protected float m_lineHeight; //Field offset: 0x2C8
	protected bool m_IsDrivenLineSpacing; //Field offset: 0x2CC
	[SerializeField]
	protected float m_lineSpacingMax; //Field offset: 0x2D0
	[SerializeField]
	protected float m_paragraphSpacing; //Field offset: 0x2D4
	[SerializeField]
	protected float m_charWidthMaxAdj; //Field offset: 0x2D8
	protected float m_charWidthAdjDelta; //Field offset: 0x2DC
	[SerializeField]
	protected bool m_enableWordWrapping; //Field offset: 0x2E0
	protected bool m_isCharacterWrappingEnabled; //Field offset: 0x2E1
	protected bool m_isNonBreakingSpace; //Field offset: 0x2E2
	protected bool m_isIgnoringAlignment; //Field offset: 0x2E3
	[SerializeField]
	protected float m_wordWrappingRatios; //Field offset: 0x2E4
	[SerializeField]
	protected TextOverflowModes m_overflowMode; //Field offset: 0x2E8
	protected int m_firstOverflowCharacterIndex; //Field offset: 0x2EC
	[SerializeField]
	protected TMP_Text m_linkedTextComponent; //Field offset: 0x2F0
	[SerializeField]
	internal TMP_Text parentLinkedComponent; //Field offset: 0x2F8
	protected bool m_isTextTruncated; //Field offset: 0x300
	[SerializeField]
	protected bool m_enableKerning; //Field offset: 0x301
	protected float m_GlyphHorizontalAdvanceAdjustment; //Field offset: 0x304
	[SerializeField]
	protected bool m_enableExtraPadding; //Field offset: 0x308
	[SerializeField]
	protected bool checkPaddingRequired; //Field offset: 0x309
	[SerializeField]
	protected bool m_isRichText; //Field offset: 0x30A
	[SerializeField]
	protected bool m_parseCtrlCharacters; //Field offset: 0x30B
	protected bool m_isOverlay; //Field offset: 0x30C
	[SerializeField]
	protected bool m_isOrthographic; //Field offset: 0x30D
	[SerializeField]
	protected bool m_isCullingEnabled; //Field offset: 0x30E
	protected bool m_isMaskingEnabled; //Field offset: 0x30F
	protected bool isMaskUpdateRequired; //Field offset: 0x310
	protected bool m_ignoreCulling; //Field offset: 0x311
	[SerializeField]
	protected TextureMappingOptions m_horizontalMapping; //Field offset: 0x314
	[SerializeField]
	protected TextureMappingOptions m_verticalMapping; //Field offset: 0x318
	[SerializeField]
	protected float m_uvLineOffset; //Field offset: 0x31C
	protected TextRenderFlags m_renderMode; //Field offset: 0x320
	[SerializeField]
	protected VertexSortingOrder m_geometrySortingOrder; //Field offset: 0x324
	[SerializeField]
	protected bool m_IsTextObjectScaleStatic; //Field offset: 0x328
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction; //Field offset: 0x329
	protected int m_firstVisibleCharacter; //Field offset: 0x32C
	protected int m_maxVisibleCharacters; //Field offset: 0x330
	protected int m_maxVisibleWords; //Field offset: 0x334
	protected int m_maxVisibleLines; //Field offset: 0x338
	[SerializeField]
	protected bool m_useMaxVisibleDescender; //Field offset: 0x33C
	[SerializeField]
	protected int m_pageToDisplay; //Field offset: 0x340
	protected bool m_isNewPage; //Field offset: 0x344
	[SerializeField]
	protected Vector4 m_margin; //Field offset: 0x348
	protected float m_marginLeft; //Field offset: 0x358
	protected float m_marginRight; //Field offset: 0x35C
	protected float m_marginWidth; //Field offset: 0x360
	protected float m_marginHeight; //Field offset: 0x364
	protected float m_width; //Field offset: 0x368
	protected TMP_TextInfo m_textInfo; //Field offset: 0x370
	protected bool m_havePropertiesChanged; //Field offset: 0x378
	[SerializeField]
	protected bool m_isUsingLegacyAnimationComponent; //Field offset: 0x379
	protected Transform m_transform; //Field offset: 0x380
	protected RectTransform m_rectTransform; //Field offset: 0x388
	protected Vector2 m_PreviousRectTransformSize; //Field offset: 0x390
	protected Vector2 m_PreviousPivotPosition; //Field offset: 0x398
	[CompilerGenerated]
	private bool <autoSizeTextContainer>k__BackingField; //Field offset: 0x3A0
	protected bool m_autoSizeTextContainer; //Field offset: 0x3A1
	protected Mesh m_mesh; //Field offset: 0x3A8
	[SerializeField]
	protected bool m_isVolumetricText; //Field offset: 0x3B0
	[CompilerGenerated]
	private Action OnPreRenderText; //Field offset: 0x3B8
	protected TMP_SpriteAnimator m_spriteAnimator; //Field offset: 0x3C0
	protected float m_flexibleHeight; //Field offset: 0x3C8
	protected float m_flexibleWidth; //Field offset: 0x3CC
	protected float m_minWidth; //Field offset: 0x3D0
	protected float m_minHeight; //Field offset: 0x3D4
	protected float m_maxWidth; //Field offset: 0x3D8
	protected float m_maxHeight; //Field offset: 0x3DC
	protected LayoutElement m_LayoutElement; //Field offset: 0x3E0
	protected float m_preferredWidth; //Field offset: 0x3E8
	protected float m_renderedWidth; //Field offset: 0x3EC
	protected bool m_isPreferredWidthDirty; //Field offset: 0x3F0
	protected float m_preferredHeight; //Field offset: 0x3F4
	protected float m_renderedHeight; //Field offset: 0x3F8
	protected bool m_isPreferredHeightDirty; //Field offset: 0x3FC
	protected bool m_isCalculatingPreferredValues; //Field offset: 0x3FD
	protected int m_layoutPriority; //Field offset: 0x400
	protected bool m_isLayoutDirty; //Field offset: 0x404
	protected bool m_isAwake; //Field offset: 0x405
	internal bool m_isWaitingOnResourceLoad; //Field offset: 0x406
	internal TextInputSources m_inputSource; //Field offset: 0x408
	protected float m_fontScaleMultiplier; //Field offset: 0x40C
	protected float tag_LineIndent; //Field offset: 0x410
	protected float tag_Indent; //Field offset: 0x414
	protected TMP_TextProcessingStack m_indentStack; //Field offset: 0x418
	protected bool tag_NoParsing; //Field offset: 0x438
	protected bool m_isParsingText; //Field offset: 0x439
	protected Matrix4x4 m_FXMatrix; //Field offset: 0x43C
	protected bool m_isFXMatrixSet; //Field offset: 0x47C
	internal UnicodeChar[] m_TextProcessingArray; //Field offset: 0x480
	internal int m_InternalTextProcessingArraySize; //Field offset: 0x488
	private TMP_CharacterInfo[] m_internalCharacterInfo; //Field offset: 0x490
	protected int m_totalCharacterCount; //Field offset: 0x498
	protected int m_characterCount; //Field offset: 0x49C
	protected int m_firstCharacterOfLine; //Field offset: 0x4A0
	protected int m_firstVisibleCharacterOfLine; //Field offset: 0x4A4
	protected int m_lastCharacterOfLine; //Field offset: 0x4A8
	protected int m_lastVisibleCharacterOfLine; //Field offset: 0x4AC
	protected int m_lineNumber; //Field offset: 0x4B0
	protected int m_lineVisibleCharacterCount; //Field offset: 0x4B4
	protected int m_pageNumber; //Field offset: 0x4B8
	protected float m_PageAscender; //Field offset: 0x4BC
	protected float m_maxTextAscender; //Field offset: 0x4C0
	protected float m_maxCapHeight; //Field offset: 0x4C4
	protected float m_ElementAscender; //Field offset: 0x4C8
	protected float m_ElementDescender; //Field offset: 0x4CC
	protected float m_maxLineAscender; //Field offset: 0x4D0
	protected float m_maxLineDescender; //Field offset: 0x4D4
	protected float m_startOfLineAscender; //Field offset: 0x4D8
	protected float m_startOfLineDescender; //Field offset: 0x4DC
	protected float m_lineOffset; //Field offset: 0x4E0
	protected Extents m_meshExtents; //Field offset: 0x4E4
	protected Color32 m_htmlColor; //Field offset: 0x4F4
	protected TMP_TextProcessingStack m_colorStack; //Field offset: 0x4F8
	protected TMP_TextProcessingStack m_underlineColorStack; //Field offset: 0x518
	protected TMP_TextProcessingStack m_strikethroughColorStack; //Field offset: 0x538
	protected TMP_TextProcessingStack m_HighlightStateStack; //Field offset: 0x558
	protected TMP_ColorGradient m_colorGradientPreset; //Field offset: 0x588
	private static ProfilerMarker k_ParseTextMarker; //Field offset: 0x1588
	protected TMP_TextProcessingStack m_colorGradientStack; //Field offset: 0x590
	private static ProfilerMarker k_InsertNewLineMarker; //Field offset: 0x1590
	protected static Vector2 k_LargePositiveVector2; //Field offset: 0x1598
	protected static Vector2 k_LargeNegativeVector2; //Field offset: 0x15A0
	protected static float k_LargePositiveFloat; //Field offset: 0x15A8
	protected static float k_LargeNegativeFloat; //Field offset: 0x15AC
	protected static int k_LargePositiveInt; //Field offset: 0x15B0
	protected static int k_LargeNegativeInt; //Field offset: 0x15B4
	protected bool m_colorGradientPresetIsTinted; //Field offset: 0x5B8
	protected float m_tabSpacing; //Field offset: 0x5BC
	protected float m_spacing; //Field offset: 0x5C0
	protected TMP_TextProcessingStack[] m_TextStyleStacks; //Field offset: 0x5C8
	protected int m_TextStyleStackDepth; //Field offset: 0x5D0
	protected TMP_TextProcessingStack m_ItalicAngleStack; //Field offset: 0x5D8
	protected int m_ItalicAngle; //Field offset: 0x5F8
	protected TMP_TextProcessingStack m_actionStack; //Field offset: 0x600
	protected float m_padding; //Field offset: 0x620
	protected float m_baselineOffset; //Field offset: 0x624
	protected TMP_TextProcessingStack m_baselineOffsetStack; //Field offset: 0x628
	protected float m_xAdvance; //Field offset: 0x648
	protected TMP_TextElementType m_textElementType; //Field offset: 0x64C
	protected TMP_TextElement m_cached_TextElement; //Field offset: 0x650
	protected SpecialCharacter m_Ellipsis; //Field offset: 0x658
	protected SpecialCharacter m_Underline; //Field offset: 0x678
	protected TMP_SpriteAsset m_defaultSpriteAsset; //Field offset: 0x698
	protected TMP_SpriteAsset m_currentSpriteAsset; //Field offset: 0x6A0
	protected int m_spriteCount; //Field offset: 0x6A8
	protected int m_spriteIndex; //Field offset: 0x6AC
	protected int m_spriteAnimationID; //Field offset: 0x6B0
	protected bool m_ignoreActiveState; //Field offset: 0x6B4
	private TextBackingContainer m_TextBackingArray; //Field offset: 0x6B8
	private readonly decimal[] k_Power; //Field offset: 0x6C8

	public static event Func OnFontAssetRequest
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	public override event Action OnPreRenderText
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public static event Func OnSpriteAssetRequest
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	public TextAlignmentOptions alignment
	{
		 get { } //Length: 13
		 set { } //Length: 65
	}

	public float alpha
	{
		 get { } //Length: 9
		 set { } //Length: 51
	}

	public override bool autoSizeTextContainer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Bounds bounds
	{
		 get { } //Length: 307
	}

	public float characterSpacing
	{
		 get { } //Length: 9
		 set { } //Length: 92
	}

	public float characterWidthAdjustment
	{
		 get { } //Length: 9
		 set { } //Length: 92
	}

	public virtual Color color
	{
		 get { } //Length: 14
		 set { } //Length: 144
	}

	public VertexGradient colorGradient
	{
		 get { } //Length: 47
		 set { } //Length: 70
	}

	public TMP_ColorGradient colorGradientPreset
	{
		 get { } //Length: 8
		 set { } //Length: 120
	}

	public bool enableAutoSizing
	{
		 get { } //Length: 8
		 set { } //Length: 76
	}

	public bool enableCulling
	{
		 get { } //Length: 8
		 set { } //Length: 55
	}

	public bool enableKerning
	{
		 get { } //Length: 8
		 set { } //Length: 83
	}

	public bool enableVertexGradient
	{
		 get { } //Length: 8
		 set { } //Length: 42
	}

	public bool enableWordWrapping
	{
		 get { } //Length: 8
		 set { } //Length: 83
	}

	public bool extraPadding
	{
		 get { } //Length: 8
		 set { } //Length: 83
	}

	public Color32 faceColor
	{
		 get { } //Length: 425
		 set { } //Length: 158
	}

	public int firstOverflowCharacterIndex
	{
		 get { } //Length: 7
	}

	public int firstVisibleCharacter
	{
		 get { } //Length: 7
		 set { } //Length: 42
	}

	public override float flexibleHeight
	{
		 get { } //Length: 9
	}

	public override float flexibleWidth
	{
		 get { } //Length: 9
	}

	public TMP_FontAsset font
	{
		 get { } //Length: 8
		 set { } //Length: 448
	}

	public Material fontMaterial
	{
		 get { } //Length: 27
		 set { } //Length: 441
	}

	public override Material[] fontMaterials
	{
		 get { } //Length: 27
		 set { } //Length: 85
	}

	public override Material fontSharedMaterial
	{
		 get { } //Length: 8
		 set { } //Length: 367
	}

	public override Material[] fontSharedMaterials
	{
		 get { } //Length: 20
		 set { } //Length: 85
	}

	public float fontSize
	{
		 get { } //Length: 9
		 set { } //Length: 109
	}

	public float fontSizeMax
	{
		 get { } //Length: 9
		 set { } //Length: 85
	}

	public float fontSizeMin
	{
		 get { } //Length: 9
		 set { } //Length: 85
	}

	public FontStyles fontStyle
	{
		 get { } //Length: 7
		 set { } //Length: 83
	}

	public FontWeight fontWeight
	{
		 get { } //Length: 7
		 set { } //Length: 83
	}

	public VertexSortingOrder geometrySortingOrder
	{
		 get { } //Length: 7
		 set { } //Length: 33
	}

	public bool havePropertiesChanged
	{
		 get { } //Length: 8
		 set { } //Length: 35
	}

	public HorizontalAlignmentOptions horizontalAlignment
	{
		 get { } //Length: 7
		 set { } //Length: 42
	}

	public TextureMappingOptions horizontalMapping
	{
		 get { } //Length: 7
		 set { } //Length: 42
	}

	public bool ignoreVisibility
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	public bool isOrthographic
	{
		 get { } //Length: 8
		 set { } //Length: 42
	}

	public bool isOverlay
	{
		 get { } //Length: 8
		 set { } //Length: 83
	}

	public bool isRightToLeftText
	{
		 get { } //Length: 8
		 set { } //Length: 83
	}

	public bool isTextObjectScaleStatic
	{
		 get { } //Length: 8
		 set { } //Length: 136
	}

	public bool isTextOverflowing
	{
		 get { } //Length: 11
	}

	public bool isTextTruncated
	{
		 get { } //Length: 8
	}

	public bool isUsingBold
	{
		 get { } //Length: 8
	}

	public bool isUsingLegacyAnimationComponent
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool isVolumetricText
	{
		 get { } //Length: 8
		 set { } //Length: 289
	}

	protected LayoutElement layoutElement
	{
		 get { } //Length: 323
	}

	public override int layoutPriority
	{
		 get { } //Length: 7
	}

	public float lineSpacing
	{
		 get { } //Length: 9
		 set { } //Length: 92
	}

	public float lineSpacingAdjustment
	{
		 get { } //Length: 9
		 set { } //Length: 92
	}

	public TMP_Text linkedTextComponent
	{
		 get { } //Length: 8
		 set { } //Length: 620
	}

	public float mappingUvLineOffset
	{
		 get { } //Length: 9
		 set { } //Length: 51
	}

	public override Vector4 margin
	{
		 get { } //Length: 14
		 set { } //Length: 185
	}

	public float maxHeight
	{
		 get { } //Length: 9
	}

	public int maxVisibleCharacters
	{
		 get { } //Length: 7
		 set { } //Length: 42
	}

	public int maxVisibleLines
	{
		 get { } //Length: 7
		 set { } //Length: 42
	}

	public int maxVisibleWords
	{
		 get { } //Length: 7
		 set { } //Length: 42
	}

	public float maxWidth
	{
		 get { } //Length: 9
	}

	public override Mesh mesh
	{
		 get { } //Length: 8
	}

	public override float minHeight
	{
		 get { } //Length: 9
	}

	public override float minWidth
	{
		 get { } //Length: 9
	}

	public Color32 outlineColor
	{
		 get { } //Length: 425
		 set { } //Length: 136
	}

	public float outlineWidth
	{
		 get { } //Length: 387
		 set { } //Length: 99
	}

	public TextOverflowModes overflowMode
	{
		 get { } //Length: 7
		 set { } //Length: 83
	}

	public bool overrideColorTags
	{
		 get { } //Length: 8
		 set { } //Length: 42
	}

	public int pageToDisplay
	{
		 get { } //Length: 7
		 set { } //Length: 42
	}

	public float paragraphSpacing
	{
		 get { } //Length: 9
		 set { } //Length: 92
	}

	public bool parseCtrlCharacters
	{
		 get { } //Length: 8
		 set { } //Length: 83
	}

	public float pixelsPerUnit
	{
		 get { } //Length: 702
	}

	public override float preferredHeight
	{
		 get { } //Length: 30
	}

	public override float preferredWidth
	{
		 get { } //Length: 30
	}

	public RectTransform rectTransform
	{
		 get { } //Length: 323
	}

	public override float renderedHeight
	{
		 get { } //Length: 34
	}

	public override float renderedWidth
	{
		 get { } //Length: 38
	}

	public TextRenderFlags renderMode
	{
		 get { } //Length: 7
		 set { } //Length: 22
	}

	public bool richText
	{
		 get { } //Length: 8
		 set { } //Length: 83
	}

	protected TMP_SpriteAnimator spriteAnimator
	{
		 get { } //Length: 700
	}

	public TMP_SpriteAsset spriteAsset
	{
		 get { } //Length: 8
		 set { } //Length: 154
	}

	public TMP_StyleSheet styleSheet
	{
		 get { } //Length: 8
		 set { } //Length: 154
	}

	public override string text
	{
		 get { } //Length: 219
		 set { } //Length: 265
	}

	public Bounds textBounds
	{
		 get { } //Length: 90
	}

	public TMP_TextInfo textInfo
	{
		 get { } //Length: 8
	}

	public ITextPreprocessor textPreprocessor
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public TMP_Style textStyle
	{
		 get { } //Length: 552
		 set { } //Length: 180
	}

	public bool tintAllSprites
	{
		 get { } //Length: 8
		 set { } //Length: 42
	}

	public Transform transform
	{
		 get { } //Length: 323
	}

	public bool useMaxVisibleDescender
	{
		 get { } //Length: 8
		 set { } //Length: 42
	}

	public bool vertexBufferAutoSizeReduction
	{
		 get { } //Length: 8
		 set { } //Length: 33
	}

	public VerticalAlignmentOptions verticalAlignment
	{
		 get { } //Length: 7
		 set { } //Length: 42
	}

	public TextureMappingOptions verticalMapping
	{
		 get { } //Length: 7
		 set { } //Length: 42
	}

	public float wordSpacing
	{
		 get { } //Length: 9
		 set { } //Length: 92
	}

	public float wordWrappingRatios
	{
		 get { } //Length: 9
		 set { } //Length: 92
	}

	private static TMP_Text() { }

	protected TMP_Text() { }

	[CompilerGenerated]
	public static void add_OnFontAssetRequest(Func value) { }

	[CompilerGenerated]
	public override void add_OnPreRenderText(Action value) { }

	[CompilerGenerated]
	public static void add_OnSpriteAssetRequest(Func value) { }

	private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) { }

	private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) { }

	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	protected override Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled) { }

	public override void ClearMesh(bool uploadGeometry) { }

	public override void ClearMesh() { }

	public override void ComputeMarginSize() { }

	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	protected override Material CreateMaterialInstance(Material source) { }

	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	protected override void DestroySubMeshObjects() { }

	protected override void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	protected override void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	protected override void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	protected override void FillCharacterVertexBuffers(int i, int index_X4) { }

	protected override void FillSpriteVertexBuffers(int i, int index_X4) { }

	public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false) { }

	public TextAlignmentOptions get_alignment() { }

	public float get_alpha() { }

	[CompilerGenerated]
	public override bool get_autoSizeTextContainer() { }

	public Bounds get_bounds() { }

	public float get_characterSpacing() { }

	public float get_characterWidthAdjustment() { }

	public virtual Color get_color() { }

	public VertexGradient get_colorGradient() { }

	public TMP_ColorGradient get_colorGradientPreset() { }

	public bool get_enableAutoSizing() { }

	public bool get_enableCulling() { }

	public bool get_enableKerning() { }

	public bool get_enableVertexGradient() { }

	public bool get_enableWordWrapping() { }

	public bool get_extraPadding() { }

	public Color32 get_faceColor() { }

	public int get_firstOverflowCharacterIndex() { }

	public int get_firstVisibleCharacter() { }

	public override float get_flexibleHeight() { }

	public override float get_flexibleWidth() { }

	public TMP_FontAsset get_font() { }

	public Material get_fontMaterial() { }

	public override Material[] get_fontMaterials() { }

	public override Material get_fontSharedMaterial() { }

	public override Material[] get_fontSharedMaterials() { }

	public float get_fontSize() { }

	public float get_fontSizeMax() { }

	public float get_fontSizeMin() { }

	public FontStyles get_fontStyle() { }

	public FontWeight get_fontWeight() { }

	public VertexSortingOrder get_geometrySortingOrder() { }

	public bool get_havePropertiesChanged() { }

	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	public TextureMappingOptions get_horizontalMapping() { }

	public bool get_ignoreVisibility() { }

	public bool get_isOrthographic() { }

	public bool get_isOverlay() { }

	public bool get_isRightToLeftText() { }

	public bool get_isTextObjectScaleStatic() { }

	public bool get_isTextOverflowing() { }

	public bool get_isTextTruncated() { }

	public bool get_isUsingBold() { }

	public bool get_isUsingLegacyAnimationComponent() { }

	public bool get_isVolumetricText() { }

	protected LayoutElement get_layoutElement() { }

	public override int get_layoutPriority() { }

	public float get_lineSpacing() { }

	public float get_lineSpacingAdjustment() { }

	public TMP_Text get_linkedTextComponent() { }

	public float get_mappingUvLineOffset() { }

	public override Vector4 get_margin() { }

	public float get_maxHeight() { }

	public int get_maxVisibleCharacters() { }

	public int get_maxVisibleLines() { }

	public int get_maxVisibleWords() { }

	public float get_maxWidth() { }

	public override Mesh get_mesh() { }

	public override float get_minHeight() { }

	public override float get_minWidth() { }

	public Color32 get_outlineColor() { }

	public float get_outlineWidth() { }

	public TextOverflowModes get_overflowMode() { }

	public bool get_overrideColorTags() { }

	public int get_pageToDisplay() { }

	public float get_paragraphSpacing() { }

	public bool get_parseCtrlCharacters() { }

	public float get_pixelsPerUnit() { }

	public override float get_preferredHeight() { }

	public override float get_preferredWidth() { }

	public RectTransform get_rectTransform() { }

	public override float get_renderedHeight() { }

	public override float get_renderedWidth() { }

	public TextRenderFlags get_renderMode() { }

	public bool get_richText() { }

	protected TMP_SpriteAnimator get_spriteAnimator() { }

	public TMP_SpriteAsset get_spriteAsset() { }

	public TMP_StyleSheet get_styleSheet() { }

	public override string get_text() { }

	public Bounds get_textBounds() { }

	public TMP_TextInfo get_textInfo() { }

	public ITextPreprocessor get_textPreprocessor() { }

	public TMP_Style get_textStyle() { }

	public bool get_tintAllSprites() { }

	public Transform get_transform() { }

	public bool get_useMaxVisibleDescender() { }

	public bool get_vertexBufferAutoSizeReduction() { }

	public VerticalAlignmentOptions get_verticalAlignment() { }

	public TextureMappingOptions get_verticalMapping() { }

	public float get_wordSpacing() { }

	public float get_wordWrappingRatios() { }

	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	internal override Rect GetCanvasSpaceClippingRect() { }

	protected override Bounds GetCompoundBounds() { }

	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	private int GetMarkupTagHashCode(TextBackingContainer tagDefinition, int readIndex) { }

	private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex) { }

	protected override Material GetMaterial(Material mat) { }

	protected override Material[] GetMaterials(Material[] mats) { }

	protected override float GetPaddingForMaterial() { }

	protected override float GetPaddingForMaterial(Material mat) { }

	public override string GetParsedText() { }

	private float GetPreferredHeight(Vector2 margin) { }

	protected float GetPreferredHeight() { }

	public Vector2 GetPreferredValues(string text) { }

	public Vector2 GetPreferredValues(float width, float height) { }

	public Vector2 GetPreferredValues(string text, float width, float height) { }

	public Vector2 GetPreferredValues() { }

	protected float GetPreferredWidth() { }

	private float GetPreferredWidth(Vector2 margin) { }

	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	private float GetRenderedHeight() { }

	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	public Vector2 GetRenderedValues() { }

	private float GetRenderedWidth() { }

	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	protected override Material[] GetSharedMaterials() { }

	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	private TMP_Style GetStyle(int hashCode) { }

	private int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	private int GetStyleHashCode(ref int[] text, int index, out int closeIndex) { }

	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	protected Bounds GetTextBounds() { }

	protected override Vector3[] GetTextContainerLocalCorners() { }

	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	public override TMP_TextInfo GetTextInfo(string text) { }

	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	protected int GetUTF16(string text, int i) { }

	protected int GetUTF16(StringBuilder text, int i) { }

	protected int GetUTF16(int[] text, int i) { }

	internal int GetUTF16(uint[] text, int i) { }

	private int GetUTF16(TextBackingContainer text, int i) { }

	private int GetUTF32(TextBackingContainer text, int i) { }

	protected int GetUTF32(string text, int i) { }

	protected int GetUTF32(int[] text, int i) { }

	protected int GetUTF32(StringBuilder text, int i) { }

	internal int GetUTF32(uint[] text, int i) { }

	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	protected int HexToInt(char hex) { }

	private void InsertClosingStyleTag(ref UnicodeChar[] charBuffer, ref int writeIndex) { }

	protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex) { }

	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	private string InternalTextBackingArrayToString() { }

	internal override void InternalUpdate() { }

	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	protected void LoadDefaultSettings() { }

	protected override void LoadFontAsset() { }

	protected float PackUV(float x, float y) { }

	protected Vector2 PackUV(float x, float y, float scale) { }

	protected void ParseInputText() { }

	private void PopulateTextBackingArray(string sourceText) { }

	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) { }

	private void PopulateTextBackingArray(char[] sourceText, int start, int length) { }

	private void PopulateTextProcessingArray() { }

	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	[CompilerGenerated]
	public static void remove_OnFontAssetRequest(Func value) { }

	[CompilerGenerated]
	public override void remove_OnPreRenderText(Action value) { }

	[CompilerGenerated]
	public static void remove_OnSpriteAssetRequest(Func value) { }

	private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex) { }

	private void ReplaceClosingStyleTag(ref TextBackingContainer sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex) { }

	private bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex) { }

	private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex) { }

	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	private void ResizeInternalArray(ref T[] array) { }

	private void ResizeInternalArray(ref T[] array, int size) { }

	protected void ResizeLineExtents(int size) { }

	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	protected override void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	protected override void SaveSpriteVertexInfo(Color32 vertexColor) { }

	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	public void set_alignment(TextAlignmentOptions value) { }

	public void set_alpha(float value) { }

	[CompilerGenerated]
	public override void set_autoSizeTextContainer(bool value) { }

	public void set_characterSpacing(float value) { }

	public void set_characterWidthAdjustment(float value) { }

	public virtual void set_color(Color value) { }

	public void set_colorGradient(VertexGradient value) { }

	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	public void set_enableAutoSizing(bool value) { }

	public void set_enableCulling(bool value) { }

	public void set_enableKerning(bool value) { }

	public void set_enableVertexGradient(bool value) { }

	public void set_enableWordWrapping(bool value) { }

	public void set_extraPadding(bool value) { }

	public void set_faceColor(Color32 value) { }

	public void set_firstVisibleCharacter(int value) { }

	public void set_font(TMP_FontAsset value) { }

	public void set_fontMaterial(Material value) { }

	public override void set_fontMaterials(Material[] value) { }

	public override void set_fontSharedMaterial(Material value) { }

	public override void set_fontSharedMaterials(Material[] value) { }

	public void set_fontSize(float value) { }

	public void set_fontSizeMax(float value) { }

	public void set_fontSizeMin(float value) { }

	public void set_fontStyle(FontStyles value) { }

	public void set_fontWeight(FontWeight value) { }

	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	public void set_havePropertiesChanged(bool value) { }

	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	public void set_horizontalMapping(TextureMappingOptions value) { }

	public void set_ignoreVisibility(bool value) { }

	public void set_isOrthographic(bool value) { }

	public void set_isOverlay(bool value) { }

	public void set_isRightToLeftText(bool value) { }

	public void set_isTextObjectScaleStatic(bool value) { }

	public void set_isUsingLegacyAnimationComponent(bool value) { }

	public void set_isVolumetricText(bool value) { }

	public void set_lineSpacing(float value) { }

	public void set_lineSpacingAdjustment(float value) { }

	public void set_linkedTextComponent(TMP_Text value) { }

	public void set_mappingUvLineOffset(float value) { }

	public override void set_margin(Vector4 value) { }

	public void set_maxVisibleCharacters(int value) { }

	public void set_maxVisibleLines(int value) { }

	public void set_maxVisibleWords(int value) { }

	public void set_outlineColor(Color32 value) { }

	public void set_outlineWidth(float value) { }

	public void set_overflowMode(TextOverflowModes value) { }

	public void set_overrideColorTags(bool value) { }

	public void set_pageToDisplay(int value) { }

	public void set_paragraphSpacing(float value) { }

	public void set_parseCtrlCharacters(bool value) { }

	public void set_renderMode(TextRenderFlags value) { }

	public void set_richText(bool value) { }

	public void set_spriteAsset(TMP_SpriteAsset value) { }

	public void set_styleSheet(TMP_StyleSheet value) { }

	public override void set_text(string value) { }

	public void set_textPreprocessor(ITextPreprocessor value) { }

	public void set_textStyle(TMP_Style value) { }

	public void set_tintAllSprites(bool value) { }

	public void set_useMaxVisibleDescender(bool value) { }

	public void set_vertexBufferAutoSizeReduction(bool value) { }

	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	public void set_verticalMapping(TextureMappingOptions value) { }

	public void set_wordSpacing(float value) { }

	public void set_wordWrappingRatios(float value) { }

	protected override void SetActiveSubMeshes(bool state) { }

	internal override int SetArraySizes(UnicodeChar[] unicodeChars) { }

	public void SetCharArray(char[] sourceText, int start, int length) { }

	public void SetCharArray(char[] sourceText) { }

	protected override void SetCulling() { }

	protected override void SetFaceColor(Color32 color) { }

	protected override void SetFontBaseMaterial(Material mat) { }

	protected override void SetOutlineColor(Color32 color) { }

	protected override void SetOutlineThickness(float thickness) { }

	protected override void SetShaderDepth() { }

	protected override void SetSharedMaterial(Material mat) { }

	protected override void SetSharedMaterials(Material[] materials) { }

	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) { }

	public void SetText(char[] sourceText, int start, int length) { }

	private void SetText(StringBuilder sourceText, int start, int length) { }

	public void SetText(StringBuilder sourceText) { }

	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	public void SetText(char[] sourceText) { }

	public void SetText(string sourceText, float arg0, float arg1, float arg2) { }

	public void SetText(string sourceText, bool syncTextInputBox = true) { }

	public void SetText(string sourceText, float arg0) { }

	public void SetText(string sourceText, float arg0, float arg1) { }

	private void SetTextInternal(string sourceText) { }

	protected void SetTextSortingOrder(int[] order) { }

	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	public override void SetVertices(Vector3[] vertices) { }

	internal override void UpdateCulling() { }

	public override void UpdateGeometry(Mesh mesh, int index) { }

	public override void UpdateMeshPadding() { }

	public override void UpdateVertexData() { }

	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	internal bool ValidateHtmlTag(UnicodeChar[] chars, int startIndex, out int endIndex) { }

}

