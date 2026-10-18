namespace Audio.AmbientSubsystem;

public class WindAmbientBlender : MonoBehaviour, ISoundBlender, IDisposable, ISeasonDependent
{
	private const float MIN_WIND_SQR_MAGNITUDE_DELTA = 0.05; //Field offset: 0x0
	private const float MIN_WIND_MAGNITUDE = 0.1; //Field offset: 0x0
	private const float MAX_WIND_MAGNITUDE = 1; //Field offset: 0x0
	private const float MIN_WIND_VOLUME = 0.2; //Field offset: 0x0
	private const float MAX_WIND_VOLUME = 1; //Field offset: 0x0
	[SerializeField]
	private AudioSource _windSource; //Field offset: 0x20
	[SerializeField]
	private AudioSource _windMixSource; //Field offset: 0x28
	[SerializeField]
	private AudioMixerGroup _outputMixerGroup; //Field offset: 0x30
	[SerializeField]
	private float _defaultBlendSpeed; //Field offset: 0x38
	[SerializeField]
	private float _crossfadeDuration; //Field offset: 0x3C
	private float _globalsVolumeMult; //Field offset: 0x40
	private SeasonAmbientSoundDataSO _ambientSoundData; //Field offset: 0x48
	private IAudioCrossfader _crossfader; //Field offset: 0x50
	private EnvironmentType _environment; //Field offset: 0x58
	private EnvironmentType _prevEnvironment; //Field offset: 0x5C
	private float _currentWindSqrMagnitude; //Field offset: 0x60
	private float _prevWindSqrMagnitude; //Field offset: 0x64
	private SeasonAmbientSettings _ambientSettings; //Field offset: 0x68
	private Action _unsubscribeOnDestroy; //Field offset: 0x70

	private static Vector2 Wind
	{
		private get { } //Length: 232
	}

	public WindAmbientBlender() { }

	public override void Dispose() { }

	private static Vector2 get_Wind() { }

	private float GetWindClampedMagnitude() { }

	private EWindSpeed GetWindSpeed() { }

	private float GetWindSqrMagnitude() { }

	private float GetWindVolume() { }

	public override void Init() { }

	private bool IsWindMagnitudeChanged() { }

	public override void ManualUpdate(float dt) { }

	private void OnDestroy() { }

	private void OnPlayerRoomChanged(MyPlayerRoomChangedEvent roomChangedEvent) { }

	private void SetClip() { }

	public override void SetSeasonStatus(ESeasonStatus targetSeasonStatus) { }

	private bool TryGetClip(out AudioClip clip) { }

	private bool UpdateCrossfader(bool force = false) { }

	private void UpdateCurrentVolumeMultiplier() { }

	private void UpdateWindSound(bool force = false) { }

}

