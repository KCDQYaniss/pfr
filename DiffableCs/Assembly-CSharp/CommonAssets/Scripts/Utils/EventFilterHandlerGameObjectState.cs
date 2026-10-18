namespace CommonAssets.Scripts.Utils;

public class EventFilterHandlerGameObjectState : MonoBehaviour
{
	[SerializeField]
	private GameObject _gameObject; //Field offset: 0x20
	[SerializeField]
	private bool _targetState; //Field offset: 0x28
	[SerializeField]
	private BaseEventFilter _filterToReact; //Field offset: 0x30

	public EventFilterHandlerGameObjectState() { }

	private void Awake() { }

	private void FilterPassedHandler(BaseEventFilter eventFilter, BaseEvent eventToReact) { }

	private void OnDestroy() { }

}

