namespace EFT.VolumePropagation;

public sealed class VolumePropagationSource : IVolumePropagationSourceReadOnly
{
	private const float DOOR_PROBE_RADIUS_FACTOR = 1.8; //Field offset: 0x0
	private readonly VolumeCollisionHandler _collisionHandler; //Field offset: 0x10
	private readonly DoorVoxelTracker _doorTracker; //Field offset: 0x18
	private readonly WindowBreakerTracker _windowTracker; //Field offset: 0x20
	private readonly ChunkedGrid _grid; //Field offset: 0x28
	private readonly float _unitSize; //Field offset: 0x30
	private readonly float _maxRadius; //Field offset: 0x34
	private readonly float _lifetime; //Field offset: 0x38
	private readonly float _growTime; //Field offset: 0x3C
	private readonly int _theoreticalMaxUnits; //Field offset: 0x40
	private readonly byte[] _directionOrder; //Field offset: 0x48
	private readonly int _renderStride; //Field offset: 0x50
	private readonly List _frontier; //Field offset: 0x58
	private readonly List _all; //Field offset: 0x60
	private readonly List _renderable; //Field offset: 0x68
	private readonly Queue _bfsQueue; //Field offset: 0x70
	private readonly HashSet _bfsVisited; //Field offset: 0x78
	private float _elapsed; //Field offset: 0x80
	private float _accumulatedCollisionEventTime; //Field offset: 0x84
	private float _currentReachRadius; //Field offset: 0x88
	private bool _hasNewVoxelsSinceLastEvent; //Field offset: 0x8C
	private bool _trackersDisposed; //Field offset: 0x8D
	private bool _frozen; //Field offset: 0x8E
	private int _currentFrontierIdx; //Field offset: 0x90
	private int _renderStrideCounter; //Field offset: 0x94
	[CompilerGenerated]
	private int <NetBroadcastCursor>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private readonly int <SourceId>k__BackingField; //Field offset: 0x9C
	[CompilerGenerated]
	private readonly Vector3 <Position>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private readonly IVolumePropagationSettings <Settings>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private readonly byte <PresetId>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private readonly float <StartRemoteTime>k__BackingField; //Field offset: 0xBC

	public float AccumulatedCollisionEventTime
	{
		 get { } //Length: 9
	}

	public override float CurrentReachRadius
	{
		 get { } //Length: 9
	}

	public IReadOnlyDictionary DoorMasks
	{
		 get { } //Length: 27
	}

	public DoorVoxelTracker DoorTracker
	{
		 get { } //Length: 5
	}

	public override bool IsAlive
	{
		 get { } //Length: 16
	}

	public bool IsVolumeExhausted
	{
		 get { } //Length: 71
	}

	public override float Lifetime
	{
		 get { } //Length: 9
	}

	public int NetBroadcastCursor
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override Vector3 Position
	{
		[CompilerGenerated]
		 get { } //Length: 25
	}

	public override byte PresetId
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override IReadOnlyList RenderableVoxels
	{
		 get { } //Length: 5
	}

	public override IVolumePropagationSettings Settings
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override int SourceId
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public float StartRemoteTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public IReadOnlyDictionary WindowMasks
	{
		 get { } //Length: 27
	}

	public VolumePropagationSource(int sourceId, Vector3 position, IVolumeSourceSettings sourceSettings, VolumeCollisionHandler collisionHandler, float startRemoteTime) { }

	public void AdvanceTime(float dt) { }

	private void AppendToAll(VoxelUnit voxel) { }

	private bool CheckAbilityToExpand(VoxelUnit parent, float weight, out int expandDirIdx) { }

	private void ClearFrontier() { }

	private float ComputeWeight() { }

	public bool ConsumeRenderFlag() { }

	public void Dispose() { }

	private void DisposeTrackersIfNeeded() { }

	private bool ExpandOneFromParent(VoxelUnit parent, float weight, ref int budget) { }

	public int ExpectedCostThisFrame(float dt) { }

	public void FormFirstGeneration() { }

	public void FreezePropagation() { }

	public float get_AccumulatedCollisionEventTime() { }

	public override float get_CurrentReachRadius() { }

	public IReadOnlyDictionary get_DoorMasks() { }

	public DoorVoxelTracker get_DoorTracker() { }

	public override bool get_IsAlive() { }

	public bool get_IsVolumeExhausted() { }

	public override float get_Lifetime() { }

	[CompilerGenerated]
	public int get_NetBroadcastCursor() { }

	[CompilerGenerated]
	public override Vector3 get_Position() { }

	[CompilerGenerated]
	public override byte get_PresetId() { }

	public override IReadOnlyList get_RenderableVoxels() { }

	[CompilerGenerated]
	public override IVolumePropagationSettings get_Settings() { }

	[CompilerGenerated]
	public override int get_SourceId() { }

	[CompilerGenerated]
	public float get_StartRemoteTime() { }

	public IReadOnlyDictionary get_WindowMasks() { }

	private void HandleDoorClosed(Door door) { }

	private void HandleDoorOpened(Door door) { }

	private void HandleWindowBroken(WindowBreaker window) { }

	public override bool IsFilled(int x, int y, int z) { }

	private void ProcessTrackerEvents() { }

	public int Propagate(int budget, float dt) { }

	private void PushToFrontier(int x, int y, int z) { }

	private void ReconcileFrontierWithEpicenter() { }

	private void RemoveFromFrontierByPos(int x, int y, int z) { }

	public void ResetCollisionAccumulator() { }

	[CompilerGenerated]
	public void set_NetBroadcastCursor(int value) { }

	private void TryProbeDoorsForFrontierPass() { }

	private void UpdateReachRadius(int x, int y, int z) { }

}

