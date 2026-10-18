namespace Audio.SpatialSystem;

public sealed class PropagationVolumesManager : Singleton
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__24_0; //Field offset: 0x8
		public static Func <>9__24_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <LogMissingColliderInVolume>b__24_0(BetterPropagationVolume x) { }

		internal string <LogMissingColliderInVolume>b__24_1(BetterPropagationVolume x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Vector3 firstPos; //Field offset: 0x10
		public Vector3 secondPos; //Field offset: 0x1C

		public <>c__DisplayClass15_0() { }

		internal bool <IsPositionsInDifferentVolume>b__0(BetterPropagationVolume volume) { }

	}

	private static bool _loggedCollider; //Field offset: 0x0
	private readonly List _volumes; //Field offset: 0x10
	private readonly List _isolatedVolumes; //Field offset: 0x18
	private readonly List _volumesBuffer; //Field offset: 0x20
	private readonly List _volumesExtraBuffer; //Field offset: 0x28
	private readonly List _playerRooms; //Field offset: 0x30
	private BetterPropagationGroups _propagationTree; //Field offset: 0x38

	public PropagationVolumesManager() { }

	public void AddPlayerCurrentPropagationVolume(BetterPropagationVolume volume) { }

	public List GetAdjustedAndIsolatedVolumes(Vector3 position, List volumesBuffer) { }

	public List GetIsolatedVolumes() { }

	[CanBeNull]
	public BetterPropagationVolume GetPlayerCurrentPropagationVolume() { }

	[CanBeNull]
	public BetterPropagationVolume GetVolumeByPosition(Vector3 position) { }

	public List GetVolumesByPosition(Vector3 position) { }

	public bool IsPlayerAndSourceInSameVolume(Vector3 sourcePos) { }

	public bool IsPlayersInDifferentVolumes(Player listenerPlayer, Player sourcePlayer) { }

	public bool IsPositionsInDifferentVolume(Vector3 firstPos, Vector3 secondPos) { }

	private bool IsVolumesDifferent(List listenerVolumes, List sourceVolumes) { }

	private void LogMissingColliderInVolume(string errorCaption, BetterPropagationVolume vol, Vector3 position) { }

	public void RegisterGroup(BetterPropagationGroups group) { }

	public void RegisterVolume(BetterPropagationVolume volume) { }

	public void RemovePlayerCurrentVolume(BetterPropagationVolume volume) { }

	public void RemoveVolume(BetterPropagationVolume volume) { }

	private void ValidateIsolatedPropagationVolumes(Vector3 position, List volumesBuffer) { }

	private void ValidatePropagationVolumes(Vector3 position, List volumesBuffer) { }

	private void ValidatePropagationVolumesConnections(Vector3 position, BetterPropagationVolume propagationVolume) { }

}

