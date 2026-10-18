namespace UnityEngine;

[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[UsedByNativeCode]
public class RenderTexture : Texture
{

	public static RenderTexture active
	{
		 get { } //Length: 69
		 set { } //Length: 78
	}

	public int antiAliasing
	{
		 set { } //Length: 91
	}

	public bool autoGenerateMips
	{
		 set { } //Length: 93
	}

	public RenderBuffer colorBuffer
	{
		 get { } //Length: 117
	}

	public int depth
	{
		[FreeFunction("RenderTextureScripting::GetDepth", HasExplicitThis = True)]
		 get { } //Length: 78
		[FreeFunction("RenderTextureScripting::SetDepth", HasExplicitThis = True)]
		 set { } //Length: 91
	}

	public RenderBuffer depthBuffer
	{
		 get { } //Length: 117
	}

	public GraphicsFormat depthStencilFormat
	{
		 set { } //Length: 91
	}

	public RenderTextureDescriptor descriptor
	{
		 get { } //Length: 169
	}

	public virtual TextureDimension dimension
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public bool enableRandomWrite
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public RenderTextureFormat format
	{
		 get { } //Length: 398
		 set { } //Length: 238
	}

	public GraphicsFormat graphicsFormat
	{
		 get { } //Length: 80
		 set { } //Length: 91
	}

	public virtual int height
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public bool isPowerOfTwo
	{
		 set { } //Length: 3
	}

	[NativeProperty("SRGBReadWrite")]
	public bool sRGB
	{
		 get { } //Length: 78
	}

	[NativeProperty("MipMap")]
	public bool useMipMap
	{
		 set { } //Length: 93
	}

	public int volumeDepth
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public virtual int width
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format) { }

	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[RequiredByNativeCode]
	protected private RenderTexture() { }

	public RenderTexture(RenderTextureDescriptor desc) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, DefaultFormat format) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format) { }

	public RenderTexture(RenderTexture textureToCopy) { }

	public bool Create() { }

	public void DiscardContents(bool discardColor, bool discardDepth) { }

	public void DiscardContents() { }

	public void GenerateMips() { }

	public static RenderTexture get_active() { }

	public RenderBuffer get_colorBuffer() { }

	[FreeFunction("RenderTextureScripting::GetDepth", HasExplicitThis = True)]
	public int get_depth() { }

	public RenderBuffer get_depthBuffer() { }

	public RenderTextureDescriptor get_descriptor() { }

	public virtual TextureDimension get_dimension() { }

	public bool get_enableRandomWrite() { }

	public RenderTextureFormat get_format() { }

	public GraphicsFormat get_graphicsFormat() { }

	public virtual int get_height() { }

	public bool get_sRGB() { }

	public int get_volumeDepth() { }

	public virtual int get_width() { }

	[FreeFunction("RenderTexture::GetActive")]
	private static RenderTexture GetActive() { }

	[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = True)]
	private RenderBuffer GetColorBuffer() { }

	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	[NativeName("GetColorFormat")]
	private GraphicsFormat GetColorFormat(bool suppressWarnings) { }

	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = True)]
	private RenderBuffer GetDepthBuffer() { }

	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	[NativeName("GetRenderTextureDesc")]
	private RenderTextureDescriptor GetDescriptor() { }

	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	public IntPtr GetNativeDepthBufferPtr() { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height) { }

	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = false) { }

	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	[FreeFunction("RenderTextureScripting::Create")]
	private static void Internal_Create(RenderTexture rt) { }

	public bool IsCreated() { }

	[Obsolete("This function has no effect.", False)]
	public void MarkRestoreExpected() { }

	public void Release() { }

	[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
	public static void ReleaseTemporary(RenderTexture temp) { }

	public static void set_active(RenderTexture value) { }

	public void set_antiAliasing(int value) { }

	public void set_autoGenerateMips(bool value) { }

	[FreeFunction("RenderTextureScripting::SetDepth", HasExplicitThis = True)]
	public void set_depth(int value) { }

	public void set_depthStencilFormat(GraphicsFormat value) { }

	public virtual void set_dimension(TextureDimension value) { }

	public void set_enableRandomWrite(bool value) { }

	public void set_format(RenderTextureFormat value) { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	public virtual void set_height(int value) { }

	public void set_isPowerOfTwo(bool value) { }

	public void set_useMipMap(bool value) { }

	public void set_volumeDepth(int value) { }

	public virtual void set_width(int value) { }

	[FreeFunction("RenderTextureScripting::SetActive")]
	private static void SetActive(RenderTexture rt) { }

	[NativeName("SetColorFormat")]
	private void SetColorFormat(GraphicsFormat format) { }

	private void SetMipMapCount(int count) { }

	[NativeName("SetRenderTextureDescFromScript")]
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	internal void SetSRGBReadWrite(bool srgb) { }

	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

}

