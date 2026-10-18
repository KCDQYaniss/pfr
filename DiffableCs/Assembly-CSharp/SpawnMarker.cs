//Type is in global namespace

public sealed class SpawnMarker : MonoBehaviour
{
	public ESpawnCategory Category; //Field offset: 0x20
	public EPlayerSide Side; //Field offset: 0x24
	public string GroupId; //Field offset: 0x28
	public string Infiltration; //Field offset: 0x30
	public string BotZoneName; //Field offset: 0x38
	public SpawnPointMarker SpawnPointMarker; //Field offset: 0x40

	public SpawnMarker() { }

	public static SpawnMarker Create(SpawnPointMarker spawnPointMarker, ESpawnCategory category, EPlayerSide side, string groupId, string infiltration, string botZoneName) { }

	public static SpawnMarker Create(ISpawnPoint spawnPoint, ESpawnCategory category, EPlayerSide side, string groupId, string infiltration, string botZoneName) { }

	private void OnDrawGizmos() { }

}

