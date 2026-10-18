namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
public sealed class SystemInfo
{

	public static CopyTextureSupport copyTextureSupport
	{
		 get { } //Length: 69
	}

	public static string deviceModel
	{
		 get { } //Length: 69
	}

	public static DeviceType deviceType
	{
		 get { } //Length: 69
	}

	public static string deviceUniqueIdentifier
	{
		 get { } //Length: 69
	}

	public static int graphicsDeviceID
	{
		 get { } //Length: 69
	}

	public static string graphicsDeviceName
	{
		 get { } //Length: 69
	}

	public static GraphicsDeviceType graphicsDeviceType
	{
		 get { } //Length: 69
	}

	public static string graphicsDeviceVendor
	{
		 get { } //Length: 69
	}

	public static int graphicsDeviceVendorID
	{
		 get { } //Length: 69
	}

	public static string graphicsDeviceVersion
	{
		 get { } //Length: 69
	}

	public static int graphicsMemorySize
	{
		 get { } //Length: 69
	}

	public static bool graphicsMultiThreaded
	{
		 get { } //Length: 69
	}

	public static int graphicsShaderLevel
	{
		 get { } //Length: 69
	}

	public static bool graphicsUVStartsAtTop
	{
		 get { } //Length: 69
	}

	public static long maxGraphicsBufferSize
	{
		 get { } //Length: 69
	}

	internal static int maxRenderTextureSize
	{
		internal get { } //Length: 69
	}

	public static int maxTextureSize
	{
		 get { } //Length: 69
	}

	public static string operatingSystem
	{
		 get { } //Length: 69
	}

	public static OperatingSystemFamily operatingSystemFamily
	{
		 get { } //Length: 69
	}

	public static int processorCount
	{
		 get { } //Length: 69
	}

	public static int processorFrequency
	{
		 get { } //Length: 69
	}

	public static string processorType
	{
		 get { } //Length: 69
	}

	public static RenderingThreadingMode renderingThreadingMode
	{
		 get { } //Length: 69
	}

	public static int supportedRandomWriteTargetCount
	{
		 get { } //Length: 69
	}

	public static int supportedRenderTargetCount
	{
		 get { } //Length: 69
	}

	public static bool supports3DRenderTextures
	{
		 get { } //Length: 69
	}

	public static bool supports3DTextures
	{
		 get { } //Length: 69
	}

	public static bool supportsComputeShaders
	{
		 get { } //Length: 69
	}

	public static bool supportsGyroscope
	{
		 get { } //Length: 69
	}

	[Obsolete("supportsImageEffects always returns true, no need to call it")]
	public static bool supportsImageEffects
	{
		 get { } //Length: 5
	}

	public static bool supportsIndirectArgumentsBuffer
	{
		 get { } //Length: 69
	}

	public static bool supportsInstancing
	{
		 get { } //Length: 69
	}

	public static bool supportsMipStreaming
	{
		 get { } //Length: 69
	}

	public static bool supportsMotionVectors
	{
		 get { } //Length: 69
	}

	public static bool supportsShadows
	{
		 get { } //Length: 69
	}

	public static int systemMemorySize
	{
		 get { } //Length: 69
	}

	public static bool usesLoadStoreActions
	{
		 get { } //Length: 69
	}

	public static bool usesReversedZBuffer
	{
		 get { } //Length: 69
	}

	public static CopyTextureSupport get_copyTextureSupport() { }

	public static string get_deviceModel() { }

	public static DeviceType get_deviceType() { }

	public static string get_deviceUniqueIdentifier() { }

	public static int get_graphicsDeviceID() { }

	public static string get_graphicsDeviceName() { }

	public static GraphicsDeviceType get_graphicsDeviceType() { }

	public static string get_graphicsDeviceVendor() { }

	public static int get_graphicsDeviceVendorID() { }

	public static string get_graphicsDeviceVersion() { }

	public static int get_graphicsMemorySize() { }

	public static bool get_graphicsMultiThreaded() { }

	public static int get_graphicsShaderLevel() { }

	public static bool get_graphicsUVStartsAtTop() { }

	public static long get_maxGraphicsBufferSize() { }

	internal static int get_maxRenderTextureSize() { }

	public static int get_maxTextureSize() { }

	public static string get_operatingSystem() { }

