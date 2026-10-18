namespace EFT.Game.Spawning;

public interface ISpawnPointCollider
{

	public bool Contains(Vector3 point) { }

	public string DebugInfo() { }

}

