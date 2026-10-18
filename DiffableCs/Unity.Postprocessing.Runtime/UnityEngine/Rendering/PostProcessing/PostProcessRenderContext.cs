namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessRenderContext
{
	internal enum StereoRenderingMode
	{
		MultiPass = 0,
		SinglePass = 1,
		SinglePassInstanced = 2,
		SinglePassMultiview = 3,
	}

	private Camera m_Camera; //Field offset: 0x10
	public SSAA SSAA; //Field offset: 0x18
	public StreamingController MipStreamingController; //Field offset: 0x20
	[CompilerGenerated]
	private CommandBuffer <command>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private RenderTargetIdentifier <source>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private RenderTargetIdentifier <destination>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private RenderTextureFormat <sourceFormat>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private bool <flip>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private PostProcessResources <resources>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private PropertySheetFactory <propertySheets>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private Dictionary <userData>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private PostProcessDebugLayer <debugLayer>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private int <width>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private int <height>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	private bool <stereoActive>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private int <xrActiveEye>k__BackingField; //Field offset: 0xB4
	[CompilerGenerated]
	private int <numberOfEyes>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private StereoRenderingMode <stereoRenderingMode>k__BackingField; //Field offset: 0xBC
	[CompilerGenerated]
	private int <screenWidth>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private int <screenHeight>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private bool <isSceneView>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private Antialiasing <antialiasing>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	private TemporalAntialiasing <temporalAntialiasing>k__BackingField; //Field offset: 0xD0
	internal PropertySheet uberSheet; //Field offset: 0xD8
	internal Texture autoExposureTexture; //Field offset: 0xE0
	internal LogHistogram logHistogram; //Field offset: 0xE8
	internal Texture logLut; //Field offset: 0xF0
	internal AutoExposure autoExposure; //Field offset: 0xF8
	internal int bloomBufferNameID; //Field offset: 0x100
	internal bool physicalCamera; //Field offset: 0x104
	private RenderTextureDescriptor m_sourceDescriptor; //Field offset: 0x108

	public internal Antialiasing antialiasing
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public Camera camera
	{
		 get { } //Length: 5
		 set { } //Length: 2153
	}

	public CommandBuffer command
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public internal PostProcessDebugLayer debugLayer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public RenderTargetIdentifier destination
	{
		[CompilerGenerated]
		 get { } //Length: 29
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public bool flip
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private int height
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public internal bool isSceneView
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public private int numberOfEyes
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public internal PropertySheetFactory propertySheets
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public internal PostProcessResources resources
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public private int screenHeight
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int screenWidth
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public RenderTargetIdentifier source
	{
		[CompilerGenerated]
		 get { } //Length: 29
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public RenderTextureFormat sourceFormat
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private bool stereoActive
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private StereoRenderingMode stereoRenderingMode
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public internal TemporalAntialiasing temporalAntialiasing
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public private Dictionary userData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int width
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private int xrActiveEye
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public PostProcessRenderContext() { }

	[CompilerGenerated]
	public Antialiasing get_antialiasing() { }

	public Camera get_camera() { }

	[CompilerGenerated]
	public CommandBuffer get_command() { }

	[CompilerGenerated]
	public PostProcessDebugLayer get_debugLayer() { }

	[CompilerGenerated]
	public RenderTargetIdentifier get_destination() { }

	[CompilerGenerated]
	public bool get_flip() { }

	[CompilerGenerated]
	public int get_height() { }

	[CompilerGenerated]
	public bool get_isSceneView() { }

	[CompilerGenerated]
	public int get_numberOfEyes() { }

	[CompilerGenerated]
	public PropertySheetFactory get_propertySheets() { }

	[CompilerGenerated]
	public PostProcessResources get_resources() { }

	[CompilerGenerated]
	public int get_screenHeight() { }

	[CompilerGenerated]
	public int get_screenWidth() { }

	[CompilerGenerated]
	public RenderTargetIdentifier get_source() { }

	[CompilerGenerated]
	public RenderTextureFormat get_sourceFormat() { }

	[CompilerGenerated]
	public bool get_stereoActive() { }

	[CompilerGenerated]
	public StereoRenderingMode get_stereoRenderingMode() { }

	[CompilerGenerated]
	public TemporalAntialiasing get_temporalAntialiasing() { }

	[CompilerGenerated]
	public Dictionary get_userData() { }

	[CompilerGenerated]
	public int get_width() { }

	[CompilerGenerated]
	public int get_xrActiveEye() { }

	private RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = 0, RenderTextureReadWrite readWrite = 0) { }

	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = 0, RenderTextureReadWrite readWrite = 0, FilterMode filter = 1, int widthOverride = 0, int heightOverride = 0) { }

	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = 0, RenderTextureReadWrite readWrite = 0, int widthOverride = 0, int heightOverride = 0) { }

	public bool IsDebugOverlayEnabled(DebugOverlay overlay) { }

	public bool IsTemporalAntialiasingActive() { }

	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	public void Reset() { }

	[CompilerGenerated]
	internal void set_antialiasing(Antialiasing value) { }

	public void set_camera(Camera value) { }

	[CompilerGenerated]
	public void set_command(CommandBuffer value) { }

	[CompilerGenerated]
	internal void set_debugLayer(PostProcessDebugLayer value) { }

	[CompilerGenerated]
	public void set_destination(RenderTargetIdentifier value) { }

	[CompilerGenerated]
	public void set_flip(bool value) { }

	[CompilerGenerated]
	private void set_height(int value) { }

	[CompilerGenerated]
	internal void set_isSceneView(bool value) { }

	[CompilerGenerated]
	private void set_numberOfEyes(int value) { }

	[CompilerGenerated]
	internal void set_propertySheets(PropertySheetFactory value) { }

	[CompilerGenerated]
	internal void set_resources(PostProcessResources value) { }

	[CompilerGenerated]
	private void set_screenHeight(int value) { }

	[CompilerGenerated]
	private void set_screenWidth(int value) { }

	[CompilerGenerated]
	public void set_source(RenderTargetIdentifier value) { }

	[CompilerGenerated]
	public void set_sourceFormat(RenderTextureFormat value) { }

	[CompilerGenerated]
	private void set_stereoActive(bool value) { }

	[CompilerGenerated]
	private void set_stereoRenderingMode(StereoRenderingMode value) { }

	[CompilerGenerated]
	internal void set_temporalAntialiasing(TemporalAntialiasing value) { }

	[CompilerGenerated]
	private void set_userData(Dictionary value) { }

	[CompilerGenerated]
	private void set_width(int value) { }

	[CompilerGenerated]
	private void set_xrActiveEye(int value) { }

}

