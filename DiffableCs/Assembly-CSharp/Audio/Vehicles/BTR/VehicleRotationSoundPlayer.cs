namespace Audio.Vehicles.BTR;

public class VehicleRotationSoundPlayer : MonoBehaviour, IVolumeControl, IRotationTracker, IDisposable
{
	[SerializeField]
	private float _rotationPlaySoundCooldown; //Field offset: 0x20
	[SerializeField]
	private float _rotationChangeThreshold; //Field offset: 0x24
	[SerializeField]
	private float _maxDistance; //Field offset: 0x28
	[SerializeField]
	private AudioClip _startClip; //Field offset: 0x30
	[SerializeField]
	private AudioClip _loopClip; //Field offset: 0x38
	[SerializeField]
	private AudioClip _endClip; //Field offset: 0x40
	[SerializeField]
	private float _volumeMult; //Field offset: 0x48
	[SerializeField]
	private AudioMixerGroup _output; //Field offset: 0x50
	private float _prevRotationAngle; //Field offset: 0x58
	private float _currentRotationAngle; //Field offset: 0x5C
	private float _nextPlayingTime; //Field offset: 0x60
	private float _baseVolume; //Field offset: 0x64
	private bool _isPlaying; //Field offset: 0x68
	private BetterSource _source; //Field offset: 0x70
	private bool _initialized; //Field offset: 0x78

	private float BaseVolumeWithMult
	{
		private get { } //Length: 11
	}

	public VehicleRotationSoundPlayer() { }

	public void Awake() { }

	private bool CanPlayRotationSound() { }

	public void CheckRotation() { }

	public override void Dispose() { }

	private float get_BaseVolumeWithMult() { }

	private void PlaySound() { }

	private bool RotationHasChanged() { }

	public override void SetBaseVolume(float volume) { }

	private void SetupSource() { }

	public void Start() { }

	private void StopSound() { }

	private void UpdateNextPlayingTime(float clipLength) { }

	public override void UpdateRotation(float rotationAngle) { }

}

