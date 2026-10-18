namespace EFT;

public class MuteSpeechToggler : MonoBehaviour
{
	[SerializeField]
	private BaseEventFilter _muteSpeechEventFilter; //Field offset: 0x20
	[SerializeField]
	private BaseEventFilter _unmuteSpeechEventFilter; //Field offset: 0x28

	public MuteSpeechToggler() { }

	private void Awake() { }

	private void MuteSpeech(BaseEventFilter filter, BaseEvent passedEvent) { }

	private void UnmuteSpeech(BaseEventFilter filter, BaseEvent passedEvent) { }

}

