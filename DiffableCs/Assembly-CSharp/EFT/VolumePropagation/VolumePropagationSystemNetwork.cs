namespace EFT.VolumePropagation;

public sealed class VolumePropagationSystemNetwork : IVolumePropagationSystem, IDisposable
{
	private sealed class ClientVolumeSource : IVolumePropagationSourceReadOnly
	{
		private readonly List _renderable; //Field offset: 0x10
		private readonly IVolumePropagationSettings _settings; //Field offset: 0x18
		private readonly float _unitSize; //Field offset: 0x20
		private float _currentReachRadius; //Field offset: 0x24
		[CompilerGenerated]
		private readonly int <SourceId>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private readonly Vector3 <Position>k__BackingField; //Field offset: 0x2C
		[CompilerGenerated]
		private readonly byte <PresetId>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private readonly float <StartRemoteTime>k__BackingField; //Field offset: 0x3C

		public override float CurrentReachRadius
		{
			 get { } //Length: 6
		}

		public override bool IsAlive
		{
			 get { } //Length: 3
		}

		public override float Lifetime
		{
			 get { } //Length: 4
		}

		public override Vector3 Position
		{
			[CompilerGenerated]
			 get { } //Length: 19
		}

		public override byte PresetId
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override IReadOnlyList RenderableVoxels
		{
			 get { } //Length: 5
		}

		public override IVolumePropagationSettings Settings
		{
			 get { } //Length: 5
		}

		public override int SourceId
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public float StartRemoteTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
		}

		public ClientVolumeSource(int sourceId, Vector3 position, byte presetId, IVolumeSourceSettings settings) { }

		public int AppendVoxels(IReadOnlyList voxels, int fromIndex, int count) { }

		public override float get_CurrentReachRadius() { }

		public override bool get_IsAlive() { }

		public override float get_Lifetime() { }

		[CompilerGenerated]
		public override Vector3 get_Position() { }

		[CompilerGenerated]
		public override byte get_PresetId() { }

		public override IReadOnlyList get_RenderableVoxels() { }

		public override IVolumePropagationSettings get_Settings() { }

		[CompilerGenerated]
		public override int get_SourceId() { }

		[CompilerGenerated]
		public float get_StartRemoteTime() { }

		public override bool IsFilled(int x, int y, int z) { }

		private void UpdateReachRadius(VoxelUnit v) { }

	}

	private readonly Dictionary _sources; //Field offset: 0x10
	private readonly Dictionary _renderers; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnCollisionTick; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnSourceExpired; //Field offset: 0x28
	private List _renderersToRemove; //Field offset: 0x30

	public override event Action OnCollisionTick
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnSourceExpired
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override int ActiveSourceCount
	{
		 get { } //Length: 68
	}

	public override IEnumerable ActiveSources
	{
		 get { } //Length: 73
	}

	public VolumePropagationSystemNetwork() { }

	[CompilerGenerated]
	public override void add_OnCollisionTick(Action value) { }

	[CompilerGenerated]
	public override void add_OnSourceExpired(Action value) { }

	private void AppendToRenderer(int sourceId, ClientVolumeSource view, int fromIndex, int count) { }

	public override void ApplyDelta(VolumetricSystemSourceDeltaPacket packet) { }

	public override void ApplyInitialState(VolumeInitialStateMessage message) { }

	public override void ApplyRemove(VolumetricSystemSourceRemovePacket packet) { }

	public override void ApplySpawn(VolumetricSystemSourceSpawnPacket packet) { }

	public override bool Contains(int sourceId) { }

	private void CreateOrReplaceSource(int sourceId, Vector3 position, byte presetId) { }

	public override void Dispose() { }

	private void DropFadeoutRenderers() { }

	private void DropSource(int sourceId) { }

	public override void EnumerateSnapshot(List destination) { }

	public override void FreezeSource(int sourceId) { }

	public override int get_ActiveSourceCount() { }

	public override IEnumerable get_ActiveSources() { }

	public override int RegisterSource(IVolumeSourceSettings sourceSettings, Vector3 position) { }

	[CompilerGenerated]
	public override void remove_OnCollisionTick(Action value) { }

	[CompilerGenerated]
	public override void remove_OnSourceExpired(Action value) { }

	public override void RemoveSource(int sourceId) { }

	public override void Tick(float dt) { }

	public override bool TryGetSource(int sourceId, out IVolumePropagationSourceReadOnly source) { }

	private void UpdateRenderers() { }

}

