namespace UnityEngine;

[NativeHeader("Runtime/Graphics/QualitySettings.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[StaticAccessor("GetQualitySettings()", StaticAccessorType::Dot (0))]
public sealed class QualitySettings : Object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeQualityLevelChanged; //Field offset: 0x0

	public static ColorSpace activeColorSpace
	{
		[NativeName("GetColorSpace")]
		[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
		 get { } //Length: 69
	}

	[NativeProperty("AnisotropicTextures")]
	public static AnisotropicFiltering anisotropicFiltering
	{
		 set { } //Length: 76
	}

	public static int antiAliasing
	{
		 get { } //Length: 69
		 set { } //Length: 76
	}

	public static int asyncUploadBufferSize
	{
		 get { } //Length: 69
		 set { } //Length: 76
	}

	public static bool asyncUploadPersistentBuffer
	{
		 set { } //Length: 78
	}

	public static int asyncUploadTimeSlice
	{
		 get { } //Length: 69
		 set { } //Length: 76
	}

	public static bool billboardsFaceCameraPosition
	{
		 set { } //Length: 78
	}

	public static int globalTextureMipmapLimit
	{
		 get { } //Length: 69
		 set { } //Length: 76
	}

	[NativeName("RenderPipeline")]
	private static ScriptableObject INTERNAL_renderPipeline
	{
		private get { } //Length: 69
		private set { } //Length: 78
	}

	[NativeProperty("LODBias")]
	public static float lodBias
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	public static int maximumLODLevel
	{
		 set { } //Length: 76
	}

	public static int particleRaycastBudget
	{
		 set { } //Length: 76
	}

	public static int pixelLightCount
	{
		 get { } //Length: 69
		 set { } //Length: 76
	}

	public static bool realtimeReflectionProbes
	{
		 set { } //Length: 78
	}

	public static RenderPipelineAsset renderPipeline
	{
		 get { } //Length: 172
		 set { } //Length: 78
	}

	public static float resolutionScalingFixedDPIFactor
	{
		 set { } //Length: 85
	}

	public static float shadowCascade2Split
	{
		 set { } //Length: 85
	}

	public static Vector3 shadowCascade4Split
	{
		 set { } //Length: 78
	}

	public static int shadowCascades
	{
		 get { } //Length: 69
		 set { } //Length: 76
	}

	public static float shadowDistance
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	[NativeProperty("ShadowmaskMode")]
	public static ShadowmaskMode shadowmaskMode
	{
		 set { } //Length: 76
	}

	public static float shadowNearPlaneOffset
	{
		 set { } //Length: 85
	}

	public static ShadowProjection shadowProjection
	{
		 set { } //Length: 76
	}

	[NativeProperty("ShadowResolution")]
	public static ShadowResolution shadowResolution
	{
		 set { } //Length: 76
	}

	[NativeProperty("ShadowQuality")]
	public static ShadowQuality shadows
	{
		 set { } //Length: 76
	}

	public static SkinWeights skinWeights
	{
		 get { } //Length: 69
		 set { } //Length: 76
	}

	public static bool softParticles
	{
		 set { } //Length: 78
	}

	public static bool streamingMipmapsActive
	{
		 get { } //Length: 69
		 set { } //Length: 78
	}

	public static bool streamingMipmapsAddAllCameras
	{
		 set { } //Length: 78
	}

	public static int streamingMipmapsMaxFileIORequests
	{
		 set { } //Length: 76
	}

	public static int streamingMipmapsMaxLevelReduction
	{
		 get { } //Length: 69
		 set { } //Length: 76
	}

	public static float streamingMipmapsMemoryBudget
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	public static int vSyncCount
	{
		 set { } //Length: 76
	}

	[NativeName("GetColorSpace")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	public static ColorSpace get_activeColorSpace() { }

	public static int get_antiAliasing() { }

	public static int get_asyncUploadBufferSize() { }

	public static int get_asyncUploadTimeSlice() { }

	public static int get_globalTextureMipmapLimit() { }

	private static ScriptableObject get_INTERNAL_renderPipeline() { }

	public static float get_lodBias() { }

	public static int get_pixelLightCount() { }

	public static RenderPipelineAsset get_renderPipeline() { }

	public static int get_shadowCascades() { }

	public static float get_shadowDistance() { }

	public static SkinWeights get_skinWeights() { }

	public static bool get_streamingMipmapsActive() { }

	public static int get_streamingMipmapsMaxLevelReduction() { }

	public static float get_streamingMipmapsMemoryBudget() { }

	[RequiredByNativeCode]
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	public static void set_antiAliasing(int value) { }

	public static void set_asyncUploadBufferSize(int value) { }

	public static void set_asyncUploadPersistentBuffer(bool value) { }

	public static void set_asyncUploadTimeSlice(int value) { }

	public static void set_billboardsFaceCameraPosition(bool value) { }

	public static void set_globalTextureMipmapLimit(int value) { }

	private static void set_INTERNAL_renderPipeline(ScriptableObject value) { }

	public static void set_lodBias(float value) { }

	public static void set_maximumLODLevel(int value) { }

	public static void set_particleRaycastBudget(int value) { }

	public static void set_pixelLightCount(int value) { }

	public static void set_realtimeReflectionProbes(bool value) { }

	public static void set_renderPipeline(RenderPipelineAsset value) { }

	public static void set_resolutionScalingFixedDPIFactor(float value) { }

	public static void set_shadowCascade2Split(float value) { }

	public static void set_shadowCascade4Split(Vector3 value) { }

	private static void set_shadowCascade4Split_Injected(ref Vector3 value) { }

	public static void set_shadowCascades(int value) { }

	public static void set_shadowDistance(float value) { }

	public static void set_shadowmaskMode(ShadowmaskMode value) { }

	public static void set_shadowNearPlaneOffset(float value) { }

	public static void set_shadowProjection(ShadowProjection value) { }

	public static void set_shadowResolution(ShadowResolution value) { }

	public static void set_shadows(ShadowQuality value) { }

	public static void set_skinWeights(SkinWeights value) { }

	public static void set_softParticles(bool value) { }

	public static void set_streamingMipmapsActive(bool value) { }

	public static void set_streamingMipmapsAddAllCameras(bool value) { }

	public static void set_streamingMipmapsMaxFileIORequests(int value) { }

	public static void set_streamingMipmapsMaxLevelReduction(int value) { }

	public static void set_streamingMipmapsMemoryBudget(float value) { }

	public static void set_vSyncCount(int value) { }

}

