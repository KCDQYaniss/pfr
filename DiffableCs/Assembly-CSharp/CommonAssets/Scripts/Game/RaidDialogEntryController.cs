namespace CommonAssets.Scripts.Game;

public sealed class RaidDialogEntryController : IDisposable
{
	private readonly Dictionary _occupantByPointId; //Field offset: 0x10
	[CompilerGenerated]
	private Action PointOccupancyChanged; //Field offset: 0x18

	public event Action PointOccupancyChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public static RaidDialogEntryController Instance
	{
		 get { } //Length: 61
	}

	public RaidDialogEntryController() { }

	[CompilerGenerated]
	public void add_PointOccupancyChanged(Action value) { }

	public void ApplyFullReconnectState(IReadOnlyList entries) { }

	public void ApplyOccupancyState(string pointId, int occupantRaidID) { }

	public override void Dispose() { }

	public static RaidDialogEntryController get_Instance() { }

	public void InitAllEntryPointsOnLocation(IEnumerable traders) { }

	public bool IsOccupiedByOther(string pointId, int myPlayerRaidID) { }

	public void ReleaseOffline(string pointId, int raidID) { }

	[CompilerGenerated]
	public void remove_PointOccupancyChanged(Action value) { }

	public bool TryClaimOffline(string pointId, int raidID) { }

}

