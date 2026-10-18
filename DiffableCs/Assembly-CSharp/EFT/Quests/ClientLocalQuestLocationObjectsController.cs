namespace EFT.Quests;

public sealed class ClientLocalQuestLocationObjectsController : QuestLocationObjectsController
{
	private readonly bool _showQuestLocationObjects; //Field offset: 0x38
	private bool _suppressBreakEffects; //Field offset: 0x39

	public ClientLocalQuestLocationObjectsController(IPlayer player, QuestController questController, IReadOnlyList questObjects, bool showQuestLocationObjects) { }

	protected virtual void ApplyVisibility(QuestLocationObject questLocationObject) { }

	public virtual void Initialize() { }

	private void RefreshAll() { }

}

