namespace EFT.Ballistics;

public interface IBallisticsCalculator
{

	public int ActiveShotsCount
	{
		 get { } //Length: 0
	}

	public BallisticCollider DefaultHitBody
	{
		 get { } //Length: 0
	}

	public void ClearShots() { }

	public int get_ActiveShotsCount() { }

	public BallisticCollider get_DefaultHitBody() { }

	public Shot GetActiveShot(int shotsIndex) { }

	public void ManualUpdate(float deltaTime) { }

	public Shot Shoot(Ammo ammo, Vector3 shotPosition, Vector3 shotDirection, Vector3 abc, int playerRaidId, Item item, float speedFactor, int fragmentIndex) { }

	public Shot Shoot(Ammo ammo, Vector3 shotPosition, Vector3 shotDirection, int fireIndex, int playerRaidId, Item item, float speedFactor, int fragmentIndex) { }

	public Shot Shoot(Ammo ammo, Vector3 shotPosition, Vector3 shotDirection, int playerRaidId, Item item, float speedFactor, int fragmentIndex, Transform ammoPrefab, bool needReturnToPool) { }

	public void ShotMultiProjectileShot(Ammo ammo, Vector3 shotPosition, Vector3 shotDirection, float speedFactor, List preAllocatedShots, Vector3 abc, int playerRaidId, Item item) { }

}

