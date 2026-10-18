namespace UnityStandardAssets.CinematicEffects;

public class RenderTextureUtility
{
	private List m_TemporaryRTs; //Field offset: 0x10

	public RenderTextureUtility() { }

	public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, FilterMode filterMode = 1) { }

	public void ReleaseAllTemporaryRenderTextures() { }

	public void ReleaseTemporaryRenderTexture(RenderTexture rt) { }

}

