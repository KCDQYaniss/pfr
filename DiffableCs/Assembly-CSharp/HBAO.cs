//Type is in global namespace

[AddComponentMenu("Image Effects/HBAO")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class HBAO : HBAO_Core
{
	private RenderTexture[] _mrtTexDepth; //Field offset: 0xF0
	private RenderTexture[] _mrtTexNrm; //Field offset: 0xF8
	private RenderTexture[] _mrtTexAO; //Field offset: 0x100
	private RenderBuffer[][] _mrtRB; //Field offset: 0x108
	private RenderBuffer[][] _mrtRBNrm; //Field offset: 0x110
	private RenderTexture _downsampledRT; //Field offset: 0x118
	private RenderTexture _mainRT; //Field offset: 0x120
	private CommandBuffer _cmdBuf; //Field offset: 0x128
	public bool useTriangleBlit; //Field offset: 0x130

	public HBAO() { }

	private bool IsRenderTextureNeedResize() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void RecreateRTs() { }

	private void RenderHBAO(RenderTexture source, RenderTexture destination) { }

	private void RenderHBAODeinterleaved2x(RenderTexture source, RenderTexture destination) { }

	private void RenderHBAODeinterleaved4x(RenderTexture source, RenderTexture destination) { }

}

