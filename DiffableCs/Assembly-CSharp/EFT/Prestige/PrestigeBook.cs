namespace EFT.Prestige;

public sealed class PrestigeBook : ConditionalBook, IDisposable
{
	private readonly IEnumerable _completedStatuses; //Field offset: 0x88
	private readonly IReadOnlyList _templates; //Field offset: 0x90

	public PrestigeBook(string profileId, EPlayerSide profileGroup, IEnumerable prestigeStatusData, Dictionary conditionCounters) { }

	private bool ContainsTemplate(MongoID templateId) { }

	private void CreatePrestigeLevel(PrestigeTemplate template) { }

	public virtual void Dispose() { }

	private PrestigeStatusData GetStatus(PrestigeTemplate template) { }

	public virtual void LoadAll() { }

	public virtual void RemoveConditionalsWithoutTemplate() { }

	private void TryCreatePrestigeLevel(PrestigeTemplate template) { }

}

