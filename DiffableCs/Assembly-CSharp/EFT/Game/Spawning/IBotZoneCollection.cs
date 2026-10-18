namespace EFT.Game.Spawning;

public interface IBotZoneCollection
{

	[NotNull]
	public ISpawnPoint[] AllZonesSpawnPoints(bool canBeSnipe = false) { }

	[CanBeNull]
	public Nullable GetBossPosition(BotZone zone, Nullable closestBossPos = null) { }

	[NotNull]
	public IEnumerable ZoneNames(bool canBeSnipe = false) { }

	[NotNull]
	public ISpawnPoint[] ZoneSpawnPoints(string zoneName) { }

}

