namespace EFT.Interactive;

public sealed class TransitCompletedQuestRequirement : TransitRequirement
{
	private readonly string _completedQuestId; //Field offset: 0x18

	public TransitCompletedQuestRequirement(string completedQuestId) { }

	private static Quest FindQuest(string questTemplateId, QuestController questController) { }

	public virtual string GetLocalizedTip() { }

	private static bool MatchesCompletedQuest(string questTemplateId, QuestController questController) { }

	public virtual bool Met(Player player) { }

}

