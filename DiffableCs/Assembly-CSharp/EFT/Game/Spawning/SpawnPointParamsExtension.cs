namespace EFT.Game.Spawning;

[Extension]
public static class SpawnPointParamsExtension
{

	[Extension]
	public static Collider AddSpawnCollider(GameObject go, ISpawnColliderParams spawnColliderParams) { }

	[Extension]
	public static ISpawnColliderParams GetSpawnColliderParams(GameObject go) { }

	[Extension]
	public static void TryAddNavMeshModifier(GameObject go) { }

	[Extension]
	public static Collider TryAddSpawnCollider(GameObject go, ISpawnColliderParams spawnColliderParams) { }

	[Extension]
	public static SpawnPointMarker TryAddSpawnPointMarker(GameObject go, SpawnPointParams params) { }

}

