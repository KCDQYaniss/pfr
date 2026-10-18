namespace EFT.NPC;

public class AnimatorByEventsToggler : MonoBehaviour
{
	[SerializeField]
	private Animator _targetAnimator; //Field offset: 0x20
	[SerializeField]
	private string _triggerOnToggleOn; //Field offset: 0x28
	[SerializeField]
	private BaseEventFilter toggleOnEvent; //Field offset: 0x30
	[SerializeField]
	private BaseEventFilter toggleOffEvent; //Field offset: 0x38

	public AnimatorByEventsToggler() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnToggleOffEvent(BaseEventFilter filter, BaseEvent invokedEvent) { }

	private void OnToggleOnEvent(BaseEventFilter filter, BaseEvent invokedEvent) { }

	private void ToggleAnimator(bool toggle) { }

}

