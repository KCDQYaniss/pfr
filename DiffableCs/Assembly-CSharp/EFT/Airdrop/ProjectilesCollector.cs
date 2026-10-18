namespace EFT.Airdrop;

public class ProjectilesCollector : IDisposable
{
	private Dictionary _activeProjectiles; //Field offset: 0x10
	private List _projectilesToDestroy; //Field offset: 0x18

	public ProjectilesCollector() { }

	public void AddProjectile(GameObject projectile, float expiredTime) { }

	public override void Dispose() { }

	public void ManualUpdate(float deltaTime) { }

}

