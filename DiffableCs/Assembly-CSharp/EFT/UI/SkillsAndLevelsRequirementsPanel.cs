namespace EFT.UI;

public sealed class SkillsAndLevelsRequirementsPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Profile profile; //Field offset: 0x10
		public SkillsAndLevelsRequirementsPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <Show>b__0(SkillRequirements skillRequirement, RequiredSkillOrLevel view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_1
	{
		public SkillRequirements skillRequirement; //Field offset: 0x10

		public <>c__DisplayClass13_1() { }

		internal bool <Show>b__1(Skill skill) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public QuestBook quests; //Field offset: 0x10
		public SkillsAndLevelsRequirementsPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal void <ShowQuestsRequirements>b__0(QuestTemplate questTemplate, RequiredSkillOrLevel view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_1
	{
		public string questId; //Field offset: 0x10

		public <>c__DisplayClass14_1() { }

		internal bool <ShowQuestsRequirements>b__1(QuestTemplate template) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public AchievementsBook achievements; //Field offset: 0x10
		public SkillsAndLevelsRequirementsPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal void <ShowAchievementsRequirements>b__0(AchievementTemplate achievementTemplate, RequiredSkillOrLevel view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_1
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass15_1() { }

		internal bool <ShowAchievementsRequirements>b__1(AchievementTemplate template) { }

	}

	[SerializeField]
	private RequiredSkillOrLevel _loyalty; //Field offset: 0x70
	[SerializeField]
	private RequiredSkillOrLevel _level; //Field offset: 0x78
	[SerializeField]
	private RequiredSkillOrLevel _prestigeLevel; //Field offset: 0x80
	[SerializeField]
	private RequiredSkillOrLevel _standing; //Field offset: 0x88
	[SerializeField]
	private RequiredSkillOrLevel _skillTemplate; //Field offset: 0x90
	[SerializeField]
	private RequiredSkillOrLevel _questTemplate; //Field offset: 0x98
	[SerializeField]
	private RequiredSkillOrLevel _achievementTemplate; //Field offset: 0xA0
	[SerializeField]
	private ItemRequirementsPanel _itemsPanel; //Field offset: 0xA8
	[SerializeField]
	private Color _goodColor; //Field offset: 0xB0
	[SerializeField]
	private Color _badColor; //Field offset: 0xC0
	[SerializeField]
	private Image _traderImage; //Field offset: 0xD0
	private bool _allAvailable; //Field offset: 0xD8
	private Action _onAvailableChanged; //Field offset: 0xE0

	public SkillsAndLevelsRequirementsPanel() { }

	public virtual void Close() { }

	public void Show(Profile profile, TraderInfo trader, QuestBook quests, AchievementsBook achievements, OfferRequirements offerRequirements, Stash stashGrid, Action onAvailableChanged) { }

	private void ShowAchievementsRequirements(IEnumerable achRequirementsIds, AchievementsBook achievements, IReadOnlyCollection templatesCollection) { }

	private void ShowQuestsRequirements(IEnumerable questsRequirementsIds, QuestBook quests, IReadOnlyCollection templatesCollection) { }

	private void ShowRequirement(RequiredSkillOrLevel requirement, string message, bool available, Sprite icon = null, float width = -1) { }

}

