namespace EFT.Hideout;

public sealed class ItemRequirementPanel : UIElement, IRequirementPanel, IUIView, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public ItemRequirement itemRequirement; //Field offset: 0x10
		public ItemRequirementPanel <>4__this; //Field offset: 0x18
		public bool ignoreFulfillment; //Field offset: 0x20

		public <>c__DisplayClass1_0() { }

		internal void <Show>g__UpdateFulfillment|0() { }

	}

	[SerializeField]
	private HideoutItemViewFactory _itemIconViewFactory; //Field offset: 0x70

	public ItemRequirementPanel() { }

	public override void Show(ItemUiContext itemUiContext, InventoryController inventoryController, Requirement requirement, EAreaType areaType, bool ignoreFulfillment) { }

}

