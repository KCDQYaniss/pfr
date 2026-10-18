namespace EFT.GameTriggers;

public class HandlerExfiltration : BaseTriggerHandler
{
	[SerializeField]
	private ExfiltrationPoint _exfiltrationPoint; //Field offset: 0x28
	[SerializeField]
	private EExfiltrationStatus _targetStatus; //Field offset: 0x30

	public HandlerExfiltration() { }

	private void OnTrigger() { }

	private void Start() { }

}

