namespace CommonAssets.Scripts.Game.GameTriggers.Handlers;

public class HandlerGameObjectState : BaseTriggerHandler
{
	[SerializeField]
	private GameObject[] _controlledGameObjects; //Field offset: 0x28
	[SerializeField]
	private bool _targetState; //Field offset: 0x30
	[SerializeField]
	private bool _resetStateOnAwake; //Field offset: 0x31

	public HandlerGameObjectState() { }

	private void Awake() { }

	private void OnTrigger(TriggerEvent triggerEvent) { }

	private void Start() { }

}

