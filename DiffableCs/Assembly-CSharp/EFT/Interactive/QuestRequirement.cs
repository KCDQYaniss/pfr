namespace EFT.Interactive;

public sealed class QuestRequirement : TransitRequirement
{
	private List _questTemplateIds; //Field offset: 0x18

	public QuestRequirement(IReadOnlyList questTemplateIds, string conditionsQuestRequirementTipKey) { }

	private bool CheckQuest(string questTemplateId, QuestController questController) { }

	public virtual bool Met(Player player) { }

}

