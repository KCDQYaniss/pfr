namespace EFT.VolumePropagation;

public sealed class VolumePropagationSystem : IVolumePropagationSystem, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__40_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <.cctor>b__55_0(VolumePropagationSource a, VolumePropagationSource b) { }

		internal int <TickRenderers>b__40_0(IVolumeRenderer r1, IVolumeRenderer r2) { }

	}

	public const int DEFAULT_FRAME_BUDGET = 256; //Field offset: 0x0
	public const float MAX_ALLOWED_RADIUS = 8; //Field offset: 0x0
	private static readonly Comparison ByLifetime; //Field offset: 0x0
	private readonly VolumeCollisionHandler _collisionHandler; //Field offset: 0x10
	private readonly PlayerCollisionProbe _playerProbe; //Field offset: 0x18
	private readonly Dictionary _activeSources; //Field offset: 0x20
	private readonly List _pendingSources; //Field offset: 0x28
	private readonly HashSet _expiredBuffer; //Field offset: 0x30
	private readonly List _workingBuffer; //Field offset: 0x38
	private readonly List _collisionTickBuffer; //Field offset: 0x40
	private readonly IVolumeNetSink _netSink; //Field offset: 0x48
	private int _nextSourceId; //Field offset: 0x50
	private readonly Dictionary _renderers; //Field offset: 0x58
	private readonly Dictionary _renderSettings; //Field offset: 0x60
	private readonly Dictionary _renderUploadedCount; //Field offset: 0x68
	private readonly List _renderersToRemove; //Field offset: 0x70
	[CompilerGenerated]
	private int <MaxFrameBudget>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnCollisionTick; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnSourceExpired; //Field offset: 0x88

	public override event Action OnCollisionTick
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action OnSourceExpired
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override int ActiveSourceCount
	{
		 get { } //Length: 68
	}

	public override IEnumerable ActiveSources
	{
		 get { } //Length: 73
	}

	public int MaxFrameBudget
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static VolumePropagationSystem() { }

	public VolumePropagationSystem(IVolumeNetSink netSink = null) { }

	[CompilerGenerated]
	public override void add_OnCollisionTick(Action value) { }

	[CompilerGenerated]
	public override void add_OnSourceExpired(Action value) { }

	public override void ApplyDelta(VolumetricSystemSourceDeltaPacket packet) { }

	public override void ApplyInitialState(VolumeInitialStateMessage message) { }

	public override void ApplyRemove(VolumetricSystemSourceRemovePacket packet) { }

	public override void ApplySpawn(VolumetricSystemSourceSpawnPacket packet) { }

	private void CleanupExpired() { }

	private void CleanupRenderer(int sourceId) { }

	private void CommitPending() { }

	public override bool Contains(int sourceId) { }

	public override void Dispose() { }

	private void DistributeBudget(float dt) { }

	private void DropFadeoutRenderers() { }

	private void EmitAllDeltas() { }

	private void EmitDeltaIfAny(VolumePropagationSource source) { }

	public override void EnumerateSnapshot(List destination) { }

	private void FireIntervalEvents() { }

	private void FlushRenderer(int sourceId, VolumePropagationSource source) { }

	public override void FreezeSource(int sourceId) { }

	public override int get_ActiveSourceCount() { }

	public override IEnumerable get_ActiveSources() { }

	[CompilerGenerated]
	public int get_MaxFrameBudget() { }

	public override int RegisterSource(IVolumeSourceSettings sourceSettings, Vector3 position) { }

	[CompilerGenerated]
	public override void remove_OnCollisionTick(Action value) { }

	[CompilerGenerated]
	public override void remove_OnSourceExpired(Action value) { }

	public override void RemoveSource(int sourceId) { }

	[CompilerGenerated]
	public void set_MaxFrameBudget(int value) { }

	private void StartRendererFadeout(int sourceId) { }

	public override void Tick(float dt) { }

	private void TickActiveSources(float dt) { }

	private void TickRenderers() { }

	public override bool TryGetSource(int sourceId, out IVolumePropagationSourceReadOnly source) { }

}

