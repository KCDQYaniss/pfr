namespace EFT;

public class BotArtilleryZonesController
{
	public static readonly ShellingZoneBotData DefaultZoneData; //Field offset: 0x0
	public Dictionary ActiveZonesOnMap; //Field offset: 0x10
	private readonly BotsController _botsController; //Field offset: 0x18
	private float _settedTime; //Field offset: 0x20
	private List _zonesToRemove; //Field offset: 0x28
	private readonly string _logTag; //Field offset: 0x30

	private static BotArtilleryZonesController() { }

	public BotArtilleryZonesController(BotsController botsController) { }

	public void Activate() { }

	private void AddOrUpdateDangerZone(string zoneId, Vector3 position, float radius, float startTime = -1, float duration = -1) { }

	private void AddZoneToRemove(string zoneId) { }

	private void ArtilleryEndHandler(string zoneId, Vector3 position, float radius) { }

	private void ArtilleryStartHandler(string zoneId, Vector3 position, float radius) { }

	public void Dispose() { }

	public ShellingZoneBotData GetZoneById(string zoneId) { }

	public void ManualUpdate() { }

	private void RemoveActiveZones() { }

	private void StartWithTimerHandler(Vector3 position, float radius, float duration) { }

	public bool TryGetZoneById(string zoneId, out ShellingZoneBotData zoneData) { }

}

