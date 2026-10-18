namespace CommonAssets.Scripts.ArtilleryShelling;

public class ArtilleryServerProjectilesPool
{
	private List _poolItems; //Field offset: 0x10
	private ArtilleryShellingGlobalSettings _artilleryShellingSettings; //Field offset: 0x18

	public ArtilleryServerProjectilesPool() { }

	private void CreateNewPoolElement() { }

	public ArtilleryProjectileServer GetProjectile() { }

	public void InitPool(int capacity, ArtilleryShellingGlobalSettings artilleryShellingSettings) { }

	public void ReturnProjectile(ArtilleryProjectileServer projectile) { }

}

