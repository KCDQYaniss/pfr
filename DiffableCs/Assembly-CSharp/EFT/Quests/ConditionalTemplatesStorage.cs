namespace EFT.Quests;

public sealed class ConditionalTemplatesStorage
{
	internal struct FreeChangesCount
	{
		public int CurrentValue; //Field offset: 0x0
		public int MaxValue; //Field offset: 0x4

		public FreeChangesCount(int currentValue, int maxValue) { }

	}

	private static readonly Lazy _instance; //Field offset: 0x0
	public readonly QuestTemplatesCollection GlobalQuestTemplates; //Field offset: 0x10
	public readonly AchievementTemplatesCollection GlobalAchievementTemplates; //Field offset: 0x18
	private readonly Dictionary _profileQuestTemplates; //Field offset: 0x20
	private readonly Dictionary _questRequirements; //Field offset: 0x28
	private readonly Dictionary _freeChanges; //Field offset: 0x30
	private readonly Dictionary _questChains; //Field offset: 0x38

	public static ConditionalTemplatesStorage Instance
	{
		 get { } //Length: 121
	}

	public IReadOnlyDictionary QuestChains
	{
		 get { } //Length: 5
	}

	private static ConditionalTemplatesStorage() { }

	public ConditionalTemplatesStorage() { }

	public void AddGlobalAchievementTemplates(IEnumerable globalTemplates) { }

	public void AddGlobalQuestTemplates(IEnumerable globalTemplates) { }

	public bool AddProfileQuestTemplate(string profileId, QuestTemplate profileTemplate) { }

	public void AddProfileQuestTemplates(string profileId, IEnumerable profileTemplates) { }

	public void Clear() { }

	public static ConditionalTemplatesStorage get_Instance() { }

	public IReadOnlyDictionary get_QuestChains() { }

	public IReadOnlyCollection GetAllAchievementTemplates() { }

	public IReadOnlyCollection GetAllProfileQuestTemplates(string profileId) { }

	public IReadOnlyCollection GetAllQuestTemplates() { }

	private IReadOnlyCollection GetAllTemplates(IReadOnlyCollection templatesCollection, Dictionary profileTemplatesDict = null, string profileId = "") { }

	public QuestChangeRequirement GetChangeRequirements(string templateId) { }

	private TTemplatesCollection GetTemplatesCollection(string profileId, IDictionary conditionalTemplatesCollection) { }

	public void RemoveProfileQuestTemplate(string profileId, QuestTemplate template) { }

	public void SetChangeRequirements(Dictionary requirements) { }

	public void SetFreeChanges(string templateId, int current, int max) { }

	public void SetQuestChains(Dictionary questChains) { }

	public bool TryGetFreeChanges(string templateId, out FreeChangesCount value) { }

}

