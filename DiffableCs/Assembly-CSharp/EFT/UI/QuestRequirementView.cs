namespace EFT.UI;

public class QuestRequirementView : UIElement
{
	private const string DELAYED_QUEST_LOCALE = "Quest will be available later"; //Field offset: 0x0
	private const string STANDING_CONDITION_LOCALE = "UI/Quests/Conditions/TraderStanding{0}{1}"; //Field offset: 0x0
	private const string LOYALTY_CONDITION_LOCALE = "UI/Quests/Conditions/TraderLoyalty{0}{1}"; //Field offset: 0x0
	private const string SKILL_CONDITION_LOCALE = "UI/Quests/Conditions/SkillLevel{0}{1}"; //Field offset: 0x0
	private const string LEVEL_CONDITION_LOCALE = "UI/Quests/Conditions/ProfileLevel{0}"; //Field offset: 0x0
	private const string PRESTIGE_LEVEL_CONDITION_LOCALE = "UI/Quests/Conditions/PrestigeLevel{0}"; //Field offset: 0x0
	[SerializeField]
	private Image _icon; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _text; //Field offset: 0x78
	[SerializeField]
	private Graphic _checkMarkBorder; //Field offset: 0x80
	[SerializeField]
	private Graphic _checkMark; //Field offset: 0x88
	[SerializeField]
	private SpriteMap _icons; //Field offset: 0x90
	[SerializeField]
	private ColorMap _colors; //Field offset: 0x98

	public QuestRequirementView() { }

	public void Show(QuestBook questBook, Quest quest, Condition condition) { }

}

