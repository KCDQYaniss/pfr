namespace EFT.GameTriggers;

public class HandlerCompleteQuestCondition : BaseTriggerHandler
{
	[SerializeField]
	private string _questTemplateId; //Field offset: 0x28
	[SerializeField]
	private string _conditionId; //Field offset: 0x30
	[SerializeField]
	private bool _completeForAllLobby; //Field offset: 0x38

	public HandlerCompleteQuestCondition() { }

	private void CompleteCondition(TriggersModule tm, int playerRaidId) { }

	private void HandleTrigger(TriggerEvent triggerEvent) { }

	private void Start() { }

}

