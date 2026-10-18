namespace EFT;

public interface IQuestSession : IImageLoader
{

	public Task AchievementComplete(string qid, bool removeExcessItems) { }

	public void AddQuestNote(string qid, MongoID conditionId, MongoID noteId) { }

	public Task GetDailyQuests() { }

	public Task GetQuestsByCompletableItem(MongoID completableItemTemplateId) { }

	public Task QuestAccept(string questId, bool isRepeatable) { }

	public Task QuestChange(string qid) { }

	public Task QuestFail(string qid) { }

	public Task RequestAchievementsGlobalProgress() { }

	public Task RequestAchievementsTemplates(bool withCompleted) { }

	public Task RequestQuestChains() { }

	public Task RequestQuestsTemplates(bool withCompleted) { }

	public Task SendQuestComplete(string questId) { }

	public Task SendQuestFail(string questId) { }

}

