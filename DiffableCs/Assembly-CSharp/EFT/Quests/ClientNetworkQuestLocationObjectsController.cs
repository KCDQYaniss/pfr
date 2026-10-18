namespace EFT.Quests;

public sealed class ClientNetworkQuestLocationObjectsController : QuestLocationObjectsController
{
	private readonly bool _hideQuestLocationObjects; //Field offset: 0x38
	private bool _suppressBreakEffects; //Field offset: 0x39
	private Action _unsubscribe; //Field offset: 0x40
	private Dictionary _locationObjects; //Field offset: 0x48

	public ClientNetworkQuestLocationObjectsController(IPlayer player, QuestController questController, IReadOnlyList questObjects, bool hideQuestLocationObjects) { }

	protected virtual void ApplyVisibility(QuestLocationObject questLocationObject) { }

	public virtual void Dispose() { }

	public virtual void Initialize() { }

	private void OnQuestObjectStateEvent(QuestLocationObjectStateEvent evt) { }

	private void RefreshAll() { }

	public virtual bool TryCompleteQuestObjectCondition(QuestLocationObject questLocationObject) { }

}

