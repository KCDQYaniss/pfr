namespace EFT.Water;

public class WaterSurfaceRenderer : IWaterRenderer, IWaterDrawingResults
{
	private readonly WaterProperties _properties; //Field offset: 0x10
	private IReadOnlyList _drawingResults; //Field offset: 0x18
	private RenderTargetIdentifier[] _mrt; //Field offset: 0x20

	public override bool Enabled
	{
		 get { } //Length: 407
	}

	public WaterSurfaceRenderer(WaterProperties properties) { }

	public override void Cleanup(CommandBuffer cmd) { }

	public void Configure(Camera camera, CommandBuffer cmd) { }

	public override bool get_Enabled() { }

	public override void Render(Camera camera, CommandBuffer cmd) { }

	private void RenderFrontFace(CommandBuffer cmd) { }

	private void RenderRestoreFrontFace(CommandBuffer cmd) { }

	public override void SetDrawingResults(IReadOnlyList results) { }

	private void SetupRenderTargets(Camera camera) { }

	private void Update(CommandBuffer cmd) { }

}

