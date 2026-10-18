namespace UnityStandardAssets.ImageEffects;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class PostEffectsBase : MonoBehaviour
{
	protected bool supportHDRTextures; //Field offset: 0x20
	protected bool supportDX11; //Field offset: 0x21
	protected bool isSupported; //Field offset: 0x22
	private bool supportsRenderTextureFormatDepth; //Field offset: 0x23
	protected SSAAPropagator _ssaaPropagator; //Field offset: 0x28

	public PostEffectsBase() { }

	public override bool CheckResources() { }

	protected bool CheckSupport() { }

	protected bool CheckSupport(bool needDepth) { }

	protected bool CheckSupport(bool needDepth, bool needHdr) { }

	protected Material CreateMaterial(Shader s, Material m2Create) { }

	protected void DrawBorder(RenderTexture dest, Material material) { }

	public bool Dx11Support() { }

	protected void NotSupported() { }

	protected void ReportAutoDisable() { }

	protected void Start() { }

}

