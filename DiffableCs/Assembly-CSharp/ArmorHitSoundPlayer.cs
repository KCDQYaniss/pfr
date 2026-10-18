//Type is in global namespace

public class ArmorHitSoundPlayer : BulletSoundPlayer
{
	[SerializeField]
	private AudioClip[] _fpSounds; //Field offset: 0x20
	[SerializeField]
	private SoundBank _closeDistandeSound; //Field offset: 0x28
	private PlayerCameraController _playerCameraController; //Field offset: 0x30

	public ArmorHitSoundPlayer() { }

	private void ArmorHit(IPlayer player, IPlayer enemy, Vector3 directionFromPlayer) { }

	public virtual void Init(Camera camera, PlayerCameraController playerCameraController) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void PlayCloseDistandSound(IPlayer player) { }

	private void PlayFPSound(Vector3 forward, Vector3 normal) { }

	private void Start() { }

}

