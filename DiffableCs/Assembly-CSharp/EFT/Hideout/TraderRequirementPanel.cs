namespace EFT.Hideout;

public sealed class TraderRequirementPanel : UIElement, IRequirementPanel, IUIView, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public TraderRequirementPanel <>4__this; //Field offset: 0x10
		public bool ignoreFulfillment; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <Show>g__UpdateFulfillment|0() { }

	}

	private const string TRADER_LOYALTY_REQUIREMENT_TEXT = "Required <b>{0}</b>, level <b>{1}</b>"; //Field offset: 0x0
	private const string TRADER_UNLOCK_TEXT = "Required <b>{0}</b> to be unlocked"; //Field offset: 0x0
	[SerializeField]
	private TraderRequirementIcon _traderRequirementIcon; //Field offset: 0x70
	[SerializeField]
	private RequirementFulfilledStatus _fulfilledStatus; //Field offset: 0x78
	private TraderRequirement _traderRequirement; //Field offset: 0x80
	private SimpleTooltip _tooltip; //Field offset: 0x88

	public TraderRequirementPanel() { }

	[CompilerGenerated]
	private void <Awake>b__6_0(PointerEventData eventData) { }

	[CompilerGenerated]
	private void <Awake>b__6_1(PointerEventData eventData) { }

	private void Awake() { }

	public virtual void Close() { }

	public override void Show(ItemUiContext itemUiContext, InventoryController inventoryController, Requirement requirement, EAreaType areaType, bool ignoreFulfillment) { }

}

