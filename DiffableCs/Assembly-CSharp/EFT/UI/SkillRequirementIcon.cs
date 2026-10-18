namespace EFT.UI;

public sealed class SkillRequirementIcon : UIElement
{
	[SerializeField]
	private Image _border; //Field offset: 0x70
	[SerializeField]
	private Image _icon; //Field offset: 0x78
	[SerializeField]
	private SkillLevelPanel _levelPanel; //Field offset: 0x80
	private Skill _skill; //Field offset: 0x88
	private Action _onHover; //Field offset: 0x90
	private readonly Color EliteBorderColor; //Field offset: 0x98

	public SkillRequirementIcon() { }

	[CompilerGenerated]
	private void <Awake>b__6_0(PointerEventData eventData) { }

	[CompilerGenerated]
	private void <Awake>b__6_1(PointerEventData eventData) { }

	[CompilerGenerated]
	private void <Show>b__7_0() { }

	private void Awake() { }

	[CanBeNull]
	private static Sprite LoadSkillIcon(Skill skill) { }

	public void Show(Skill skill, Action onHover) { }

}

