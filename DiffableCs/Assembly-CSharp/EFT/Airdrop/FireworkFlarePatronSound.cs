namespace EFT.Airdrop;

public class FireworkFlarePatronSound : FlarePatronSound
{
	[SerializeField]
	private SoundBank _fireworkShotBank; //Field offset: 0x38
	[SerializeField]
	private SoundBank _fireworkLaunchBank; //Field offset: 0x40
	[SerializeField]
	private float _shotPlayingDelay; //Field offset: 0x48
	private float _timeToPlayShot; //Field offset: 0x4C
	private bool _isSoundPlaying; //Field offset: 0x50

	public FireworkFlarePatronSound() { }

	public virtual void Init(float lifetime) { }

	private void OnDisable() { }

	private void PlayLaunchSound() { }

	private void PlayShotSound() { }

	private void PlaySound(Vector3 position, SoundBank soundBank, bool isDistant) { }

	protected virtual void Update() { }

}

