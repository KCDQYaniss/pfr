//Type is in global namespace

public class BulletSoundPlayersController : MonoBehaviour
{
	private const int INVALID_PLAYER_ID = -1; //Field offset: 0x0
	[SerializeField]
	private List _bulletSoundPlayers; //Field offset: 0x20
	private Camera _currentCamera; //Field offset: 0x28
	private PlayerCameraController _playerCameraController; //Field offset: 0x30
	private int _spectateTargetPlayerId; //Field offset: 0x38
	private Action _unsubscribe; //Field offset: 0x40

	public BulletSoundPlayersController() { }

	private void Awake() { }

	private void CheckBallisticCalculators() { }

	public void InitCamera(PlayerCameraController playerCameraController, Camera camera) { }

	private void OnDestroy() { }

	private void OnPlayerCameraControllerCreated(PlayerCameraController playerCameraController, Camera camera) { }

	private void OnSpectateTargetChanged(LocalSpectatorTargetChangedEvent targetEvent) { }

	private void TryShot(Shot shot, Camera camera) { }

	private void Update() { }

}

