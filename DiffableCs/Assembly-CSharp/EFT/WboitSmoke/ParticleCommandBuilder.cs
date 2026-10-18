namespace EFT.WboitSmoke;

internal sealed class ParticleCommandBuilder
{
	private const string DEPTH_PREPASS_MARKER = "Depth Prepass"; //Field offset: 0x0
	private const string CULLING_PASS_MARKER = "Culling Pass"; //Field offset: 0x0
	private const string DEPTH_MINMAX_PASS_MARKER = "Depth MinMax Pass"; //Field offset: 0x0
	private const string ACCUMULATION_MARKER = "Accumulation Pass"; //Field offset: 0x0
	private const int DEPTH_PREPASS = 0; //Field offset: 0x0
	private const int ACCUMULATION_PASS = 1; //Field offset: 0x0
	private const int COMPUTE_THREAD_GROUP_SIZE = 64; //Field offset: 0x0
	private const int DEPTH_MINMAX_THREAD_GROUP_SIZE = 8; //Field offset: 0x0
	private readonly IndirectParticlesProfile _profile; //Field offset: 0x10
	private readonly Material _particleMaterial; //Field offset: 0x18
	private readonly int _cullingKernel; //Field offset: 0x20
	private readonly int _depthMinMaxKernel; //Field offset: 0x24

	public bool IsReady
	{
		 get { } //Length: 740
	}

	public ParticleCommandBuilder(IndirectParticlesProfile profile) { }

	private void ApplyAccumulation(CommandBuffer commandBuffer, ParticleRenderTargetHandler renderTargetHandler, MaterialPropertyBlock propertyBlock, ParticleBufferSet buffers, Vector3 origin) { }

	private void ApplyAccumulationProperties(MaterialPropertyBlock propertyBlock, ParticleBufferSet buffers, ParticleRenderTargetHandler renderTargetHandler, Vector3 origin) { }

	private void ApplyCulling(CommandBuffer commandBuffer, Camera camera, ParticleRenderTargetHandler renderTargetHandler, ParticleBufferSet buffers, ParticleRenderData data) { }

	private void ApplyDepthMinMax(CommandBuffer commandBuffer, ParticleRenderTargetHandler renderTargetHandler, MaterialPropertyBlock propertyBlock, ParticleRenderTargetSize targetSize) { }

	private void ApplyPrepass(CommandBuffer commandBuffer, ParticleRenderTargetHandler renderTargetHandler, MaterialPropertyBlock propertyBlock, ParticleBufferSet buffers) { }

	public void Build(ParticleCameraContext context, SSAA ssaa, ParticleRenderData data) { }

	public bool get_IsReady() { }

	private float GetMaxDistance(Camera camera, Vector3 origin) { }

}

