namespace UnityEngine.Rendering.PostProcessing;

public sealed class LightMeterMonitor : Monitor
{
	public int width; //Field offset: 0x20
	public int height; //Field offset: 0x24
	public bool showCurves; //Field offset: 0x28

	public LightMeterMonitor() { }

	internal virtual void Render(PostProcessRenderContext context) { }

	internal virtual bool ShaderResourcesAvailable(PostProcessRenderContext context) { }

}

