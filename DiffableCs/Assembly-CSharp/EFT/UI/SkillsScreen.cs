namespace EFT.UI;

[UsedImplicitly]
public sealed class SkillsScreen : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Profile profile; //Field offset: 0x10
		public SkillsScreen <>4__this; //Field offset: 0x18
		public IHealthController healthController; //Field offset: 0x20

		public <>c__DisplayClass8_0() { }

		internal void <Show>b__0(SkillList x) { }

		internal void <Show>b__1(SkillThumbs x) { }

	}

	[SerializeField]
	private SkillList _skillList; //Field offset: 0x70
	[SerializeField]
	private SkillThumbs _skillThumbs; //Field offset: 0x78
	[SerializeField]
	private DropDownBox _sortMethod; //Field offset: 0x80
	[SerializeField]
	private DropDownBox _filterMethod; //Field offset: 0x88
	[SerializeField]
	private Tab _listTab; //Field offset: 0x90
	[SerializeField]
	private Tab _thumbsTab; //Field offset: 0x98
	private TabGroup _skillViewTabGroup; //Field offset: 0xA0

	public SkillsScreen() { }

	[UsedImplicitly]
	private void Awake() { }

	public virtual void Close() { }

	public void Show(Profile profile, IHealthController healthController) { }

}

