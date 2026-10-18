//Type is in global namespace

public class BetterCamController : MonoBehaviour
{
	private float _max; //Field offset: 0x20
	private Player _player; //Field offset: 0x28
	private PlayerCameraController _playerCameraController; //Field offset: 0x30

	public BetterCamController() { }

	public void Init(Player player, PlayerCameraController playerCameraController) { }

	private void LateUpdate() { }

}

