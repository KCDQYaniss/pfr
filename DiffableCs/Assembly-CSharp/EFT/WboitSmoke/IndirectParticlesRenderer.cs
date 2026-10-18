namespace EFT.WboitSmoke;

public sealed class IndirectParticlesRenderer : IVolumeRenderer, IDisposable
{
	private readonly IndirectParticlesProfile _profile; //Field offset: 0x10
	private readonly List _particles; //Field offset: 0x18
	private readonly Vector3 _origin; //Field offset: 0x20
	private readonly Plane[] _frustumPlanes; //Field offset: 0x30
	private readonly float _voxelSize; //Field offset: 0x38
	private readonly ParticleCompositeObject _compositeObject; //Field offset: 0x40
	private readonly ParticleCameraRegistry _cameraRegistry; //Field offset: 0x48
	private readonly ParticleCommandBuilder _commandBuilder; //Field offset: 0x50
	private readonly GpuParticleBatchBuilder _particleBatchBuilder; //Field offset: 0x58
	private readonly EnvironmentStencilCache _environmentStencilCache; //Field offset: 0x60
	private Bounds _localBounds; //Field offset: 0x68
	private bool _hasLocalBounds; //Field offset: 0x80
	private bool _isDisposed; //Field offset: 0x81
	private float _totalAlpha; //Field offset: 0x84
	private float _fadeoutStartTime; //Field offset: 0x88
	private bool _fadeoutStarted; //Field offset: 0x8C
	[CompilerGenerated]
	private bool <FadeoutComplete>k__BackingField; //Field offset: 0x8D

	public override float DistanceToCamera
	{
		 get { } //Length: 698
	}

	public private override bool FadeoutComplete
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public IndirectParticlesRenderer(IndirectParticlesProfile profile, Vector3 origin, float voxelSize) { }

	[CompilerGenerated]
	private float <.ctor>b__22_0() { }

	private void AppendParticleBatch(IReadOnlyList source, int fromIndex, int count) { }

	private void AppendParticles(IndirectParticleBatch batch) { }

	public override void AppendVoxels(IReadOnlyList particles, int fromIndex, int count) { }

	private bool CanRenderSmoke() { }

	public override void Dispose() { }

	private void EncapsulateBounds(Bounds appendBounds) { }

	public override float get_DistanceToCamera() { }

	[CompilerGenerated]
	public override bool get_FadeoutComplete() { }

	private float GetEnvironmentCacheCellSize() { }

	private Bounds GetWorldBounds() { }

	private void HideSmoke() { }

	private bool IsVisibleFromCamera(Camera camera) { }

	private void ResetBounds() { }

	private void ResetSmokeData() { }

	[CompilerGenerated]
	private void set_FadeoutComplete(bool value) { }

	public override void StartFadeout() { }

	private bool TryGetAppendCount(IReadOnlyList source, int fromIndex, int requestedCount, out int countToAdd) { }

	public override void Update() { }

	private bool UpdateCamera(ParticleCameraContext context, ParticleRenderData data) { }

	private void UpdateFadeout() { }

}

