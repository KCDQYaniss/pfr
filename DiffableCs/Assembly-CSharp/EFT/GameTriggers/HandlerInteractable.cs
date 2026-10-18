namespace EFT.GameTriggers;

public class HandlerInteractable : BaseTriggerHandler
{
	[SerializeField]
	private WorldInteractiveObject _interactable; //Field offset: 0x28
	[SerializeField]
	private string _interactableId; //Field offset: 0x30
	[SerializeField]
	private EInteractionType _interactionType; //Field offset: 0x38

	public HandlerInteractable() { }

	protected virtual void OnRename() { }

	private void OnTriggerEvent(TriggerEvent triggerEvent) { }

	private void OnValidate() { }

	private void Start() { }

}

