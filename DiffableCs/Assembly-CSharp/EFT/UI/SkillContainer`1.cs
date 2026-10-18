namespace EFT.UI;

public class SkillContainer`1 : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_2; //Field offset: 0x0
		public static Func <>9__2_3; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal int <Show>b__2_2(Skill skill) { }

		internal DateTime <Show>b__2_3(Skill skill) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public AsyncViewList skillPanels; //Field offset: 0x0
		public SkillManager skillManager; //Field offset: 0x0
		public DropDownBox filterMethod; //Field offset: 0x0
		public Func <>9__4; //Field offset: 0x0

		public <>c__DisplayClass2_0() { }

		internal void <Show>b__0(int index) { }

		internal void <Show>b__1(int index) { }

		internal bool <Show>b__4(Skill skill) { }

	}

	[SerializeField]
	private Transform _skillsContainer; //Field offset: 0x0
	[SerializeField]
	private TSkillView _skillViewTemplate; //Field offset: 0x0

	public SkillContainer`1() { }

	protected void Show(SkillManager skillManager, DropDownBox sortMethod, DropDownBox filterMethod, Action showAction) { }

}

