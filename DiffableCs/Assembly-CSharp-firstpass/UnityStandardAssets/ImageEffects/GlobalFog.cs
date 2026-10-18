namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Rendering/Global Fog")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
internal class GlobalFog : PostEffectsBase
{
	[Tooltip("Apply distance-based fog?")]
	public bool distanceFog; //Field offset: 0x30
	[Tooltip("Distance fog is based on radial distance from camera when checked")]
	public bool useRadialDistance; //Field offset: 0x31
	[Tooltip("Apply height-based fog?")]
	public bool heightFog; //Field offset: 0x32
	[Tooltip("Fog top Y coordinate")]
	public float height; //Field offset: 0x34
	[Range(0.001, 10)]
	public float heightDensity; //Field offset: 0x38
	[Tooltip("Push fog away from the camera by this amount")]
	public float startDistance; //Field offset: 0x3C
	public Shader fogShader; //Field offset: 0x40
	private Material fogMaterial; //Field offset: 0x48

	public GlobalFog() { }

	public virtual bool CheckResources() { }

	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr) { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

