namespace UnityEngine;

[NativeHeader("Modules/TextRendering/TextGenerator.h")]
[UsedByNativeCode]
public sealed class TextGenerator : IDisposable
{
	internal IntPtr m_Ptr; //Field offset: 0x10
	private string m_LastString; //Field offset: 0x18
	private TextGenerationSettings m_LastSettings; //Field offset: 0x20
	private bool m_HasGenerated; //Field offset: 0x80
	private TextGenerationError m_LastValid; //Field offset: 0x84
	private readonly List m_Verts; //Field offset: 0x88
	private readonly List m_Characters; //Field offset: 0x90
	private readonly List m_Lines; //Field offset: 0x98
	private bool m_CachedVerts; //Field offset: 0xA0
	private bool m_CachedCharacters; //Field offset: 0xA1
	private bool m_CachedLines; //Field offset: 0xA2

	public int characterCount
	{
		 get { } //Length: 78
	}

	public int characterCountVisible
	{
		 get { } //Length: 80
	}

	public IList characters
	{
		 get { } //Length: 120
	}

	public int lineCount
	{
		 get { } //Length: 78
	}

	public IList lines
	{
		 get { } //Length: 120
	}

	public Rect rectExtents
	{
		 get { } //Length: 102
	}

	public IList verts
	{
		 get { } //Length: 120
	}

	public TextGenerator() { }

	public TextGenerator(int initialCapacity) { }

	protected virtual void Finalize() { }

	public int get_characterCount() { }

	public int get_characterCountVisible() { }

	public IList get_characters() { }

	public int get_lineCount() { }

	public IList get_lines() { }

	public Rect get_rectExtents() { }

	private void get_rectExtents_Injected(out Rect ret) { }

	public IList get_verts() { }

	public void GetCharacters(List characters) { }

	[NativeThrows]
	private void GetCharactersInternal(object characters) { }

	public void GetLines(List lines) { }

	[NativeThrows]
	private void GetLinesInternal(object lines) { }

	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	public void GetVertices(List vertices) { }

	[NativeThrows]
	private void GetVerticesInternal(object vertices) { }

	[NativeMethod(IsThreadSafe = True)]
	private static IntPtr Internal_Create() { }

	[NativeMethod(IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	public void Invalidate() { }

	public bool Populate(string str, TextGenerationSettings settings) { }

	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	private override void System.IDisposable.Dispose() { }

	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

}

