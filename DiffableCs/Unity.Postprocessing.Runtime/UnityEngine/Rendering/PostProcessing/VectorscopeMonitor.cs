namespace UnityEngine.Rendering.PostProcessing;

public sealed class VectorscopeMonitor : Monitor
{
	private const int k_ThreadGroupSizeX = 16; //Field offset: 0x0
	private const int k_ThreadGroupSizeY = 16; //Field offset: 0x0
	public int size; //Field offset: 0x20
	public float exposure; //Field offset: 0x24
	private ComputeBuffer m_Data; //Field offset: 0x28

	public VectorscopeMonitor() { }

	internal virtual bool NeedsHalfRes() { }

	internal virtual void OnDisable() { }

	internal virtual void Render(PostProcessRenderContext context) { }

	internal virtual bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

}

