namespace Audio.Vehicles;

public class SoundSuspensionController : MonoBehaviour, ISoundSuspensionController
{
	private const float FORCE_MAGNITUDE_DIVIDER = 10000; //Field offset: 0x0
	[SerializeField]
	private float _volumeMult; //Field offset: 0x20
	[SerializeField]
	private float _playingTimeThreshold; //Field offset: 0x24
	[SerializeField]
	private SoundSuspensionImpactSoundPlayer[] _impactSoundPlayers; //Field offset: 0x28
	[SerializeField]
	private VehicleMovementSoundContainer _indoorSoundContainer; //Field offset: 0x30
	[SerializeField]
	private VehicleMovementSoundContainer _outdoorSoundContainer; //Field offset: 0x38
	[SerializeField]
	private Vector2 _randomPitchRange; //Field offset: 0x40
	private EnvironmentType _currentEnvironment; //Field offset: 0x48
	private AudioMixerGroup _currentMixerGroup; //Field offset: 0x50

	public override float PlayingTimeThresholdSeconds
	{
		 get { } //Length: 6
	}

	public SoundSuspensionController() { }

	public void Awake() { }

	public override float CalculateVolume(float forceMagnitude) { }

	public override float get_PlayingTimeThresholdSeconds() { }

	public override AudioClip GetImpactClip() { }

	private AudioMixerGroup GetMixerByEnvironment() { }

	public override float GetRandomPitch() { }

	public override bool IsOutOfRange(Vector3 position, int sqrRolloff) { }

	public override void SetEnvironment(EnvironmentType environment) { }

	public void UpdateImpactPlayers() { }

}

