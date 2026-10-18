namespace EFT.RocketLauncher.Explosion;

public class RocketSoundPlayer
{
	private RocketSettings _rocketSettings; //Field offset: 0x10
	private BetterSource _explosionSource; //Field offset: 0x18
	private Transform _ownerTransform; //Field offset: 0x20

	public RocketSoundPlayer() { }

	public void Initialize(RocketSettings rocketSettings, Transform ownerTransform) { }

	public void PlayExplosionSound(Vector3 position) { }

	public void Release() { }

	private void ReleaseSource(ref BetterSource source) { }

}

