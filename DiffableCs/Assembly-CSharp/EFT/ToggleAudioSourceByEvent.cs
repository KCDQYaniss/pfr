namespace EFT;

public class ToggleAudioSourceByEvent : MonoBehaviour
{
	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0x20
	[SerializeField]
	private BaseEventFilter _enableAudioByFilter; //Field offset: 0x28
	[SerializeField]
	private BaseEventFilter _disableAudioByFilter; //Field offset: 0x30

	public ToggleAudioSourceByEvent() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnNeedToDisable(BaseEventFilter eventFilter, BaseEvent invokedEvent) { }

	private void OnNeedToEnable(BaseEventFilter eventFilter, BaseEvent invokedEvent) { }

}

