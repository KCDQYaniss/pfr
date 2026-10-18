namespace EFT.Quests;

public abstract class QuestLocationObjectsController : IDisposable
{
	protected readonly IPlayer Player; //Field offset: 0x10
	protected readonly QuestController QuestController; //Field offset: 0x18
	protected readonly IReadOnlyList QuestObjects; //Field offset: 0x20
	private readonly HashSet _trackedQuests; //Field offset: 0x28
	private readonly Dictionary _objectsByConditionKey; //Field offset: 0x30

	protected bool IsScav
	{
		 get { } //Length: 85
	}

	protected QuestLocationObjectsController(IPlayer player, QuestController questController, IReadOnlyList questObjects) { }

	private static void AddToIndex(Dictionary index, string key, QuestLocationObject questLocationObject) { }

	protected abstract void ApplyVisibility(QuestLocationObject questLocationObject) { }

	private void BuildIndexes() { }

	private static bool ContainsSearchAndDestroyTarget(ConditionSearchAndDestroy condition, string targetId) { }

	public override void Dispose() { }

	protected bool get_IsScav() { }

	private static string GetConditionKey(string questTemplateId, string conditionId) { }

	private CountersCollection GetSearchAndDestroyCountersCollection(ConditionSearchAndDestroy condition) { }

	public override void Initialize() { }

	protected bool IsQuestObjectActive(QuestLocationObject questLocationObject, out Quest quest, out Condition condition) { }

	protected bool IsSearchAndDestroyTargetCompleted(Quest quest, ConditionSearchAndDestroy condition, string targetId) { }

	private void OnConditionValueChanged(Quest quest, EQuestStatus status, Condition condition, bool notify) { }

	private void OnNewQuestAdded(Quest quest) { }

	private void OnQuestStatusChanged(Quest quest, bool notify) { }

	private void RefreshByConditionKey(string conditionKey) { }

	private void RefreshByQuestId(string questId) { }

	private void TrackQuest(Quest quest) { }

	public override bool TryCompleteQuestObjectCondition(QuestLocationObject questLocationObject) { }

	protected bool TryGetCondition(QuestLocationObject questLocationObject, Quest quest, out Condition condition) { }

	protected bool TryGetQuest(string questTemplateId, out Quest quest) { }

	protected bool TrySetSearchAndDestroyTargetCompleted(Quest quest, ConditionSearchAndDestroy condition, string targetId) { }

}

