//Type is in global namespace

public class ArtilleryDangerPlace : BotData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ActivateDangerPlace>b__20_0(CustomNavigationPoint coverPoint) { }

	}

	public bool WasInGoodCover; //Field offset: 0x18
	public bool NeedLay; //Field offset: 0x19
	public Dictionary ActiveZonesSpottedCovers; //Field offset: 0x20
	private float _nextActivationTime; //Field offset: 0x28
	private float _lastCheckTime; //Field offset: 0x2C
	private readonly List _zonesToRemove; //Field offset: 0x30
	private float _maxActiveZoneRadius; //Field offset: 0x38
	public bool _NoReactionToArtillery; //Field offset: 0x3C

	public bool IsActive
	{
		 get { } //Length: 71
	}

	public float MaxDangerRadius
	{
		 get { } //Length: 6
	}

	public ArtilleryDangerPlace(BotOwner owner) { }

	private void ActivateDangerPlace(string zoneId, ShellingZoneBotData zoneData) { }

	public void Dispose() { }

	public bool get_IsActive() { }

	public float get_MaxDangerRadius() { }

	public Vector3 GetAveragePositionOfAllZonesCenters() { }

	public ValueTuple GetClosestZone() { }

	public void ManualUpdate() { }

	public void OnArtilleryEnd(string zoneId) { }

	private void RemoveActiveZonesIfNeeded() { }

	public bool ShallEnd() { }

	public bool ShallRunAway() { }

	private void TryActivate() { }

	private void UpdateMaxDangerRadius() { }

	private void UpdateSpottedCovers() { }

}

