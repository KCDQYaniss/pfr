namespace EFT.Game.Spawning;

public interface ISpawnPointsCollection : IReadOnlyCollection, IEnumerable, IEnumerable
{

	public ISpawnPoint CreateSpawnPoint(SpawnPointParams params) { }

	public void DestroySpawnPoint(ISpawnPoint spawnPoint) { }

	public bool TryGetSpawnPointById(string id, out ISpawnPoint spawnPoint) { }

	public void Validate() { }

}

