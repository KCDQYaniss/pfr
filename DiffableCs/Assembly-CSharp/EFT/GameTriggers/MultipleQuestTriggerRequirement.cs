namespace EFT.GameTriggers;

public class MultipleQuestTriggerRequirement : ITriggerRequirement, IDisposable
{
	[SerializeField]
	private string[] _questTemplateIds; //Field offset: 0x10
	[SerializeField]
	private bool _requireAll; //Field offset: 0x18
	[SerializeField]
	private bool _includeMarkedAsFailed; //Field offset: 0x19

	public MultipleQuestTriggerRequirement() { }

	public override bool Check(InventoryController inventoryController, SkillManager skillManager) { }

	private bool CheckQuest(string questTemplateId, QuestController questController) { }

	public override void Dispose() { }

	public override void Start() { }

	public override bool TryRedeem(InventoryController inventoryController, SkillManager skillManager) { }

}

