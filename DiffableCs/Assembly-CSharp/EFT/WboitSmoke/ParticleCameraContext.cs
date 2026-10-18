namespace EFT.WboitSmoke;

internal sealed class ParticleCameraContext : IDisposable
{
	private readonly CameraEvent _injectionEvent; //Field offset: 0x10
	private readonly CommandBuffer _commandBuffer; //Field offset: 0x18
	private bool _isDisposed; //Field offset: 0x20
	private bool _hasCommands; //Field offset: 0x21
	private Camera _camera; //Field offset: 0x28
	[CompilerGenerated]
	private readonly ECameraType <CameraType>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly ParticleRenderTargetHandler <RenderTargetHandler>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly ParticleBufferSet <Buffers>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly MaterialPropertyBlock <PropertyBlock>k__BackingField; //Field offset: 0x48

	public ParticleBufferSet Buffers
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Camera Camera
	{
		 get { } //Length: 5
	}

	public ECameraType CameraType
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public bool CanRender
	{
		 get { } //Length: 360
	}

	public CommandBuffer CommandBuffer
	{
		 get { } //Length: 5
	}

	public bool HasPreparedFrame
	{
		 get { } //Length: 42
	}

	public MaterialPropertyBlock PropertyBlock
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ParticleRenderTargetHandler RenderTargetHandler
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ParticleCameraContext(ECameraType cameraType, string commandBufferName, CameraEvent injectionEvent, IndirectParticlesProfile profile) { }

	public void Attach() { }

	public void ClearCommands() { }

	public void Detach() { }

	public override void Dispose() { }

	[CompilerGenerated]
	public ParticleBufferSet get_Buffers() { }

	public Camera get_Camera() { }

	[CompilerGenerated]
	public ECameraType get_CameraType() { }

	public bool get_CanRender() { }

	public CommandBuffer get_CommandBuffer() { }

	public bool get_HasPreparedFrame() { }

	[CompilerGenerated]
	public MaterialPropertyBlock get_PropertyBlock() { }

	[CompilerGenerated]
	public ParticleRenderTargetHandler get_RenderTargetHandler() { }

	public void MarkFramePrepared() { }

	public void SetCamera(Camera camera) { }

	public void SetParticleCount(int particleCount) { }

	public void UploadParticleRange(List particles, int startIndex, int count) { }

}

