namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/CopyTexture.h")]
public class Graphics
{
	internal static readonly int kMaxDrawMeshInstanceCount; //Field offset: 0x0
	internal static Dictionary s_RenderInstancedDataLayouts; //Field offset: 0x8

	[StaticAccessor("GetGfxDevice()", StaticAccessorType::Dot (0))]
	public static GraphicsTier activeTier
	{
		 set { } //Length: 76
	}

	private static Graphics() { }

	public Graphics() { }

	public static void Blit(Texture source, RenderTexture dest) { }

	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass, int destDepthSlice) { }

	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	public static void Blit(Texture source, Material mat, int pass) { }

	public static void Blit(Texture source, Material mat, int pass, int destDepthSlice) { }

	[FreeFunction("GraphicsScripting::Blit")]
	private static void Blit2(Texture source, RenderTexture dest) { }

	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[StaticAccessor("GetGfxDevice()", StaticAccessorType::Dot (0))]
	public static void ClearRandomWriteTargets() { }

	public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) { }

	public static void CopyTexture(Texture src, int srcElement, Texture dst, int dstElement) { }

	public static void CopyTexture(Texture src, Texture dst) { }

	public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	[FreeFunction("CopyTexture")]
	private static void CopyTexture_Full(Texture src, Texture dst) { }

	[FreeFunction("CopyTexture")]
	private static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[FreeFunction("CopyTexture")]
	private static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	[FreeFunction("CopyTexture")]
	private static void CopyTexture_Slice_AllMips(Texture src, int srcElement, Texture dst, int dstElement) { }

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex) { }

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera) { }

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex) { }

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties) { }

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer) { }

	[ExcludeFromDocs]
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset = 0, MaterialPropertyBlock properties = null, ShadowCastingMode castShadows = 1, bool receiveShadows = true, int layer = 0, Camera camera = null, LightProbeUsage lightProbeUsage = 1) { }

	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset = 0) { }

	[NativeMethod(Name = "GraphicsScripting::ExecuteCommandBuffer", IsFreeFunction = True, ThrowsException = True)]
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	[FreeFunction("GraphicsScripting::BlitMaterial")]
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	[FreeFunction("GraphicsScripting::BlitMaterial")]
	private static void Internal_BlitMaterial6(Texture source, RenderTexture dest, Material mat, int pass, bool setRT, int destDepthSlice) { }

	[FreeFunction("GraphicsScripting::BlitMultitap")]
	private static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[FreeFunction("GraphicsScripting::DrawMesh")]
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunction("GraphicsScripting::DrawMeshInstancedIndirect")]
	private static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	private static void Internal_DrawMeshInstancedIndirect_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunction("GraphicsScripting::DrawMeshNow")]
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) { }

	[FreeFunction("GraphicsScripting::DrawProceduralIndirectNow")]
	private static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[FreeFunction("GraphicsScripting::DrawTexture")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"})]
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = True)]
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[NativeMethod(Name = "GraphicsScripting::SetMRTSimple", IsFreeFunction = True, ThrowsException = True)]
	private static void Internal_SetMRTSimple(RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	private static void Internal_SetMRTSimple_Injected(RenderBuffer[] color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[FreeFunction("GraphicsScripting::SetNullRT")]
	private static void Internal_SetNullRT() { }

	[FreeFunction("GraphicsScripting::SetRandomWriteTargetBuffer")]
	private static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = True, ThrowsException = True)]
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	public static void set_activeTier(GraphicsTier value) { }

	public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	[ExcludeFromDocs]
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav) { }

	[ExcludeFromDocs]
	public static void SetRenderTarget(RenderTexture rt) { }

	[ExcludeFromDocs]
	public static void SetRenderTarget(RenderTexture rt, int mipLevel) { }

	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	public static void SetRenderTarget(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer) { }

	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	internal static void SetRenderTargetImpl(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

}

