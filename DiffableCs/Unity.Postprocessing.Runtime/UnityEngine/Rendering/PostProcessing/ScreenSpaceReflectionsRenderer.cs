namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer
{
	private enum Pass
	{
		Test = 0,
		Resolve = 1,
		Reproject = 2,
		Composite = 3,
	}

	private class QualityPreset
	{
		public int maximumIterationCount; //Field offset: 0x10
		public float thickness; //Field offset: 0x14
		public ScreenSpaceReflectionResolution downsampling; //Field offset: 0x18

		public QualityPreset() { }

	}

	private RenderTexture m_Resolve; //Field offset: 0x20
	private RenderTexture m_History; //Field offset: 0x28
	private int[] m_MipIDs; //Field offset: 0x30
	private readonly QualityPreset[] m_Presets; //Field offset: 0x38

	public ScreenSpaceReflectionsRenderer() { }

	internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap) { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

