namespace EFT.UI;

public sealed class SkillPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__22_1; //Field offset: 0x8
		public static Func <>9__22_2; //Field offset: 0x10
		public static Func <>9__22_6; //Field offset: 0x18
		public static Func <>9__22_5; //Field offset: 0x20
		public static Action <>9__24_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal void <OnSkillLevelChanged>b__24_0(BuffIcon buffIcon) { }

		internal bool <Show>b__22_1(Buff buff) { }

		internal EBuffType <Show>b__22_2(Buff buff) { }

		internal IEnumerable <Show>b__22_5(IStimulator effect) { }

		internal bool <Show>b__22_6(IStimulatorBuff x) { }

	}

	private const string SKILL_BONUSES_ELITE = "UI/Skills/EliteBonuses"; //Field offset: 0x0
	private const string SKILL_BONUSES = "UI/Skills/Bonuses"; //Field offset: 0x0
	private const string SKILL_CURRENT_LEVEL = "UI/Skills/CurrentLevel"; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _level; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _name; //Field offset: 0x78
	[SerializeField]
	private BuffIcon _buffIconTemplate; //Field offset: 0x80
	[SerializeField]
	private Transform _buffsContainer; //Field offset: 0x88
	[SerializeField]
	private Image _currentProgressFill; //Field offset: 0x90
	[SerializeField]
	private Image _baseProgressFill; //Field offset: 0x98
	[SerializeField]
	private RectTransform _currentProgressValueTransform; //Field offset: 0xA0
	[SerializeField]
	private TextMeshProUGUI _currentProgressValueText; //Field offset: 0xA8
	[SerializeField]
	private GameObject _currentProgressValueGameObject; //Field offset: 0xB0
	[SerializeField]
	private SkillIcon _skillIcon; //Field offset: 0xB8
	[SerializeField]
	private Sprite _normalFillSprite; //Field offset: 0xC0
	[SerializeField]
	private Sprite _eliteFillSprite; //Field offset: 0xC8
	[SerializeField]
	private CanvasGroup _alphaBlockedSkill; //Field offset: 0xD0
	[SerializeField]
	private GameObject _effectivenessUp; //Field offset: 0xD8
	[SerializeField]
	private GameObject _effectivenessDown; //Field offset: 0xE0
	private SkillTooltip _tooltip; //Field offset: 0xE8
	private ViewList _buffIcons; //Field offset: 0xF0
	private Skill _skill; //Field offset: 0xF8
	private IHealthController _healthController; //Field offset: 0x100

	public SkillPanel() { }

	[CompilerGenerated]
	private void <Show>b__22_0(bool hover, PointerEventData eventData) { }

	[CompilerGenerated]
	private void <Show>b__22_3(Buff buff, BuffIcon buffIcon) { }

	[CompilerGenerated]
	private void <Show>b__22_4() { }

	private void OnSkillLevelChanged() { }

	private void OnStimulatorBuffEvent(IStimulatorBuff buff) { }

	public void Show(Skill skill, IHealthController healthController) { }

}