	public static OperatingSystemFamily get_operatingSystemFamily() { }

	public static int get_processorCount() { }

	public static int get_processorFrequency() { }

	public static string get_processorType() { }

	public static RenderingThreadingMode get_renderingThreadingMode() { }

	public static int get_supportedRandomWriteTargetCount() { }

	public static int get_supportedRenderTargetCount() { }

	public static bool get_supports3DRenderTextures() { }

	public static bool get_supports3DTextures() { }

	public static bool get_supportsComputeShaders() { }

	public static bool get_supportsGyroscope() { }

	public static bool get_supportsImageEffects() { }

	public static bool get_supportsIndirectArgumentsBuffer() { }

	public static bool get_supportsInstancing() { }

	public static bool get_supportsMipStreaming() { }

	public static bool get_supportsMotionVectors() { }

	public static bool get_supportsShadows() { }

	public static int get_systemMemorySize() { }

	public static bool get_usesLoadStoreActions() { }

	public static bool get_usesReversedZBuffer() { }

	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunction("ScriptingGraphicsCaps::GetCopyTextureSupport")]
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunction("systeminfo::GetDeviceModel")]
	private static string GetDeviceModel() { }

	[FreeFunction("systeminfo::GetDeviceType")]
	private static DeviceType GetDeviceType() { }

	[FreeFunction("systeminfo::GetDeviceUniqueIdentifier")]
	private static string GetDeviceUniqueIdentifier() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceID")]
	private static int GetGraphicsDeviceID() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
	private static string GetGraphicsDeviceName() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceType")]
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendor")]
	private static string GetGraphicsDeviceVendor() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendorID")]
	private static int GetGraphicsDeviceVendorID() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVersion")]
	private static string GetGraphicsDeviceVersion() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsMemorySize")]
	private static int GetGraphicsMemorySize() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsMultiThreaded")]
	private static bool GetGraphicsMultiThreaded() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
	private static int GetGraphicsShaderLevel() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsUVStartsAtTop")]
	private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
	private static int GetMaxRenderTextureSize() { }

	[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
	private static int GetMaxTextureSize() { }

	[FreeFunction("systeminfo::GetOperatingSystem")]
	private static string GetOperatingSystem() { }

	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
	private static int GetPhysicalMemoryMB() { }

	[FreeFunction("systeminfo::GetProcessorCount")]
	private static int GetProcessorCount() { }

	[FreeFunction("systeminfo::GetProcessorFrequencyMHz")]
	private static int GetProcessorFrequencyMHz() { }

	[FreeFunction("systeminfo::GetProcessorType")]
	private static string GetProcessorType() { }

	[FreeFunction("ScriptingGraphicsCaps::GetRenderingThreadingMode")]
	private static RenderingThreadingMode GetRenderingThreadingMode() { }

	[FreeFunction("ScriptingGraphicsCaps::HasRenderTexture")]
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunction]
	private static bool IsGyroAvailable() { }

	private static bool IsValidEnumValue(Enum value) { }

	[FreeFunction("ScriptingGraphicsCaps::MaxGraphicsBufferSize")]
	private static long MaxGraphicsBufferSize() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportedRandomWriteTargetCount")]
	private static int SupportedRandomWriteTargetCount() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportedRenderTargetCount")]
	private static int SupportedRenderTargetCount() { }

	[FreeFunction("ScriptingGraphicsCaps::Supports3DRenderTextures")]
	private static bool Supports3DRenderTextures() { }

	[FreeFunction("ScriptingGraphicsCaps::Supports3DTextures")]
	private static bool Supports3DTextures() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsComputeShaders")]
	private static bool SupportsComputeShaders() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsIndirectArgumentsBuffer")]
	private static bool SupportsIndirectArgumentsBuffer() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsInstancing")]
	private static bool SupportsInstancing() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsMipStreaming")]
	private static bool SupportsMipStreaming() { }

	[FreeFunction("SupportsMotionVectors")]
	private static bool SupportsMotionVectors() { }

	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsShadows")]
	private static bool SupportsShadows() { }

	public static bool SupportsTextureFormat(TextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::UsesLoadStoreActions")]
	private static bool UsesLoadStoreActions() { }

	[FreeFunction("ScriptingGraphicsCaps::UsesReversedZBuffer")]
	private static bool UsesReversedZBuffer() { }

}

