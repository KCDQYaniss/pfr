namespace EFT.UI;

public sealed class SkillThumbs : SkillContainer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public IHealthController healthController; //Field offset: 0x10
		public SkillThumbs <>4__this; //Field offset: 0x18

		public <>c__DisplayClass1_0() { }

		internal void <Show>b__0(Skill skill, SkillIcon skillIcon) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_1
	{
		public Skill skill; //Field offset: 0x10
		public <>c__DisplayClass1_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass1_1() { }

		internal void <Show>b__1(bool hover, PointerEventData eventData) { }

	}

	private SkillTooltip _tooltip; //Field offset: 0x80

	public SkillThumbs() { }

	public virtual void Close() { }

	public void Show(SkillManager skills, DropDownBox sortMethod, DropDownBox filterMethod, IHealthController healthController) { }

}

