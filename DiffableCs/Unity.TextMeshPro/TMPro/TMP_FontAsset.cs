namespace TMPro;

[ExcludeFromPreset]
public class TMP_FontAsset : TMP_Asset
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__124_0; //Field offset: 0x8
		public static Func <>9__125_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal uint <SortCharacterTable>b__124_0(TMP_Character c) { }

		internal uint <SortGlyphTable>b__125_0(Glyph c) { }

	}

	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; //Field offset: 0x0
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; //Field offset: 0x8
	private static ProfilerMarker k_TryAddCharacterMarker; //Field offset: 0x10
	private static ProfilerMarker k_TryAddCharactersMarker; //Field offset: 0x18
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; //Field offset: 0x20
	private static ProfilerMarker k_ClearFontAssetDataMarker; //Field offset: 0x28
	private static ProfilerMarker k_UpdateFontAssetDataMarker; //Field offset: 0x30
	private static string s_DefaultMaterialSuffix; //Field offset: 0x38
	private static HashSet k_SearchedFontAssetLookup; //Field offset: 0x40
	private static List k_FontAssets_FontFeaturesUpdateQueue; //Field offset: 0x48
	private static HashSet k_FontAssets_FontFeaturesUpdateQueueLookup; //Field offset: 0x50
	private static List k_FontAssets_AtlasTexturesUpdateQueue; //Field offset: 0x58
	private static HashSet k_FontAssets_AtlasTexturesUpdateQueueLookup; //Field offset: 0x60
	internal static uint[] k_GlyphIndexArray; //Field offset: 0x68
	[SerializeField]
	private string m_Version; //Field offset: 0x30
	[SerializeField]
	internal string m_SourceFontFileGUID; //Field offset: 0x38
	[SerializeField]
	private Font m_SourceFontFile; //Field offset: 0x40
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; //Field offset: 0x48
	[SerializeField]
	internal FaceInfo m_FaceInfo; //Field offset: 0x50
	[SerializeField]
	internal List m_GlyphTable; //Field offset: 0xB0
	internal Dictionary m_GlyphLookupDictionary; //Field offset: 0xB8
	[SerializeField]
	internal List m_CharacterTable; //Field offset: 0xC0
	internal Dictionary m_CharacterLookupDictionary; //Field offset: 0xC8
	internal Texture2D m_AtlasTexture; //Field offset: 0xD0
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; //Field offset: 0xD8
	[SerializeField]
	internal int m_AtlasTextureIndex; //Field offset: 0xE0
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; //Field offset: 0xE4
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; //Field offset: 0xE5
	[SerializeField]
	private List m_UsedGlyphRects; //Field offset: 0xE8
	[SerializeField]
	private List m_FreeGlyphRects; //Field offset: 0xF0
	[SerializeField]
	private FaceInfo_Legacy m_fontInfo; //Field offset: 0xF8
	[SerializeField]
	public Texture2D atlas; //Field offset: 0x100
	[SerializeField]
	internal int m_AtlasWidth; //Field offset: 0x108
	[SerializeField]
	internal int m_AtlasHeight; //Field offset: 0x10C
	[SerializeField]
	internal int m_AtlasPadding; //Field offset: 0x110
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; //Field offset: 0x114
	[SerializeField]
	internal List m_glyphInfoList; //Field offset: 0x118
	[FormerlySerializedAs("m_kerningInfo")]
	[SerializeField]
	internal KerningTable m_KerningTable; //Field offset: 0x120
	[SerializeField]
	internal TMP_FontFeatureTable m_FontFeatureTable; //Field offset: 0x128
	[SerializeField]
	private List fallbackFontAssets; //Field offset: 0x130
	[SerializeField]
	internal List m_FallbackFontAssetTable; //Field offset: 0x138
	[SerializeField]
	internal FontAssetCreationSettings m_CreationSettings; //Field offset: 0x140
	[SerializeField]
	private TMP_FontWeightPair[] m_FontWeightTable; //Field offset: 0x198
	[SerializeField]
	private TMP_FontWeightPair[] fontWeights; //Field offset: 0x1A0
	public float normalStyle; //Field offset: 0x1A8
	public float normalSpacingOffset; //Field offset: 0x1AC
	public float boldStyle; //Field offset: 0x1B0
	public float boldSpacing; //Field offset: 0x1B4
	public byte italicStyle; //Field offset: 0x1B8
	public byte tabSize; //Field offset: 0x1B9
	internal bool IsFontAssetLookupTablesDirty; //Field offset: 0x1BA
	internal HashSet FallbackSearchQueryLookup; //Field offset: 0x1C0
	private List m_GlyphsToRender; //Field offset: 0x1C8
	private List m_GlyphsRendered; //Field offset: 0x1D0
	private List m_GlyphIndexList; //Field offset: 0x1D8
	private List m_GlyphIndexListNewlyAdded; //Field offset: 0x1E0
	internal List m_GlyphsToAdd; //Field offset: 0x1E8
	internal HashSet m_GlyphsToAddLookup; //Field offset: 0x1F0
	internal List m_CharactersToAdd; //Field offset: 0x1F8
	internal HashSet m_CharactersToAddLookup; //Field offset: 0x200
	internal List s_MissingCharacterList; //Field offset: 0x208
	internal HashSet m_MissingUnicodesFromFontFile; //Field offset: 0x210

	public internal int atlasHeight
	{
		 get { } //Length: 7
		internal set { } //Length: 7
	}

	public internal int atlasPadding
	{
		 get { } //Length: 7
		internal set { } //Length: 7
	}

	public AtlasPopulationMode atlasPopulationMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public internal GlyphRenderMode atlasRenderMode
	{
		 get { } //Length: 7
		internal set { } //Length: 7
	}

	public Texture2D atlasTexture
	{
		 get { } //Length: 334
	}

	public int atlasTextureCount
	{
		 get { } //Length: 9
	}

	public Texture2D[] atlasTextures
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public internal int atlasWidth
	{
		 get { } //Length: 7
		internal set { } //Length: 7
	}

	public Dictionary characterLookupTable
	{
		 get { } //Length: 52
	}

	public internal List characterTable
	{
		 get { } //Length: 8
		internal set { } //Length: 82
	}

	internal bool clearDynamicDataOnBuild
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	public FontAssetCreationSettings creationSettings
	{
		 get { } //Length: 71
		 set { } //Length: 137
	}

	public FaceInfo faceInfo
	{
		 get { } //Length: 60
		 set { } //Length: 132
	}

	public List fallbackFontAssetTable
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public internal TMP_FontFeatureTable fontFeatureTable
	{
		 get { } //Length: 8
		internal set { } //Length: 82
	}

	[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
	public FaceInfo_Legacy fontInfo
	{
		 get { } //Length: 8
	}

	public internal TMP_FontWeightPair[] fontWeightTable
	{
		 get { } //Length: 8
		internal set { } //Length: 82
	}

	internal List freeGlyphRects
	{
		internal get { } //Length: 8
		internal set { } //Length: 82
	}

	public Dictionary glyphLookupTable
	{
		 get { } //Length: 52
	}

	public internal List glyphTable
	{
		 get { } //Length: 8
		internal set { } //Length: 82
	}

	public bool isMultiAtlasTexturesEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public internal Font sourceFontFile
	{
		 get { } //Length: 5
		internal set { } //Length: 82
	}

	internal List usedGlyphRects
	{
		internal get { } //Length: 8
		internal set { } //Length: 82
	}

	public internal string version
	{
		 get { } //Length: 76
		internal set { } //Length: 82
	}

	private static TMP_FontAsset() { }

	public TMP_FontAsset() { }

	internal void AddCharacterToLookupCache(uint unicode, TMP_Character character) { }

	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false) { }

	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	private void Awake() { }

	internal void ClearAtlasTextures(bool setAtlasSizeToZero = false) { }

	public void ClearFontAssetData(bool setAtlasSizeToZero = false) { }

	internal void ClearFontAssetDataInternal() { }

	internal void ClearFontAssetTables() { }

	private void CopyListDataToArray(List srcList, ref T[] dstArray) { }

	public static TMP_FontAsset CreateFontAsset(Font font) { }

	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	public int get_atlasHeight() { }

	public int get_atlasPadding() { }

	public AtlasPopulationMode get_atlasPopulationMode() { }

	public GlyphRenderMode get_atlasRenderMode() { }

	public Texture2D get_atlasTexture() { }

	public int get_atlasTextureCount() { }

	public Texture2D[] get_atlasTextures() { }

	public int get_atlasWidth() { }

	public Dictionary get_characterLookupTable() { }

	public List get_characterTable() { }

	internal bool get_clearDynamicDataOnBuild() { }

	public FontAssetCreationSettings get_creationSettings() { }

	public FaceInfo get_faceInfo() { }

	public List get_fallbackFontAssetTable() { }

	public TMP_FontFeatureTable get_fontFeatureTable() { }

	public FaceInfo_Legacy get_fontInfo() { }

	public TMP_FontWeightPair[] get_fontWeightTable() { }

	internal List get_freeGlyphRects() { }

	public Dictionary get_glyphLookupTable() { }

	public List get_glyphTable() { }

	public bool get_isMultiAtlasTexturesEnabled() { }

	public Font get_sourceFontFile() { }

	internal List get_usedGlyphRects() { }

	public string get_version() { }

	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	internal uint GetGlyphIndex(uint unicode) { }

	public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	public bool HasCharacter(int character) { }

	private bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	public bool HasCharacters(string text) { }

	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	public bool HasCharacters(string text, out List missingCharacters) { }

	internal void InitializeCharacterLookupDictionary() { }

	internal void InitializeDictionaryLookupTables() { }

	internal void InitializeGlyphLookupDictionary() { }

	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	public void ReadFontAssetDefinition() { }

	internal static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset) { }

	internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) { }

	internal void set_atlasHeight(int value) { }

	internal void set_atlasPadding(int value) { }

	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	public void set_atlasTextures(Texture2D[] value) { }

	internal void set_atlasWidth(int value) { }

	internal void set_characterTable(List value) { }

	internal void set_clearDynamicDataOnBuild(bool value) { }

	public void set_creationSettings(FontAssetCreationSettings value) { }

	public void set_faceInfo(FaceInfo value) { }

	public void set_fallbackFontAssetTable(List value) { }

	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	internal void set_freeGlyphRects(List value) { }

	internal void set_glyphTable(List value) { }

	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	internal void set_sourceFontFile(Font value) { }

	internal void set_usedGlyphRects(List value) { }

	internal void set_version(string value) { }

	private void SetupNewAtlasTexture() { }

	internal void SortAllTables() { }

	internal void SortCharacterTable() { }

	internal void SortFontFeatureTable() { }

	internal void SortGlyphTable() { }

	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	public bool TryAddCharacters(string characters, bool includeFontFeatures = false) { }

	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false) { }

	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false) { }

	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false) { }

	internal void TryAddGlyphsToAtlasTextures() { }

	private bool TryAddGlyphsToNewAtlasTexture() { }

	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) { }

	internal void UpdateAtlasTexture() { }

	internal static void UpdateAtlasTexturesForFontAssetsInQueue() { }

	internal void UpdateFontAssetData() { }

	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	internal void UpdateGlyphAdjustmentRecords(List glyphIndexes) { }

	internal void UpdateGlyphAdjustmentRecords(List newGlyphIndexes, List allGlyphIndexes) { }

	internal void UpdateGlyphAdjustmentRecords() { }

	internal void UpgradeFontAsset() { }

	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

}

