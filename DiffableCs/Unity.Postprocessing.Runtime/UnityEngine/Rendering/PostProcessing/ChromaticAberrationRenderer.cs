namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class ChromaticAberrationRenderer : PostProcessEffectRenderer
{
	private Texture2D m_InternalSpectralLut; //Field offset: 0x20

	public ChromaticAberrationRenderer() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

