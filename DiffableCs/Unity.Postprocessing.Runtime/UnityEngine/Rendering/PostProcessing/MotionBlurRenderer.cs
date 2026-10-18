namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class MotionBlurRenderer : PostProcessEffectRenderer
{
	private enum Pass
	{
		VelocitySetup = 0,
		TileMax1 = 1,
		TileMax2 = 2,
		TileMaxV = 3,
		NeighborMax = 4,
		Reconstruction = 5,
	}


	public MotionBlurRenderer() { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

