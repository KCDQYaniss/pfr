namespace Audio.AmbientSubsystem;

[RequireComponent(typeof(AudioSource))]
public class HandlerEnvironmentAudioSource : MonoBehaviour
{
	[SerializeField]
	private AudioMixerGroup _indoorMixerGroup; //Field offset: 0x20
	[SerializeField]
	private AudioMixerGroup _outdoorMixerGroup; //Field offset: 0x28
	[SerializeField]
	private bool _useIndoorOcclusion; //Field offset: 0x30
	private AudioSource _audioSource; //Field offset: 0x38
	private BetterSource _betterSourceWrapper; //Field offset: 0x40
	private Action _unsubOnDestroy; //Field offset: 0x48

	public HandlerEnvironmentAudioSource() { }

	private void Awake() { }

	private void Init() { }

	private void OnDestroy() { }

	private void SpatialAudioSystemInitHandler(SpatialAudioSystemInitializedEvent initializedEvent) { }

}

