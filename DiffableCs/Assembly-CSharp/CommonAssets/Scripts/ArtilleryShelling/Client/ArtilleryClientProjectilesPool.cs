namespace CommonAssets.Scripts.ArtilleryShelling.Client;

public class ArtilleryClientProjectilesPool
{
	private const string PROJECTILE_PREFAB_PATH = "weapon_mine_om_82mm_template"; //Field offset: 0x0
	private ObjectPool _artilleryProjectilePool; //Field offset: 0x10
	private Object _artilleryProjectileObject; //Field offset: 0x18
	private ArtilleryShellingGlobalSettings _artilleryShellingSettings; //Field offset: 0x20

	public ArtilleryClientProjectilesPool() { }

	private ArtilleryProjectileClient CreateNewPoolElement() { }

	public ArtilleryProjectileClient GetProjectile() { }

	public void InitPool(int capacity, ArtilleryShellingGlobalSettings artilleryShellingSettings) { }

	public void ReturnProjectile(ArtilleryProjectileClient projectile) { }

}

