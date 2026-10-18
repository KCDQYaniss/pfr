namespace EFT.Water;

public class UnderwaterRenderer : IWaterRenderer, IWaterDrawingResults
{
	private readonly Vector3[] _frustumCorners; //Field offset: 0x10
	private readonly WaterProperties _properties; //Field offset: 0x18
	private Matrix4x4 _frustumCornersArray; //Field offset: 0x20
	private IReadOnlyList _drawingResults; //Field offset: 0x60
	private int _lastBlurIteration; //Field offset: 0x68
	private int[] _downsampleTextureIds; //Field offset: 0x70
	private int[] _upsampleTextureIds; //Field offset: 0x78

	public override bool Enabled
	{
		 get { } //Length: 19
	}

	public UnderwaterRenderer(WaterProperties properties) { }

	private void BlurCameraColorTarget(Camera camera, CommandBuffer cmd) { }

	public override void Cleanup(CommandBuffer cmd) { }

	public void Configure(Camera camera, CommandBuffer cmd) { }

	private void EnsureBlurIds() { }

	public override bool get_Enabled() { }

	public override void Render(Camera camera, CommandBuffer cmd) { }

	private void RenderMask(CommandBuffer cmd) { }

	public override void SetDrawingResults(IReadOnlyList results) { }

	private void SetupCameraColorTarget(CommandBuffer cmd) { }

	private void SetupFrustum(Camera camera, CommandBuffer cmd) { }

	private void SetupMatrix(Camera camera, CommandBuffer cmd) { }

	private void UnderwaterFog(CommandBuffer cmd) { }

	private void Update(CommandBuffer cmd) { }

	private void UpdateUnderwaterAbsorption(CommandBuffer cmd) { }

	private void UpdateUnderwaterColor(CommandBuffer cmd) { }

	private void UpdateUnderwaterDepth(CommandBuffer cmd) { }

	private void UpdateUnderwaterGeneral(CommandBuffer cmd) { }

	private void UpdateUnderwaterRefraction(CommandBuffer cmd) { }

	private void UpdateUnderwaterScattering(CommandBuffer cmd) { }

}

