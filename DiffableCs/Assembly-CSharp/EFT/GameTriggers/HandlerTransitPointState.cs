namespace EFT.GameTriggers;

public sealed class HandlerTransitPointState : BaseTriggerHandler
{
	[SerializeField]
	private TransitPoint _transitPoint; //Field offset: 0x28
	[SerializeField]
	private bool _targetState; //Field offset: 0x30

	public HandlerTransitPointState() { }

	private void OnTrigger(TriggerEvent triggerEvent) { }

	private void Start() { }

}

