namespace EFT;

public class ForceMuteVoIPToggler : MonoBehaviour
{
	[SerializeField]
	private BaseEventFilter _disableVoipEventFilter; //Field offset: 0x20
	[SerializeField]
	private BaseEventFilter _enableVoipEventFilter; //Field offset: 0x28

	public ForceMuteVoIPToggler() { }

	private void Awake() { }

	private void DisableVoIP(BaseEventFilter filter, BaseEvent passedEvent) { }

	private void EnableVoIP(BaseEventFilter filter, BaseEvent passedEvent) { }

	private void OnDestroy() { }

}

