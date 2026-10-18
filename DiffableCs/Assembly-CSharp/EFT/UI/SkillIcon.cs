namespace EFT.UI;

public sealed class SkillIcon : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Show>b__13_2(IStimulatorBuff x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public IHealthController healthController; //Field offset: 0x10
		public SkillIcon <>4__this; //Field offset: 0x18
		public Skill skill; //Field offset: 0x20

		public <>c__DisplayClass13_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

	}

	private static readonly Color EliteBorderColor; //Field offset: 0x0
	[SerializeField]
	private Image _border; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _progress; //Field offset: 0x78
	[SerializeField]
	private Image _icon; //Field offset: 0x80
	[SerializeField]
	private SkillLevelPanel _levelPanel; //Field offset: 0x88
	[SerializeField]
	private SkillClassIcon _classIcon; //Field offset: 0x90
	[SerializeField]
	private HoverTooltipArea _alphaBlockedSkill; //Field offset: 0x98
	[SerializeField]
	private SkillBuffIcon _skillBuffIcon; //Field offset: 0xA0
	private Skill _skill; //Field offset: 0xA8
	private Action _onHover; //Field offset: 0xB0
	private bool _skillUnlocked; //Field offset: 0xB8

	private static SkillIcon() { }

	public SkillIcon() { }

	[CompilerGenerated]
	private void <Awake>b__11_0(PointerEventData eventData) { }

	[CompilerGenerated]
	private void <Awake>b__11_1(PointerEventData eventData) { }

	private void Awake() { }

	[CanBeNull]
	private static Sprite LoadSkillIcon(Skill skill) { }

	private void OnStimulatorBuffEvent(IStimulatorBuff buff) { }

	public void Show(Skill skill, IHealthController healthController, Action onHover) { }

}

