namespace EFT.UI.DragAndDrop;

public sealed class RagfairSelectableItemView : SelectableItemView
{

	public RagfairSelectableItemView() { }

	public static RagfairSelectableItemView Create(Item item, SelectableItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance) { }

	protected virtual void SetAvailability(bool available, string tooltip) { }

}

