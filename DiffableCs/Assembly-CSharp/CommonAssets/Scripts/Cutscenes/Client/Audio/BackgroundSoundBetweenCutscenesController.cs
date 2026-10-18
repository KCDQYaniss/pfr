namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

public class BackgroundSoundBetweenCutscenesController : MonoBehaviour
{
	[SerializeField]
	private BaseEventFilter _playSoundFilter; //Field offset: 0x20
	[SerializeField]
	private BaseEventFilter _stopSoundFilter; //Field offset: 0x28
	[SerializeField]
	private AmbientSoundPlayerGroup[] _ambientGroups; //Field offset: 0x30
	[SerializeField]
	private AmbientSplineEmitterController[] _splineEmittersControllers; //Field offset: 0x38
	[SerializeField]
	private bool _disableAfterPlay; //Field offset: 0x40

	public BackgroundSoundBetweenCutscenesController() { }

	private void Awake() { }

	private void EventFilterPlaySoundHandler(BaseEventFilter baseEventFilter, BaseEvent baseEvent) { }

	private void EventFilterStopSoundHandler(BaseEventFilter baseEventFilter, BaseEvent baseEvent) { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void Update() { }

}

