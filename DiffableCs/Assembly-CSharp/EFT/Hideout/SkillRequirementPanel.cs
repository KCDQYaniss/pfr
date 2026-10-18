namespace EFT.Hideout;

public sealed class SkillRequirementPanel : UIElement, IRequirementPanel, IUIView, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public SkillRequirement skillRequirement; //Field offset: 0x10
		public SkillRequirementPanel <>4__this; //Field offset: 0x18
		public bool ignoreFulfillment; //Field offset: 0x20

		public <>c__DisplayClass4_0() { }

		internal void <Show>b__0(bool hover, PointerEventData eventData) { }

		internal void <Show>g__UpdateFulfillment|1() { }

	}

	private const string SKILL_REQUIREMENT_TEXT = "Required skill <b>{0}</b>, level <b>{1}</b>"; //Field offset: 0x0
	[SerializeField]
	private SkillRequirementIcon _skillIcon; //Field offset: 0x70
	[SerializeField]
	private RequirementFulfilledStatus _fulfilledStatus; //Field offset: 0x78
	private SimpleTooltip _tooltip; //Field offset: 0x80

	public SkillRequirementPanel() { }

	public virtual void Close() { }

	public override void Show(ItemUiContext itemUiContext, InventoryController inventoryController, Requirement requirement, EAreaType areaType, bool ignoreFulfillment) { }

}

