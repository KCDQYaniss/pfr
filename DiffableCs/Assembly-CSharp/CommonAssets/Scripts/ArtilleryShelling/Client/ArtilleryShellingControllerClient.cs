namespace CommonAssets.Scripts.ArtilleryShelling.Client;

public class ArtilleryShellingControllerClient : IDisposable
{
	private ArtilleryAlarmLogic _artilleryAlarmLogic; //Field offset: 0x10
	private ArtilleryShellingGlobalSettings _artilleryShellingGlobalsSettings; //Field offset: 0x18
	private ArtilleryShellingMapConfiguration _currentMapConfiguration; //Field offset: 0x20
	private ArtilleryClientProjectilesPool _clientProjectilesPool; //Field offset: 0x60
	public Dictionary ActiveClientProjectiles; //Field offset: 0x68
	private GameWorld _gameWorld; //Field offset: 0x70
	private PlayerLoopSystem _playerLoopSystem; //Field offset: 0x78
	private bool _hasAuthority; //Field offset: 0xA0
	private ArtilleryShellingSoundControllerClient _soundController; //Field offset: 0xA8

	public ArtilleryShellingMapConfiguration CurrentMapConfiguration
	{
		 get { } //Length: 35
	}

	public ArtilleryShellingControllerClient(bool hasAuthority) { }

	public ArtilleryProjectileClient CreateActiveProjectile(int id, Vector3 startPosition = null) { }

	public override void Dispose() { }

	public ArtilleryShellingMapConfiguration get_CurrentMapConfiguration() { }

	private void Init() { }

	private void OnExplosionEvent(ArtilleryProjectileClient projectile) { }

	private void OnLateUpdate(float deltaTime) { }

	public void SyncProjectilesStates(ref List packets) { }

}

