namespace Audio.Vehicles;

public class BtrTurretSoundPlayerController : MonoBehaviour
{
	[SerializeField]
	private Transform _turretTransform; //Field offset: 0x20
	[SerializeField]
	private VehicleRotationSoundPlayer[] _turretHorizontalRotationPlayers; //Field offset: 0x28
	private bool _initialized; //Field offset: 0x30

	public BtrTurretSoundPlayerController() { }

	public void Awake() { }

	private void Update() { }

}

