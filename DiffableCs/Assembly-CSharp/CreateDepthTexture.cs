//Type is in global namespace

public class CreateDepthTexture : MonoBehaviour
{
	private static readonly int _cameraDepthTextureDeferred; //Field offset: 0x0
	private Material _depthMat; //Field offset: 0x20
	public RenderTexture _rt; //Field offset: 0x28

	private static CreateDepthTexture() { }

	public CreateDepthTexture() { }

	private void OnRenderImage(RenderTexture s, RenderTexture d) { }

	private void Start() { }

}

