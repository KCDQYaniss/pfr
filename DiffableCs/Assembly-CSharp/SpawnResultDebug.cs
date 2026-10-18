//Type is in global namespace

public class SpawnResultDebug : MonoBehaviour
{
	private ESpawnCategory _spawnCategory; //Field offset: 0x20
	private PlayerSpawnData _data; //Field offset: 0x28
	public List BotDistances; //Field offset: 0x30
	public SpawnPointMarker NearestSpawnPoint; //Field offset: 0x38
	public float NearestSpawnPointDistance; //Field offset: 0x40
	public float SpawnPointDistance; //Field offset: 0x44
	public string NearestSpawnPointInfo; //Field offset: 0x48

	public SpawnResultDebug() { }

	public void Init(PlayerSpawnData data) { }

	private void OnDrawGizmosSelected() { }

	private void OnGUI() { }

	private void UpdateBotDistances() { }

	public void UpdateDistances() { }

	public void UpdateNearestSpawnPoint() { }

}

