namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/Renderer.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public class Renderer : Component
{

	[NativeProperty("IsDynamicOccludee")]
	public bool allowOcclusionWhenDynamic
	{
		 set { } //Length: 93
	}

	public Bounds bounds
	{
		[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
		 get { } //Length: 108
		[NativeName("SetWorldAABB")]
		 set { } //Length: 93
	}

	public bool enabled
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public bool forceRenderingOff
	{
		 set { } //Length: 93
	}

	public bool isPartOfStaticBatch
	{
		[NativeName("IsPartOfStaticBatch")]
		 get { } //Length: 78
	}

	public bool isVisible
	{
		[NativeName("IsVisibleInScene")]
		 get { } //Length: 78
	}

	public int lightmapIndex
	{
		 get { } //Length: 80
		 set { } //Length: 94
	}

	public Vector4 lightmapScaleOffset
	{
		 get { } //Length: 119
	}

	public LightProbeUsage lightProbeUsage
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public Bounds localBounds
	{
		[NativeName("SetLocalAABB")]
		 set { } //Length: 93
	}

	public Matrix4x4 localToWorldMatrix
	{
		 get { } //Length: 114
	}

	public Material material
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public Material[] materials
	{
		 get { } //Length: 78
		 set { } //Length: 138
	}

	public MotionVectorGenerationMode motionVectorGenerationMode
	{
		 set { } //Length: 91
	}

	public Transform probeAnchor
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public int realtimeLightmapIndex
	{
		 get { } //Length: 83
		 set { } //Length: 97
	}

	public Vector4 realtimeLightmapScaleOffset
	{
		 get { } //Length: 122
	}

	public bool receiveShadows
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public ReflectionProbeUsage reflectionProbeUsage
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public ShadowCastingMode shadowCastingMode
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public Material sharedMaterial
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public Material[] sharedMaterials
	{
		 get { } //Length: 78
		 set { } //Length: 138
	}

	internal int sortingGroupID
	{
		internal get { } //Length: 78
	}

	internal int sortingGroupOrder
	{
		internal get { } //Length: 78
	}

	public int sortingLayerID
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public int sortingOrder
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public bool staticShadowCaster
	{
		 set { } //Length: 93
	}

	public Renderer() { }

	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = True)]
	private void CopyMaterialArray(out Material[] m) { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterialArray", HasExplicitThis = True)]
	private void CopySharedMaterialArray(out Material[] m) { }

	[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	public bool get_enabled() { }

	[NativeName("IsPartOfStaticBatch")]
	public bool get_isPartOfStaticBatch() { }

	[NativeName("IsVisibleInScene")]
	public bool get_isVisible() { }

	public int get_lightmapIndex() { }

	public Vector4 get_lightmapScaleOffset() { }

	public LightProbeUsage get_lightProbeUsage() { }

	public Matrix4x4 get_localToWorldMatrix() { }

	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	public Material get_material() { }

	public Material[] get_materials() { }

	public Transform get_probeAnchor() { }

	public int get_realtimeLightmapIndex() { }

	public Vector4 get_realtimeLightmapScaleOffset() { }

	public bool get_receiveShadows() { }

	public ReflectionProbeUsage get_reflectionProbeUsage() { }

	public ShadowCastingMode get_shadowCastingMode() { }

	public Material get_sharedMaterial() { }

	public Material[] get_sharedMaterials() { }

	internal int get_sortingGroupID() { }

	internal int get_sortingGroupOrder() { }

	public int get_sortingLayerID() { }

	public int get_sortingOrder() { }

	[NativeName("GetLightmapIndexInt")]
	private int GetLightmapIndex(LightmapType lt) { }

	[NativeName("GetLightmapST")]
	private Vector4 GetLightmapST(LightmapType lt) { }

	private void GetLightmapST_Injected(LightmapType lt, out Vector4 ret) { }

	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	private Material GetMaterial() { }

	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = True)]
	private Material[] GetMaterialArray() { }

	private int GetMaterialCount() { }

	public void GetMaterials(List m) { }

	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	private Material GetSharedMaterial() { }

	[NativeName("GetMaterialArray")]
	private Material[] GetSharedMaterialArray() { }

	public void GetSharedMaterials(List m) { }

	[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = True)]
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = True)]
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunction(Name = "RendererScripting::SetPropertyBlockMaterialIndex", HasExplicitThis = True)]
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	public void set_allowOcclusionWhenDynamic(bool value) { }

	[NativeName("SetWorldAABB")]
	public void set_bounds(Bounds value) { }

	private void set_bounds_Injected(ref Bounds value) { }

	public void set_enabled(bool value) { }

	public void set_forceRenderingOff(bool value) { }

	public void set_lightmapIndex(int value) { }

	public void set_lightProbeUsage(LightProbeUsage value) { }

	[NativeName("SetLocalAABB")]
	public void set_localBounds(Bounds value) { }

	private void set_localBounds_Injected(ref Bounds value) { }

	public void set_material(Material value) { }

	public void set_materials(Material[] value) { }

	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	public void set_probeAnchor(Transform value) { }

	public void set_realtimeLightmapIndex(int value) { }

	public void set_receiveShadows(bool value) { }

	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	public void set_shadowCastingMode(ShadowCastingMode value) { }

	public void set_sharedMaterial(Material value) { }

	public void set_sharedMaterials(Material[] value) { }

	public void set_sortingLayerID(int value) { }

	public void set_sortingOrder(int value) { }

	public void set_staticShadowCaster(bool value) { }

	[NativeName("SetIsStaticShadowCaster")]
	private void SetIsStaticShadowCaster(bool value) { }

	[NativeName("SetLightmapIndexInt")]
	private void SetLightmapIndex(int index, LightmapType lt) { }

	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	private void SetMaterial(Material m) { }

	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = True)]
	private void SetMaterialArray(Material[] m, int length) { }

	private void SetMaterialArray(Material[] m) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

}

