namespace EFT.UI;

public sealed class SkillTooltip : Tooltip
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__25_4; //Field offset: 0x8
		public static Func <>9__25_5; //Field offset: 0x10
		public static Func <>9__25_6; //Field offset: 0x18
		public static Func <>9__25_0; //Field offset: 0x20
		public static Action <>9__25_7; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal EBuffType <Show>b__25_0(Buff buff) { }

		internal string <Show>b__25_4(SkillNotGrowingPerkEffect effect) { }

		internal string <Show>b__25_5(SkillExperienceMultiplierPerkEffect effect) { }

		internal string <Show>b__25_6(SkillMaxLevelCapPerkEffect effect) { }

		internal void <Show>b__25_7(BuffPanel buffPanel) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public Skill skill; //Field offset: 0x10
		public SkillTooltip <>4__this; //Field offset: 0x18
		public ViewList buffPanels; //Field offset: 0x20

		public <>c__DisplayClass25_0() { }

		internal void <Show>b__1(Buff buff, BuffPanel buffPanel) { }

		internal void <Show>b__2() { }

		internal bool <Show>b__3(SkillNotGrowingPerkEffect effect) { }

	}

	public const string SKILL_TOOLTIP_XP_UP_MULTIPLIER = "Perks/SkillTooltip/XpUpMultiplier{0}{1}"; //Field offset: 0x0
	public const string SKILL_TOOLTIP_XP_DOWN_MULTIPLIER = "Perks/SkillTooltip/XpDownMultiplier{0}{1}"; //Field offset: 0x0
	public const string SKILL_TOOLTIP_LEVEL_CAP = "Perks/SkillTooltip/LevelCap{0}{1}"; //Field offset: 0x0
	public const string SKILL_TOOLTIP_PROGRESS_BLOCKED = "Perks/SkillTooltip/ProgressBlocked"; //Field offset: 0x0
	public const string GOOD_COLOR = "#54C1FFFF"; //Field offset: 0x0
	public const string BAD_COLOR = "#C40000FF"; //Field offset: 0x0
	public const string NEUTRAL_COLOR = "#747B7E"; //Field offset: 0x0
	[SerializeField]
	private SkillClassIcon _classIcon; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _name; //Field offset: 0xB0
	[SerializeField]
	private SkillLevelPanel _levelPanel; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0xC0
	[SerializeField]
	private Image _currentProgressFill; //Field offset: 0xC8
	[SerializeField]
	private Image _baseProgressFill; //Field offset: 0xD0
	[SerializeField]
	private TextMeshProUGUI _level; //Field offset: 0xD8
	[SerializeField]
	private TextMeshProUGUI _progress; //Field offset: 0xE0
	[SerializeField]
	private Transform _buffContainer; //Field offset: 0xE8
	[SerializeField]
	private BuffPanel _buffPanelTemplate; //Field offset: 0xF0
	[SerializeField]
	private Sprite _baseFillSprite; //Field offset: 0xF8
	[SerializeField]
	private Sprite _normalFillSprite; //Field offset: 0x100
	[SerializeField]
	private Sprite _eliteFillSprite; //Field offset: 0x108
	[SerializeField]
	private GameObject _effectivenessUp; //Field offset: 0x110
	[SerializeField]
	private GameObject _effectivenessDown; //Field offset: 0x118
	[SerializeField]
	private RectTransform _currentProgressValueTransform; //Field offset: 0x120
	[SerializeField]
	private TextMeshProUGUI _currentProgressValueText; //Field offset: 0x128
	[SerializeField]
	private GameObject _currentProgressValueGameObject; //Field offset: 0x130

	public SkillTooltip() { }

	public void Show(Skill skill) { }

}

