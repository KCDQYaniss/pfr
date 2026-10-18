namespace UnityEngine.TextCore.Text;

[ExcludeFromPreset]
public class FontAsset : TextAsset
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__151_0; //Field offset: 0x8
		public static Func <>9__152_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal uint <SortCharacterTable>b__151_0(Character c) { }

		internal uint <SortGlyphTable>b__152_0(Glyph c) { }

	}

	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; //Field offset: 0x0
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; //Field offset: 0x8
	private static ProfilerMarker k_TryAddCharacterMarker; //Field offset: 0x10
	private static ProfilerMarker k_TryAddCharactersMarker; //Field offset: 0x18
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; //Field offset: 0x20
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; //Field offset: 0x28
	private static ProfilerMarker k_ClearFontAssetDataMarker; //Field offset: 0x30
	private static ProfilerMarker k_UpdateFontAssetDataMarker; //Field offset: 0x38
	private static ProfilerMarker k_TryAddGlyphMarker; //Field offset: 0x40
	private static string s_DefaultMaterialSuffix; //Field offset: 0x48
	private static HashSet k_SearchedFontAssetLookup; //Field offset: 0x50
	private static List k_FontAssets_FontFeaturesUpdateQueue; //Field offset: 0x58
	private static HashSet k_FontAssets_FontFeaturesUpdateQueueLookup; //Field offset: 0x60
	private static List k_FontAssets_AtlasTexturesUpdateQueue; //Field offset: 0x68
	private static HashSet k_FontAssets_AtlasTexturesUpdateQueueLookup; //Field offset: 0x70
	internal static uint[] k_GlyphIndexArray; //Field offset: 0x78
	[SerializeField]
	internal string m_SourceFontFileGUID; //Field offset: 0x38
	[SerializeField]
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; //Field offset: 0x40
	[SerializeField]
	private Font m_SourceFontFile; //Field offset: 0x98
	[SerializeField]
	private string m_SourceFontFilePath; //Field offset: 0xA0
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; //Field offset: 0xA8
	[SerializeField]
	internal bool InternalDynamicOS; //Field offset: 0xAC
	[SerializeField]
	internal FaceInfo m_FaceInfo; //Field offset: 0xB0
	private int m_FamilyNameHashCode; //Field offset: 0x110
	private int m_StyleNameHashCode; //Field offset: 0x114
	[SerializeField]
	internal List m_GlyphTable; //Field offset: 0x118
	internal Dictionary m_GlyphLookupDictionary; //Field offset: 0x120
	[SerializeField]
	internal List m_CharacterTable; //Field offset: 0x128
	internal Dictionary m_CharacterLookupDictionary; //Field offset: 0x130
	internal Texture2D m_AtlasTexture; //Field offset: 0x138
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; //Field offset: 0x140
	[SerializeField]
	internal int m_AtlasTextureIndex; //Field offset: 0x148
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; //Field offset: 0x14C
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; //Field offset: 0x14D
	[SerializeField]
	internal int m_AtlasWidth; //Field offset: 0x150
	[SerializeField]
	internal int m_AtlasHeight; //Field offset: 0x154
	[SerializeField]
	internal int m_AtlasPadding; //Field offset: 0x158
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; //Field offset: 0x15C
	[SerializeField]
	private List m_UsedGlyphRects; //Field offset: 0x160
	[SerializeField]
	private List m_FreeGlyphRects; //Field offset: 0x168
	[SerializeField]
	internal FontFeatureTable m_FontFeatureTable; //Field offset: 0x170
	[SerializeField]
	internal List m_FallbackFontAssetTable; //Field offset: 0x178
	[SerializeField]
	private FontWeightPair[] m_FontWeightTable; //Field offset: 0x180
	[FormerlySerializedAs("normalStyle")]
	[SerializeField]
	internal float m_RegularStyleWeight; //Field offset: 0x188
	[FormerlySerializedAs("normalSpacingOffset")]
	[SerializeField]
	internal float m_RegularStyleSpacing; //Field offset: 0x18C
	[FormerlySerializedAs("boldStyle")]
	[SerializeField]
	internal float m_BoldStyleWeight; //Field offset: 0x190
	[FormerlySerializedAs("boldSpacing")]
	[SerializeField]
	internal float m_BoldStyleSpacing; //Field offset: 0x194
	[FormerlySerializedAs("italicStyle")]
	[SerializeField]
	internal byte m_ItalicStyleSlant; //Field offset: 0x198
	[FormerlySerializedAs("tabSize")]
	[SerializeField]
	internal byte m_TabMultiple; //Field offset: 0x199
	internal bool IsFontAssetLookupTablesDirty; //Field offset: 0x19A
	private List m_GlyphsToRender; //Field offset: 0x1A0
	private List m_GlyphsRendered; //Field offset: 0x1A8
	private List m_GlyphIndexList; //Field offset: 0x1B0
	private List m_GlyphIndexListNewlyAdded; //Field offset: 0x1B8
	internal List m_GlyphsToAdd; //Field offset: 0x1C0
	internal HashSet m_GlyphsToAddLookup; //Field offset: 0x1C8
	internal List m_CharactersToAdd; //Field offset: 0x1D0
	internal HashSet m_CharactersToAddLookup; //Field offset: 0x1D8
	internal List s_MissingCharacterList; //Field offset: 0x1E0
	internal HashSet m_MissingUnicodesFromFontFile; //Field offset: 0x1E8

	public internal int atlasHeight
	{
		 get { } //Length: 9
		internal set { } //Length: 7
	}

	public internal int atlasPadding
	{
		 get { } //Length: 9
		internal set { } //Length: 7
	}

	public AtlasPopulationMode atlasPopulationMode
	{
		 get { } //Length: 9
		 set { } //Length: 7
	}

	public internal GlyphRenderMode atlasRenderMode
	{
		 get { } //Length: 9
		internal set { } //Length: 7
	}

	public Texture2D atlasTexture
	{
		 get { } //Length: 334
	}

	public int atlasTextureCount
	{
		 get { } //Length: 11
	}

	public Texture2D[] atlasTextures
	{
		 get { } //Length: 10
		 set { } //Length: 82
	}

	public internal int atlasWidth
	{
		 get { } //Length: 9
		internal set { } //Length: 7
	}

	public float boldStyleSpacing
	{
		 get { } //Length: 11
		 set { } //Length: 9
	}

	public float boldStyleWeight
	{
		 get { } //Length: 11
		 set { } //Length: 9
	}

	public Dictionary characterLookupTable
	{
		 get { } //Length: 52
	}

	public internal List characterTable
	{
		 get { } //Length: 10
		internal set { } //Length: 82
	}

	internal bool clearDynamicDataOnBuild
	{
		internal get { } //Length: 10
		internal set { } //Length: 7
	}

	public FaceInfo faceInfo
	{
		 get { } //Length: 69
		 set { } //Length: 135
	}

	public List fallbackFontAssetTable
	{
		 get { } //Length: 10
		 set { } //Length: 82
	}

	internal int familyNameHashCode
	{
		internal get { } //Length: 56
		internal set { } //Length: 7
	}

	public FontAssetCreationEditorSettings fontAssetCreationEditorSettings
	{
		 get { } //Length: 59
		 set { } //Length: 132
	}

	public internal FontFeatureTable fontFeatureTable
	{
		 get { } //Length: 10
		internal set { } //Length: 82
	}

	public internal FontWeightPair[] fontWeightTable
	{
		 get { } //Length: 10
		internal set { } //Length: 82
	}

	internal List freeGlyphRects
	{
		internal get { } //Length: 10
		internal set { } //Length: 82
	}

	public Dictionary glyphLookupTable
	{
		 get { } //Length: 52
	}

	public internal List glyphTable
	{
		 get { } //Length: 10
		internal set { } //Length: 82
	}

	public bool isMultiAtlasTexturesEnabled
	{
		 get { } //Length: 10
		 set { } //Length: 7
	}

	public byte italicStyleSlant
	{
		 get { } //Length: 10
		 set { } //Length: 7
	}

	public float regularStyleSpacing
	{
		 get { } //Length: 11
		 set { } //Length: 9
	}

	public float regularStyleWeight
	{
		 get { } //Length: 11
		 set { } //Length: 9
	}

	public internal Font sourceFontFile
	{
		 get { } //Length: 10
		internal set { } //Length: 82
	}

	internal int styleNameHashCode
	{
		internal get { } //Length: 56
		internal set { } //Length: 7
	}

	public byte tabMultiple
	{
		 get { } //Length: 10
		 set { } //Length: 7
	}

	internal List usedGlyphRects
	{
		internal get { } //Length: 10
		internal set { } //Length: 82
	}

	private static FontAsset() { }

	public FontAsset() { }

	internal void AddCharacterToLookupCache(uint unicode, Character character) { }

	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false) { }

	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	private void Awake() { }

	internal void ClearAtlasTextures(bool setAtlasSizeToZero = false) { }

	public void ClearFontAssetData(bool setAtlasSizeToZero = false) { }

	internal void ClearFontAssetDataInternal(bool clearFontFeatures = false) { }

	internal void ClearFontAssetTables(bool clearFontFeatures) { }

	private void CopyListDataToArray(List srcList, ref T[] dstArray) { }

	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 2, bool enableMultiAtlasSupport = true) { }

	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	public static FontAsset CreateFontAsset(Font font) { }

	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	private void DestroyAtlasTextures() { }

	public int get_atlasHeight() { }

	public int get_atlasPadding() { }

	public AtlasPopulationMode get_atlasPopulationMode() { }

	public GlyphRenderMode get_atlasRenderMode() { }

	public Texture2D get_atlasTexture() { }

	public int get_atlasTextureCount() { }

	public Texture2D[] get_atlasTextures() { }

	public int get_atlasWidth() { }

	public float get_boldStyleSpacing() { }

	public float get_boldStyleWeight() { }

	public Dictionary get_characterLookupTable() { }

	public List get_characterTable() { }

	internal bool get_clearDynamicDataOnBuild() { }

	public FaceInfo get_faceInfo() { }

	public List get_fallbackFontAssetTable() { }

	internal int get_familyNameHashCode() { }

	public FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }

	public FontFeatureTable get_fontFeatureTable() { }

	public FontWeightPair[] get_fontWeightTable() { }

	internal List get_freeGlyphRects() { }

	public Dictionary get_glyphLookupTable() { }

	public List get_glyphTable() { }

	public bool get_isMultiAtlasTexturesEnabled() { }

	public byte get_italicStyleSlant() { }

	public float get_regularStyleSpacing() { }

	public float get_regularStyleWeight() { }

	public Font get_sourceFontFile() { }

	internal int get_styleNameHashCode() { }

	public byte get_tabMultiple() { }

	internal List get_usedGlyphRects() { }

	public static string GetCharacters(FontAsset fontAsset) { }

	public static int[] GetCharactersArray(FontAsset fontAsset) { }

	internal uint GetGlyphIndex(uint unicode) { }

	public bool HasCharacter(uint character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	public bool HasCharacter(int character) { }

	private bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	public bool HasCharacters(string text, out List missingCharacters) { }

	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	public bool HasCharacters(string text) { }

	internal void InitializeCharacterLookupDictionary() { }

	internal void InitializeDictionaryLookupTables() { }

	internal void InitializeGlyphLookupDictionary() { }

	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	private FontEngineError LoadFontFace() { }

	private void OnDestroy() { }

	public void ReadFontAssetDefinition() { }

	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) { }

	internal void set_atlasHeight(int value) { }

	internal void set_atlasPadding(int value) { }

	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	public void set_atlasTextures(Texture2D[] value) { }

	internal void set_atlasWidth(int value) { }

	public void set_boldStyleSpacing(float value) { }

	public void set_boldStyleWeight(float value) { }

	internal void set_characterTable(List value) { }

	internal void set_clearDynamicDataOnBuild(bool value) { }

	public void set_faceInfo(FaceInfo value) { }

	public void set_fallbackFontAssetTable(List value) { }

	internal void set_familyNameHashCode(int value) { }

	public void set_fontAssetCreationEditorSettings(FontAssetCreationEditorSettings value) { }

	internal void set_fontFeatureTable(FontFeatureTable value) { }

	internal void set_fontWeightTable(FontWeightPair[] value) { }

	internal void set_freeGlyphRects(List value) { }

	internal void set_glyphTable(List value) { }

	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	public void set_italicStyleSlant(byte value) { }

	public void set_regularStyleSpacing(float value) { }

	public void set_regularStyleWeight(float value) { }

	internal void set_sourceFontFile(Font value) { }

	internal void set_styleNameHashCode(int value) { }

	public void set_tabMultiple(byte value) { }

	internal void set_usedGlyphRects(List value) { }

	private void SetupNewAtlasTexture() { }

	internal void SortAllTables() { }

	internal void SortCharacterTable() { }

	internal void SortFontFeatureTable() { }

	internal void SortGlyphTable() { }

	internal bool TryAddCharacterInternal(uint unicode, out Character character, bool shouldGetFontFeatures = false) { }

	public bool TryAddCharacters(string characters, bool includeFontFeatures = false) { }

	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false) { }

	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false) { }

	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false) { }

	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	internal void TryAddGlyphsToAtlasTextures() { }

	private bool TryAddGlyphsToNewAtlasTexture() { }

	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out Character character, bool shouldGetFontFeatures = false) { }

	private void UpdateAllFontFeatures() { }

	internal static void UpdateAtlasTexturesInQueue() { }

	internal void UpdateFontAssetData() { }

	internal static void UpdateFontAssetsInUpdateQueue() { }

	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	internal void UpdateGlyphAdjustmentRecords(List newGlyphIndexes, List allGlyphIndexes) { }

	internal void UpdateGlyphAdjustmentRecords(List glyphIndexes) { }

	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	internal void UpdateGlyphAdjustmentRecords() { }

}

