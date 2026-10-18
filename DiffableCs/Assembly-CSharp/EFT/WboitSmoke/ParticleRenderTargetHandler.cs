namespace EFT.WboitSmoke;

internal sealed class ParticleRenderTargetHandler
{
	private readonly IndirectParticlesProfile _profile; //Field offset: 0x10
	private int _width; //Field offset: 0x18
	private int _height; //Field offset: 0x1C
	private RenderTexture _depthPrepassTarget; //Field offset: 0x20
	private RenderTexture _depthMinMaxTarget; //Field offset: 0x28
	private RenderTexture _accumulationTarget; //Field offset: 0x30
	private RenderTexture _revealTarget; //Field offset: 0x38
	[CompilerGenerated]
	private readonly RenderTargetIdentifier[] <ColorTargets>k__BackingField; //Field offset: 0x40

	public RenderTexture AccumulationTarget
	{
		 get { } //Length: 76
	}

	public RenderTargetIdentifier[] ColorTargets
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public RenderTexture DepthMinMaxTarget
	{
		 get { } //Length: 5
	}

	public RenderTexture DepthPrepassTarget
	{
		 get { } //Length: 5
	}

	public int Height
	{
		 get { } //Length: 4
	}

	public bool IsAllocated
	{
		 get { } //Length: 689
	}

	public RenderTexture RevealTarget
	{
		 get { } //Length: 5
	}

	public int Width
	{
		 get { } //Length: 4
	}

	public ParticleRenderTargetHandler(IndirectParticlesProfile profile) { }

	private ParticleRenderTargetSize CalculateSize(Camera camera, SSAA ssaa) { }

	private static RenderTexture CreateTexture(int width, int height, int depth, RenderTextureFormat format, FilterMode filterMode, bool randomWrite) { }

	public void Ensure(int width, int height) { }

	public RenderTexture get_AccumulationTarget() { }

	[CompilerGenerated]
	public RenderTargetIdentifier[] get_ColorTargets() { }

	public RenderTexture get_DepthMinMaxTarget() { }

	public RenderTexture get_DepthPrepassTarget() { }

	public int get_Height() { }

	public bool get_IsAllocated() { }

	public RenderTexture get_RevealTarget() { }

	public int get_Width() { }

	private static float GetRenderScale(IndirectParticlesProfile profile) { }

	public void Release() { }

	private static void Release(ref RenderTexture renderTexture) { }

	private static EParticleRenderScale RenderScaleByTextureQuality(int textureQuality) { }

	public ParticleRenderTargetSize ResizeFor(Camera camera, SSAA ssaa) { }

}

